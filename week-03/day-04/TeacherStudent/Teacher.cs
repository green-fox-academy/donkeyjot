using System;
namespace TeacherStudent
{
    public class Teacher
    {
        public string Name { get; set; }
        public Teacher(string name)
        {
            Name = name;
        }

        public void Answer()
        {
            Console.WriteLine($"{Name} is answering a question...");

        }
        public void Teach(Student student)
        {
            student.Learn();
        }
    }
}
