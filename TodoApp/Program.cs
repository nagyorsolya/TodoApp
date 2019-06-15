using System;
using System.Collections.Generic;
using System.Linq;
using TodoApp.File_Manipulation;
using TodoApp.Tasks;

namespace TodoApp
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> todoList = new List<string>();
            try
            {
                todoList = FileManipulation.ReadFile(@"C:\Users\Nagy Orsi\Documents\C#\TodoApp\Test.txt").ToList<string>();
            }
            catch (MissingFieldException error)
            {
                Console.WriteLine(error);
                return;
            }
            string firstInput = string.Empty;
            while (firstInput != "q")
            {
                firstInput = Console.ReadLine();
                switch (firstInput)
                {
                    case "l":
                        FileManipulation.ListFiles(todoList);
                        break;
                    case "a":
                        Console.WriteLine("Enter the name of the to do: ");
                        string newTodo = Console.ReadLine();
                        FileManipulation.AddItem(newTodo, todoList);
                        break;
                    case "r":
                        Console.WriteLine("Enter the number of the task you want to remove: ");
                        FileManipulation.ListFiles(todoList);
                        try
                        {
                            int inputNumber = Convert.ToInt32(Console.ReadLine());
                            FileManipulation.RemoveItem(inputNumber, todoList);
                        }
                        catch (FormatException error)
                        {
                            Console.WriteLine(error.Message);
                        }
                        break;
                    case "c":
                        Console.WriteLine("Enter the number of the task you want to complete: ");
                        int input = Convert.ToInt32(Console.ReadLine());
                        FileManipulation.CompleteTask(input, todoList);
                        FileManipulation.ListFiles(todoList);
                        break;
                    case "q":
                        FileManipulation.WriteToFile(@"C:\Users\Nagy Orsi\Documents\C#\TodoApp\Test.txt", todoList);
                        break;
                    default:
                        Console.WriteLine("Please enter a valid command.");
                        break;
                }
            }
        }
    }
}
