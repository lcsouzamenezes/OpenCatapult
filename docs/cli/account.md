# Activate

Activate a suspended user

Usage: 
```sh
dotnet occli.dll account activate --user [user]
```

**Options**
* user (mandatory)
    * Email of the user to be activated
    * Usage: `--user` (alias `-u`)
    
# List
List users

Usage: 
```sh
dotnet occli.dll account list --status [status] --role [role]
```

**Options**
* status
    * Status of the users
    * Usage: `--status` (alias `-s`)
    * Allowed values: `all` | `Active` | `Suspended`
    * Default value: `all`
* role
    * Role of the users
    * Usage: `--role` (alias `-r`)
    * Allowed values: `all` | `Administrator` | `Basic` | `Guest`
    * Default value: `all`

# Register
Register a catapult user by admin

Usage: 
```sh
dotnet occli.dll account register --email [email] --firstname [firstname] --lastname [lastname]
```

**Options**
* email (mandatory)
    * Email of the user
    * Usage: `--email` (alias `-e`)
* firstname
    * First name of the user
    * Usage: `--firstname` (alias: `-fn`)
* lastname
    * Last name of the user
    * Usage: `--lastname` (alias: `-ln`)

# Remove
Remove a user

Usage: 
```sh
dotnet occli.dll account remove --user [user]
```

**Options**
* user (mandatory)
    * Email of the user to be removed
    * Usage: `--user` (alias: `-u`)

# Suspend
Suspend a user	

Usage: 
```sh
dotnet occli.dll account suspend --user [user]
```

**Options**
* user (mandatory)
    * Email of the user to be suspended
    * Usage: `--user` (alias: `-u`)

# Update
Update user profile

Usage: 
```sh
dotnet occli.dll account update --user [user] --firstname [firstname] --lastname [lastname]
```

**Options**
* user (mandatory)
    * Email of the user
    * Usage: `--user` (alias `-u`)
* firstname
    * First name of the user
    * Usage: `--firstname` (alias: `-fn`)
* lastname
    * Last name of the user
    * Usage: `--lastname` (alias: `-ln`)
    
# Password Update
Update current user's password. You will be prompted to input the old and new password.

Usage: 
```sh
dotnet occli.dll account password update
```
**Options**
* user (mandatory)
    * Email of the user
    * Usage: `--user` (alias `-u`)

# Password ResetToken
Request reset password token

Usage: 
```sh
dotnet occli.dll account password resettoken --user [user]
```
**Options**
* user (mandatory)
    * Email of the user
    * Usage: `--user` (alias `-u`)

# Password Reset
Reset the user's password

Usage: 
```sh
dotnet occli.dll account password reset --user [user] --token [reset password token]
```

**Options**
* user (mandatory)
    * Email of the user
    * Usage: `--user` (alias `-u`)
* token (mandatory)
    * Reset password token emailed to the user
    * Usage: `--token` (alias `-t`)
    
# SetRole
Set a user role so it can have needed access

Usage: 
```sh
dotnet occli.dll account setrole --user [user] --role [role]
```

**Options**
* user (mandatory)
    * Email of the user
    * Usage: `--user` (alias `-u`)
* role
    * Role of the user
    * Usage: `--role` (alias: `-r`)
    * Allowed values: `Administrator` | `Basic` | `Guest`