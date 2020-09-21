using System;

namespace GardenApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            Garden myGarden = new Garden("My oasis of peace");
            myGarden.Add(new Flower("yellow"));
            myGarden.Add(new Flower("blue"));
            myGarden.Add(new Tree("purple"));
            myGarden.Add(new Tree("orange"));

            myGarden.Info();
            myGarden.WaterGarden(40);
            myGarden.WaterGarden(70);
        }
    }
}
