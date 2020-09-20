using System;
namespace PetrolStation
{
    public class Car
    {
        public int GasAmount { get; set; }
        public int Capacity { get; set; }

        public Car()
        {
            Capacity = 100;
            GasAmount = 0;
        }


    }
}
