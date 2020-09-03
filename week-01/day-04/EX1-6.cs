using System;

namespace GreenFox
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello Ondrej!");

            // Modify this program to print Humpty Dumpty riddle correctly
            Console.WriteLine("Humpty Dumpty sat on a wall,");
            Console.WriteLine("Humpty Dumpty had a great fall.");
            Console.WriteLine("All the king's horses and all the king's men");
            Console.WriteLine("Couldn't put Humpty together again.");

            // Greet 3 of your classmates with this program, in three separate lines
            // like:
            //
            // Hello, Esther!
            // Hello, Mary!
            // Hello, Joe!

            Console.WriteLine("Hello, Esther!");
            Console.WriteLine("Hello, Mary!");
            Console.WriteLine("Hello, Joe!");

            // Write a program that prints a few details to the terminal window about you
            // It should print each detail to a new line.
            //  - Your name
            //  - Your age
            //  - Your height in meters (as a decimal fraction)
            //
            //  Example output:
            //  John Doe
            //  31
            //  1.87"

            Console.WriteLine("Ondrej Sebl");
            Console.WriteLine(29);
            Console.WriteLine(1.8 + "\"");
            
            // Create a program that prints a few operations on two numbers: 22 and 13

            // Print the result of 13 added to 22
            Console.WriteLine(13 + 22);
            // Print the result of 13 substracted from 22
            Console.WriteLine(22 - 13);
            // Print the result of 22 multiplied by 13
            Console.WriteLine(13 * 22);
            // Print the result of 22 divided by 13 (as a decimal fraction)
           
            decimal a = 22 / 13M;
            Console.WriteLine(a);
            // Print the integer part of 22 divided by 13
            Console.WriteLine(22 / 13);
            // Print the remainder of 22 divided by 13
            Console.WriteLine(22 % 13);



            // An average Green Fox attendee codes 6 hours daily
            int HoursPerDay = 6;
            // The semester is 17 weeks long
            int SemesterLenght = 17;
            //
            // Print how many hours is spent with coding in a semester by an attendee,
            // if the attendee only codes on workdays.

            int WorkdaysInWeek = 5;

            int TotalWorkdays = WorkdaysInWeek * SemesterLenght;
            int TotalHours = TotalWorkdays * HoursPerDay;

            Console.WriteLine(TotalHours);
            //
            // Print the percentage of the coding hours in the semester if the average
            // work hours weekly is 52

            int WeekAverage = 52;
            decimal percentage = (30M / WeekAverage) * 100;
            Console.WriteLine(percentage);





        }
    }
}

