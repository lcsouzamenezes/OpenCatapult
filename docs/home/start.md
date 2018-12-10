# Quick Start

This document will guide you to get started with `OpenCatapult`.

_Note: although it is planned that OpenCatapult will support multi-platform environments in the future, but the defined steps below are tested in Windows environment only for now._

## Setup from release library

[coming soon]

## Build from source code

**Prerequisites:**

- Git (https://git-scm.com/)
- .Net Core 2.1 SDK (https://dot.net)
  - You can download the latest version of the installer
- SQL Server 2017 (https://www.microsoft.com/en-us/sql-server/sql-server-2017)
  - If you want to use local instance, you can use the `Express` or `Developer` edition
  - You can alo use remote instance (e.g. Azure SQL)
- [Optional] Code editor, e.g. Visual Studio Code (https://code.visualstudio.com/)

**Get the source code**

Clone `OpenCatapult` source code from the repository:

```sh
git clone https://github.com/Polyrific-Inc/OpenCatapult.git
```

Go to the root folder:

```sh
cd OpenCatapult
```

From this point you have two options: build the source code using PowerShell scripts, or build manually.

### Option 1: Build using PowerShell scripts

Note: when running the scripts, you might get execution policy error. In most of the time it can be fixed by setting the execution policy to `RemoteSigned`:
```powershell
Set-ExecutionPolicy -ExecutionPolicy RemoteSigned
```

Please check the following [article](https://docs.microsoft.com/en-us/powershell/module/microsoft.powershell.core/about/about_execution_policies?view=powershell-6) for more details about execution policies.

**Run pre-requisites script**

This script will check your environment for required tools to build OpenCatapult source code:
```powershell
.\builds\build-prerequisites.ps1
```

**Run API build script**

Before running the script, you need to prepare a database, which the connection string needs to be inputted later.

Let's run the script to publish and run the API:
```powershell
.\builds\build-api.ps1
```

By default it will listen to url http://localhost:8005 and https://localhost:44305. If you want to set it to different urls, please use `-http` or `-https` parameter respectively:
```powershell
.\builds\build-api.ps1 -http http://localhost:5000 -https https://localhost:5001
```

**Run Engine build script**

Open a new PowerShell instance, and run the script to publish the Engine:
```powershell
.\builds\build-engine.ps1
```

**Run CLI build script**

Open a new PowerShell instance, and run the script to publish the CLI:
```powershell
.\builds\build-cli.ps1
```

### Option 2: Build from source code manually

If for any reasons you cannot run the PowerShell scripts, you can always build the source code manually by following these steps:

**Setup database**

Please make sure you have access to a SQL Server instance, and put the connection string in `.\src\API\Polyrific.Catapult.Api\appsettings.json`, e.g.

```json
{
  "ConnectionStrings": {
    "DefaultConnection": "Server=localhost;Database=opencatapult-db;User ID=sa;Password=sapassword;"
  }
}
```

Note: You don't need to create the database in advance because EF will automatically create it if it doesn't exist.

Run the migration script to initialize the database:
```sh
dotnet ef database update --startup-project .\src\API\Polyrific.Catapult.Api\Polyrific.Catapult.Api.csproj --project .\src\API\Polyrific.Catapult.Api.Data\Polyrific.Catapult.Api.Data.csproj
```

**Run the API**

Let's publish and run the API in localhost:

```sh
dotnet publish .\src\API\Polyrific.Catapult.Api\Polyrific.Catapult.Api.csproj -c Release -o ..\..\..\publish\api
cd .\publish\api\
dotnet .\ocapi.dll --urls "http://localhost:8005;https://localhost:44305"
```

**Prepare the Engine**

Open new shell, go to the root folder, and publish the Engine:

```sh
dotnet publish .\src\Engine\Polyrific.Catapult.Engine\Polyrific.Catapult.Engine.csproj -c Release -o ..\..\..\publish\engine
```

Set API URL in the Engine's config:

```sh
dotnet .\publish\engine\ocengine.dll config set -n ApiUrl -v https://localhost:44305
```

While configuring the Engine environment, let's publish the built-in plugins as well. They will be required later when executing job tasks.

```sh
dotnet publish .\src\Plugins\GeneratorProvider\Polyrific.Catapult.Plugins.AspNetCoreMvc\src\Polyrific.Catapult.Plugins.AspNetCoreMvc.csproj -c Release -o ..\..\..\..\publish\engine\plugins\GeneratorProvider\Polyrific.Catapult.Plugins.AspNetCoreMvc
dotnet publish .\src\Plugins\HostingProvider\Polyrific.Catapult.Plugins.AzureAppService\src\Polyrific.Catapult.Plugins.AzureAppService.csproj -c Release -o ..\..\..\..\publish\engine\plugins\HostingProvider\Polyrific.Catapult.Plugins.AzureAppService
dotnet publish .\src\Plugins\BuildProvider\Polyrific.Catapult.Plugins.DotNetCore\src\Polyrific.Catapult.Plugins.DotNetCore.csproj -c Release -o ..\..\..\..\publish\engine\plugins\BuildProvider\Polyrific.Catapult.Plugins.DotNetCore
dotnet publish .\src\Plugins\TestProvider\Polyrific.Catapult.Plugins.DotNetCoreTest\src\Polyrific.Catapult.Plugins.DotNetCoreTest.csproj -c Release -o ..\..\..\..\publish\engine\plugins\TestProvider\Polyrific.Catapult.Plugins.DotNetCoreTest
dotnet publish .\src\Plugins\DatabaseProvider\Polyrific.Catapult.Plugins.EntityFrameworkCore\src\Polyrific.Catapult.Plugins.EntityFrameworkCore.csproj -c Release -o ..\..\..\..\publish\engine\plugins\DatabaseProvider\Polyrific.Catapult.Plugins.EntityFrameworkCore
dotnet publish .\src\Plugins\RepositoryProvider\Polyrific.Catapult.Plugins.GitHub\src\Polyrific.Catapult.Plugins.GitHub.csproj -c Release -o ..\..\..\..\publish\engine\plugins\RepositoryProvider\Polyrific.Catapult.Plugins.GitHub
```

**Prepare the CLI**

Open new shell, go to the root folder, and build the CLI project:

```sh
dotnet publish .\src\CLI\Polyrific.Catapult.Cli\Polyrific.Catapult.Cli.csproj -c Release -o ..\..\..\publish\cli
```

Set API URL in the CLI's config:

```sh
dotnet .\publish\cli\occli.dll config set -n ApiUrl -v https://localhost:44305
```

**Note:**

If you have some error related to ssl, you can try to run the following command, and accept the popup prompt:
```sh
dotnet dev-certs https --trust
```

If for any reasons you cannot use https, you can just use the http url. But please make sure you are not in `Production` environment, otherwise you will be redirected to the https url.
Setting up `Development` environment can be done via environment variable:
```sh
$env:ASPNETCORE_ENVIRONMENT = "Development"
```

You are now ready to create your first catapult project.

## Create your first (empty) project

Activate the previously opened CLI shell, and go to the published folder:

```sh
cd .\publish\cli\
```

When you previously applied migrations to initiate the database, a default user was created. You can use this user to login. When you're prompted to enter the password, the default password is `opencatapult`.

```sh
dotnet occli.dll login --user admin@opencatapult.net
```

We strongly advise you to change the default password (or just remove the default user), especially when you deploy the API into public environment:

```sh
dotnet occli.dll account password update
```

And now, you're good to go to create an empty project:

```sh
dotnet occli.dll project create --name first-project --client Polyrific
```

## Next steps

After creating your first project, you can:
- [add models to the project](../user-guides/data-models.md)
- [Register the engine](../user-guides/engine-registration.md#register-a-new-engine) and [set the authorization token](../user-guides/engine-registration.md#obtain-token-for-an-engine) so it can talk to the API
- [explore what else you can do with the project](../user-guides/user-guides.md)
- [create another project by using Sample project template](../user-guides/sample-project.md)
- check references of [API](../api/api.md), [Engine](../engine/engine.md), [CLI](../cli/cli.md)