# Job Queue

These endpoints provide methods to queue a job, and monitor its progress

## Get Job Queue List
Method: `GET`

Uri: `/Project/{projectId}/queue?filter={filter}`

Authorization: `ProjectMaintainerAccess`

Get list of job queues in a project, optionally filter the result (all | current | past | succeeded | failed)

## Queue Job
Method: `POST`

Uri: `/Project/{projectId}/queue`

Authorization: `ProjectMaintainerAccess`

Add a job into the queue for a project so it can be picked up by engine

## Get Job Queue by Id
Method: `GET`

Uri: `/Project/{projectId}/queue/{queue`

Authorization: `ProjectMaintainerAccess`

Get a job queue by its Id

## Cancel Job Queue
Method: `POST`

Uri: `/Project/{projectId}/queue/{queueId}/cancel`

Authorization: `ProjectMaintainerAccess`

Cancel an in-progress job.

## Check Job Queue
Method: `GET`

Uri: `/Queue`

Authorization: `UserRoleEngineAccess`

Check whether there's a queued job that the engine could run

## Update Job Queue
Method: `PUT`

Uri: `/Queue`

Authorization: `UserRoleEngineAccess`

Update a job queue. Used by engine to update the status of a queue.

## Get Job Queue Status
Method: `GET`

Uri: `/Project/{projectId}/queue/{queueId}/status`

Authorization: `ProjectMaintainerAccess`

Get the status of a job queue

## Get Job Queue Status
Method: `GET`

Uri: `/Project/{projectId}/queue/{queueId}/logs`

Authorization: `ProjectMaintainerAccess`

Get the logs of a job queue