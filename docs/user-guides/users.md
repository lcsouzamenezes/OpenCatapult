# Manage users

## Login
To login into the application, use the following command:
```sh
dotnet occli.dll login -e admin@opencatapult.net
```

To logout, use the `logout` command:
```sh
dotnet occli.dll logout
```

## Register user

Register a new user by specifying the email and password:
```sh
dotnet occli.dll account register --email john.smith@opencatapult.net
```
A confirmation email will be emailed to the user (Make sure you set the [smtp](#setting-email) properly). User will need to confirm their email before being able to login to the application

To list the users registered in the opencatapult, use the `account list`
```sh
dotnet occli.dll account list
```

## Update user

Update a user by specifying the email. Then specify other options to update
```sh
dotnet occli.dll account update --email john.smith@opencatapult.net --firstname John --lastname Smith
```

## Update password

Update user password by specifying the email. Then you will be prompt to enter the old and new password.
```sh
dotnet occli.dll password update --email john.smith@opencatapult.net
```

## Reset password

When you forgot your password, you can request password reset using the following command:
```sh
dotnet occli.dll account password resettoken --email john.smith@opencatapult.net
```
The reset password token will then be emailed to you (Make sure you set the [smtp](#setting-email) properly). Afterward, use the following command to set your new password:
```sh
dotnet occli.dll account password reset --email john.smith@opencatapult.net --token [emailed token]
```

## Remove user

Remove a user by specifying the email of the user to be removed
```sh
dotnet occli.dll account remove --email john.smith@opencatapult.net
```

## Suspend user

Suspend a user by specifying the email of the user to be suspended
```sh
dotnet occli.dll account suspend --email john.smith@opencatapult.net
```

## Activate user

Activate a suspended user by specifying the email of the user to be activated
```sh
dotnet occli.dll account activate --email john.smith@opencatapult.net
```

## Set user role

The API have some authorization needed to access the endpoints. For example, only user with at least Basic permission can create a new project. To set this role for a user, use the following command.

```sh
dotnet occli.dll account setrole --email john.smith@opencatapult.net --role Basic
```

## User Roles

Available user roles in catapult:
- `Guest`: Have access to only view project 
- `Basic`: Have access to create a new project
- `Administrator`: Have all access within the application

## Setting Email
Email is required during registration and reset password. To set the smtp, update the following section in API's `appsettings.json`:
```json
"SmtpSetting": {
    "Server": "localhost",
    "Port": 0,
    "Username": "username",
    "Password": "password",
    "SenderEmail": "admin@opencatapult.net"
  }
```