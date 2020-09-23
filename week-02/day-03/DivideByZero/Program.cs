using System;
using System.IO;

namespace DivideByZero
{
    class Program
    {


        static void Main(string[] args)
        {
            Console.WriteLine("Please input a number:");
            int input = Int32.Parse(Console.ReadLine());


            try
            {
                Console.WriteLine(DivideByTen(input));
            }
            catch (Exception ex)
            {
                Console.WriteLine("fail);
                Console.WriteLine(ex.Message);
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