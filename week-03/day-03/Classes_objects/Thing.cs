using System;
namespace Classes_objects
{
    public class Thing
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
    }
}
