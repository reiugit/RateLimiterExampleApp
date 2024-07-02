using RateLimiterExample;

var builder = WebApplication.CreateBuilder(args);
{
    builder.Services.AddFixedWindowRateLimiter(); //extension method
}

var app = builder.Build();
{
    app.UseRateLimiter();

    app.MapGet(
        pattern: "/testRateLimiter",
        handler: () => new
        {
            statusCode = "200 OK",
            message = "This response was allowed by the RateLimiter"
        })
        .RequireRateLimiting(RateLimiterPolicies.TwoRequestsPerTenSeconds);
}

app.Run();
