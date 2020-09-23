using System;
using System.IO;

namespace CopyFile
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(CopyFile("tetx.txt", "copy.txt"));
        }

        private static bool CopyFile(string sourceFile, string newFile)
        {
            try
            {
                string[] allLines = File.ReadAllLines(sourceFile);
                File.WriteAllLines(newFile, allLines);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
    }
}
