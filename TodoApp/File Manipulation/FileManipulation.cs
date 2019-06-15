using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TodoApp.File_Manipulation
{
    class FileManipulation
    {
        public static void ListFiles(List<string> list)
        {
            if (list.Count == 0)
            {
                Console.WriteLine("No todos for today :)");
            }
            for (int i = 0; i < list.Count; i++)
            {
                Console.WriteLine(list[i]);
            }
        }
        public static void AddItem(string newTodo, List<string> list)
        {
            list.Add(list.Count + 1 + ". [ ] " + newTodo);
            Console.WriteLine("New todo is added to the list.");
        }
        public static void RemoveItem(int inputNumber, List<string> list)
        {
            if (inputNumber <= list.Count)
            {
                list.RemoveAt((inputNumber - 1));
                Console.WriteLine("Task was succesfully removed!");
            }
            else
            {
                Console.WriteLine("Unable to check: index is out of bound.");
            }
        }
        public static void WriteToFile(string pathToFile, List<string> lines)
        {
            System.IO.File.WriteAllLines(pathToFile, lines);

        }
        public static void CompleteTask(int inputNumber, List<string> list)
        {
            string elementToModify = list[(inputNumber - 1)];
            StringBuilder sb = new StringBuilder(elementToModify);
            sb[4] = 'X';
            elementToModify = sb.ToString();
            list[(inputNumber - 1)] = elementToModify;
        }

        public static string[] ReadFile(string pathToFile)
        {
            Console.WriteLine("Hello, please enter the path to your to do list: ");
            string toDoPath = Console.ReadLine();

            if (toDoPath == "")
            {
                throw new MissingFieldException("Missing input");
            }
            Console.WriteLine("What would you like to do today?: \nl - list todos\na - add todo\nr - remove todo\nc - complete todo\nq - exit");
            return System.IO.File.ReadAllLines(pathToFile);
        }
    }
}
