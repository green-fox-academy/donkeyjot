using System;
using System.Collections.Generic;
using System.Linq;

namespace Classes_objects

{
    class Program
    {
        public static void Main(string[] args)
        {
            PostIt post1 = new PostIt("Idea 1", ConsoleColor.Blue, ConsoleColor.DarkRed);


            post1.Post();

            PostIt post2 = new PostIt();
            post2.Text = "Awesome";
            post2.TextColor = ConsoleColor.Black;
            post2.BackgroundColor = ConsoleColor.Red;

            post2.Post();

            PostIt post3 = new PostIt();

            post3.Text = "Superb!";
            post3.TextColor = ConsoleColor.Green;
            post3.BackgroundColor = ConsoleColor.Yellow;

            post3.Post();

            Console.BackgroundColor = 0;
            Console.ForegroundColor = ConsoleColor.White;

            BlogPost blog1 = new BlogPost("John Doe", "Lorem Ipsum", "Lorem ipsum dolor sit amet.", "2000.05.04.");
            BlogPost blog2 = new BlogPost("Tim Urban", "Wait but why", "A popular long-form, " +
                "stick-figure-illustrated blog about almost everything.", "2017.03.28.");
            BlogPost blog3 = new BlogPost("William Turton", "One Engineer Is Trying to Get IBM to Reckon With Trump",
                "Daniel Hanley, a cybersecurity engineer at IBM, doesn’t want to be the center of attention. " +
                "When I asked to take his picture outside one of IBM’s New York City offices, he told me that" +
                " he wasn’t really into the whole organizer profile thing.", "2000.05.04.");

            Animal lion = new Animal();
            lion.Play();
            lion.Play();
            lion.Play();
            lion.Eat();
            Console.WriteLine(lion.thirst);
            Console.WriteLine(lion.hunger);

            Sharpie fix1 = new Sharpie("red", 0.2f);
            fix1.Use();
            fix1.Use();
            fix1.Use();
            fix1.Use();
            fix1.Use();
            //Console.WriteLine(fix1.InkAmount);

            Counter firstCounter = new Counter();
            Console.WriteLine(firstCounter.Count);
            firstCounter.Add(6);
            firstCounter.Add();
            Console.WriteLine(firstCounter.Get() + firstCounter.Get());
            firstCounter.Reset();
            Console.WriteLine(firstCounter.Count);
            Counter.Method1();
            Counter secondCounter = new Counter(6);
            Counter.Method1();

            List<Pokemon> pokemonOfAsh = InitializePokemon();

            // Every pokemon has a name and a type.
            // Certain types are effective against others, e.g. water is effective against fire.

            // Ash has a few pokemon.
            // A wild pokemon appeared!

            Pokemon wildPokemon = new Pokemon("Oddish", "leaf", "water");

            List<Pokemon> effectivePokemon = new List<Pokemon>();       //I create a new list of Pokemons to save only the effective ones

            foreach (Pokemon ashPokemons in pokemonOfAsh)               //I go through Ash's pokemons and choose the effective ones
            {
                if (ashPokemons.IsEffectiveAgainst(wildPokemon))
                {
                    effectivePokemon.Add(ashPokemons);
                }

            }

            Random random = new Random();                               //Creating random object

            // Which pokemon should Ash use?
            if (effectivePokemon.Count == 0)                            //If list of effective pokemons is empty, Ash is in bad luck
            {
                Console.WriteLine("Ash just lost his fight :(");
            }
            else
            {

                Console.WriteLine("I choose you, " + effectivePokemon[random.Next(0, effectivePokemon.Count)].Name + ".");

                //Otherwise I randomly pick one effective Pokemon and choose him
            }
            // Fleet Of Things

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

            fleet.PrintFleet();
        }



        private static List<Pokemon> InitializePokemon()
        {
            return new List<Pokemon>
            {
                new Pokemon("Balbasaur", "leaf", "water"),
                new Pokemon("Pikatchu", "electric", "water"),
                new Pokemon("Charizard", "fire", "leaf"),
                new Pokemon("Balbasaur", "water", "fire"),
                new Pokemon("Kingler", "water", "fire")

            };

        }
    }
}




