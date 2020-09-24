using System;
using System.Collections.Generic;

namespace ToDoApp
{
    class Program
    {
        static void Main(string[] args)
        {
            string filename = "mylist.txt";
            try
            {
                if (args.Length == 0)
                {
                    PrintMenu();
                }
                else
                {
                    switch (args[0])
                    {
                        case "-l":
                            ListAllTasks(filename);
                            break;
                        case "-a":
                            try
                            {
                                AddNewTask(filename, args[1]);
                                Console.WriteLine("Success");
                            }
                            catch
                            {
                                Console.WriteLine("Unable to add: no task provided");
                            }
                            break;
                        case "-r":
                            try
                            {
                                RemoveTask(filename, int.Parse(args[1]));
                                Console.WriteLine("Success");
                            }
                            catch (IndexOutOfRangeException)
                            {
                                if (args.Length < 2)
                                {
                                    Console.WriteLine("Give me something");
                                }
                                else
                                {
                                    Console.WriteLine($"Unable to remove: index is out of bound");
                                }
                            }
                            catch (FormatException)
                            {
                                Console.WriteLine("Wrong format, only input a number.");
                            }
                            break;
                        case "-c":
                            try
                            {
                                CheckTask(filename, int.Parse(args[1]));
                                Console.WriteLine("Success");
                            }
                            catch (IndexOutOfRangeException)
                            {
                                if (args.Length < 2)
                                {
                                    Console.WriteLine("Give me something");
                                }
                                else
                                {
                                    Console.WriteLine($"Unable to check: index is out of bound");
                                }
                            }
                            break;
                        default:
                            Console.WriteLine("Not valid argument, try again.");
                            break;
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Oh no, something went really wrong!");
                Console.WriteLine(e.Message);
            }
        }

        private static void PrintMenu()
        {
            Console.WriteLine();
            Console.WriteLine("Command Line Todo application");
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine("\n" + "=============================" + "\n");
            Console.ResetColor();
            Console.WriteLine("Command line arguments:");
            Console.WriteLine("     -l   Lists all the tasks");
            Console.WriteLine("     -a   Adds a new task");
            Console.WriteLine("     -r   Removes a task");
            Console.WriteLine("     -c   Check a task");
            //Console.WriteLine("     -q   Exit the program");
        }

        public static void ListAllTasks(string filename)
        {
            TaskList myTasks = new TaskList(filename);
            myTasks.PrintAll();
        }

        public static void AddNewTask(string filename, string description)
        {
            TaskList myTasks = new TaskList(filename);
            Task newTask = new Task(description);
            myTasks.tasksList.Add(newTask);
            myTasks.SaveAll(filename);
        }

        public static void RemoveTask(string filename, int index)
        {
            TaskList myTasks = new TaskList(filename);
            myTasks.tasksList.RemoveAt(index - 1);
            myTasks.SaveAll(filename);
        }

        public static void CheckTask(string filename, int index)
        {
            try
            {
                TaskList myTasks = new TaskList(filename);
                myTasks.tasksList[index - 1].CheckTask();
                myTasks.SaveAll(filename);
                Console.WriteLine("Success");
            }
            catch (IndexOutOfRangeException)
            {
                Console.WriteLine("Out of range");
            }
        }
            

    }
}
