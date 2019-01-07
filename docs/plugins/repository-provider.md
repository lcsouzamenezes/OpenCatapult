# Repository Provider
Repository provider can be used for [Clone task](../user-guides/job-definitions.md#clone), [Push task](../user-guides/job-definitions.md#push), and [Merge task](../user-guides/job-definitions.md#merge). So, a repository provider should be able to handle those 3 tasks. 

## Polyrific.Catapult.Plugins.GitHub
This is the built-in repository provider in opencatapult. This plugin can be used to clone, push, create pull request, and merge into github repository. 

### Usage
The repository provider can be used in clone, push, and merge task. You can use the name `Polyrific.Catapult.Plugins.GitHub` when adding or updating the task:

```sh
dotnet occli.dll task add -p SampleProject -j Default -n Clone -t Clone -prov Polyrific.Catapult.Plugins.GitHub
```

```sh
dotnet occli.dll task update -p SampleProject -j Default -n Clone -prov Polyrific.Catapult.Plugins.GitHub
```

### Required services
This plugin require the `GitHub` external service to operate. Please refer to the [user guide](../user-guides/external-services.md#GitHub) for details on the external service