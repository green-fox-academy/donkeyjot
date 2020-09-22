using System;

namespace Cloneable
{
    class Program
    {
        static void Main(string[] args)
        {
            Student john = new Student("John", 20, Person.Gender.male, "BMI");
            var johnTheClone = john.Clone();

            if(johnTheClone is Student)
            {
                ((Student)johnTheClone).Introduce();
            }
            

        }
    }
}
