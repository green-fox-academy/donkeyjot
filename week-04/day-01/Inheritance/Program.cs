using System;

namespace Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            Hero pepa = new Hero("Pepa", true);
            pepa.Shout();
            Console.WriteLine(pepa);
            Character jan = new Character("Jan");

    

            if(pepa is Character character)
            {
                Console.WriteLine(character);
            }
        }
    }
}
