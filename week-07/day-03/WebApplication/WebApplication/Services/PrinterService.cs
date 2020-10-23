using WebApplication.Models;
using System;
using WebApplication.Models;

namespace WebApplication.Services
{
    public class PrinterService
    {
        public string message;

        public PrinterService()
        {
            message = "Hello";
        }
        
        public void PrintLog(string message)
        {
            printer.Log(message);
        }
    }
}