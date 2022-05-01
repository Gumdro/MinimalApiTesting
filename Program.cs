using MinimalApiDemo;

WebApplication.CreateBuilder(args)
              .ConfigureServices()
              .Build()
              .ConfigureApp()
              .Run();