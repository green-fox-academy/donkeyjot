using System;
using System.Collections.Generic;

namespace TestingMain
{
    public class Sum
    {
        public Sum()
        {
        }

        public int Summa(List<int> mylist)
        {
            if (mylist == null)
            {
                return 0;
            }
            int sum=0;
            foreach (int number in mylist)
            {
                sum += number;
            }
            return sum;

        }
    }
}
