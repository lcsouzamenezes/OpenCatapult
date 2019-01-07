# Hosting Provider
Hosting providers can be used in [Deploy task](../user-guides/job-definitions.md#deploy). This task uses the artifact from build task to deploy an application into deploy environment.

## Polyrific.Catapult.Plugins.AzureAppService
This is the built-in hosting provider in opencatapult. This plugin can be used to deploy a web application into azure app service instance. It uses kudu deploy `zipdeploy` api to upload the package and update the application.

### Usage
The hosting provider can only be used in deploy task. You can use the name `Polyrific.Catapult.Plugins.AzureAppService` when adding or updating a build task:

```sh
dotnet occli.dll task add -p SampleProject -j Default -n Deploy -t Deploy -prov Polyrific.Catapult.Plugins.AzureAppService
```

```sh
dotnet occli.dll task update -p SampleProject -j Default -n Deploy -prov Polyrific.Catapult.Plugins.AzureAppService
```

### Required services
This plugin require the `AzureAppService` external service to operate. Please refer to the [user guide](../user-guides/external-services.md#AzureAppService) for details on the external service

### Additional configs

This plugin have several additional configurations that you can use to fit your use case

| Name | Description | DefaultValue | Mandatory |
| --- | --- | --- | --- | --- |
| SubscriptionId | The subscription id for the app service | -| Yes |
| ResourceGroupName | The name of the resource group in which the app service reside | -| Yes |
| AppServiceName | The name of the app service to be deployed | -| Yes |
| DeploymentSlot | The deployment slot of the app service | -| No |
| ConnectionString | The connection string that shall be set to the app settings to be used by the application | -| No |