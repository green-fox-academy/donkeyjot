using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;
using DIApp.Servies;
using DIApp.Entities;
using DIApp.Interfaces;

namespace DIApp
{
    // You may need to install the Microsoft.AspNetCore.Http.Abstractions package into your project
    public class ConsoleLoggerMiddleware : IMiddleware
    {
        //    private readonly RequestDelegate _next;

        private readonly Printer Printer;
        private readonly IColor IColor;

        public ConsoleLoggerMiddleware(Printer printer, IColor color)
        {
            Printer = printer;
            this.IColor = color;

        }

        //public Task Invoke(HttpContext httpContext)
        //{

        //    return _next(httpContext);
        //}

        public Task InvokeAsync(HttpContext context, RequestDelegate next)
        {
            Printer.Log("Hello");
            Console.WriteLine("Hi from the middleware");
            IColor.PrintColor();

            return next(context);
        }

        
    }
    // Extension method used to add the middleware to the HTTP request pipeline.
    public static class ConsoleLoggerMiddlewareExtensions
    {
        public static IApplicationBuilder UseConsoleLoggerMiddleware(this IApplicationBuilder builder)
        {
            return builder.UseMiddleware<ConsoleLoggerMiddleware>();
        }
    }
}
