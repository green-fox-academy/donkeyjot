using System;

namespace Expressions
{
    class Program
    {
        static void Main(string[] args)
        {
            Third();

            CompareLength();

            SumElements();

            ChangeElement();

            IncrementElement();

            PrintAll();

            DiagonalMatrix();

            DoubleItems();

            AppendA();

            SwapElements();

            SumAllElements();

            Reverse();


        }
        public static void Third()
        {
            // - Create an array variable named `numbers`
            //   with the following content: `[4, 5, 6, 7]`
            // - Print the third element of `numbers`

            int[] numbers = { 4, 5, 6, 7 };
            Console.WriteLine(numbers[2]);
        }
        public static void CompareLength()
        {
            // - Create an array variable named `firstArrayOfNumbers`
            //   with the following content: `[1, 2, 3]`
            // - Create an array variable named `secondArrayOfNumbers`
            //   with the following content: `[4, 5]`
            // - Print "secondArrayOfNumbers is longer" if 
            //   `secondArrayOfNumbers` has more elements than
            //   `firstArrayOfNumbers`

            int[] firtArrayOfNumbers = { 1, 2, 3 };
            int[] secondArrayOfNumbers = { 4, 5 };

            if (secondArrayOfNumbers.Length > firtArrayOfNumbers.Length)
            {
                Console.WriteLine("secondArrayOfNumbers is longer");
            }
        }
        public static void SumElements()
        {
            // - Create an array variable named `numbers`
            //   with the following content: `[54, 23, 66, 12]`
            // - Print the sum of the second and the third element

            int[] numbers = { 54, 23, 66, 12 };
            Console.WriteLine(numbers[1] + numbers[2]);
        }
        public static void ChangeElement()
        {
            // - Create an array variable named `numbers`
            //   with the following content: `[1, 2, 3, 8, 5, 6]`
            // - Change the 8 to 4
            // - Print the fourth element

            var numbers = new int[] { 1, 2, 3, 8, 5, 6 };
            numbers[3] = 4;
            Console.WriteLine(numbers[3]);
        }
        public static void IncrementElement()
        {
            //- Create an array variable named `numbers`
            //  with the following content: `[1, 2, 3, 4, 5]`
            //- Increment the third element
            //- Print the third element

            int[] numbers = { 1, 2, 3, 4, 5 };

            Console.WriteLine(++numbers[2]);

        }
        public static void PrintAll()
        {
            // - Create an array variable named `numbers`
            //   with the following content: `[4, 5, 6, 7]`
            // - Print all the elements of `numbers`

            var numbers = new int[] { 4, 5, 6, 7 };
            Console.WriteLine("[{0}]", string.Join(", ", numbers)); //a way to print it formated and on one line

            foreach (var i in numbers)                               //using foreach to print each element on a new line
            {
                Console.WriteLine(i);
            }

            Array.ForEach(numbers, Console.WriteLine);            //there is also this easy method with actions, however, for now it "just works"
        }
        public static void DiagonalMatrix()
        {
            // - Create (dynamically) a two dimensional array
            //   with the following matrix. Use a loop!
            //
            //   1 0 0 0
            //   0 1 0 0
            //   0 0 1 0
            //   0 0 0 1
            //
            // - Print this two dimensional array to the output

            var matrix = new string[4, 4];
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    if (i == j)
                    {
                        matrix[i, j] = "1 ";
                    }
                    else
                    {
                        matrix[i, j] = "0 ";
                    }
                }
            }
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    Console.Write(matrix[i, j]);
                }
                Console.WriteLine();
            }


        }
        public static void DoubleItems()
        {
            // - Create an array variable named `numList`
            //   with the following content: `[3, 4, 5, 6, 7]`
            // - Double all the values in the array

            var numList = new int[] { 3, 4, 5, 6, 7 };
            for (int i = 0; i < numList.Length; i++)
            {
                numList[i] *= 2;
            }

            Console.WriteLine("[{0}]", string.Join(", ", numList));

        }
        public static void Colors()
        {
            // - Create a two dimensional array
            //   which can contain the different shades of specified colors
            // - In `colors[0]` store the shades of green:
            //   `"lime", "forest green", "olive", "pale green", "spring green"`
            // - In `colors[1]` store the shades of red:
            //   `"orange red", "red", "tomato"`
            // - In `colors[2]` store the shades of pink:
            //   `"orchid", "violet", "pink", "hot pink"`

            string[][] colors = new string[3][];
            colors[0] = new string[] { "lime", "forest green", "olive", "pale green", "spring green" };
            colors[1] = new string[] { "orange red", "red", "tomato" };
            colors[2] = new string[] { "orchid", "violet", "pink", "hot pink" };
        }
        public static void AppendA()
        {
            // - Create an array variable named `animals`
            //   with the following content: `["koal", "pand", "zebr"]`
            // - Add all elements an `"a"` at the end

            var animals = new string[] { "koal", "pand", "zebr" };
            for (int i = 0; i < animals.Length; i++)
            {
                animals[i] += "a";
                Console.WriteLine(animals[i]);
            }

        }
        public static void SwapElements()
        {
            // - Create an array variable named `orders`
            //   with the following content: `["first", "second", "third"]`
            // - Swap the first and the third element of `orders`

            var orders = new string[] { "first", "second", "third" };
            var help = orders[2];
            orders[2] = orders[0];
            orders[0] = help;
            Console.WriteLine("[{0}]", string.Join(", ", orders));
        }
        public static void SumAllElements()
        {
            // - Create an array variable named `numbers`
            //   with the following content: `[3, 4, 5, 6, 7]`
            // - Print the sum of the elements in `numbers`

            var numbers = new int[] { 3, 4, 5, 6, 7 };
            int sum = 0;
            foreach (int value in numbers)
            {
                sum += value;
            }
            Console.WriteLine(sum);
        }
        public static void Reverse()
        {
            // - Create an array variable named `numbers`
            //   with the following content: `[3, 4, 5, 6, 7]`
            // - Reverse the order of the elements in `numbers`
            // - Print the elements of the reversed `numbers`

            var numbers = new int[] { 3, 4, 5, 6, 7 };
            var numbersReversed = new int[5];
            for (int i = 0, j = numbersReversed.Length - 1; i < numbers.Length; i++, j--)
            {
               numbersReversed[j] = numbers[i];
            }
            numbers = numbersReversed;
            Console.WriteLine("[{0}]", string.Join(", ", numbers));
        }
    }
}


