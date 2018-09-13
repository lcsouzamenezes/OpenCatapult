# Manage external services

When connecting to external service such as github, we would need to provide some security token, or our user and password, to connect to the service. 

## Add new external service connection

Add a new external service by specifying the name and the properties of the external service. You can also specify the type 
```sh
dotnet PC.dll service add --name default-github --property authorizationToken:123456xxx --description "Default github account" --type github
```

All of the created external services can be viewed using the `list` command:
```sh
dotnet pc.dll service list
```

## Remove external service connection

Remove an external service by specifying the name of the service to be removed:
```sh
dotnet PC.dll service remove --name default-github
```

## Use external service properties

> TODO: Describe ways to make use of the recorded external service properties

