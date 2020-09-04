using System;

namespace Expressions
{
    class Program
    {
        static void Main(string[] args)
        {
            // Write a program that asks for two numbers
            // The first number represents the number of girls that comes to a party, the
            // second the boys
            // It should print: The party is exellent!
            // If the the number of girls and boys are equal and there are more people coming than 20
            //
            // It should print: Quite cool party!
            // It there are more than 20 people coming but the girl - boy ratio is not 1-1
            //
            // It should print: Average party...
            // If there are less people coming than 20
            //
            // It should print: Sausage party
            // If no girls are coming, regardless the count of the people

            Console.WriteLine("How many boys are coming to the party?");
            int boys = Int32.Parse(Console.ReadLine());
            Console.WriteLine("How many girls are coming to the party?");
            int girls = Int32.Parse(Console.ReadLine());

            int people = girls + boys;

            if (people > 20)
            {
                if (girls == boys)
                {
                    Console.WriteLine("The party is excellent!");
                }
                else if (girls == 0)
                {
                    Console.WriteLine("Sausage party");
                }
                else
                {
                    Console.WriteLine("Quite cool party!");
                }
            }
            else if (girls == 0)
            {
                Console.WriteLine("Sausage party");
            }
            else if (people < 20)
            {
                Console.WriteLine("Average party...");
            }

        }
    }
}

