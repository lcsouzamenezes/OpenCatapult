# Service Provider (Plugins)

Service Provider is an extension of `OpenCatapult` which provides specific implementation of a task. It holds an important role because the `OpenCatapult` itself is designed to be "platform-agnostic system", which means it should not make assumption on how a task should work. `OpenCatapult` just provides the skeleton of the tasks so they can be executed correctly in the defined sequence. That's why you are required to define a provider when defining a job task.

By default, `OpenCatapult` is packed with some built-in service provider plugins. They are just ordinary plugins actually, which you can remove or replace if they are not required. The plugins are:
- [AspNetCoreMvc](generator-provider.md): the built-in plugin for Generator Provider
- [AzureAppService](hosting-provider.md): the built-in plugin for Hosting Provider
- [DotNetCore](build-provider.md): the built-in plugin for Build Provider
- [DotNetCoreTest](test-provider.md): the built-in plugin for Test Provider
- [EntityFrameworkCore](database-provider.md): the built-in plugin for Database Provider
- [GitHub](repository-provider.md): the built-in plugin for Repository Provider
