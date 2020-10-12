using System.Linq;
using System;
using System.Collections.Generic;
using System.IO;

namespace Linq
{
    class Program
    {
        public delegate bool MyDelegate(int first, int second);

        static void Main(string[] args)
        {

            //1 only even numbers into array
            int[] n1 = { 1, 3, -2, -4, -7, -3, -8, 12, 19, 6, 9, 10, 14 };

            var n1Method = n1.Where(n => n % 2 == 0).ToArray();

            var n1Query = from number in n1
                          where number % 2 == 0
                          select number;

            foreach (var nubmer in n1Query)
            {
                Console.WriteLine(nubmer);
            }


            ////2 average of odd numbers
            int[] n2 = { 1, 3, -2, -4, -7, -3, -8, 12, 19, 6, 9, 10, 14 };

            var avgMethod = n2.Where(n => n % 2 != 0).ToArray().Average();

            var avgQuerry = (from number in n2
                             where number % 2 != 0
                             select number).Average();

            Console.WriteLine(avgQuerry);


            ////3 squared positive numbers
            int[] n3 = { 1, 3, -2, -4, -7, -3, -8, 12, 19, 6, 9, 10, 14 };

            var positiveMethod = n3.Where(n => n > 0).Select(n => n * n);

            var positiveQuerry = from number in n3
                                 where number > 0
                                 select number * number;

            foreach (var number in positiveQuerry)
            {
                Console.WriteLine(number);
            }


            ////4 squared more than 20
            int[] n4 = new[] { 3, 9, 2, 8, 6, 5 };

            var squaredMethod = n4.Where(n => Math.Pow(n, 2) > 20).ToArray();

            var squaredQuerry = from number in n4
                                where number * number > 20
                                select number;

            foreach (var number in squaredQuerry)
            {
                Console.WriteLine(number);
            }


            ////5 frequency of numbers
            int[] n5 = new int[] { 5, 9, 1, 2, 3, 7, 5, 6, 7, 3, 7, 6, 8, 5, 4, 9, 6, 2 };

            var frequencyMethod = n5.GroupBy(n => n).ToDictionary(n => n.Key, n => n.Count());

            var frequencyQuerry = (from number in n5
                                   group number by number into n
                                   select n).ToDictionary(n => n.Key, n => n.Count());

            foreach (var number in frequencyQuerry)
            {
                Console.WriteLine(number);
            }


            //6 Write a LINQ Expression to find the frequency of characters in a given string.
            string a = "dasbgajvskjhasfyugajbcasljhduyga";


            var frequencyStringMethod = a.Where(n => Char.IsLetter(n)).GroupBy(n => n).ToDictionary(n => n.Key, n => n.Count());

            var frequencyStringQuerry = (from character in a
                                         where Char.IsLetter(character)
                                         group character by character into grp
                                         select grp).ToDictionary(n => n.Key, n => n.Count());

            foreach (var pair in frequencyStringQuerry)
            {
                Console.WriteLine(pair);
            }


            //7 Write a LINQ Expression to find the strings which starts with A and ends with I in the following array:
            string[] cities = { "ROME", "LONDON", "NAIROBI", "CALIFORNIA", "ZURICH", "NEW DELHI", "AMSTERDAM", "ABU DHABI", "PARIS" };

            var citiesMethod = cities.Where(n => n[0] == 'A' && n[n.Length - 1] == 'I');

            var citiesQuerry = from city in cities
                               where city[0] == 'A' && city[city.Length - 1] == 'I'
                               select city;

            foreach (var city in citiesQuerry)
            {
                Console.WriteLine(city);
            }


            //8 Write a LINQ Expression to find the uppercase characters in a string.
            string b = "asd AD SAf Aknjas dhjasghdasfgjasdjk sD DBH SADbh asdbjk ASD bjkSAdfks a ";

            var upperCaseMethod = String.Join("", b.Where(c => Char.IsUpper(c)));

            var upperCaseQuerry = String.Join("", from c in b
                                                  where Char.IsUpper(c)
                                                  select c);

            Console.WriteLine(upperCaseQuerry);

            //9 Write a LINQ Expression to convert a char array to a string
            string d = "Mama mele maso";
            char[] cchar = d.ToCharArray();

            string conc = new string(cchar);

            Console.WriteLine(conc);

            //10 Create a Fox class with 3 properties: name, type and color.

            //Fill a list with at least 5 foxes, it's up to you how you name/create them.
            //Write a LINQ Expression to find the foxes with green color.
            //Write a LINQ Expression to find the foxes with green color and pallida type.

            Fox foxOne = new Fox("One", "Black", "Palinda");
            Fox foxTwo = new Fox("Two", "Green", "Regular");
            Fox foxThree = new Fox("Three", "Blue", "Polar");
            Fox foxFour = new Fox("Four", "Green", "Latest");
            Fox foxFive = new Fox("Five", "Green", "Palinda");

            List<Fox> foxes = new List<Fox>() { foxOne, foxTwo, foxThree, foxFour, foxFive };

            List<Fox> Method1 = new List<Fox>(foxes.Where(fox => fox.Color == "Green"));
            List<Fox> Method2 = new List<Fox>(foxes.Where(fox => fox.Color == "Green" && fox.Type == "Palinda"));

            var Querry1 = from fox in foxes
                          where fox.Color == "Green"
                          select fox;

            var Querry2 = from fox in foxes
                          where fox.Color == "Green" && fox.Type == "Palinda"
                          select fox;
            //11

            var text = File.ReadAllText("WikiText.txt").Split(" ").Select(w => Char.IsLetter(w[w.Length - 1]) ? w : w.Remove(w.Length-1)).GroupBy(w => w).ToDictionary(w => w.Key, w => w.Count()).OrderByDescending(w => w.Value);

            for (int i = 0; i < 100; i++)
            {
                Console.WriteLine(text.ElementAtOrDefault(i));
            }
        }
    }
}
