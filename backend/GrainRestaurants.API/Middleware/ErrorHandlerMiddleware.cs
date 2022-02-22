using GrainRestaurants.Core.DTOs.Shared;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Text.Json;
using System.Threading.Tasks;

namespace GrainRestaurants.API.Middleware
{
    public class ErrorHandlerMiddleware
    {
        private readonly RequestDelegate _next;

        public ErrorHandlerMiddleware(RequestDelegate next)
        {
            _next = next;
        }

        public async Task Invoke(HttpContext httpContext)
        {
            try
            {
                await _next(httpContext);
            }
            catch (Exception ex)
            {
                ErrorResponse dto = ErrorHandler.Create(ex);
                httpContext.Response.StatusCode = dto.Status;
                httpContext.Response.ContentType = "application/json";
                var jsonError = JsonSerializer.Serialize(dto);
                await httpContext.Response.WriteAsync(jsonError);
            }
        }

    }
}
