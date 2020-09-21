using System;
namespace GreenFoxInheritance
{
    public class Mentor:Person
    {
        public enum Level
        {
            junior,
            intermediate,
            senior
        }
        protected Level level = new Level();

        public Mentor(string Name, int Age, Gender gender, Level level):base(Name, Age, gender)
        {
            this.level = level;
        }

        public Mentor() : base()
        {
            this.level = Level.intermediate;
        }

        public override void GetGoal()
        {
            Console.WriteLine("Educate brilliant junior software developers.");
        }

        public override void Introduce()
        {
            Console.WriteLine($"Hi, I'm {Name}, a {Age} year old {gender} {level} mentor.");
        }
    }
}
