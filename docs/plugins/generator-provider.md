# Generator Provider
Generator providers can be used in [Generate task](../user-guides/job-definitions.md#generate). This task will generate the source code based on the project configuration and its defined models.

## Polyrific.Catapult.Plugins.AspNetCoreMvc
This is the built-in generator provider in opencatapult. This plugin will create a web application using AspNet Core Mvc. The generated code further explained in the last section.

### Usage
The generator provider can only be used in generate task. You can use the name `Polyrific.Catapult.Plugins.AspNetCoreMvc` when adding or updating a build task:

```sh
dotnet occli.dll task add -p SampleProject -j Default -n Generate -t Generate -prov Polyrific.Catapult.Plugins.AspNetCoreMvc
```

```sh
dotnet occli.dll task update -p SampleProject -j Default -n Generate -prov Polyrific.Catapult.Plugins.AspNetCoreMvc
```

### Additional configs

This plugin have several additional configurations that you can use to fit your use case

| Name | Description | DefaultValue | Mandatory |
| --- | --- | --- | --- | --- |
| AdminEmail | The email of the admin user used to login to the application | - | Yes |

### Structures of generated code
The AspNetCoreMvc generator will generate the code with the following structure:
- Main Web Project: The Web UI project. It uses Asp Net Core Mvc as the web framework.
- Business layer project: The core business of the applications reside here.
- Data project: The project that define the structure of physical database. It uses entity framework core fluent API to define the data structure, and generate migration script.
- Infrastructure project: Mainly used to define the dependency injection between Data project and Main Web project, to keep the dependency clean.

<!--TODO: explain more on the template>
