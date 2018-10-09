# Health

These endpoints are used to check whether the API is working normally.

## Check Health
Method: `HEAD`

Uri: `/Health`

Authorization: `Anonymous`

Check whether the engine API is healthy

## Check Health (GET)
Method: `GET`

Uri: `/Health`

Authorization: `Anonymous`

Check whether the engine API is healthy using GET method (For client that does not support HEAD)

## Check Health Secured
Method: `HEAD`

Uri: `/Health/Secure`

Authorization: `Authenticated`

Check whether the engine API is healthy when invoked by authenticated user

## Check Health Secured (GET)
Method: `GET`

Uri: `/Health/Secure`

Authorization: `Authenticated`

Check whether the engine API is healthy when invoked by authenticated user using GET method (For client that does not support HEAD)
