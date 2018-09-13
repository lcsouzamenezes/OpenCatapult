# Manage users

## Register user

Register a new user by specifying the email and password:
```sh
dotnet pc.dll account register --email john.smith@opencatapult.net --password securepassword
```

## Update user

Update a user by specifying the email and password. Then specify other options to update
```sh
dotnet pc.dll account update --email john.smith@opencatapult.net --password securepassword --firstname John --lastname Smith
```

## Remove user

Remove a user by specifying the email of the user to be removed
```sh
dotnet pc.dll account remove --email john.smith@opencatapult.net
```

## Suspend user

Suspend a user by specifying the email of the user to be suspended
```sh
dotnet pc.dll account suspend --email john.smith@opencatapult.net
```

## Activate user

Activate a suspended user by specifying the email of the user to be activated
```sh
dotnet pc.dll account activate --email john.smith@opencatapult.net
```

## User Roles

Available user roles in catapult:
- `Guest`: Have access to only view project 
- `Basic`: Have access to create a new project
- `Administrator`: Have all access within the application


