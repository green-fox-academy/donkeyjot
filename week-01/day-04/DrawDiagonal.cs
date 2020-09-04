using System;

namespace Expressions
{
    class Program
    {
        static void Main(string[] args)
        {

            // Write a program that reads a number from the standard input, then draws a
            // square like this:
            //
            //
            // %%%%%
            // %%  %
            // % % %
            // %  %%
            // %%%%%
            //
            // The square should have as many lines as the number was

            Console.WriteLine("I will draw a square. How many rows should it have?");
            int RowCount = Int32.Parse(Console.ReadLine());

            for (int row = 0; row < RowCount; row++)
            {
                for (int column = 0; column < RowCount; column++)
                {
                    if (row == 0 || row == RowCount - 1 || column == 0 || column == RowCount - 1 || column == row)
                    {
                        Console.Write("%");
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


