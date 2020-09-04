using System;

namespace Expressions
{
    class Program
    {
        static void Main(string[] args)
        {
            // Modify this program to greet user instead of the World!
            // The program should ask for the name of the user
            Console.WriteLine("What is your name?");
            string name = Console.ReadLine();
            Console.WriteLine($"Hello, {name}!");

            // Write a program that asks for a double that is a distance in miles,
            // then it converts that value to kilometers and prints it
            Console.WriteLine("Put in a distance in miles to convert to kilometers:");
            double miles = Double.Parse(Console.ReadLine());
            double km = miles * 1.6;
            Console.WriteLine($"The distance in km is: {km}");

            // Write a program that asks for two integers
            // The first represents the number of chickens the farmer has
            // The second represents the number of pigs owned by the farmer
            // It should print how many legs all the animals have

            Console.WriteLine("How many chickens do you have?");
            int chickens = Int32.Parse(Console.ReadLine());
            Console.WriteLine("How many pigs do you have?");
            int pigs = Int32.Parse(Console.ReadLine());
            int legs = chickens * 2 + pigs * 4;
            Console.WriteLine("Your animals have " + legs + " legs.");


            // Write a program that asks for 5 integers in a row,
            // then it should print the sum and the average of these numbers like:
            //
            // Sum: 22, Average: 4.4
            int sum = 0;

            Console.WriteLine("I will ask for 5 numbers...");
            for(int i = 1; i < 6; i+=1)
            {
                Console.WriteLine("Put in number #" + i + ":");
                int cislo = Int32.Parse(Console.ReadLine());
                sum += cislo;
            }
            int avg = sum / 5;
            Console.WriteLine($"Sum: {sum}, Average: {avg}");






        }
    }
}

