using System;
namespace GreenFoxInheritance
{
    public class Sponsor:Person
    {
        protected string Company;
        protected int hiredStudents;

        public Sponsor(string Name, int Age, Gender gender, string company):base(Name, Age, gender)
        {
            Company = company;
            hiredStudents = 0;
        }

        public Sponsor() : base()
        {
            Company = "Google";
            hiredStudents = 0;
        }

        public override void Introduce()
        {
            Console.WriteLine($"Hi, I'm {Name}, a {Age} year old {gender} who represents " +
                $"{Company} and hired {hiredStudents} students so far.");
        }

        public override void GetGoal()
        {
            Console.WriteLine("Hire brilliant junior software developers.");
        }

        public void Hire()
        {
            hiredStudents++;
        }


    }
}
