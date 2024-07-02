using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.RateLimiting;

namespace RateLimiterExample;

public static class RateLimiterExtensions
{
    public static void AddFixedWindowRateLimiter(this IServiceCollection services)
    {
        services.AddRateLimiter(rateLimiterOptions =>
         {
             rateLimiterOptions.AddFixedWindowLimiter(RateLimiterPolicies.TwoRequestsPerTenSeconds, fixedWindowOptions =>
             {
                 fixedWindowOptions.Window = TimeSpan.FromSeconds(10);
                 fixedWindowOptions.PermitLimit = 2;
             });

             rateLimiterOptions.RejectionStatusCode = StatusCodes.Status429TooManyRequests;

             rateLimiterOptions.OnRejected = Rejected;
         });
    }

    static async ValueTask Rejected(OnRejectedContext context, CancellationToken cancellationToken)
    {
        var problem = new ProblemDetails
        {
            Title = "Rate Limit Exceeded",
            Detail = "Rate Limit of 2 requests per 10 seconds exceeded.",
            Status = StatusCodes.Status429TooManyRequests,
            Type = "https://tools.ietf.org/html/rfc6585#section-4"
        };

        await context.HttpContext.Response.WriteAsJsonAsync(problem, cancellationToken);
    }
}
