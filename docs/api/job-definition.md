# Job Definition

These endpoints provide methods to add, edit, and delete jobs and task definitions.

## Get Job Definition List
Method: `GET`

Uri: `/Project/{projectId}/job`

Authorization: `ProjectContributorAccess`

Get list of job definition within a project

## Create Job Definition
Method: `POST`

Uri: `/Project/{projectId}/job`

Authorization: `ProjectContributorAccess`

Create a new job definition for a project

## Get Job Definition By Id
Method: `GET`

Uri: `/Project/{projectId}/job/{jobId}`

Authorization: `ProjectContributorAccess`

Get a job definition by its id

## Update Job Definition
Method: `PUT`

Uri: `/Project/{projectId}/job/{jobId}`

Authorization: `ProjectContributorAccess`

Update a job definition

## Delete Job Definition
Method: `PUT`

Uri: `/Project/{projectId}/job/{jobId}`

Authorization: `ProjectContributorAccess`

Delete a job definition

## Get Job Definition By Name
Method: `GET`

Uri: `/Project/{projectId}/job/name/{jobName}`

Authorization: `ProjectContributorAccess`

Get a job definition by its name

## Get Task Definition List
Method: `GET`

Uri: `/Project/{projectId}/job/{jobId}/task`

Authorization: `ProjectContributorAccess`

Get task definition list of a job

## Create Task Definition
Method: `POST`

Uri: `/Project/{projectId}/job/{jobId}/task`

Authorization: `ProjectContributorAccess`

Create a task definition for a job

## Create Task Definitions
Method: `POST`

Uri: `/Project/{projectId}/job/{jobId}/task`

Authorization: `ProjectContributorAccess`

Create task definitions in batch for a job

## Get Task Definition By Id
Method: `GET`

Uri: `/Project/{projectId}/job/{jobId}/task/{taskId}`

Authorization: `ProjectContributorAccess`

Get a task definition by its id

## Update Job Definition
Method: `PUT`

Uri: `/Project/{projectId}/job/{jobId}/task/{taskId}`

Authorization: `ProjectContributorAccess`

Update a task definition

## Delete Job Definition
Method: `PUT`

Uri: `/Project/{projectId}/job/{jobId}/task/{taskId}`

Authorization: `ProjectContributorAccess`

Delete a task definition

## Get Job Definition By Name
Method: `GET`

Uri: `/Project/{projectId}/job/{jobId}/task/name/{taskName}`

Authorization: `ProjectContributorAccess`

Get a task definition by its name

## Update Task Config
Method: `PUT`

Uri: `/Project/{projectId}/job/{jobId}/task/{taskId}/config`

Authorization: `ProjectContributorAccess`

Update the configurations of a task