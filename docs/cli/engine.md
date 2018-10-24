# Activate

Activate a suspended engine

Usage: 
```sh
dotnet occli.dll engine activate --name [name]
```

**Options**
* name (mandatory)
    * Name of the engine to be activated
    * Usage: `--name` (alias: `-n`)

# Get
Get a single engine record

Usage: 
```sh
dotnet occli.dll engine get --name [name]
```

**Options**
* name (mandatory)
    * Name of the engine to get
    * Usage: `--name` (alias: `-n`)
    
# List
List registered engines

Usage: 
```sh
dotnet occli.dll engine list --status [status]
```

**Options**
* status
    * Filter the engines by their status
    * Usage: `--status` (alias: `-s`)
    * Allowed values: Allowed values: `all` | `active` | `suspended` | `running`
    * Default value: `all`

# Register
Register a new engine

Usage: 
```sh
dotnet occli.dll engine register --name [name]
```

**Options**
* name (mandatory)
    * Name of the engine to be registered
    * Usage: `--name` (alias: `-n`)

# Remove
Remove an engine

Usage: 
```sh
dotnet occli.dll engine remove --name [name]
```

**Options**
* name (mandatory)
    * Name of the engine to be removed
    * Usage: `--name` (alias: `-n`)
* autoconfirm
    * Perform the removal without asking for confirmation
    * Usage: `--autoconfirm` (alias: `-ac`)

# Suspend
Suspend an engine

Usage: 
```sh
dotnet occli.dll engine suspend --name [name]
```

**Options**
* name (mandatory)
    * Name of the engine to be suspended
    * Usage: `--name` (alias: `-n`)

# Token
Generate a token for the engine

Usage: 
```sh
dotnet occli.dll engine token --name [name]
```

**Options**
* name (mandatory)
    * Name of the engine
    * Usage: `--name` (alias: `-n`)
