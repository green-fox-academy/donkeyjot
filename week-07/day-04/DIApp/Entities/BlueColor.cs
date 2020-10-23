using System;
using DIApp.Interfaces;

namespace DIApp.Entities
{
    public class BlueColor:IColor
    {
        public BlueColor()
        {
        }

        public void PrintColor()
        {
            Console.WriteLine("It is blue in color.");
        }
    }
}
