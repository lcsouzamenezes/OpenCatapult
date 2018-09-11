# Queue

## Add

Add job to queue

Usage: `dotnet pc.dll queue add --project [project] --job [job]`

**Options**

project \(mandatory\)

 `--project` \(alias: `-p`\)

 Name of the projectjob \(mandatory\)

 `--job` \(alias: `-j`\)

 Name of the job definition

## List

List queued jobs

Usage: `dotnet pc.dll queue list --project [project]`

**Options**

project \(mandatory\)

 `--project` \(alias: `-p`\)

 Name of the project

## Get

Get complete log of a queued job

Usage: `dotnet pc.dll queue get --project [project] --number [number]`

**Options**

project \(mandatory\)

 `--project` \(alias: `-p`\)

 Name of the projectnumber \(mandatory\)

 `--number` \(alias: `-n`\)

 Queue number

## Restart

Restart the pending queue

Usage: `dotnet pc.dll queue restart --project [project] --number [number]`

**Options**

project \(mandatory\)

 `--project` \(alias: `-p`\)

 Name of the projectnumber \(mandatory\)

 `--number` \(alias: `-n`\)

 Queue number

