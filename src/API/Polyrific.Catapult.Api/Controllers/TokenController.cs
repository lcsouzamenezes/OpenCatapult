﻿// Copyright (c) Polyrific, Inc 2018. All rights reserved.

using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Polyrific.Catapult.Api.Core.Services;
using Polyrific.Catapult.Api.Identity;
using Polyrific.Catapult.Shared.Dto.CatapultEngine;
using Polyrific.Catapult.Shared.Dto.User;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Polyrific.Catapult.Api.Controllers
{
    [Route("Token")]
    [ApiController]
    public class TokenController : ControllerBase
    {
        private readonly IUserService _userService;
        private readonly IProjectService _projectService;
        private readonly ICatapultEngineService _catapultEngineService;
        private readonly IConfiguration _configuration;

        public TokenController(IUserService userService, IProjectService projectService, ICatapultEngineService catapultEngineService, IConfiguration configuration)
        {
            _userService = userService;
            _projectService = projectService;
            _catapultEngineService = catapultEngineService;
            _configuration = configuration;
        }

        /// <summary>
        /// Request a user token
        /// </summary>
        /// <param name="dto">Request token body</param>
        /// <returns></returns>
        [HttpPost]
        public async Task<IActionResult> RequestToken(RequestTokenDto dto)
        {
            if (!await _userService.ValidateUserPassword(dto.Email, dto.Password)) 
                return BadRequest("Username or password is invalid");

            var user = await _userService.GetUser(dto.Email);
            if (!user.IsActive)
                return BadRequest("User is suspended");

            var userRole = await _userService.GetUserRole(dto.Email);
            var userProjects = await GetUserProjects(dto.Email);
            var tokenKey = _configuration["Security:Tokens:Key"];
            var tokenIssuer = _configuration["Security:Tokens:Issuer"];
            var tokenAudience = _configuration["Security:Tokens:Audience"];

            var token = AuthorizationToken.GenerateToken(dto.Email, userRole, userProjects, tokenKey, tokenIssuer,
                tokenAudience);

            return Ok(token);
        }

        /// <summary>
        /// Request an engine token
        /// </summary>
        /// <param name="engineId">Id of the engine</param>
        /// <param name="dto">Request engine token body</param>
        /// <returns></returns>
        [HttpPost("engine/{engineId}")]
        [Authorize(Policy = AuthorizePolicy.UserRoleAdminAccess)]
        public async Task<IActionResult> RequestEngineToken(int engineId, RequestEngineTokenDto dto)
        {
            var engine = await _catapultEngineService.GetCatapultEngine(engineId);
            if (!engine.IsActive)
                return BadRequest("Engine is suspended");

            var engineRole = await _catapultEngineService.GetCatapultEngineRole(engineId);
            var tokenKey = _configuration["Security:Tokens:Key"];
            var tokenIssuer = _configuration["Security:Tokens:Issuer"];
            var tokenAudience = _configuration["Security:Tokens:Audience"];

            var token = AuthorizationToken.GenerateEngineToken(engine.Name, engineRole, tokenKey, tokenIssuer, tokenAudience, dto?.Expires);

            return Ok(token);
        }

        private async Task<List<(int, string, string)>> GetUserProjects(string userName)
        {
            var user = await _userService.GetUser(userName);
            var result = await _projectService.GetProjectsByUser(user.Id);
            return result.Select(m => (m.Item1.Id, m.Item1.Name, m.Item2?.Name)).ToList();
        }
    }
}