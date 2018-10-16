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

Invite a new user to the opencatapult by using the `register` command:
```sh
dotnet occli.dll account register --email john.smith@opencatapult.net
```

A confirmation email will be emailed to the user (Make sure you set the [smtp](#setting-email) properly) that will contain the temporary password, along with the link to login instruction. User will need to confirm their email, by opening the link in their email, before being able to login to the application

To list the users registered in the opencatapult, use the `account list`
```sh
dotnet occli.dll account list
```

## Update user

Update a user by specifying the user's email. Then specify other options to update
```sh
dotnet occli.dll account update --user john.smith@opencatapult.net --firstname John --lastname Smith
```

## Update password

Update your own password by using the `password update` command. Then you will be prompt to enter the old and new password.
```sh
dotnet occli.dll account password update
```

## Reset password

When you forgot your password, you can request password reset using the following command:
```sh
dotnet occli.dll account password resettoken --user john.smith@opencatapult.net
```
The reset password token will then be emailed to you (Make sure you set the [smtp](#setting-email) properly). Afterward, use the following command to set your new password:
```sh
dotnet occli.dll account password reset --user john.smith@opencatapult.net --token [emailed token]
```

## Remove user

Remove a user by specifying the user's email of the user to be removed
```sh
dotnet occli.dll account remove --user john.smith@opencatapult.net
```

## Suspend user

Suspend a user by specifying the user's email of the user to be suspended
```sh
dotnet occli.dll account suspend --user john.smith@opencatapult.net
```

## Activate user

Activate a suspended user by specifying the user's email of the user to be activated
```sh
dotnet occli.dll account activate --user john.smith@opencatapult.net
```

## Set user role

The API have some authorization needed to access the endpoints. For example, only user with at least Basic permission can create a new project. To set this role for a user, use the following command.

```sh
dotnet occli.dll account setrole --user john.smith@opencatapult.net --role Basic
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