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
  - You can use the `Express` or `Developer` version for local usage
- Code editor, e.g. Visual Studio Code (https://code.visualstudio.com/)

**Get the source code**

Clone `OpenCatapult` source code from the repository:

```sh
git clone https://github.com/Polyrific-Inc/OpenCatapult.git
```

Go to the root folder:

```sh
cd OpenCatapult
```

**Setup database**

Create a database in SQL Server, and put the connection string in `.\src\API\Polyrific.Catapult.Api\appsettings.json`, e.g.

```json
{
  "ConnectionStrings": {
    "DefaultConnection": "Server=localhost;Database=opencatapult-db;User ID=sa;Password=sapassword;"
  }
}
```

Run the migration script to initialize the database:
```sh
dotnet ef database update --startup-project .\src\API\Polyrific.Catapult.Api\Polyrific.Catapult.Api.csproj --project .\src\API\Polyrific.Catapult.Api.Data\Polyrific.Catapult.Api.Data.csproj
```

**Run the API**

Let's run the API in localhost:

```sh
dotnet run -p .\src\API\Polyrific.Catapult.Api\Polyrific.Catapult.Api.csproj -c Release
```

**Prepare the Engine**

Open new shell, go to the root folder, and build the Engine project:

```sh
dotnet build .\src\Engine\Polyrific.Catapult.Engine\Polyrific.Catapult.Engine.csproj -c Release
```

Set API URL in the Engine's config:

```sh
dotnet .\src\Engine\Polyrific.Catapult.Engine\bin\Release\PCEngine.dll config set -n ApiUrl -v https://localhost:5001
```

**Prepare the CLI**

Open new shell, go to the root folder, and build the CLI project:

```sh
dotnet build .\src\CLI\Polyrific.Catapult.Cli\Polyrific.Catapult.Cli.csproj -c Release
```

Set API URL in the CLI's config:

```sh
dotnet .\src\CLI\Polyrific.Catapult.Cli\bin\Release\PC.dll config set -n ApiUrl -v https://localhost:5001
```

Note:

If you have some error related to ssl, you can try to run the following command, and accept the popup prompt:
```sh
dotnet dev-certs https --trust
```

You are now ready to create your first catapult project.

## Create your first (empty) project

Activate the previously opened CLI shell, and go to the output folder:

```sh
cd src\CLI\Polyrific.Catapult.Cli\bin\Release
```

When you previously applied migrations to initiate the database, a default user was created. You can use this user to login. When you're prompted to enter the password, the default password is `opencatapult`.

```sh
dotnet PC.dll login --user admin@opencatapult.net
```

We strongly advise you to change the default password, especially when you deploy the API into public environment:

```sh
dotnet PC.dll account updateuser --email admin@opencatapult.net
```

And now, let's create an empty project:

```sh
dotnet PC.dll project create --name first-project --client Polyrific
```

## Next steps

After creating your first project, you can:
- [create a complete project by using `Sample` project template](user-guides/sample-project.md)
- [add models to the project](user-guides/data-models.md)
- [explore what else you can do with the project](user-guides/user-guides.md)
- check references of [API](api/api.md), [Engine](engine/engine.md), [CLI](cli/cli.md)