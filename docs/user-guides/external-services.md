# Manage external services

When connecting to external service such as github, we would need to provide some security token, or our user and password, to connect to the service. To make it easier for the user to reuse the external service account, user can store their external service configuration, and catapult will manage it securely in the API.

## Add new external service connection

Add a new external service by specifying the name and type of the external service. You will then be prompted to enter the service properties based on the Type you provided.
```sh
dotnet occli.dll service add --name default-github --description "Default github account" --type github
```

All of the created external services can be viewed using the `list` command:
```sh
dotnet occli.dll service list
```

## Remove external service connection

Remove an external service by specifying the name of the service to be removed:
```sh
dotnet occli.dll service remove --name default-github
```

## Use external service properties

After you've added external services, you can then use them in a task. When you add a certain task, you will be prompted to enter the external service name of a specific service type the task Provider require. For example, if you add Push task with provider `GitHub`, you will then be prompted to enter the name of GitHub external service you want to use.

