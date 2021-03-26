
using System;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Logging;
using System.Diagnostics;
using System.Threading;

public class MyMiddleware
{
    private const string RESPONSE_HEADER_RESPONSE_TIME = "X-Response-Time-ms";
    // Handle to the next Middleware in the pipeline  
    private readonly RequestDelegate _next;
    public MyMiddleware(RequestDelegate next)
    {
        _next = next;
    }
    public Task InvokeAsync(HttpContext context)
    {
        // Start the Timer using Stopwatch  
        var watch = new Stopwatch();
        watch.Start();
        context.Response.OnStarting(() =>
        { 
            watch.Stop();
            var responseTimeForCompleteRequest = watch.ElapsedMilliseconds;
            context.Response.Headers[RESPONSE_HEADER_RESPONSE_TIME] = responseTimeForCompleteRequest.ToString();
            return Task.CompletedTask;
        }); 
        return this._next(context);
    }
}

public static class MyMiddlewareExtensions
{
    public static IApplicationBuilder UseMyMiddleware(this IApplicationBuilder builder)
    {
        return builder.UseMiddleware<MyMiddleware>();
    }
}