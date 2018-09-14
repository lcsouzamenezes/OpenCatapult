# Quick Start

This document will guide you to get started with `OpenCatapult`.

## Setup from release library

Please go to [release page](https://opencatapult.net/releases) to download the latest version of `OpenCatapult`.

Unzip the release package into your local directory, and run the components.

## Build from source code

Clone `OpenCatapult` source code from the repository:

```sh
git clone https://github.com/Polyrific-Inc/OpenCatapult.git
```

Go to the root folder:

```sh
cd OpenCatapult
```

Modify the connection string in `.\src\API\Polyrific.Catapult.Api\appsettings.json` to connect to your database server

Run the migration srcript to initialize the database:
```sh
dotnet ef database update --startup-project .\src\API\Polyrific.Catapult.Api\Polyrific.Catapult.Api.csproj --project .\src\API\Polyrific.Catapult.Api.Data\Polyrific.Catapult.Api.Data.csproj
```

Run the API:

```sh
dotnet run -p .\src\API\Polyrific.Catapult.Api\Polyrific.Catapult.Api.csproj -c Release
```

Open new shell, go to the root folder, build and start the Engine:

```sh
dotnet build .\src\Engine\Polyrific.Catapult.Engine\Polyrific.Catapult.Engine.csproj -c Release
dotnet .\src\Engine\Polyrific.Catapult.Engine\bin\Release\PCEngine.dll config set -n ApiUrl -v https://localhost:5001
dotnet .\src\Engine\Polyrific.Catapult.Engine\bin\Release\PCEngine.dll start
```

Open new shell, go to the root folder, build and run a CLI command:

```sh
dotnet build .\src\CLI\Polyrific.Catapult.Cli\Polyrific.Catapult.Cli.csproj -c Release
dotnet .\src\CLI\Polyrific.Catapult.Cli\bin\Release\PC.dll config set -n ApiUrl -v https://localhost:5001
dotnet .\src\CLI\Polyrific.Catapult.Cli\bin\Release\PC.dll --help
```

## Create your first project

