using System;

namespace GreenFoxInheritance
{
    public class Student : Person
    {
        protected string PreviousOrganization;
        protected int skippedDays;

        public Student(string Name, int Age, Gender gender, string previousOrganization) : base(Name, Age, gender)
        {
            PreviousOrganization = previousOrganization;
            skippedDays = 0;
        }

        public Student() : base()
        {
            PreviousOrganization = "School of Life";
            skippedDays = 0;
        }

        public override void GetGoal()
        {
            Console.WriteLine("Be a junior software developer.");
        }

        public override void Introduce()
        {
            Console.WriteLine($"Hi, I'm {Name}, a {Age} year old {gender} from {PreviousOrganization} " +
                $"who skipped {skippedDays} already.");
        }
        public void SkipDays(int numberOfDays)
        {
            this.skippedDays += numberOfDays;
        }
    }

}
