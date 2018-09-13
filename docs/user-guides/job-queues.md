# Manage job queues

You can queue a job into the engine, and monitor the result. 

## Queue a job

You can queue a job by specifying the project name and the job definition name to be queued.
```sh
dotnet pc.dll queue add --project my-project --job Default
```

You will get a queue id. Use this id for other command such as getting the job status.

All of the queued job can be viewed using the `list` command:
```sh
dotnet pc.dll queue list --project my-project
```

## Get job status

You can get the progressing job status in real time by using this command:
```sh
dotnet pc.dll queue get --number 1
```

## Cancel job

You can cancel a job before it's processed:
```sh
dotnet pc.dll queue cancel --number 1
```

## Restart job

There's a case where the status of the queue is pending. This is usually happened when a user action is needed. For example, the user need to review the updated code, before the engine perform the merge.
```sh
dotnet pc.dll queue restart --number 1
```