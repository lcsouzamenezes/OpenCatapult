# Command Line Interface

## Architecture

![Architecture](../img/cli-arch.jpeg)


## Commands
Opencatapult provide a command line interface to interact with the API. Following are the commands available:

### Login
Login to catapult. You will be prompted to input the user's password.

Usage:
```sh
dotnet occli.dll login --user [user]
```

**Options:**
* user (mandatory)
    * The user email used for login
    * Usage: `--user` (alias: `-u`)

### Logout
Logout from catapult

Usage:
```sh
dotnet occli.dll logout
```

### Account		
User account related commands			

#### Subcommands

* [Activate](account.md#activate)
* [List](account.md#list)
* [Register](account.md#register)
* [Remove](account.md#remove)
* [Suspend](account.md#suspend)
* [Update](account.md#update)
* [SetRole](account.md#setrole)
* [Password Update](account.md#password-update)
* [Password ResetToken](account.md#password-resettoken)
* [Password Reset](account.md#password-reset)

### Config		
CLI Configurations

Usage: 
```sh
dotnet occli.dll config [subcommands]
```

#### Subcommands

* [get](config.md#get)
* [import](config.md#import)
* [remove](config.md#remove)
* [set](config.md#set)

### Engine		
Catapult engine registration commands

Usage: 
```sh
dotnet occli.dll engine [subcommands]
```

#### Subcommands

* [activate](engine.md#activate)
* [get](engine.md#get)
* [list](engine.md#list)
* [register](engine.md#register)
* [remove](engine.md#remove)
* [suspend](engine.md#suspend)
* [token](engine.md#token)

### Job		
Job Definition related commands

Usage: 
```sh
dotnet occli.dll job [subcommands]
```

#### Subcommands

* [add](job.md#add)
* [list](job.md#list)
* [remove](job.md#remove)

### Member		
Project member related commands

Usage: 
```sh
dotnet occli.dll member [subcommands]
```

#### Subcommands

* [add](member.md#add)
* [list](member.md#list)
* [remove](member.md#remove)
* [update](member.md#update)

### Model		
Project Data Model related commands

Usage: 
```sh
dotnet occli.dll model [subcommands]
```

#### Subcommands

* [add](model.md#add)
* [list](model.md#list)
* [remove](model.md#remove)
* [update](model.md#update)

### Plugin		
Plugin registration commands

Usage: 
```sh
dotnet occli.dll plugin [subcommands]
```

#### Subcommands

* [get](plugin.md#get)
* [list](plugin.md#list)
* [register](plugin.md#register)
* [remove](plugin.md#remove)

### Project		
Project related commands

Usage: 
```sh
dotnet occli.dll project [subcommands]
```

#### Subcommands

* [archive](project.md#archive)
* [clone](project.md#clone)
* [create](project.md#create)
* [update](project.md#update)
* [export](project.md#export)
* [List](project.md#list)
* [remove](project.md#remove)
* [restore](project.md#restore)

### Property		
Project Data Model Property related commands

Usage: 
```sh
dotnet occli.dll property [subcommands]
```

#### Subcommands

* [add](property.md#add)
* [list](property.md#list)
* [remove](property.md#remove)
* [update](property.md#update)

### Queue		
Job Queue related commands

Usage: 
```sh
dotnet occli.dll queue [subcommands]
```

#### Subcommands

* [add](queue.md#add)
* [get](queue.md#get)
* [list](queue.md#list)
* [restart](queue.md#restart)

### Service		
External service related commands

Usage: 
```sh
dotnet occli.dll service [subcommands]
```

#### Subcommands

* [add](service.md#add)
* [get](service.md#get)
* [list](service.md#list)
* [remove](service.md#remove)
* [update](service.md#update)

### Task		
Job Task Definitions related commands

Usage: 
```sh
dotnet occli.dll task [subcommands]
```

#### Subcommands

* [add](task.md#add)
* [list](task.md#list)
* [remove](task.md#remove)