using System;
using DIApp.Interfaces;

namespace DIApp.Entities
{
    public class GreenColor:IColor
    {
        public GreenColor()
        {
        }

        public void PrintColor()
        {
            Console.WriteLine("It is green in color.");
        }
    }
}

