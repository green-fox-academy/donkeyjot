using System;

namespace Expressions
{
    class Program
    {
        static void Main(string[] args)
        {

            // Store your favorite number in a variable (as a number)
            // And print it like this: "My favorite number is: 8"

            int favorite = 1;
            Console.WriteLine("My Favorite number is: " + favorite);

            // Swap the values of the variables
            int a1 = 123;
            int b1 = 526;

            int c1 = a1;
            a1 = b1;
            b1 = c1;

            // Print the Body mass index (BMI) based on these values
            double massInKg = 81.2;
            double heightInM = 1.78;

            //BMI formula
            double BMI = massInKg / Math.Pow(heightInM, 2.0);
            Console.WriteLine(BMI);

            // Define several things as a variable then print their values
            // Your name as a string
            string name = "Ondrej";
            Console.WriteLine(name);
            // Your age as an integer
            int age = 29;
            Console.WriteLine(age);
            // Your height in meters as a double
            double height = 1.8d;
            Console.WriteLine(height);
            // Whether you are married or not as a boolean
            bool isMarried = false;
            Console.WriteLine(isMarried);

            int a = 3;

            // make it bigger by 10
            a += 10;
            Console.WriteLine(a);

            int b = 100;
            // make it smaller by 7
            b -= 7;
            Console.WriteLine(b);

            int c = 44;
            // please double c's value
            c *= 2;
            Console.WriteLine(c);

            int d = 125;
            // please divide by 5 d's value
            d /= 5;
            Console.WriteLine(d);

            int e = 8;
            double e1 = e;
            // please cube of e's value
            e1 = Math.Pow(e1, 3.0);

            Console.WriteLine(e1);

            int f1 = 123;
            int f2 = 345;
            // tell if f1 is bigger than f2 (print as a boolean)
            bool result;
            if (f1 > f2)
            { result = true;

            }
            else {
                result = false;
            }

            Console.WriteLine(result);


            int g1 = 350;
            int g2 = 200;
            // tell if the double of g2 is bigger than g1 (print as a boolean)
            bool result1;
            bool testResult;

            testResult = (g2 * 2 > g1);
            Console.WriteLine($"Test result is {testResult}");

            if (g2 * 2 > g1)
            {
                result1 = true;

            }
            else
            {
                result1 = false;
            }

            Console.WriteLine(result1);

            long h = 1357988018575474;
            // tell if 11 is a divisor of h (print as a boolean)
            bool divisor;
            divisor = (h % 11) == 0;
            Console.WriteLine($"Result is {divisor}");

            int i1 = 10;
            int i2 = 3;
            // tell if i1 is higher than i2 squared and smaller than i2 cubed (print as a boolean)
     
            bool isHigher;
            isHigher = i1 > (int)Math.Pow((double)i2, 2.0) * i2 && i1 < (int)Math.Pow((double)i2, 3.0);
            Console.WriteLine($"Result is {isHigher}");

            int j = 1521;
            // tell if j is divisible by 3 or 5 (print as a boolean)
            bool divisor2;
            divisor2 = (j % 3) == 0 || (j % 5) == 0;
            Console.WriteLine($"Result is {divisor2}");


            // Write a program that stores 3 sides of a cuboid as variables (doubles)
            // The program should write the surface area and volume of the cuboid like:
            //
            // Surface Area: 600
            // Volume: 1000

            double x;
            double y;
            double z;

            x = 2; //test variables
            y = 3;
            z = 4;

            double Volume = x * y * z;
            double Surface = 2 * x * y + 2 * x * z + 2 * y * z;

            Console.WriteLine($"Surface Area: {Surface}");
            Console.WriteLine($"Volume: {Volume}");


            int currentHours = 14;
            int currentMinutes = 34;
            int currentSeconds = 42;

            // Write a program that prints the remaining seconds (as an integer) from a
            // day if the current time is represented by the variables

            int SecondsInHour = 60 * 60;
            int TotalDaySeconds = 24 * SecondsInHour;
            int CurrentTotalSeconds = currentHours * SecondsInHour + currentMinutes*60 + currentSeconds;
            int remaining = TotalDaySeconds - CurrentTotalSeconds;


            Console.WriteLine($"Remaining seconds for today: {remaining} seconds.");


        }
    }
}

