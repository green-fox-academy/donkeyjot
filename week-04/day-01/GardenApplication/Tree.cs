using System;
namespace GardenApplication
{
    public class Tree : Plant
    {
        public Tree(string color) : base(color)
        {
            AbsorptionLevel = 0.4;
            WateringTrigger = 10;
            Type = "Tree";
        }
    }
}
