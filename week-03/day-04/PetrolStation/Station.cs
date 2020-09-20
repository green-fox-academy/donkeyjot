using System;
namespace PetrolStation
{
    public class Station
    {
        public int GasAmount { get; set; }

        public Station(int gassAmount)
        {
            GasAmount = gassAmount;
        }

        public void Refill(Car car)
        {
            this.GasAmount -= car.Capacity;
            car.GasAmount = car.Capacity;
        }

        
      
    }
}
