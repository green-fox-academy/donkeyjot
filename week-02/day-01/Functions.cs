using System;

namespace Expressions
{
    class Program
    {
        static void Main(string[] args)
        {

            //Doubling
            int baseNum = 123;
            Console.WriteLine(Doubling(baseNum));

            //Greet
            string al = "Green Fox";
            Greet(al);

            // AppendAFunc
            string typo = "Chinchill";
            AppendAFunc(typo);
            Console.WriteLine(AppendAFunc(typo));

            //Sum
            Console.WriteLine(Sum(5));

            //Factorial
            Console.WriteLine(Factorio(17));

            //Anagram
            Console.WriteLine(isAnagram("tom marvolo riddle", "i am lord voldemort"));

        }

        public static int Doubling(int a)
        {
            // - Create an integer variable named `baseNum` and assign the value `123` to it
            // - Create a function called `Doubling` that doubles it's input parameter and returns with an integer
            // - Print the result of `Doubling(baseNum)`
            int result = a * 2;
            return result;
        }

        public static void Greet(string name)
        {
            Console.WriteLine("Hello, " + name + "!");
        }

        public static string AppendAFunc(string a)
        {
            // - Create a string variable named `typo` and assign the value `Chinchill` to it
            // - Write a function called `AppendAFunc` that gets a string as an input,
            //   appends an 'a' character to its end and returns with a string
            // - Print the result of `AppendAFunc(typo)`

            string result = a + "a";
            return result;
        }

        public static int Sum(int parameter)
        {
            int sum = 0;
            for (int i = 1; i <= parameter; i++)
            {
                sum += i;

            }
            return sum;
        }

        public static int Factorio(int parameter)
        {
            int factorial = 1;
            if (parameter != 0)
            {
                for (int i = 1; i < (parameter + 1); i++)
                {
                    factorial *= i;
                }
            }
            if (parameter < 0)
            {
                factorial = -1;
            }

            return factorial;
        }

        public static bool isAnagram(string a, string b)
        {
            if (a.Length != b.Length)                       //dealing with spaces
            {
                if (a.Length > b.Length)
                {
                    for (int i = 0; i < (a.Length - b.Length); i++)
                    {
                        b += " ";
                    }
                }
                else
                {
                    for (int i = 0; i < (b.Length - a.Length); i++)
                    {
                        a += " ";
                    }
                }
            }

            char[] toSort1 = a.ToLower().ToCharArray();         //ToLower - its then not case sensitive
            Array.Sort(toSort1);
            string sorted1 = String.Join("", toSort1);

            char[] toSort2 = b.ToLower().ToCharArray();
            Array.Sort(toSort2);
            string sorted2 = String.Join("", toSort2);

            bool result;
            if (sorted1 == sorted2)
            {
                result = true;
            }
            else
            {
                result = false;
            }
            return result;


        }

    }


}


