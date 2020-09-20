using System;
namespace Classes_objects
{
    public class Animal
    {

        public int hunger = 50;
        public int thirst = 50;

        public Animal()
        {
        }

        public void Eat()
        {
            hunger--;
        }

        public void Drink()
        {
            thirst--;
        }

        public void Play()
        {
            hunger++;
            thirst++;
        }
    }
}

