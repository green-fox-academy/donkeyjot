using System;
using System.IO;
using System.Collections.Generic;

// Write a function that is able to manipulate a file
// By writing your name into it as a single line
// The file should be named "my-file.txt"
// In case the program is unable to write the file,
// It should print the following error message: "Unable to write file: my-file.txt"

namespace WriteSingleLine
{
    class Program
    {
        static void Main(string[] args)
        {
            SaveName("text.txt");
            SaveName("text.txt");

            Console.WriteLine(File.ReadAllText("text.txt"));
        }
        public static void SaveName(string filename)
        {
            Console.WriteLine("What is your name?");

            List<string> names = new List<string>()
            {
                {Console.ReadLine() }
            };

            try
            {
                File.AppendAllLines(filename, names);
            }
            catch (Exception)
            {
                Console.WriteLine("Unable to write file: " + filename);
            }
        }
    }

}
