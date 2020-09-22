using System;
using System.Collections.Generic;

namespace PrintableInterface
{
    class Program
    {
        static void Main(string[] args)
        {
            Domino domino1 = new Domino(3, 2);
            Todo todo1 = new Todo("Buy milk", "high", true);

            List<Domino> dominoes = new List<Domino>() { domino1 };
            List<Todo> todos = new List<Todo>() { todo1 };

            foreach (var domino in dominoes)
            {
                domino.PrintAllFields();
            }

            foreach (var todo in todos)
            {
                todo.PrintAllFields();
            }


        }
    }
}
