# Project Member

These endpoints provide methods to add, edit, and delete project member related data

## Get Project Member
Method: `GET`

Uri: `/Project/{projectId}/member?roleId={roleId}`

Authorization: `ProjectAccess`

Get list of members in a project. Optionally filter it by the role Id

## Add Project Member
Method: `POST`

Uri: `/Project/{projectId}/member`

Authorization: `ProjectOwnerAccess`

Add a member for a project

## Get Project Member By Id
Method: `GET`

Uri: `/Project/{projectId}/member/{memberId}`

Authorization: `ProjectAccess`

Get a project member by its Id

## Update Project Member
Method: `PUT`

Uri: `/Project/{projectId}/member/{memberId}`

Authorization: `ProjectOwnerAccess`

Update a project member

## Delete Project Member
Method: `DELETE`

Uri: `/Project/{projectId}/member/{memberId}`

Authorization: `ProjectOwnerAccess`

Delete a project member

## Get Project Member By User Id
Method: `GET`

Uri: `/Project/{projectId}/member/user/{userId}`

Authorization: `ProjectAccess`

Get a project member by the user Id

