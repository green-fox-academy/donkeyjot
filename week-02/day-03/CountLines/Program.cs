using System;
using System.IO;

namespace CountLines
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(NumberOfLines("text.txt"));

        }
        static int NumberOfLines(string filename)
        {
            try
            {
                StreamReader reader = new StreamReader(filename);
                string line = "";
                int count = 0;

                while (line != null)
                {
                    line = reader.ReadLine();
                    if (line != null)
                    {
                        count++;
                    }
                }
                reader.Close();
                return count;
                
            }
            catch (FileNotFoundException)
            {
                return 0;
            }

        }
    }
}
