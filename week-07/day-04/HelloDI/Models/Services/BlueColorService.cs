using System;
using HelloDI.Models.Interfaces;

namespace HelloDI.Models.Services
{
    public class BlueColorService : IColor
    {
        public PrinterService PrinterService { get; set; }

        public BlueColorService(PrinterService printerService)
        {
            PrinterService = printerService;
        }

        public void PrintColor()
        {
            PrinterService.Log("It is blue in color...");
        }
    }
}
