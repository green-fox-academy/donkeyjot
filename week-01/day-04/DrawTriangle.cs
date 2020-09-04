using System;

namespace Expressions
{
    class Program
    {
        static void Main(string[] args)
        {

            // Write a program that reads a number from the standard input, then draws a
            // triangle like this:
            //
            // *
            // **
            // ***
            // ****
            //
            // The triangle should have as many lines as the number was

            Console.WriteLine("I will draw a triangle. How many rows should it have?");
            int RowCount = Int32.Parse(Console.ReadLine());

            for (int i = 0; i < RowCount; i++)
            {
                for (int column = 0; column < RowCount; column++)
                {
                    if (i >= column)
                    {
                        Console.Write("*");
                    }
                    else
                    {
                        Console.Write(" ");
                    }
                }
                Console.WriteLine();
            }


        }
    }
}


