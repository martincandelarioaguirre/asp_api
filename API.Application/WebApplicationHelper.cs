namespace API.Application
{
    public static class WebApplicationHelper
    {
        public static WebApplication CreateApiApplication(this WebApplicationBuilder options)
        {
            // Add services to the container
            return options.Build();
        }

        public static WebApplication ConfigureApiApplication(this WebApplication app)
        {
            // Configure the HTTP request pipeline.
            app.UseHttpsRedirection();
            return app;
        }

    }
}
