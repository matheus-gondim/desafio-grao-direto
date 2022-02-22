using Microsoft.AspNetCore.Builder;

namespace GrainRestaurants.API.Middleware
{
    public static class ErrorHandlerMiddlewareExtension
    {
        public static IApplicationBuilder ErrorHandlerMiddleware(this IApplicationBuilder applicationBuilder)
        {
            return applicationBuilder.UseMiddleware<ErrorHandlerMiddleware>();
        }
    }
}
