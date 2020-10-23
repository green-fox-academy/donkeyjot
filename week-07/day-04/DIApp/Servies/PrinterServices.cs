using System;
using DIApp.Entities;
using DIApp.Interfaces;

namespace DIApp.Servies

{
    public class PrinterService : IPrinterService
    {
        public Printer printer;
        public string message;
        public PrinterService()
        {

        }

        public void Log(string message)
        {
            Console.WriteLine(" --- " + DateTime.Now + " MY PRINTER SAYS --- " + message);
        }
    }
}
