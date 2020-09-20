using System;
using System.Collections.Generic;

namespace Farm
{
    public class Farm
    {
        private List<Animal> Animals;
        private int Slots;

        public Farm(int capacity)
        {
            Animals = new List<Animal>();
            Slots = capacity;
        }

        public void Breed()
        {
            if (Animals.Count >= Slots)
            {
                Console.WriteLine("There are no free slots.");
                return;
            }
            else
            {
                Animal newAnimal = new Animal();
                Animals.Add(newAnimal);
            }
        }

        public void Slaughter()
        {
            Animal leastHungryOne = new Animal();
            int leastHungryOnePosition = 0;

            for (int i = 0; i < Animals.Count; i++)
            {
                if (Animals[i].hunger <= leastHungryOne.hunger)
                {
                    Animals[i] = leastHungryOne;
                    leastHungryOnePosition = i;

                }

            }
            Animals.RemoveAt(leastHungryOnePosition);

        }
    }
}