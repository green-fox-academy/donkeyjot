using System;
namespace GardenApplication
{
    public class Flower : Plant
    {
        public Flower(string color) : base(color)
        {
            AbsorptionLevel = 0.75;
            WateringTrigger = 5;
            Type = "Flower";
        }

    }

}
