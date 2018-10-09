# Project Data Model

These endpoints provide methods to add, edit, and delete data model and property related data

## Get Data Model List
Method: `GET`

Uri: `/Project/{projectId}/model`

Authorization: `ProjectAccess`

Get list of data model in a project

## Create Data Model
Method: `POST`

Uri: `/Project/{projectId}/model`

Authorization: `ProjectContributorAccess`

Create a data model for a project

## Get Data Model By Id
Method: `GET`

Uri: `/Project/{projectId}/model/{modelId}`

Authorization: `ProjectAccess`

Get a data model by its Id

## Update Data Model
Method: `PUT`

Uri: `/Project/{projectId}/model/{modelId}`

Authorization: `ProjectContributorAccess`

Update a data model

## Delete Data Model
Method: `DELETE`

Uri: `/Project/{projectId}/model/{modelId}`

Authorization: `ProjectContributorAccess`

Delete a data model

## Get Data Model By Name
Method: `GET`

Uri: `/Project/{projectId}/model/name/{modelName}`

Authorization: `ProjectAccess`

Get a data model by its name

## Get Property List
Method: `GET`

Uri: `/Project/{projectId}/model/{modelId}/property`

Authorization: `ProjectAccess`

Get the list of property in a data model

## Create Data Model
Method: `POST`

Uri: `/Project/{projectId}/model/property/{propertyId}`

Authorization: `ProjectContributorAccess`

Create a property for a data model

## Get Data Model By Id
Method: `GET`

Uri: `/Project/{projectId}/model/{modelId}property/{propertyId}`

Authorization: `ProjectAccess`

Get a property by its Id

## Update property
Method: `PUT`

Uri: `/Project/{projectId}/model/{modelId}/property/{propertyId}`

Authorization: `ProjectContributorAccess`

Update the property of a data model

## Delete Data Model
Method: `DELETE`

Uri: `/Project/{projectId}/model/{modelId}/property/{propertyId}`

Authorization: `ProjectContributorAccess`

Delete a property of a data model

## Get Property By Name
Method: `GET`

Uri: `/Project/{projectId}/model/{modelId}/property/name/{propertyName}`

Authorization: `ProjectAccess`

Get a data model's property by its name