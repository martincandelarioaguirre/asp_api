namespace API.Application.EndPoints
{
    public static class APIEndPoint
    {
        public static IEndpointRouteBuilder useEndPointRoutes(this IEndpointRouteBuilder app)
        {
            var group = app.MapGroup("api");
            group.MapGet("", () =>
            {
                return Results.Ok("Hello world");
            });
            return group;
        }
    }
}
