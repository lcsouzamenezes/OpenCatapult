# Test Provider
Test providers can be used in [Test task](../user-guides/job-definitions.md#test). This task runs the unit test of the dotnet core 

## Polyrific.Catapult.Plugins.DotNetCoreTest
This is the built-in test provider in opencatapult. This plugin can be used to run the test from the generated dotnet core application. It uses the `dotnet test` command that comes with the dotnet core entity framework sdk.

### Usage
The test provider can only be used in test task. You can use the name `Polyrific.Catapult.Plugins.DotNetCoreTest` when adding or updating a test task:

```sh
dotnet occli.dll task add -p SampleProject -j Default -n Test -t Test -prov Polyrific.Catapult.Plugins.DotNetCoreTest
```

```sh
dotnet occli.dll task update -p SampleProject -j Default -n Test -prov Polyrific.Catapult.Plugins.DotNetCoreTest
```