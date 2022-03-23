using System;
using System.Diagnostics;
using System.Threading.Tasks;
using BookStore.Services.Logger;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;

namespace BookStore.Middlewares
{
    public class CustomExceptionMiddleware
    {
        private readonly ILoggerService _logger;
        private readonly RequestDelegate _next;
        public CustomExceptionMiddleware(RequestDelegate next, ILoggerService logger)
        {
            _next = next;
            _logger = logger;
        }
        public async Task Invoke(HttpContext context)
        {
            var watch = Stopwatch.StartNew();

            string message = $"[Request] HTTP {context.Request.Method} - {context.Request.Path}";

            await _next.Invoke(context);
            _logger.Write(message);
            watch.Stop();

            message = $"[Response] HTTP {context.Request.Method} - {context.Request.Path} responded {context.Response.StatusCode} in {watch.Elapsed.TotalMilliseconds} ms";
            _logger.Write(message);




        }

    }

    public static class CustomExceptionMiddlewareExtension
    {
        public static IApplicationBuilder UseCustomExceptionMiddleware(this IApplicationBuilder builder)
        {
            return builder.UseMiddleware<CustomExceptionMiddleware>();
        }
    }
}