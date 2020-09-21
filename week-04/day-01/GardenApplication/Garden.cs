using System;
using System.Collections.Generic;

namespace GardenApplication
{
    public class Garden
    {

        public List<Plant> MyGarden;
        public string Name;

        public Garden(string name)
        {
            Name = name;
            MyGarden = new List<Plant>();
        }

        public void WaterGarden(int amountOfWater)
        {
            Console.WriteLine("Watering with " + amountOfWater);

            List<Plant> inNeed = new List<Plant>();
            foreach (Plant plant in MyGarden)
            {
                if (plant.NeedsWater())
                {
                    inNeed.Add(plant);
                }
            }

            double waterForEach = amountOfWater / inNeed.Count;

            foreach(Plant plant in inNeed)
            {
                plant.WaterPlant(waterForEach);
            }

            Info();
        }

        public void Info()
        {
            foreach(Plant plant in MyGarden)
            {
                plant.Info();
            }
            Console.WriteLine();
        }

        public void Add(Plant plant)
        {
            MyGarden.Add(plant);
        }

    }



}
