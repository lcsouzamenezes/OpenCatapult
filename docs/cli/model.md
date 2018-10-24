# Add

Add a project data model

Usage: 
```sh
dotnet occli.dll model add --project [project] --name [name]
```

**Options**
* project (mandatory)
    * Name of the project
    * Usage: `--project` (alias: `-p`)
* name (mandatory)
    * Name of the data model
    * Usage: `--name` (alias: `-n`)
* description
    * Description of the data model
    * Usage: `--description` (alias: `-d`)
* label
    * Label of the data model
    * Usage: `--label` (alias: `-l`)

# List
List data models in a project

Usage: 
```sh
dotnet occli.dll model list --project [project]
```

**Options**
* project (mandatory)
    * Name of the project
    * Usage: `--project` (alias: `-p`)

# Remove
Remove a project data model

Usage: 
```sh
dotnet occli.dll model remove --project [project] --name [name]
```

**Options**
* project (mandatory)
    * Name of the project
    * Usage: `--project` (alias: `-p`)
* name (mandatory)
    * Name of the data model
    * Usage: `--name` (alias: `-n`)
* autoconfirm
    * Perform the removal without asking for confirmation
    * Usage: `--autoconfirm` (alias: `-ac`)

# Update
Update a project data model

Usage: 
```sh
dotnet occli.dll model update --project [project] --name [name] --rename [newname]
```

**Options**
* project (mandatory)
    * Name of the project
    * Usage: `--project` (alias: `-p`)
* name (mandatory)
    * Name of the data model
    * Usage: `--name` (alias: `-n`)
* rename
    * New name of the data model
    * Usage: `--rename` (alias: `-r`)
* description
    * Description of the data model
    * Usage: `--description` (alias: `-d`)
* label
    * Label of the data model
    * Usage: `--label` (alias: `-l`)
