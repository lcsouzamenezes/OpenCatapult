# Member

## Add

Add user as a project member

Usage: `dotnet pc.dll member add --project [project] --user [user] --role [role]`

**Options**

project \(mandatory\)

 `--project` \(alias: `-p`\)

 Name of the projectuser \(mandatory\)

 `--user` \(alias: `-u`\)

 Username \(email\) of the userrole

 `--role` \(alias: `-r`\)

 Role of the project member

 Default value: `member`

 Allowed values: `member` \| `contributor` \| `maintainer` \| `owner`

## List

List members of the project

Usage: `dotnet pc.dll member list --project [project]`

**Options**

project \(mandatory\)

 `--project` \(alias: `-p`\)

 Name of the projectrole

 `--role` \(alias: `-r`\)

 Role of the project member

 Default value: `all`

 Allowed values: `all` \| `member` \| `contributor` \| `maintainer` \| `owner`

## Remove

Remove a project member

Usage: `dotnet pc.dll member remove --project [project] --user [user]`

**Options**

project \(mandatory\)

 `--project` \(alias: `-p`\)

 Name of the projectuser \(mandatory\)

 `--user` \(alias: `-u`\)

 Username \(email\) of the user

## Update

Update the role of a project member

Usage: `dotnet pc.dll member update --project [project] --name [name]`

**Options**

project \(mandatory\)

 `--project` \(alias: `-p`\)

 Name of the projectuser \(mandatory\)

 `--user` \(alias: `-u`\)

 Username \(email\) of the userrole

 `--role` \(alias: `-r`\)

 Role of the project member

 Allowed values: `member` \| `contributor` \| `maintainer` \| `owner`

