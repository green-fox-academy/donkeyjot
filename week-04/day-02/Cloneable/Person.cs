using System;

namespace Cloneable
{
    public class Person : ICloneable
    {
        protected string Name;
        protected int Age;
        public enum Gender
        {
            male,
            female
        }
        protected Gender gender = new Gender();

        public Person()
        {
            Name = "Jane Doe";
            Age = 30;
            gender = Gender.female;

        }

        public Person(string name, int age, Gender gender)
        {
            Name = name;
            Age = age;
            this.gender = gender;
        }

        public virtual void Introduce()
        {
            Console.WriteLine($"Hi, I'm {Name}, a {Age} year old {gender}.");
        }

        public virtual void GetGoal()
        {
            Console.WriteLine("My goal is: Live for the moment");
        }

        public virtual object Clone()
        {
            return new Person(Name, Age, gender);
        }
    }
}
