# Add

Add a new job definition

Usage: 
```sh
dotnet occli.dll job add --project [project] --name [name]
```

**Options**
* project (mandatory)
    * Name of the project
    * Usage: `--project` (alias: `-p`)
* name (mandatory)
    * Name of the new job definition
    * Usage: `--name` (alias: `-n`)

# List
List project's job definition

Usage: 
```sh
dotnet occli.dll job list --project [project]
```

# Get
Get a single job definition detailed record

Usage: 
```sh
dotnet occli.dll job get --project [project] --name [name]
```

**Options**
* project (mandatory)
    * Name of the project
    * Usage: `--project` (alias: `-p`)
* name (mandatory)
    * Name of the new job definition
    * Usage: `--name` (alias: `-n`)

# Remove
Remove a job definition

Usage: 
```sh
dotnet occli.dll job remove --project [project] --name [name]
```

**Options**
* project (mandatory)
    * Name of the project
    * Usage: `--project` (alias: `-p`)
* name (mandatory)
    * Name of the job definition to be removed
    * Usage: `--name` (alias: `-n`)
* autoconfirm
    * Perform the removal without asking for confirmation
    * Usage: `--autoconfirm` (alias: `-ac`)

# Update
Update a job definition

Usage: 
```sh
dotnet occli.dll job update --project [project] --name [name] --rename [new name]
```

**Options**
* project (mandatory)
    * Name of the project
    * Usage: `--project` (alias: `-p`)
* name (mandatory)
    * Name of the job definition to be updated
    * Usage: `--name` (alias: `-n`)
* rename
    * New name of the job definition
    * Usage: `--rename` (alias: `-rn`)
