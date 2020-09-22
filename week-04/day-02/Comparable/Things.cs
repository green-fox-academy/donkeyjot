using System;
using System.Diagnostics.CodeAnalysis;

namespace Comparable
{
    public class Thing:IComparable<Thing>
    {
        private string Name;
        private bool Completed;

        public Thing(string name)
        {
            this.Name = name;
        }

        public void Complete()
        {
            this.Completed = true;
        }
        public string IsComplete()
        {
            if (Completed)
            {
                return "X";
            }
            else
            {
                return " ";
            }
        }
        public string GetName()
        {
            return this.Name;
        }

        public int CompareTo([AllowNull] Thing other)
        {
            if (Completed.CompareTo(other.Completed) == 0)
            {
                return this.Name.CompareTo(other.Name);
            }
            else
            {
                return other.Completed.CompareTo(Completed);
            }
            
        }
    }
}
