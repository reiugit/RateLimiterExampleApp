using RateLimiterExample;

var builder = WebApplication.CreateBuilder(args);
{
    builder.Services.AddFixedWindowRateLimiter(); //extension method
}

var app = builder.Build();
{
    app.UseRateLimiter();

    app.MapGet(
        pattern: "/test-ratelimiter",
        handler: () => new
        {
            statusCode = "200 OK",
            limit = "2 requests per 10 seconds are allowed.",
            message = "OK - This response was allowed by the RateLimiter."
        })
        .RequireRateLimiting(RateLimiterPolicies.TwoRequestsPerTenSeconds);
}

app.Run();
