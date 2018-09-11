# Task

## Add

Add a new job task definition

Usage: `dotnet pc.dll task add --project [project] --job [job] --name [name]`

**Options**

project \(mandatory\)

 `--project` \(alias: `-p`\)

 Name of the projectjob \(mandatory\)

 `--job` \(alias: `-j`\)

 Name of the job definitionname \(mandatory\)

 `--name` \(alias: `-n`\)

 Name of the new job task definitiontype

 `--type` \(alias: `-t`\)

 Type of the task

 Default value: `generate`

 Allowed values: `generate` \| `push` \| `build` \| `deploy` \| `deploydb`property

 `--property` \(alias: `-prop`\)

 Property of the task. Several properties can be added. A key and value should be provided for each property using the format `key:value`. Sample usage: `--property githubUser:testuser --property githubPassword:testPassword`

## List

List job task definitions

Usage: `dotnet pc.dll task list --project [project] --job [job]`

**Options**

project \(mandatory\)

 `--project` \(alias: `-p`\)

 Name of the projectjob \(mandatory\)

 `--job` \(alias: `-j`\)

 Name of the job definition

## Remove

Remove a job task definition

Usage: `dotnet pc.dll task remove --project [project] --job [job] --name [name]`

**Options**

project \(mandatory\)

 `--project` \(alias: `-p`\)

 Name of the projectjob \(mandatory\)

 `--job` \(alias: `-j`\)

 Name of the job definitionname \(mandatory\)

 `--name` \(alias: `-n`\)

 Name of the job task definition to be removed

## Update

Update a job task definition

Usage: `dotnet pc.dll task update --project [project] --job [job] --name [name] --rename [newname]`

**Options**

project \(mandatory\)

 `--project` \(alias: `-p`\)

 Name of the projectjob \(mandatory\)

 `--job` \(alias: `-j`\)

 Name of the job definitionname \(mandatory\)

 `--name` \(alias: `-n`\)

 Name of the data modelrename

 `--rename` \(alias: `-r`\)

 New name of the job task definitiontype

 `--type` \(alias: `-t`\)

 Type of the task

 Allowed values: `generate` \| `push` \| `build` \| `deploy` \| `deploydb`property

 `--property` \(alias: `-prop`\)

 Property of the task. Several properties can be added. A key and value should be provided for each property using the format `key:value`. Sample usage: `--property githubUser:testuser --property githubPassword:testPassword`

