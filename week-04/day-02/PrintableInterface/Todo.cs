using System;
namespace PrintableInterface
{
    public class Todo : IPrintable
    {
        protected string task;
        protected string priority;
        protected bool isDone;

        public Todo(string task, string priority, bool isDone)
        {
            this.task = task;
            this.priority = priority;
            this.isDone = isDone;
        }

        public void PrintAllFields()
        {
            Console.WriteLine($"Task: {task} | Priority: {priority} | Done: {isDone}");
        }
    }
}
