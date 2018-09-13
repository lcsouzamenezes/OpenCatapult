# Manage projects

In catapult, a project is a software project you are working on. It can have several applications in it. For example, a project can contain an API, an Admin application, and a front-facing customer application.

## Create project
Create a project by specifying the name and optionally the client of this project
```sh
dotnet PC.dll project create --name my-project --client Polyrific
```

You can also create a project based on a previously exported project, by using the `template` option:
```sh
dotnet PC.dll project create --name my-project --client Polyrific --template my-previous-project
```

Finally, [service providers](../home/intro.md#service-providers-plugins) may have some configuration key that you can override for each project. You can set this when creating the project by using the `property` option:
```sh
dotnet PC.dll project create --name my-project --client Polyrific --property createAdmin:false  
```

For the configuration key that the service provider have, please refer to each service provider's page.

All of the created projects can be viewed using the `list` command:
```sh
dotnet pc.dll project list
```

## Update project

You can update the project's client or property by using the `update` command:
```sh
dotnet PC.dll project update --name my-project --client Polyrific --property createAdmin:false
```

## Remove project

Remove a project by specifying the name of the project to be removed:
```sh
dotnet PC.dll project remove --name my-project
```

## Archive project

When you want to remove external services of a project, but don't want to remove the project from the database, you can opt to archive it. The archived project can be [restored](#restore-project) later.
```sh
dotnet PC.dll project archive --name my-project
```

## Restore project

Restore an archived project by specifying the name of the project:
```sh
dotnet PC.dll project restore --name my-project
```

## Clone project

You can clone an existing project, and create a new one. The new project will have the [models](data-models.md) copied from the cloned project. You can optionally copy the [members](project-members.md) and [jobs](job-definitions.md) by using the option `includemember` and `includejob` respectively:
```sh
dotnet pc.dll project clone --project my-project --name my-other-project --includemember --includejob
```

## Export project

You can export an existing project into a yaml file, when then can be used as a template when you create a new project. 
```sh
dotnet pc.dll project export --name my-project
```

The yaml file will be created in the AppData folder. You can also specify a specific location for the template file to be saved:
```sh
dotnet pc.dll project export --name my-project --output D:/my-project.yaml
```