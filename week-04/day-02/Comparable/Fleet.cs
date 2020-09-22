using System;
using System.Collections.Generic;

namespace Comparable
{
    public class Fleet
    {
        public List<Thing> Things;
        private static int counter;

        public Fleet()
        {
            Things = new List<Thing>();
            counter = 0;
        }

        public void Add(Thing thing)
        {
            Things.Add(thing);
            counter++;
        }
        public int GetCount()
        {
            return counter;
        }

        public void PrintFleet()
        {
            for (int i = 0; i < GetCount(); i++)
            {
                Console.WriteLine($"{i + 1}. [{Things[i].IsComplete()}] {Things[i].GetName()}");
            }
        }


    }
}