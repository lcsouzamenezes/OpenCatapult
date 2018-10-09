# Plugin

These endpoints provide methods to register, remove, and get info of plugins within the catapult instalation

## Get Plugin List
Method: `GET`

Uri: `/Plugin`

Authorization: `UserRoleAdminAccess`

Get list of plugins installed within the catapult.

## Register Plugin
Method: `POST`

Uri: `/Plugin`

Authorization: `UserRoleAdminAccess`

Register a plugin into the catapult by uploading the .yml file that describe the plugin metadata.

## Get Plugins by Plugin Type
Method: `GET`

Uri: `/plugin/type/{pluginType}`

Authorization: `UserRoleAdminAccess`

Get list of plugin, filtered by type (all | BuildProvider | DatabaseProvider | GeneratorProvider | HostingProvider | RepositoryProvider | StorageProvider | TestProvider)

## Get Plugin By Id
Method: `GET`

Uri: `/Plugin/{pluginId}`

Authorization: `UserRoleBasicAccess`

Get a plugin by its Id

## Remove Plugin
Method: `DELETE`

Uri: `/Plugin/{pluginId}`

Authorization: `UserRoleAdminAccess`

Remove plugin from catapult

## Get Plugin By Name
Method: `GET`

Uri: `/Plugin/name/{pluginName}`

Authorization: `UserRoleBasicAccess`

Get a plugin by its Name

## Get Plugin's Configs
Method: `GET`

Uri: `/plugin/name/{pluginName}/config`

Authorization: `UserRoleBasicAccess`

Get list of additional configs of a plugin