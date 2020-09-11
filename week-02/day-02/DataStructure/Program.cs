using System;
using System.Text;
using System.Linq;
using System.Collections.Generic;
using System.Numerics;

namespace DataStructure
{
    class Program
    {
        static void Main(string[] args)
        {
            SimpleReplace();
            UrlFixer();
            TakesLonger();
            ToDoPrint();

            string toBeReversed = ".eslaf eb t'ndluow ecnetnes siht ,dehctiws erew eslaf dna eurt fo sgninaem eht fI";
            Console.WriteLine(Reverse(toBeReversed));

            ListsIntroduction1();
            MapIntroduction();
            Console.WriteLine(Factorio(7));
            ListIntroduction2();
            MapIntroduction2();

        }
        public static void SimpleReplace()
        {
            string example = "In a dishwasher far far away";

            example = example.Replace("dishwasher", "galaxy");

            // I would like to replace "dishwasher" with "galaxy" in this example, but it has a problem.
            // Please fix it for me!
            // Expected ouput: In a galaxy far far away

            Console.WriteLine(example);
        }

        public static void UrlFixer()
        {
            string url = "https//www.reddit.com/r/nevertellmethebots";

            // Accidentally I got the wrong URL for a funny subreddit. It's probably "odds" and not "bots"
            // Also, the URL is missing a crucial component, find out what it is and insert it too!
            // Try to solve it more than once using different string functions!

            url = url.Replace("bots", "odds");
            url = url.Insert(5, ":");
            url = string.Concat(url, "/");

            Console.WriteLine(url);
        }
        public static void TakesLonger()
        {
            string quote = "Hofstadter's Law: It you expect, even when you take into account Hofstadter's Law.";

            // When saving this quote a disk error has occured. Please fix it.
            // Add "always takes longer than" to the StringBuilder (quote) between the words "It" and "you"
            // Using pieces of the quote variable (instead of just redefining the string)

            StringBuilder quoteManipulated = new StringBuilder(quote);
            quoteManipulated.Insert(20, " always takes longer than");
            Console.WriteLine(quoteManipulated);

            string middle = "always takes longer than";
            quote = quote.Substring(0, 20) + " " + middle + " " + quote.Substring(21);
            Console.WriteLine(quote);
        }

        public static void ToDoPrint()
        {
            string todoText = " - Buy milk\n";
            // Add "My todo:" to the beginning of the todoText
            // Add " - Download games" to the end of the todoText
            // Add " - Diablo" to the end of the todoText but with indentation
            todoText = "My todo:\n" + todoText;
            todoText += " - Download games\n";
            todoText += "   - Diablo\n";

            // Expected output:

            // My todo:
            //  - Buy milk
            //  - Download games
            //      - Diablo

            Console.WriteLine(todoText);
        }

        public static string Reverse(string original)
        {
            StringBuilder reversed = new StringBuilder(original);
            for (int i = 0, j = original.Length - 1; j >= 0; i++, j--)
            {
                reversed[i] = original[j];
            }
            return reversed.ToString();
            // Create a method that can reverse a String, which is passed as the parameter
            // Use it on this reversed string to check it!

        }

        public static void ListsIntroduction1()
        {
            var names = new List<string>();
            Console.WriteLine(names.Count());
            names.Add("William");
            Console.WriteLine(names.Any());             //also possible using .Count=0 if List is empty
            names.Add("John");
            names.Add("Amanda");
            Console.WriteLine(names.Count());
            Console.WriteLine(names[2]);

            foreach (string name in names)
            {
                Console.WriteLine(name);
            }

            for (int i = 0; i < names.Count(); i++)
            {
                Console.WriteLine(i + 1 + ". " + names[i]);
            }
            names.RemoveAt(1);
            for (int i = names.Count(); i > 0; i--)
            {
                Console.WriteLine(names[i - 1]);
            }
            names.Clear();
        }

        public static void MapIntroduction()
        {
            Dictionary<int, char> map = new Dictionary<int, char>();
            Console.WriteLine(map.Any());
            map.Add(97, 'a');
            map.Add(98, 'b');
            map.Add(99, 'c');
            map.Add(65, 'A');
            map.Add(66, 'B');
            map.Add(67, 'C');
            foreach (var pair in map)
            {
                Console.WriteLine($"keyword: {pair.Key}");
            }
            foreach (var pair in map)
            {
                Console.WriteLine($"value: {pair.Value}");
            }
            map.Add(68, 'D');
            Console.WriteLine(map.Count());
            Console.WriteLine(map[99]);
            map.Remove(97);
            Console.WriteLine(map.TryGetValue(100, out char result));
            map.Clear();
        }
        public static BigInteger Factorio(int parameter)
        {
            BigInteger factorial = new BigInteger(1);
            if (parameter != 0)
            {
                for (int i = 1; i < (parameter + 1); i++)
                {
                    factorial *= i;
                }
            }
            if (parameter < 0)
            {
                factorial = -1;
            }

            return factorial;
        }
        public static void ListIntroduction2()
        {
            List<string> listA = new List<string>()
            {
                "Apple",
                "Avocado",
                "Blueberries",
                "Durian",
                "Lychee"
            };
            List<string> listB = listA.ToList();
            listB.Remove("Durian");
            listA.Insert(3, "Kiwi");

            if (listA.Count() == listB.Count())
            {
                Console.WriteLine("True");
            }
            else
            {
                Console.WriteLine("False");
            }

            Console.WriteLine(listA.IndexOf("Avocado"));
            Console.WriteLine(listB.IndexOf("Durian"));

            var collection = new string[] { "Passion Fruit", "Pomelo" };
            listB.AddRange(collection);

            Console.WriteLine(listA[2]);
        }

        public static void MapIntroduction2()
        {
            Dictionary<string, string> books = new Dictionary<string, string>()
            {
                { "978-1-60309-452-8", "A Letter to Jo" },
                { "978-1-60309-459-7", "Lupus" },
                { "978-1-60309-444-3", "Red Panda and Moon Bear" },
                { "978-1-60309-461-0", "The Lab" }
            };
            foreach (var book in books)
            {
                Console.WriteLine($"{book.Value} (ISBN: {book.Key})");
            }
            books.Remove("978-1-60309-444-3");

            var key = books.FirstOrDefault(pair => pair.Value == "The Lab").Key;
            books.Remove(key);


            foreach (var book in books)
            {
                Console.WriteLine($"{book.Value} (ISBN: {book.Key})");
            }

            Dictionary<string, string> newBooks = new Dictionary<string, string>()
            {
                {"978-1-60309-450-4", "They Called Us Enemy"},
                {"978-1-60309-453-5", "Why Did We Trust Him?" }
            };
            books = books.Union(newBooks).ToDictionary(kvp => kvp.Key, kvp => kvp.Value);
        }
    }
}