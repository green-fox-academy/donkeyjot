using System;
namespace Abstracts_Interfaces
{
    public class Queen : Honeybee, IStinger
    {
        public Queen()
        {
        }

        public void LayEggs()
        {
            Console.WriteLine("I'm laying eggs.");

        }

        public override void DoWork()
        {
            LayEggs();
        }

        public void Sting()
        {
            Console.WriteLine("I will kill you");
        }
    }
}
