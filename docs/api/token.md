# Token

These endpoints are used to request a token for user or engine

## Request User Token
Method: `POST`

Uri: `/Token`

Authorization: `Anonymous`

Request token for a specific user

## Request Engine Token
Method: `POST`

Uri: `/Token/engine/{engineId}`

Authorization: `UserRoleAdminAccess`

Request a token for a specific engine