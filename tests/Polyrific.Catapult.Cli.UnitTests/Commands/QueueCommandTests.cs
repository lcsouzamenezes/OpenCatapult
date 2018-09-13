﻿// Copyright (c) Polyrific, Inc 2018. All rights reserved.

using McMaster.Extensions.CommandLineUtils;
using Moq;
using Polyrific.Catapult.Cli.Commands;
using Polyrific.Catapult.Cli.Commands.Queue;
using Polyrific.Catapult.Shared.Dto.Constants;
using Polyrific.Catapult.Shared.Dto.JobDefinition;
using Polyrific.Catapult.Shared.Dto.JobQueue;
using Polyrific.Catapult.Shared.Dto.Project;
using Polyrific.Catapult.Shared.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Xunit;

namespace Polyrific.Catapult.Cli.UnitTests.Commands
{
    public class QueueCommandTests
    {
        private readonly Mock<IConsole> _console;
        private readonly Mock<IJobQueueService> _jobQueueService;
        private readonly Mock<IProjectService> _projectService;
        private readonly Mock<IJobDefinitionService> _jobDefinitionService;
        private readonly Mock<IJobQueueLogListener> _jobQueueLogListener;

        public QueueCommandTests()
        {
            var jobs = new List<JobDto>
            {
                new JobDto
                {
                    Id = 1,
                    ProjectId = 1,
                    Status = JobStatus.Queued
                }
            };

            var projects = new List<ProjectDto>
            {
                new ProjectDto
                {
                    Id = 1,
                    Name = "Project 1"
                }
            };

            var jobDefinitionss = new List<JobDefinitionDto>
            {
                new JobDefinitionDto
                {
                    Id = 1,
                    ProjectId = 1,
                    Name = "Default"
                }
            };

            _console = new Mock<IConsole>();
            _projectService = new Mock<IProjectService>();
            _projectService.Setup(p => p.GetProjectByName(It.IsAny<string>())).ReturnsAsync((string name) => projects.FirstOrDefault(p => p.Name == name));

            _jobDefinitionService = new Mock<IJobDefinitionService>();
            _jobDefinitionService.Setup(s => s.GetJobDefinitionByName(It.IsAny<int>(), It.IsAny<string>())).ReturnsAsync((int projectId, string name) => jobDefinitionss.FirstOrDefault(u => u.ProjectId == projectId && u.Name == name));

            _jobQueueService = new Mock<IJobQueueService>();
            _jobQueueService.Setup(s => s.GetJobQueues(It.IsAny<int>(), It.IsAny<string>())).ReturnsAsync(jobs);
            _jobQueueService.Setup(s => s.GetJobQueue(It.IsAny<int>(), It.IsAny<int>())).ReturnsAsync((int projectId, int queueId) => jobs.FirstOrDefault(u => u.Id == queueId));
            _jobQueueService.Setup(s => s.CreateJobQueue(It.IsAny<int>(), It.IsAny<NewJobDto>()))
                .ReturnsAsync((int projectId, NewJobDto dto) => new JobDto
                {
                    Id = 2,
                    ProjectId = projectId,
                    JobType = dto.JobType,
                    OriginUrl = dto.OriginUrl,
                    JobDefinitionId = dto.JobDefinitionId
                });

            _jobQueueLogListener = new Mock<IJobQueueLogListener>();
        }

        [Fact]
        public void Queue_Execute_ReturnsEmpty()
        {
            var command = new QueueCommand(_console.Object, LoggerMock.GetLogger<QueueCommand>().Object);
            var resultMessage = command.Execute();

            Assert.Equal("", resultMessage);
        }

        [Fact]
        public void QueueAdd_Execute_ReturnsSuccessMessage()
        {
            var command = new AddCommand(_console.Object, LoggerMock.GetLogger<AddCommand>().Object, _projectService.Object, _jobDefinitionService.Object, _jobQueueService.Object)
            {
                Project = "Project 1",
                Job = "Default"                
            };

            var resultMessage = command.Execute();

            Assert.StartsWith("Job Default queued:", resultMessage);
        }

        [Fact]
        public void QueueAdd_Execute_ReturnsNotFoundMessage()
        {
            var command = new AddCommand(_console.Object, LoggerMock.GetLogger<AddCommand>().Object, _projectService.Object, _jobDefinitionService.Object, _jobQueueService.Object)
            {
                Project = "Project 1",
                Job = "Default 2"
            };

            var resultMessage = command.Execute();

            Assert.Equal("Failed to add queue. Make sure the project and job definition names are correct.", resultMessage);
        }

