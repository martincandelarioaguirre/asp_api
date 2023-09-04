using API.Application.EndPoints;

namespace API.Application
{
    public static class WebApplicationHelper
    {
        private static readonly string _specificOrigins = "_specificOrigins";
        public static WebApplication CreateApiApplication(this WebApplicationBuilder options)
        {
            // Add services to the container

            // Add Cors
            options.Services.AddCors(options =>
            {
                options.AddPolicy(name: _specificOrigins,
                    policy =>
                    {
                        policy
                        .WithOrigins("*")
                        .WithMethods("*")
                        .WithHeaders("*");
                    });
            });
            return options.Build();
        }

        public static WebApplication ConfigureApiApplication(this WebApplication app)
        {
            // Configure the HTTP request pipeline.
            app.UseHttpsRedirection();
            // We use defined cors
            app.UseCors(_specificOrigins);
            app.useEndPointRoutes();
            return app;
        }

    }
}
