# Manage data models

Data models are the entities in your project. 

## Add data model

Add new data model by specifying the project name and the new data model name. You can also specify the description and label of the data model.
```sh
dotnet PC.dll model add --project MyProject --name Product --description "Product data model" --label Product
```

All of the created model for a project can be viewed using the `list` command:
```sh
dotnet pc.dll model list --project MyProject
```

## Update data model

You can update adata model by specifying the project name and the new data model name, then specify the new name or other options to be updated
```sh
dotnet PC.dll model update --project MyProject --name Product --rename Item --description "Item data model" --label Item
```

## Remove data model

Remove a data model by specifying the project name and data model name to be removed:
```sh
dotnet PC.dll model remove --project MyProject --name Product
```

## Add data model property

Add new property of a data model by specifying the project name, data model name, and property name. 
```sh
dotnet pc.dll property add --project MyProject --model Product --name Price
```

If not set, the data type is set to `string`, and the control type is set to `input-text`. You can optionally set them if you want to change to another type:
```sh
dotnet pc.dll property add --project MyProject --model Product --name Price --type int --controltype input-number
```

Lastly, you can add a relational property, if you want to relate a model to another model:
```sh
dotnet pc.dll property add --project MyProject --model Product --name Tags --relational Tag --relationaltype one-to-many
```

All of the created property for a model can be viewed using the `list` command:
```sh
dotnet pc.dll property list --project MyProject --model Product
```

## Update data model property

You can update a property by specifying the project name, data model name, and property name, then specify the new value for other options:
```sh
dotnet pc.dll property add --project MyProject --model Product --name Price --type decimal --controltype input-number
```

## Remove data model property

Remove a data model by specifying the project name, data model name, and the property name to be removed:
```sh
dotnet PC.dll property remove --project MyProject --model Product --name Price
```

## Data model property type

Data types of data model property:
- `string`
- `int`
- `short`
- `float`
- `double`
- `decimal`
- `bool`
- `datetime`
- `byte`
- `guid`
- `dbgeography`

## Data model property control type

Control types of data model property:
- `input-text`
- `input-number`
- `input-file`
- `textarea`
- `checkbox`
- `select`
- `radio`
- `calendar`
- `image`

## Data model property relationship

Types of data model relationship:
- `one-to-one`: The property is related to one object instance of the related model
- `one-to-many`: The property contains list of object instances of the related model
- `many-to-many`: The property contains list of object instances of the related model, and the related model may also have list of object instances of the current model.

