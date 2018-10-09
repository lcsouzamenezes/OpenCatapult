# Project

These endpoints provide methods to add, edit, and delete project related data

## Get Project List
Method: `GET`

Uri: `/Project?status={status}`

Authorization: `ProjectMemberAccess`

Get list of projects in which the user is a member. Optionally filter it by status (all | active | archived)

## Create Project
Method: `POST`

Uri: `/Project`

Authorization: `UserRoleBasicAccess`

Create a new project

## Get Project By Name
Method: `GET`

Uri: `/Project/name/{projectName}`

Authorization: `ProjectAccess`

Get a project by its name


## Get Project By Id
Method: `GET`

Uri: `/Project/{projectId}`

Authorization: `ProjectAccess`

Get a project by its Id

## Update Project
Method: `PUT`

Uri: `/Project/{projectId}`

Authorization: `ProjectOwnerAccess`

Update a project

## Delete Project
Method: `DELETE`

Uri: `/Project/{projectId}`

Authorization: `ProjectOwnerAccess`

Delete a project

## Clone Project
Method: `POST`

Uri: `/Project/{projectId}/clone`

Authorization: `ProjectOwnerAccess`

Clone an existing project into a new project

## Archive Project
Method: `POST`

Uri: `/Project/{projectId}/archive`

Authorization: `ProjectOwnerAccess`

Archive a project to temporarily delete a project

## Restore Project
Method: `POST`

Uri: `/Project/{projectId}/restore`

Authorization: `ProjectOwnerAccess`

Restore an archived project

## Export Project
Method: `GET`

Uri: `/Project/{projectId}/export`

Authorization: `ProjectOwnerAccess`

Export a project to a YAML template file.