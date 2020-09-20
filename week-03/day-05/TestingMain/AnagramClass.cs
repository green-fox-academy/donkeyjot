using System;
namespace TestingMain
{
    public class AnagramClass
    {
        public AnagramClass()
        {
        }

        public bool IsAnagram(string a, string b)
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
            return result; ;
        }
    }
}