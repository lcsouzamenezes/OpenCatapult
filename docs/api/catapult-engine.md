# Catapult Engine

These endpoints provide methods to add, edit, and delete engine related data

## Register Engine
Method: `POST`

Uri: `/Engine/Register`

Authorization: `UserRoleAdminAccess`

Register a new engine

## Confirm Engine
Method: `GET`

Uri: `/Engine/{engineId}/Confirm?token={token}`

Authorization: `UserRoleAdminAccess`

Manually confirm engine registration.

## Suspend Engine
Method: `POST`

Uri: `/Engine/{engineId}/Suspend`

Authorization: `UserRoleAdminAccess`

Suspend an engine to reject its access temporarily

## Reactivate Engine
Method: `POST`

Uri: `/Engine/{engineId}/Activate`

Authorization: `UserRoleAdminAccess`

Reactivate a suspended engine


## Get Engine List
Method: `GET`

Uri: `/Engine?status={status}`

Authorization: `UserRoleAdminAccess`

Get the list  of engines available. Optionally filtered it by status (Active | Suspended | Running)

## Get Engine By Name
Method: `GET`

Uri: `/Engine/name/{engineName}`

Authorization: `UserRoleAdminAccess`

Get the engine data by name

## Delete Engine
Method: `DELETE`

Uri: `/Engine/{engineId}`

Authorization: `UserRoleAdminAccess`

Delete an engine
