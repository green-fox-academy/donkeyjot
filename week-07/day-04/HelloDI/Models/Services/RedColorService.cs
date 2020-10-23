using System;
using HelloDI.Models.Interfaces;

namespace HelloDI.Models.Services
{
    public class RedColorService:IColor
    {
        public PrinterService PrinterService { get; set; }

        public RedColorService(PrinterService printerService)
        {
            PrinterService = printerService;
        }

        public void PrintColor()
        {
            PrinterService.Log("It is red in color...");
        }
    }
}
