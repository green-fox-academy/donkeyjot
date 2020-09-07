using System;

namespace Expressions
{
    class Program
    {
        static void Main(string[] args)
        {

            // Crate a program that draws a chess table like this
            //
            // % % % %
            //  % % % %
            // % % % %
            //  % % % %
            // % % % %
            //  % % % %
            // % % % %
            //  % % % %
            //

            for (int i = 0; i<8; i++)
            {
                for (int n = 0; n < 5; n++)
                {
                    if (i % 2 != 0 && n == 0)
                    {
                        Console.Write(" ");
                    }
                    else if (i % 2 == 0 && n == 4)
                    {
                        Console.Write(" ");
                    }
                    else
                    {
                        Console.Write("% ");
                    }
                }
                Console.WriteLine();
            }
        }
    }
}


