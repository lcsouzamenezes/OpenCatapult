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

## Built-in external service types
Following are the external service type that supported out of the box:

### GitHub
It's used to connect to the GitHub repository using either an authorization token, or username and password. Upon creating a github external service you will be prompted to enter the following properties:
| Name |  Description | Allowed Values | DefaultValue | Mandatory |
| --- | --- | --- | --- | --- |
| RemoteCredentialType | The type of github credential to be used | userPassword, authToken| - | Yes |
| RemoteUsername | The github username | | - | Yes if the RemoteCredentialType = userPassword |
| RemotePassword | The github password | | - | Yes if the RemoteCredentialType = userPassword |
| RepoAuthToken | The github authorization token | | - | Yes if the RemoteCredentialType = authToken |

### Azure
It's used to connect to the Azure services using azure active directory.
| Name |  Description | Allowed Values | DefaultValue | Mandatory |
| --- | --- | --- | --- | --- |
| ApplicationId | The Application Id of the azure Ad |  | - | Yes |
| ApplicationKey | The type of github credential to be used |  | - | Yes |
| TenantId | The type of github credential to be used |  | - | Yes |

### Generic
Should you want to have an external service, but the type is not available in opencatapult, you can just use the `Generic` type. You will not be prompted for the external service properties. Instead, you need to manually enter the property key and value through --property option. For example:
```sh
dotnet occli.dll service add --name AWSDeploy --ttype Generic --property AccessKey:xxxx --property SecretKey:yyyy
```

## Using external service properties

After you've added external services, you can then use them in a task. When you add a certain task, you will be prompted to enter the external service name of a specific service type the task Provider require. For example, if you add Push task with provider `GitHub`, you will then be prompted to enter the name of GitHub external service you want to use.