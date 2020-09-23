using System;
namespace Flyable
{
    public abstract class Vehicle
    {
        protected string name;
        protected string type;
        protected int numberOfPassengers;

        public Vehicle(string name, string type, int numberOfPassengers)
        {
            this.name = name;
            this.type = type;
            this.numberOfPassengers = numberOfPassengers;
        }
    }
}
