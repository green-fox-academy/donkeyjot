using System;
namespace TeacherStudent
{
    public class Student
    {
        public string Name { get; set; }

        public void Learn()
        {
            Console.WriteLine($"{Name} is learning something new...");
        }
        public Student(string name)
        {
            Name = name;
        }
        public void Question(Teacher teacher)
        {
            teacher.Answer();
        }
    }
}
