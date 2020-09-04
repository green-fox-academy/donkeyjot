using System;

namespace Expressions
{
    class Program
    {
        static void Main(string[] args)
        {
            // Write a program that reads a number from the standard input,
            // Then prints "Odd" if the number is odd, or "Even" if it is even.

            Console.WriteLine("Please give me a number: ");
            int number = Int32.Parse(Console.ReadLine());
            if (number % 2 == 0)
            {
                Console.WriteLine("The number is even.");
            }

            Console.WriteLine("The number is odd.");

        }
    }
}