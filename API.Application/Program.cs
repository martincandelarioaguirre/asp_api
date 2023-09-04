using API.Application;

WebApplication.CreateBuilder(args)
    .CreateApiApplication()
    .ConfigureApiApplication()
    .Run();