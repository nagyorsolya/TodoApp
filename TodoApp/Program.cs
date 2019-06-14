using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TodoApp.File_Manipulation;

namespace TodoApp
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> todoList = System.IO.File.ReadAllLines(@"C:\Users\Nagy Orsi\Documents\C#\TodoApp\Test.txt").ToList<string>();

            Console.WriteLine("What would you like to do today?: \nl - list todos\na - add todo\nr - remove todo\nc - complete todo");
            string firstInput = Console.ReadLine();
            if (firstInput == "l")
            {
                FileManipulation.ListFiles(todoList);
            }
            if (firstInput == "a")
            {
                Console.WriteLine("Enter the name of the to do: ");
                string newTodo = Console.ReadLine();
                FileManipulation.AddItem(newTodo, todoList);
            }
            Console.ReadLine();
        }
    }
}
