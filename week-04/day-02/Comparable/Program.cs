using System;
using System.Collections.Generic;

namespace Comparable
{
    class Program
    {
        public static void Main(string[] args)
        {
            var dominoes = InitializeDominoes();
            dominoes.Sort();

            foreach (Domino domino in dominoes)
            {
                Console.Write($"[{domino.GetValues()[0]}, {domino.GetValues()[1]}]   ");
            }

            var fleet = new Fleet();
            // - You have the `Thing` class
            // - You have the `Fleet` class
            // - You have the `FleetOfThings` class with a `Main` method
            // - Download those, use those
            // - In the Main method create a fleet
            // - Achieve this output:s
            // Create a fleet of things to have this output:
            // 1. [ ] Get milk
            // 2. [ ] Remove the obstacles
            // 3. [x] Stand up
            // 4. [x] Eat lunch
            // Hint: You have to create a Print method also
            string[] tasks = new string[] {
                "Get milk",
                "Remove the obstacles",
                "Stand up",
                "Ëat lunch",
            };
            Thing getMilk = new Thing("Get milk");
            Thing removeObstacles = new Thing(tasks[1]);
            Thing standUp = new Thing(tasks[2]);
            Thing eatLunch = new Thing(tasks[3]);

            fleet.Add(getMilk);
            fleet.Add(removeObstacles);
            fleet.Add(standUp);
            fleet.Add(eatLunch);

            standUp.Complete();
            eatLunch.Complete();

            Console.WriteLine();
            fleet.PrintFleet();

            fleet.Things.Sort();

            Console.WriteLine();
            fleet.PrintFleet();

        }


        public static List<Domino> InitializeDominoes()
        {
            var dominoes = new List<Domino>();
            dominoes.Add(new Domino(5, 2));
            dominoes.Add(new Domino(4, 6));
            dominoes.Add(new Domino(1, 5));
            dominoes.Add(new Domino(6, 7));
            dominoes.Add(new Domino(2, 4));
            dominoes.Add(new Domino(7, 1));
            return dominoes;
        }

       
    }
}
