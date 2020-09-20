using System;

namespace TeacherStudent
{
    class Program
    {
        static void Main(string[] args)
        {
            Student ondra = new Student("Ondra");
            Teacher tom = new Teacher("Tom");
            ondra.Question(tom);
            tom.Teach(ondra);
        }
    }
}
