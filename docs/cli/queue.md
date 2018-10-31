# Add

Add job to queue

Usage: 
```sh
dotnet occli.dll queue add --project [project] --job [job]
```

**Options**
* project (mandatory)
    * Name of the project
    * Usage: `--project` (alias: `-p`)
* job (mandatory)
    * Name of the job definition
    * Usage: `--job` (alias: `-j`)

# Get
Get a single job queue detailed record

Usage: 
```sh
dotnet occli.dll queue get --project [project] --number [number]
```

**Options**
* project (mandatory)
    * Name of the project
    * Usage: `--project` (alias: `-p`)
* number (mandatory)
    * Queue number (Id or Code)
    * Usage: `--number` (alias: `-n`)

# List
List queued jobs

Usage: 
```sh
dotnet occli.dll queue list --project [project]
```

**Options**
* project (mandatory)
    * Name of the project
    * Usage: `--project` (alias: `-p`)

# Log
Get complete log of a queued job

Usage: 
```sh
dotnet occli.dll queue log --project [project] --number [number]
```

**Options**
* project (mandatory)
    * Name of the project
    * Usage: `--project` (alias: `-p`)
* number (mandatory)
    * Queue number (Id or Code)
    * Usage: `--number` (alias: `-n`)

# Restart
Restart the pending queue

Usage: 
```sh
dotnet occli.dll queue restart --project [project] --number [number]
```

**Options**
* project (mandatory)
    * Name of the project
    * Usage: `--project` (alias: `-p`)
* number (mandatory)
    * Queue number (Id or Code)
    * Usage: `--number` (alias: `-n`)
