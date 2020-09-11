using System;
using System.IO;
using System.Linq;
using System.Collections.Generic;
using System.Text;


namespace FileIO
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Give me a number and I will divide 10 with it");
            int a = Int32.Parse(Console.ReadLine());
            Console.WriteLine(DivideByZero(a));

            static void DivideByZero(int a)
            {     // Create a function that takes a number
                  // divides ten with it,
                  // and prints the result.
                  // It should print "fail" if the parameter is 0)
                try
                {
                    double b = 10 / a;
                    Console.WriteLine(b);
                    Console.ReadLine();
                }
                catch (DivideByZeroException)
                {
                    Console.WriteLine("fail");
                    Console.ReadLine();
                }


            }
        }

    }
}
