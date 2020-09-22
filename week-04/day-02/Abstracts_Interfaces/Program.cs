using System;

namespace Abstracts_Interfaces
{
    class Program
    {
        static void Main(string[] args)
        {
            // Abstraction

            // Encapsulation - hiding the internals from the outside world to make the code

            // Inheritance

            // Polymorphism

            Honeybee honeybee = new Queen();

            //((Drone)honeybee).GetLaid();            //Casting - "Using brute force" //Last resort solution

            if(honeybee is Drone)
            {
                ((Drone)honeybee).GetLaid();        //Always check for validity!
            }

            //is-a inheritance

            Honeybee bee1 = new Drone();
            Honeybee bee2 = new Queen();
            Honeybee bee3 = new Worker();

            BeeHive beeHive = new BeeHive();

            beeHive.AddNewBee(bee1);
            beeHive.AddNewBee(bee2);
            beeHive.AddNewBee(bee3);

            beeHive.StartWorking();
            beeHive.Defend();

        }
    }
}
