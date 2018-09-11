# Property

## Add

Add a project data model property

Usage: `dotnet pc.dll property add --project [project] --model [model] --name [name]`

**Options**

project \(mandatory\)

 `--project` \(alias: `-p`\)

 Name of the projectmodel \(mandatory\)

 `--model` \(alias: `-m`\)

 Name of the data modelname \(mandatory\)

 `--name` \(alias: `-n`\)

 Name of the data model propertylabel

 `--label` \(alias: `-l`\)

 Label of the data model propertytype

 `--type` \(alias: `-t`\)

 Data type of the property

 Default value: `string`

 Allowed values: `string` \| `int` \| `short` \| `float` \| `double` \| `decimal` \| `bool` \| `datetime` \|`byte` \| `guid` \| `dbgeography`controltype

 `--controltype` \(alias: `-ct`\)

 Control type of the property

 Default value: `input-text`

 Allowed values: `input-text` \| `input-number` \| `input-file` \| `textarea` \| `checkbox` \| `select` \| `radio` \| `calendar` \|`image`relational

 `--relational` \(alias: `-r`\)

 Name of the related data modelrelationaltype

 `--relationaltype` \(alias: `-rt`\)

 Relationship type

 Default value: `one-to-one`

 Allowed values: `one-to-one` \| `one-to-many` \| `many-to-many`

## List

List properties in a data model

Usage: `dotnet pc.dll property list --project [project] --model [model`

**Options**

project \(mandatory\)

 `--project` \(alias: `-p`\)

 Name of the projectmodel \(mandatory\)

 `--model` \(alias: `-m`\)

 Name of the data model

## Remove

Remove a project data model property

Usage: `dotnet pc.dll property remove --project [project] --model [model] --name [name]`

**Options**

project \(mandatory\)

 `--project` \(alias: `-p`\)

 Name of the projectmodel \(mandatory\)

 `--model` \(alias: `-m`\)

 Name of the data modelname \(mandatory\)

 `--name` \(alias: `-n`\)

 Name of the data model property

## Update

Update a project data model property

Usage: `dotnet pc.dll property update --project [project] --name [name] --rename [newname]`

**Options**

project \(mandatory\)

 `--project` \(alias: `-p`\)

 Name of the projectmodel \(mandatory\)

 `--model` \(alias: `-m`\)

 Name of the data modelname \(mandatory\)

 `--name` \(alias: `-n`\)

 Name of the data model propertyrename

 `--rename` \(alias: `-r`\)

 New name of the data model propertylabel

 `--label` \(alias: `-l`\)

 Label of the data model propertytype

 `--type` \(alias: `-t`\)

 Data type of the property

 Allowed values: `string` \| `int` \| `short` \| `float` \| `double` \| `decimal` \| `bool` \| `datetime` \|`byte` \| `guid` \| `dbgeography`controltype

 `--controltype` \(alias: `-ct`\)

 Control type of the property

 Allowed values: `input-text` \| `input-number` \| `input-file` \| `textarea` \| `checkbox` \| `select` \| `radio` \| `calendar` \|`image`relational

 `--relational` \(alias: `-r`\)

 Name of the related data modelrelationaltype

 `--relationaltype` \(alias: `-rt`\)

 Relationship type

 Allowed values: `one-to-one` \| `one-to-many` \| `many-to-many`

