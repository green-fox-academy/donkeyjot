using System;
namespace Abstracts_Interfaces
{
    public abstract class Honeybee
    // Abstract classes - they are meant to be base classes
    // Not able to be used on their own  - not even calling the constructor directly
    // Only through inheritance

        //It is then possible to create abstract methods
    {
        public int LegCount { get; protected set; }
        public int Length { get; protected set; }

        public Honeybee()
        {
            LegCount = 6;
            Length = new Random().Next(14, 40);
        }

        public void Fly()
        {
            Console.WriteLine("Weeee, I'm flying.");
        }

        public void TearALeg()
        {
            LegCount--;
        }

        public abstract void DoWork();
        //Abstract methods do not have a body
    }
}
