# Account

These endpoints provide methods to add, edit, and delete account related data

## Register
Method: `POST`

Uri: `/Account/Register`

Authorization: `Anonymous`

Register a new user to authenticate into the Catapult API.


## Confirm Email
Method: `GET`

Uri: `/Account/{userId}/Confirm?token={token}`

Authorization: `Anonymous`

Confirm the email using the confirmation token.

## Get Users
Method: `GET`

Uri: `/Account?status={status}`

Authorization: `UserRoleAdminAccess`

Get the list of users within the system. Optionally filter it by status (`active` | `suspended`)

## Get User By Id
Method: `GET`

Uri: `/Account/{userId}`

Authorization: `Authenticated`

Get a user by user Id. Only administrator would be able to call this endpoint for other user Id. The rest would only be accepted if the supplied `userId` is of the current user.

## Update User Profile
Method: `PUT`

Uri: `/Account/{userId}`

Authorization: `Authenticated`

Update user profile (i.e. First Name and Last Name). Only administrator would be able to call this endpoint for other user Id. The rest would only be accepted if the supplied `userId` is of the current user.

## Delete User
Method: `DELETE`

Uri: `/Account/{userId}`

Authorization: `UserRoleAdminAccess`

Delete a user.

## Get Current user
Method: `GET`

Uri: `/Account/CurrentUser`

Authorization: `Authenticated`

Get the current user data.

## Get User By Email
Method: `GET`

Uri: `/Account/email/{email}`

Authorization: `Authenticated`

Get a user by its email. Only administrator would be able to call this endpoint for other user email. The rest would only be accepted if the supplied `email` is of the current user.

## Suspend user
Method: `POST`

Uri: `/Account/{userId}/suspend`

Authorization: `UserRoleAdminAccess`

Suspend a user to reject its access temporarily

## Reactivate user
Method: `POST`

Uri: `/Account/{userId}/activate`

Authorization: `UserRoleAdminAccess`

Reactivate a suspended user so that it can regain access to the application

## Update password
Method: `POST`

Uri: `/Account/{userId}/password`

Authorization: `Authenticated`

Update a user password. Only administrator would be able to call this endpoint for other user Id. The rest would only be accepted if the supplied `userId` is of the current user.

## Request reset password
Method: `GET`

Uri: `/Account/email/{email}/resetpassword`

Authorization: `Anonymous`

Send a request password token to the email of the user

## Reset password

Method: `POST`

Uri: `/Account/email/{email}/resetpassword`

Authorization: `Anonymous`

Update the user's password into a new one by specifying the request password token.

## Set User Role
Method: `POST`

Uri: `/Account/{userId}/role`

Set the role of the user. Available roles are: `Administrator`, `Basic`, or `Guest`