# Engine

## Activate

Activate a suspended engine

Usage: `dotnet pc.dll engine activate --name [name]`

**Options**

name \(mandatory\)

 `--name` \(alias: `-n`\)

 Name of the engine to be activated

## Get

Get a single engine record

Usage: `dotnet pc.dll engine get --name [name]`

**Options**

name \(mandatory\)

 `--name` \(alias: `-n`\)

 Name of the engine to get

## List

List registered engines

Usage: `dotnet pc.dll engine list --status [status]`

**Options**

status

 `--status` \(alias: `-s`\)

 Filter the engines by their status.

 Allowed values: `all` \| `active` \| `suspended` \| `running`.

 Default value: `all`.

## Register

Register a new engine

Usage: `dotnet pc.dll engine register --name [name]`

**Options**

name \(mandatory\)

 `--name` \(alias: `-n`\)

 Name of the engine to be registered

## Remove

Remove an engine

Usage: `dotnet pc.dll engine remove --name [name]`

**Options**

name \(mandatory\)

 `--name` \(alias: `-n`\)

 Name of the engine to be removed

## Suspend

Suspend an engine

Usage: `dotnet pc.dll engine suspend --name [name]`

**Options**

name \(mandatory\)

 `--name` \(alias: `-n`\)

 Name of the engine to be suspended

## Token

Generate a token for the engine

Usage: `dotnet pc.dll engine token --name [name]`

**Options**

name \(mandatory\)

 `--name` \(alias: `-n`\)

 Name of the engine

