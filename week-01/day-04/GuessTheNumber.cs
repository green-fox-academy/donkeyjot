using System;

namespace Expressions
{
    class Program
    {
        static void Main(string[] args)
        {
            // Write a program that stores a number, and the user has to figure it out.
            // The user can input guesses, after each guess the program would tell one
            // of the following:
            //
            // The stored number is higher
            // The stried number is lower
            // You found the number: 8

            int number = 8;
            Console.WriteLine("I have a number in my mind, guess what it is!");
            int guess = Int32.Parse(Console.ReadLine());

            while (guess != number)
            {
                if (guess > number)
                {
                    Console.WriteLine("The stored number is lower");
                }
                else if (guess < number)
                {
                    Console.WriteLine("The stored number is higher");
                }
                guess = Int32.Parse(Console.ReadLine());
            }
            Console.WriteLine("You found the number:" + guess);
        }
    }
}



