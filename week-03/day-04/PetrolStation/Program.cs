using System;

namespace PetrolStation
{
    class Program
    {
        static void Main(string[] args)
        {
            Station shell = new Station(5000);
            Car tourneo = new Car();
            Console.WriteLine(tourneo.GasAmount);

            shell.Refill(tourneo);

            Console.WriteLine(tourneo.GasAmount);
        }
    }
}
