# Activate

Activate a suspended user

Usage: 
```sh
dotnet occli.dll account activate --user [user]
```

| Option | Alias | Description | Allowed Values | DefaultValue | Mandatory |
| --- | --- | --- | --- | --- | --- |
| --user | -u | Username of the suspended user ||| Yes |
    
# List
List users

Usage: 
```sh
dotnet occli.dll account list --status [status] --role [role]
```

| Option | Alias | Description | Allowed Values | Default Value | Mandatory |
| --- | --- | --- | --- | --- | --- |
| --status | -s | Status of the users | all, Active, Suspended | all | No |
| --role | -r | Role of the users | all, Administrator, Basic, Guest | all | No |

# Register
Register a catapult user by admin

Usage: 
```sh
dotnet occli.dll account register --email [email] --firstname [firstname] --lastname [lastname]
```

| Option | Alias | Description | Allowed Values | Default Value | Mandatory |
| --- | --- | --- | --- | --- | --- |
| --email | -e | Email of the user ||| Yes |
| --firstname | -fn | First name of the user ||| No |
| --lastname | -ln | Last name of the user ||| No |

# Remove
Remove a user

Usage: 
```sh
dotnet occli.dll account remove --user [user]
```

| Option | Alias | Description | Allowed Values | Default Value | Mandatory |
| --- | --- | --- | --- | --- | --- |
| --user | -u | Email of the user ||| Yes |
| --autoconfirm | -ac | Perform the removal without asking for confirmation || false | No |

# Suspend
Suspend a user	

Usage: 
```sh
dotnet occli.dll account suspend --user [user]
```

| Option | Alias | Description | Allowed Values | Default Value | Mandatory |
| --- | --- | --- | --- | --- | --- |
| --user | -u | Email of the active user ||| Yes |

# Update
Update user profile

Usage: 
```sh
dotnet occli.dll account update --user [user] --firstname [firstname] --lastname [lastname]
```

| Option | Alias | Description | Allowed Values | Default Value | Mandatory |
| --- | --- | --- | --- | --- | --- |
| --user | -u | Username of the user ||| Yes |
| --firstname | -fn | First name of the user ||| No |
| --lastname | -ln | Last name of the user ||| No |

# Password Update
Update current user's password. You will be prompted to input the old and new password.

Usage: 
```sh
dotnet occli.dll account password update
```

| Option | Alias | Description | Allowed Values | Default Value | Mandatory |
| --- | --- | --- | --- | --- | --- |
| --user | -u | Username of the user ||| Yes |

# Password ResetToken
Request reset password token

Usage: 
```sh
dotnet occli.dll account password resettoken --user [user]
```

| Option | Alias | Description | Allowed Values | Default Value | Mandatory |
| --- | --- | --- | --- | --- | --- |
| --user | -u | Username of the user ||| Yes |

# Password Reset
Reset the user's password

Usage: 
```sh
dotnet occli.dll account password reset --user [user] --token [reset password token]
```

| Option | Alias | Description | Allowed Values | Default Value | Mandatory |
| --- | --- | --- | --- | --- | --- |
| --user | -u | Username of the user ||| Yes |
| --token | -t | Reset password token emailed to the user ||| Yes |
    
# SetRole
Set a user role so it can have needed access

Usage: 
```sh
dotnet occli.dll account setrole --user [user] --role [role]
```

| Option | Alias | Description | Allowed Values | Default Value | Mandatory |
| --- | --- | --- | --- | --- | --- |
| --user | -u | Username of the user ||| Yes |
| --role | -r | New role the user | Administrator, Basic, Guest || Yes |