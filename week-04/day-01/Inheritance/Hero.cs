using System;
namespace Inheritance
{
    public class Hero : Character
    {
        public bool CanFly { get; set; }

        public Hero(string name, bool canFly) : base(name)        //Constructor chaining
        {
            CanFly = canFly;

        }

        public override void Shout()
        {
            Console.WriteLine("Hero is shouting");
        }

        public override string ToString()
        {
            return $"Hero name is {Name} and he can fly {CanFly}";
        }

    }
}
