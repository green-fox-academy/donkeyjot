using System;
namespace GardenApplication
{
    public class Plant
    {
        protected double Water { get; private set; }
        protected string Color { get; private set; }
        protected bool needsWater;
        protected double AbsorptionLevel;
        protected int WateringTrigger;
        protected string Type;

        public Plant(string color)
        {
            Color = color;
            Water = 0.0;
            needsWater = NeedsWater();
        }

        public bool NeedsWater()
        {
            return Water < WateringTrigger;
        }

        public void WaterPlant(double amount)
        {
            Water += AbsorptionLevel * amount;
        }

        public void Info()
        {
            string needsWater;
            if (NeedsWater())
            {
                needsWater = "needs";
            }
            else
            {
                needsWater = "doesnt need";
            }

            Console.WriteLine($"The {Color} {Type} {needsWater} water. Water is :[{Water}]");

        }

    }
}
