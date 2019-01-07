# Database Provider
Database providers can be used in [Deploy Db task](../user-guides/job-definitions.md#deploydb). This task uses the artifact from build task to update the database in the deployment environment.

## Polyrific.Catapult.Plugins.EntityFrameworkCore
This is the built-in database provider in opencatapult. This plugin can be used to update a specified database to the latest migration script available in the source code. It uses the `dotnet ef database update` command that comes with the dotnet core entity framework sdk.

### Usage
The database provider can only be used in deploy db task. You can use the name `Polyrific.Catapult.Plugins.EntityFrameworkCore` when adding or updating a build task:

```sh
dotnet occli.dll task add -p SampleProject -j Default -n DeployDb -t DeployDb -prov Polyrific.Catapult.Plugins.EntityFrameworkCore
```

```sh
dotnet occli.dll task update -p SampleProject -j Default -n DeployDb -prov Polyrific.Catapult.Plugins.EntityFrameworkCore
```

### Additional configs

This plugin have several additional configurations that you can use to fit your use case

| Name | Description | DefaultValue | Mandatory |
| --- | --- | --- | --- | --- |
| StartupProjectName | The name of the startup project | {ProjectName}| No |
| DatabaseProjectName | The name of the project that contains ef database migrations | {ProjectName}.Data| No |
| ConnectionString | The connection string to the database that will be updated | -| Yes |