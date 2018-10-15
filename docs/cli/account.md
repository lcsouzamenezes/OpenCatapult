# Activate

Activate a suspended user

Usage: 
```sh
dotnet occli.dll account activate --email [email]
```

**Options**
* email (mandatory)
    * Email of the user to be activated
    * Usage: `--email` (alias `-e`)
    
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
dotnet occli.dll account remove --email [email]
```

**Options**
* email (mandatory)
    * Email of the user to be removed
    * Usage: `--email` (alias: `-e`)

# Suspend
Suspend a user	

Usage: 
```sh
dotnet occli.dll account suspend --email [email]
```

**Options**
* email (mandatory)
    * Email of the user to be suspended
    * Usage: `--email` (alias: `-e`)

# Update
Update user profile

Usage: 
```sh
dotnet occli.dll account update --email [email] --firstname [firstname] --lastname [lastname]
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
    
# Password Update
Update user's password. You will be prompted to input the old and new password.

Usage: 
```sh
dotnet occli.dll account password update --email [email]
```
**Options**
* email (mandatory)
    * Email of the user
    * Usage: `--email` (alias `-e`)

# Password ResetToken
Request reset password token

Usage: 
```sh
dotnet occli.dll account password resettoken --email [email]
```
**Options**
* email (mandatory)
    * Email of the user
    * Usage: `--email` (alias `-e`)

# Password Reset
Reset the user's password

Usage: 
```sh
dotnet occli.dll account password reset --email [email] --token [reset password token]
```

**Options**
* email (mandatory)
    * Email of the user
    * Usage: `--email` (alias `-e`)
* token (mandatory)
    * Reset password token emailed to the user
    * Usage: `--token` (alias `-t`)
    
# SetRole
Set a user role so it can have needed access

Usage: 
```sh
dotnet occli.dll account setrole --email [email] --role [role]
```

**Options**
* email (mandatory)
    * Email of the user
    * Usage: `--email` (alias `-e`)
* role
    * Role of the user
    * Usage: `--role` (alias: `-r`)
    * Allowed values: `Administrator` | `Basic` | `Guest`