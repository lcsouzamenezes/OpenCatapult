﻿// Copyright (c) Polyrific, Inc 2018. All rights reserved.

using Polyrific.Catapult.Api.Core.Entities;

namespace Polyrific.Catapult.Api.Core.Specifications
{
    public class ProjectMemberFilterSpecification : BaseSpecification<ProjectMember>
    {
        public int ProjectId { get; set; }
        public int UserId { get; set; }
        public bool? IsArchived { get; set; }
        public int RoleId { get; set; }
        
        public ProjectMemberFilterSpecification(int projectId, int userId, bool? isArchived = null, int roleId = 0) 
            : base(m => (projectId == 0 || m.ProjectId == projectId) 
                        && (userId == 0 || m.UserId == userId) 
                        && (isArchived == null || m.Project.IsArchived == isArchived)
                        && (roleId == 0 || m.ProjectMemberRoleId == roleId))
        {
            ProjectId = projectId;
            UserId = userId;
            IsArchived = isArchived;
            RoleId = roleId;

            if (projectId == 0)
            {
                Includes.Add(m => m.Project);
            }                
            else
            {
                Includes.Add(m => m.ProjectMemberRole);
                Includes.Add(m => m.User);
            }                
        }
    }
}
