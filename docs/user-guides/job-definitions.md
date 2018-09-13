# Manage job definitions

Job definitions contain jobs that can be [queued](job-queues.md) to [engine](engine-registration.md). Each job definition would contains a list of task that the engine would need to execute.

## Add job definition

Add new job definition by specifying the project name and the new job definition name
```sh
dotnet pc.dll job add --project my-project --name Default
```

All of the created job for a project can be viewed using the `list` command:
```sh
dotnet pc.dll job list --project my-project
```

## Remove job definition

Remove job definition by specifying the project name and the job definition name to be removed
```sh
dotnet pc.dll job remove --project my-project --name Default
```

## Add job task

Add a task to a job definition by specifying the project name, job definition name, and the name of the new task. You can also specify the task properties that would be used in the task's service provider
```sh
dotnet pc.dll task add --project my-project --job Default --name generate --type generate --property generatorname:default
```

All of the created task for a job definition can be viewed using the `list` command:
```sh
dotnet pc.dll task list --project my-project --job Default
```

## Update job task

You can update a task by specifying the project name, job definition name, and the name of the task to be updated. Then you can specify the other options to be updated:
```sh
dotnet pc.dll task update --project my-project --job Default --name generate --property generatorname:defaultv2
```

## Remove job task

Remove a task by specifying the project name, the job definition name, and the task name to be removed
```sh
dotnet pc.dll task remove --project my-project --job Default --name generate
```

## Job task types

Available job task types:
- `generate`: Generate the source code of the project
- `push`: Upload the source code into source code repository such as Github
- `build`: Build the source code into deployable artifacts
- `deploy`: Deploy the build result into cloud provider such as Azure app service
- `deploydb`: Apply the changes in model into the deployed database

