using System;

namespace WebApplication.Models
{
    public class Printer
    {
        public string message;

        public Printer()
        {
            
        }
        
        public void Log(string message)
        {
            Console.WriteLine(" --- " + DateTime.Now + " MY PRINTER SAYS --- " + message);
        }
    }
    
}