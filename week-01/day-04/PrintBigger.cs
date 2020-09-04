using System;

namespace Expressions
{
    class Program
    {
        static void Main(string[] args)
        {
            // Write a program that asks for two numbers and prints the bigger one
            Console.WriteLine("Please give me a number:");
            int numberOne = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Please give me a second number:");
            int numberTwo = Int32.Parse(Console.ReadLine());

            if (numberOne > numberTwo)
            {
                Console.WriteLine(numberOne);
            }
            else
            {
                Console.WriteLine(numberTwo);
            }
        }
    }
}