        [Fact]
        public void QueueGet_Execute_JobQueuedReturnsSuccessMessage()
        {
            var command = new GetCommand(_console.Object, LoggerMock.GetLogger<GetCommand>().Object, _projectService.Object, _jobQueueService.Object, _jobQueueLogListener.Object)
            {
                Project = "Project 1",
                Number = 1
            };

            var resultMessage = command.Execute();

            Assert.StartsWith("Queue 1 is queued", resultMessage);
        }

        [Fact]
        public void QueueGet_Execute_JobCompletedReturnsSuccessMessage()
        {
            _jobQueueService.Setup(s => s.GetJobQueue(It.IsAny<int>(), It.IsAny<int>())).ReturnsAsync(new JobDto
            {
                Id = 1,
                ProjectId = 1,
                Status = JobStatus.Completed
            });
            _jobQueueService.Setup(s => s.GetJobLogs(It.IsAny<int>(), It.IsAny<int>())).ReturnsAsync("test logs");

            var command = new GetCommand(_console.Object, LoggerMock.GetLogger<GetCommand>().Object, _projectService.Object, _jobQueueService.Object, _jobQueueLogListener.Object)
            {
                Project = "Project 1",
                Number = 1
            };

            var resultMessage = command.Execute();

            Assert.Equal("test logs", resultMessage);
        }

        [Fact]
        public void QueueGet_Execute_JobProcessingReturnsSuccessMessage()
        {
            _jobQueueService.Setup(s => s.GetJobQueue(It.IsAny<int>(), It.IsAny<int>())).ReturnsAsync(new JobDto
            {
                Id = 1,
                ProjectId = 1,
                Status = JobStatus.Processing
            });
            _jobQueueLogListener.Setup(s => s.Listen(1, It.IsAny<Action<string>>(), It.IsAny<Action<string>>())).Returns(Task.CompletedTask);

            var command = new GetCommand(_console.Object, LoggerMock.GetLogger<GetCommand>().Object, _projectService.Object, _jobQueueService.Object, _jobQueueLogListener.Object)
            {
                Project = "Project 1",
                Number = 1
            };

            var resultMessage = command.Execute();

            _jobQueueLogListener.Verify(s => s.Listen(1, It.IsAny<Action<string>>(), It.IsAny<Action<string>>()), Times.Once);
        }

        [Fact]
        public void QueueGet_Execute_ReturnsNotFoundMessage()
        {
            var command = new GetCommand(_console.Object, LoggerMock.GetLogger<GetCommand>().Object, _projectService.Object, _jobQueueService.Object, _jobQueueLogListener.Object)
            {
                Project = "Project 1",
                Number = 2
            };

            var resultMessage = command.Execute();

            Assert.Equal("Failed getting queue 2. Make sure the project name and queue number are correct.", resultMessage);
        }

        [Fact]
        public void QueueList_Execute_ReturnsSuccessMessage()
        {
            var command = new ListCommand(_console.Object, LoggerMock.GetLogger<ListCommand>().Object, _projectService.Object, _jobQueueService.Object)
            {
                Project = "Project 1",
            };

            var resultMessage = command.Execute();

            Assert.StartsWith("Queues in project Project 1:", resultMessage);
        }

        [Fact]
        public void QueueList_Execute_ReturnsNotFoundMessage()
        {
            var command = new ListCommand(_console.Object, LoggerMock.GetLogger<ListCommand>().Object, _projectService.Object, _jobQueueService.Object)
            {
                Project = "Project 2",
            };

            var resultMessage = command.Execute();

            Assert.Equal("Project Project 2 was not found.", resultMessage);
        }

        [Fact]
        public void QueueRestart_Execute_ReturnsSuccessMessage()
        {
            var command = new RestartCommand(_console.Object, LoggerMock.GetLogger<RestartCommand>().Object, _projectService.Object, _jobDefinitionService.Object, _jobQueueService.Object)
            {
                Project = "Project 1",
                Number = 1
            };

            var resultMessage = command.Execute();

            Assert.StartsWith("Queue 1 restarted", resultMessage);
        }

        [Fact]
        public void QueueRestart_Execute_ReturnsNotFoundMessage()
        {
            var command = new RestartCommand(_console.Object, LoggerMock.GetLogger<RestartCommand>().Object, _projectService.Object, _jobDefinitionService.Object, _jobQueueService.Object)
            {
                Project = "Project 1",
                Number = 2
            };

            var resultMessage = command.Execute();

            Assert.Equal("Failed to restart queue. Make sure the project name and queue number are correct.", resultMessage);
        }
    }
}