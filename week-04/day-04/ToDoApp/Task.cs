using System;


namespace ToDoApp
{
    public class Task
    {
        public string Description { get; protected set; }
        public int IsDone { get; protected set; }

        public Task(string description)
        {
            Description = description;
            IsDone = 0;
        }

        public Task(int isDone, string description)
        {
            Description = description;
            IsDone = isDone;
        }

        public void CheckTask()
        {
            if (IsDone == 0)
            {
                IsDone = 1;
            }
            else
            {
                IsDone = 0;
            }
        }

        public string AssertCompletness()
        {
            if (IsDone == 0)
            {
                return " ";
            }
            else
            {
                return "x";
            }
        }
    }
}
