using System;
using DIApp.Interfaces;

namespace DIApp.Entities
{
    public class RedColor:IColor
    {
        public RedColor()
        {
        }

        public void PrintColor()
        {
            Console.WriteLine("It is red in color.");
        }
    }
}
