using System;
namespace TestingMain
{
    public class Fibonacci
    {
        public Fibonacci()
        {
        }
        public int FibonacciByIndex(int i)
        {
            if (i == 1 || i == 2)
            {
                return 1;
            }
            else if (i == 0)
            {
                return 0;
            }
            else
            {
                return FibonacciByIndex(i-1) + FibonacciByIndex(i - 2);
            }
        }
    }
}
