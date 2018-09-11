# Project

## Archive

Archive a project

Usage: `dotnet pc.dll project archive --name [name]`

**Options**

name \(mandatory\)

 `--name` \(alias: `-n`\)

 Name of the project to be archived

## Clone

Clone a project

Usage: `dotnet pc.dll project clone --project [project] --name [name]`

**Options**

project \(mandatory\)

 `--project` \(alias: `-p`\)

 Name of the project to be clonedname \(mandatory\)

 `--name` \(alias: `-n`\)

 Name of the new project

## Create

Create a project

Usage: `dotnet pc.dll project create --name [name] --client [client] --template [template]`

**Options**

name \(mandatory\)

 `--name` \(alias: `-n`\)

 Name of the new projectclient

 `--client` \(alias: `-c`\)

 Client of the new projecttemplate

 `--template` \(alias: `-t`\)

 Project template name or path to template file \(.yaml\)

## Export

Export project into a yaml file

Usage: `dotnet pc.dll project export --name [name]`

**Options**

name \(mandatory\)

 `--name` \(alias: `-n`\)

 Name of the project to be exportedoutput

 `--output` \(alias: `-o`\)

 Output file location

## List

List projects which the user has access to

Usage: `dotnet pc.dll project list --status [status]`

**Options**

status

 `--status` \(alias: `-s`\)

 Filter the projects by their status

 Default value: `all`

 Allowed values: `all` \| `active` \| `archived`

## Remove

Remove a project

Usage: `dotnet pc.dll project remove --name [name]`

**Options**

name \(mandatory\)

 `--name` \(alias: `-n`\)

 Name of the project to be removed

## restore

Restore an archived project

Usage: `dotnet pc.dll project restore --name [name]`

**Options**

name \(mandatory\)

 `--name` \(alias: `-n`\)

 Name of the project to be restored

