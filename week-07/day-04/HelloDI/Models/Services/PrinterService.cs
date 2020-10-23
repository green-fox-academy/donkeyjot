using System;
namespace HelloDI.Models.Services
{
    public class PrinterService
    {
        public PrinterService()
        {
        }

        public void Log(string message)
        {
            Console.WriteLine(" --- " + DateTime.Now + " MY PRINTER SAYS --- " + message);
        }
    }
}
