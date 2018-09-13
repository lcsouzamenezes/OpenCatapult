﻿// Copyright (c) Polyrific, Inc 2018. All rights reserved.

using McMaster.Extensions.CommandLineUtils;
using Microsoft.Extensions.Logging;
using Polyrific.Catapult.Shared.Service;
using System.ComponentModel.DataAnnotations;

namespace Polyrific.Catapult.Cli.Commands.Job
{
    [Command(Description = "Remove a job definition")]
    public class RemoveCommand : BaseCommand
    {
        private readonly IProjectService _projectService;
        private readonly IJobDefinitionService _jobDefinitionService;

        public RemoveCommand(IConsole console, ILogger<RemoveCommand> logger,
            IProjectService projectService, IJobDefinitionService jobDefinitionService) : base(console, logger)
        {
            _projectService = projectService;
            _jobDefinitionService = jobDefinitionService;
        }

        [Required]
        [Option("-p|--project <PROJECT>", "Name of the project", CommandOptionType.SingleValue)]
        public string Project { get; set; }

        [Required]
        [Option("-n|--name <NAME>", "Name of the job definition", CommandOptionType.SingleValue)]
        public string Name { get; set; }

        public override string Execute()
        {
            string message = string.Empty;

            var project = _projectService.GetProjectByName(Project).Result;

            if (project != null)
            {
                var job = _jobDefinitionService.GetJobDefinitionByName(project.Id, Name).Result;

                if (job != null)
                {
                    _jobDefinitionService.DeleteJobDefinition(project.Id, job.Id).Wait();

                    message = $"Job definition {Name} has been removed";
                    Logger.LogInformation(message);
                    return message;
                }
            }

            message = $"Failed removing job definition {Name}. Make sure the project and job definition names are correct.";

            return message;
        }
    }
}