using System;
using System.IO;
using System.Collections.Generic;

// Create a function that takes 3 parameters: a path, a word and a number
// and is able to write into a file.
// The path parameter should be a string that describes the location of the file you wish to modify
// The word parameter should also be a string that will be written to the file as individual lines
// The number parameter should describe how many lines the file should have.
// If the word is 'apple' and the number is 5, it should write 5 lines
// into the file and each line should read 'apple'
// The function should not raise any errors if it could not write the file.

namespace WriteMultipleLInes
{
    class Program
    {
        static void Main(string[] args)
        {
            SaveWord("text.txt", "apples", 5);

            Console.WriteLine(File.ReadAllText("text.txt"));
        }
        public static void SaveWord(string path, string word, int numberOfLines)
        {
            List<string> words = new List<string>();
            for (int i = 0; i < numberOfLines; i++)
            {
                words.Add(word);
            }

            try
            {
                File.WriteAllLines(path, words);
            }
            catch (Exception)
            {
                Console.WriteLine("Unable to write file: " + path);
            }
        }
    }

}
