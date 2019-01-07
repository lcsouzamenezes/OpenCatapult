# Manage job queues

You can queue a job into the engine, and monitor the result. 

## Queue a job

You can queue a job by specifying the project name and the job definition name to be queued.
```sh
dotnet occli.dll queue add --project MyProject --job Default
```

You will get a queue id. Use this id for other command such as getting the job status.

All of the queued job can be viewed using the `list` command:
```sh
dotnet occli.dll queue list --project MyProject
```

## Get job status

You can get the progressing job status in real time by using this command:
```sh
dotnet occli.dll queue get --project MyProject --number 1
```

## Restart job

There's a case where the status of the queue is pending. This is usually happened when a user action is needed. For example, the user need to review the updated code, before the engine perform the merge.
```sh
dotnet occli.dll queue restart --project MyProject --number 1
```

## Cancel job

You will need to cancel a job when it's force cancelled in the engine, or you don't want to continue a pending job. 

```sh
dotnet occli.dll queue cancel --project MyProject --number 1
```