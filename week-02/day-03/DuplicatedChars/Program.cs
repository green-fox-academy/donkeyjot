using System;
using System.IO;
using System.Collections.Generic;
using System.Text;

namespace DuplicatedChars
{
    class Program
    {
        static void Main(string[] args)
        {
            string sourceFile = "duplicatedChars.txt";
            Decrypt(sourceFile);

            foreach (var line in File.ReadAllLines("decryptedText.txt"))
            {
                Console.WriteLine(line);
            }
            
        }

        private static void Decrypt(string sourceFile)
        {
            try
            {
                string[] allLines = File.ReadAllLines(sourceFile);
                List<string> decryptedLines = new List<string>();

                foreach (var line in allLines)
                {
                    List<char> chars = new List<char>();

                    for (int i = 0; i < line.Length; i++)
                    {
                        if(i%2 == 0)
                        {
                            chars.Add(line[i]);
                        }
                    }

                    char[] charsArray = chars.ToArray();

                    string decryptedLine = String.Join("", charsArray);
                    decryptedLines.Add(decryptedLine);
                }

                File.AppendAllLines("decryptedText.txt", decryptedLines);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            
        }
    }
}
