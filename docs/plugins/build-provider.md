# Build Provider
Build providers can be used in [Build task](../user-guides/job-definitions.md#build). This provider build the generated source code, and create a publishable artifact. The artifact can then be used by [Hosting provider](hosting-provider.md) or [Database provider](database-provider.md) to deploy the application and database.

## Polyrific.Catapult.Plugins.DotNetCore
This is the built-in build provider in opencatapult. This plugin can be used to build and create deployable artifact for dotnet core applications. It uses the `dotnet publish` command that comes with the dotnet core sdk.

### Usage
The build provider can only be used in build task. You can use the name `Polyrific.Catapult.Plugins.DotNetCore` when adding or updating a build task:

```sh
dotnet occli.dll task add -p SampleProject -j Default -n Build -t Build -prov Polyrific.Catapult.Plugins.DotNetCore
```

```sh
dotnet occli.dll task update -p SampleProject -j Default -n Build -prov Polyrific.Catapult.Plugins.DotNetCore
```

### Additional configs

This plugin have several additional configurations that you can use to fit your use case

| Name | Description | DefaultValue | Mandatory |
| --- | --- | --- | --- | --- |
| CsprojLocation | The location/path of the startup project | {ProjectName}.csproj| No |
| Configuration | The build configuration used in the build process | Release| No |