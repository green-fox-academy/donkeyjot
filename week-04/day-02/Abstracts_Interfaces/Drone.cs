using System;
namespace Abstracts_Interfaces
{
    public class Drone : Honeybee, IStinger
    {
        public Drone()
        {
        }

        public override void DoWork()
        {
            GetLaid();
        }

        public void GetLaid()
        {
            Console.WriteLine("Some privacy please?");
        }

        public void Sting()
        {
            
        }
    }
}
