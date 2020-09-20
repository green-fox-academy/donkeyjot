using System;
using System.IO;

namespace DivideByZero
{
    class Program
    {
        static void ReadFile(string filename)
        {
            Console.WriteLine(File.ReadAllText(filename));
        }

        static void WriteFile(string filename)
        {

            File.WriteAllText(filename, "Hello world!");
        }
        static void Main(string[] args)
        {

            string filename = @"/Users/ondra/Documents/greenfox/donkeyjot/week-02/day-03/DivideByZero/newfile.txt";
            WriteFile(filename);
            ReadFile(filename);

        }

    }
}