# CLI

Opencatapult provide a command line interface to interact with the API

## Login

Login to catapult

Usage: `dotnet pc.dll login --user [user] --password [password]`

**Options:**

user \(mandatory\)

 `--user` \(alias: `-u`\)

 The user email used for loginpassword \(mandatory\)

 `--password` \(alias: `-p`\)

 The password of the user

## Logout

Logout from catapult

Usage: `dotnet pc.dll logout`

## Account

User account related commands

### Subcommands

* [Register](account.md#register)
* [Remove](account.md#remove)
* [Suspend](account.md#suspend)
* [Activate](account.md#activate)

## Engine

Catapult engine registration commands

Usage: `dotnet pc.dll engine [subcommands]`

### Subcommands

* [activate](engine.md#activate)
* [get](engine.md#get)
* [list](engine.md#list)
* [register](engine.md#register)
* [remove](engine.md#remove)
* [suspend](engine.md#suspend)
* [token](engine.md#token)

## Job

Job Definition related commands

Usage: `dotnet pc.dll job [subcommands]`

### Subcommands

* [add](job.md#add)
* [list](job.md#list)
* [remove](job.md#remove)

## Member

Project member related commands

Usage: `dotnet pc.dll member [subcommands]`

### Subcommands

* [add](member.md#add)
* [list](member.md#list)
* [remove](member.md#remove)
* [update](member.md#update)

## Model

Project Data Model related commands

Usage: `dotnet pc.dll model [subcommands]`

### Subcommands

* [add](model.md#add)
* [list](model.md#list)
* [remove](model.md#remove)
* [update](model.md#update)

## Project

Project related commands

Usage: `dotnet pc.dll project [subcommands]`

### Subcommands

* [archive](project.md#archive)
* [clone](project.md#clone)
* [create](project.md#create)
* [export](project.md#export)
* [List](project.md#list)
* [remove](project.md#remove)
* [restore](project.md#restore)

## Property

Project Data Model Property related commands

Usage: `dotnet pc.dll property [subcommands]`

### Subcommands

* [add](property.md#add)
* [list](property.md#list)
* [remove](property.md#remove)
* [update](property.md#update)

## Property

Job Queue related command.

Usage: `dotnet pc.dll queue [subcommands]`

### Subcommands

* [add](queue.md#add)
* [get](queue.md#get)
* [list](queue.md#list)
* [restart](queue.md#restart)

## Task

Job Task Definitions related command.

Usage: `dotnet pc.dll task [subcommands]`

### Subcommands

* [add](task.md#add)
* [list](task.md#list)
* [remove](task.md#remove)
* [update](task.md#update)

