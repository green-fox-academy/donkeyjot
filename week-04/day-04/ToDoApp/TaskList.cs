using System;
using System.Collections.Generic;
using System.IO;

namespace ToDoApp
{
    public class TaskList
    {
        public List<Task> tasksList;
        public string filename;

        public TaskList(string filename)
        {
            tasksList = new List<Task>();
            this.filename = filename;
            FileIntoList(filename);
        }

        public void FileIntoList(string filename)
        {
            StreamReader reader = new StreamReader(filename);
            string line = string.Empty;

            while (line != null)
            {
                line = reader.ReadLine();
                if (line != null)
                {
                    string[] splitLine = line.Split(",");

                    tasksList.Add(new Task(int.Parse(splitLine[0]), splitLine[1]));
                }
            }

            reader.Close();
        }

        public void SaveAll(string filename)
        {
            string line = string.Empty;
            File.Delete(filename);
            List<string> toWrite = new List<string>();

            foreach (Task task in tasksList)
            {
                line = $"{task.IsDone},{task.Description}";
                toWrite.Add(line);
            }

            File.WriteAllLines(filename, toWrite);
        }

        public void PrintAll()
        {
            if (tasksList.Count == 0)
            {
                Console.WriteLine("No todos for today! :)");
                return;
            }
            for (int i = 0; i < tasksList.Count; i++)
            {
                Console.WriteLine($"{i + 1} - [{tasksList[i].AssertCompletness()}] {tasksList[i].Description}");
            }
        }
    }
}
