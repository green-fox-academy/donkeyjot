using System;
using System.Collections;
using System.Linq;

namespace Recursion
{
    class Program
    {
        static void Main(string[] args)
        {
            //int parameter = -34;
            //Console.WriteLine(NumberAdder(parameter));

            //int number = 2043;
            //Console.WriteLine(SumOfDigits(number));

            //int basic = 2;
            //int power = 12;
            //Console.WriteLine(PowerN(basic, power));

            Console.WriteLine(GreatestCommonDivisor(15, 10));
        }
        public static int NumberAdder(int parameter)
        {
            //Write a recursive function that takes one parameter: n and adds numbers from 1 to n.
            if (parameter <= 1)
            {
                return parameter;
            }
            else
            {
                return NumberAdder(parameter - 1) + parameter;
            }
        }
        public static int SumOfDigits(int number)
        {
            //Given a non - negative integer n, return the sum of its digits recursively(without loops).
            if (number < 10)
            {
                return number;
            }
            else
            {
                return SumOfDigits(number / 10) + number % 10;
            }

        }
        public static long PowerN(int basic, int power)
        {
            //Given base and n that are both 1 or more, compute recursively(no loops)
            //the value of base to the n power, so powerN(3, 2) is 9(3 squared).
            if (power <= 1)
            {
                return basic;
            }
            else
            {
                return PowerN(basic, power - 1) * basic;
            }
        }
        public static int GreatestCommonDivisor(int num1, int num2)
        {
            int bigger;                     //need to find which of the two is bigger
            int smaller;

            if (num1 >= num2)
            {
                bigger = num1;
                smaller = num2;
            }
            else
            {
                bigger = num2;
                smaller = num1;
            }

            if (bigger % smaller == 0)          //if the bigger can be divided by the smaller with no remaining, I am done
            {
                return smaller;
            }
            else
            {
                return GreatestCommonDivisor(bigger - smaller, smaller);  //Otherwise I use Euclidean algorithm -
                                                                          //the GCD does not change when I substract smaller from bigger
            }
        }

    }
}

