using System;

namespace Expressions
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create a program that asks for two numbers
            // If the second number is not bigger than the first one it should print:
            // "The second number should be bigger"
            //
            // If it is bigger it should count from the first number to the second by one
            //
            // example:
            //
            // first number: 3, second number: 6, should print:
            //
            // 3
            // 4
            // 5

            Console.WriteLine("Please provide a number:");
            int number = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Please provide a number:");
            int numberTwo = Int32.Parse(Console.ReadLine());

            if (numberTwo > number)
            {
                int i = numberTwo - number;
                for (int n = 0; n < i; n++)
                {
                    Console.WriteLine(number++);
                }
            }


            else
            {
                Console.WriteLine("The second number should be bigger");
       
            }



        }
    }
}


