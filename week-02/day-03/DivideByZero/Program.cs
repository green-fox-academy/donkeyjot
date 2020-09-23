using System;
using System.IO;

namespace DivideByZero
{
    class Program
    {

        static void Main(string[] args)
        {
            Console.WriteLine("Please input a number:");

            int input;

            try
            {
                input = Int32.Parse(Console.ReadLine());
                Console.WriteLine(DivideByTen(input));

            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("Fail!!!");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine("bad things happen...");
            }
            finally
            {
                Console.WriteLine("Thanks");
            }


        }

        private static double DivideByTen(int input)
        {
            return 10 / input;

        }

    }
}