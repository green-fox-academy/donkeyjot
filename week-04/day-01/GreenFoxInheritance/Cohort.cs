using System;
using System.Collections.Generic;

namespace GreenFoxInheritance
{
    public class Cohort
    {
        public string Name;
        public List<Student> students;
        public List<Mentor> mentors;

        public Cohort(string name)
        {
            Name = name;
            students = new List<Student>();
            mentors = new List<Mentor>();
        }

        public void AddStudent(Student student)
        {
            students.Add(student);
        }

        public void AddMentor(Mentor mentor)
        {
            mentors.Add(mentor);
        }

        public void Info()
        {
            Console.WriteLine($"The {Name} cohort has {students.Count} students and {mentors.Count} mentors.");
        }
    }
}
