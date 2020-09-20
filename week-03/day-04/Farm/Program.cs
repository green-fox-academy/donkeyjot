using System;

namespace Farm
{
    class Program
    {
        static void Main(string[] args)
        {
            Animal animal1 = new Animal();
            animal1.Drink();
            Animal pig2 = new Animal();
            pig2.Drink();

            Farm animalFarm = new Farm(6);
            Console.WriteLine();
            animalFarm.Breed();
            animalFarm.Breed();
        

        }
    }
}
