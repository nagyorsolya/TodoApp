using System;
using System.Collections.Generic;
using System.Linq;
using TodoApp.File_Manipulation;
using TodoApp.Task_Operations;
using TodoApp.Tasks;


namespace TodoApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, please enter the path to your to do list: ");
            string toDoPath = Console.ReadLine();
            if (toDoPath == "orsi")
            {
                toDoPath = @"C:\Users\Nagy Orsi\Documents\C#\TodoApp\Test.txt";
            }
            List<string> todoList = new List<string>();
            try
            {
                todoList = FileManipulation.ReadFile(toDoPath).ToList<string>();
            }
            catch (MissingFieldException error)
            {
                Console.WriteLine(error);
                return;
            }
            List<Task> taskList = TaskOperations.FromStringToTask(todoList);
            string firstInput = string.Empty;
            while (firstInput != "q")
            {
                firstInput = Console.ReadLine();
                switch (firstInput)
                {
                    case "l":
                        TaskOperations.ListTasks(taskList);
                        break;
                    case "a":
                        Console.WriteLine("Enter the name of the to do: ");
                        string newTodo = Console.ReadLine();
                        TaskOperations.AddItem(newTodo, taskList);
                        break;
                    case "r":
                        Console.WriteLine("Enter the number of the task you want to remove: ");
                        TaskOperations.ListTasks(taskList);
                        try
                        {
                            int inputNumber = Convert.ToInt32(Console.ReadLine());
                            TaskOperations.RemoveItem(inputNumber, taskList);
                        }
                        catch (FormatException error)
                        {
                            Console.WriteLine(error.Message);
                        }
                        break;
                    case "c":
                        Console.WriteLine("Enter the number of the task you want to complete: ");
                        int input = Convert.ToInt32(Console.ReadLine());
                        TaskOperations.CompleteTask(input, taskList);
                        TaskOperations.ListTasks(taskList);
                        break;
                    case "q":
                        todoList = TaskOperations.FromTaskToString(taskList);
                        FileManipulation.WriteToFile(toDoPath, todoList);
                        break;
                    default:
                        Console.WriteLine("Please enter a valid command.");
                        break;
                }
            }
        }
    }
}
