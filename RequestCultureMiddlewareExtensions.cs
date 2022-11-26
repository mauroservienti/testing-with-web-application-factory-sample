using Microsoft.AspNetCore.Builder;

namespace test;

public static class RequestCultureMiddlewareExtensions
{
    public static IApplicationBuilder UseRequestCulture( this IApplicationBuilder builder)
    {
        return builder.UseMiddleware<RequestCultureMiddleware>();
    }
}