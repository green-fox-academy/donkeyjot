using System;
using System.IO;

namespace AircraftCarrier
{
    class Program
    {
        static void Main(string[] args)
        {
            F16 ff = new F16();
            Console.WriteLine(ff.GetType());

            //int[,] arry = { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 } };
            //int[,] rotated = RotateMatrix(arry);

            //DisplayMatrix(rotated);
            Console.WriteLine(RemoveSwearWords());

        }

        public static int RemoveSwearWords()
        {

            string[] swearWords = new string[] { "fuck", "bloody", "cock", "shit", "fucker", "fuckstick", "asshole", "dick", "piss", "cunt" };
            string[] fileInput = File.ReadAllLines("Content.txt");
            string[] fileOutput = new string[fileInput.Length];
            int counter = 0;

            for (int i = 0; i < fileInput.Length; i++)
            {
                string[] lineSplitted = fileInput[i].Split(" ");

                for (int k = 0; k < lineSplitted.Length; k++)
                {
                    for (int j = 0; j < swearWords.Length; j++)
                    {
                        if (lineSplitted[k] == swearWords[j])
                        {
                            lineSplitted[k] = "";
                            counter++;
                        }
                    }

                }

                fileOutput[i] = String.Join(" ", lineSplitted);
            }

            File.WriteAllLines("newfile.txt",fileOutput);

            return counter;

        }

        public static void DisplayMatrix(int[,] arry)
        {
            for (int i = 0; i < arry.GetLength(0); i++)
            {
                for (int j = 0; j < arry.GetLength(0); j++)
                {
                    Console.Write(arry[i, j] + " ");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
        }

        static int[,] RotateMatrix(int[,] inputMatrix)
        {
            int matrixLength = inputMatrix.GetLength(0);
            int[,] outputMatrix = new int[matrixLength, matrixLength];
            int[,] transposedMatrix = new int[matrixLength, matrixLength];

            for (int i = 0; i < matrixLength; i++)
            {
                for (int j = 0; j < matrixLength; j++)
                {
                    transposedMatrix[i, j] = inputMatrix[j, i];
                }
            }

            for (int i = 0; i < matrixLength; i++)
            {
                for (int j = 0; j < matrixLength; j++)
                {
                    outputMatrix[i, j] = transposedMatrix[i, matrixLength - 1 - j];
                }
            }


            return outputMatrix;
        }

    }
}
