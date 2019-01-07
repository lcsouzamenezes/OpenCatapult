# Storage Provider
Storage providers can be used in [Publish task](../user-guides/job-definitions.md#publishartifact). This task is used to download some artifact in some external storage location, into the engine, so it can be processed by other tasks.

There's currently no built-in provider for this since it is not needed in the current default CI/CD workflow. We will add this in the future once we support another complex workflow, like the usage of external devops tools such as azure dev ops.