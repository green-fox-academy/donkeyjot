using System;
namespace Abstracts_Interfaces
{
    public class Worker : Honeybee
    {
        public Worker()
        {
        }

        public void Collect()
        {
            Console.WriteLine("I'm collecting material.");
        }

        public override void DoWork()
        {
            Collect();
        }

        public void Sting()
        {
            Console.WriteLine("I will kill you");
        }
    }
}
