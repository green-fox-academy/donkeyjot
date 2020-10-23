using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;
using HelloDI.Models.Services;
using HelloDI.Models.Interfaces;

namespace HelloDI
{
    // You may need to install the Microsoft.AspNetCore.Http.Abstractions package into your project
    public class ConsoleLoggerMiddleware
    {
        private readonly RequestDelegate _next;
        private PrinterService Service { get; set; }
        private RedColorService RedColor { get; set; }

        public ConsoleLoggerMiddleware(RequestDelegate next, PrinterService service, RedColorService color)
        {
            _next = next;
            Service = service;
            RedColor = color;

        }

        public Task Invoke(HttpContext httpContext)
        {
            Service.Log("Hello");
            RedColor.PrintColor();
            
            return _next(httpContext);
        }
    }

    // Extension method used to add the middleware to the HTTP request pipeline.
    public static class ConsoleLoggerMiddlewareExtensions
    {
        public static IApplicationBuilder UseMiddlewareClassTemplate(this IApplicationBuilder builder)
        {
            return builder.UseMiddleware<ConsoleLoggerMiddleware>();
        }
    }
}
