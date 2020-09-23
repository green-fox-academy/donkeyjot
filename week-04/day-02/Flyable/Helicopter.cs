using System;
namespace Flyable
{
    public class Helicopter:Vehicle, IFlyable
    {
        protected int maxSpeed;
        public Helicopter(string name, string type, int numberOfPassengers, int maxSpeed): base(name, type, numberOfPassengers)
        {
            this.maxSpeed = maxSpeed;
        }

        public void Fly()
        {
            Console.WriteLine("I'm flying.");
        }

        public void Land()
        {
            Console.WriteLine("Oh no, need to go back to ground");
        }

        public void TakeOff()
        {
            Console.WriteLine("Lets have some fun in the air");
        }
    }
}
