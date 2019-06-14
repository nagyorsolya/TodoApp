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
            FileManipulation fileManipulation = new FileManipulation();
            string[] todoList = System.IO.File.ReadAllLines(@"C:\Users\Nagy Orsi\Documents\C#\TodoApp\Test.txt");
            Console.WriteLine("What would you like to do today?: " + "\n" + "l - list todos" + "\n" + "a - add todo" + "\n" + "r - remove todo" + "\n" + "c - complete todo");
            string firstInput = Console.ReadLine();
            if (firstInput == "l")
            {
                fileManipulation.ListFiles(todoList);
            }
            if(firstInput == "a")
            {
                Console.WriteLine("Enter the name of the to do: ");
                string newTodo = Console.ReadLine();
                fileManipulation.AddItem(newTodo, todoList);
                Console.WriteLine(todoList);
            }
            Console.ReadLine();
        }
    }
}
