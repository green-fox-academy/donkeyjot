using System;
using System.Collections.Generic;
using System.Linq;

namespace Removal
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> list = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            List<int> toRemove = new List<int>();

            foreach (int item in list)
            {
                if (item % 2 == 0)      // remove even elements
                {
                    toRemove.Add(item);
                }
            }

            list.RemoveAll(toRemove.Contains);
            Console.WriteLine(String.Join(',', list));
        }
    }
}
/*
	Output: 1,3,5,7,9
*/


