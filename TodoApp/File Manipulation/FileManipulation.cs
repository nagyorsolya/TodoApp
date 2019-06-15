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
            list.Add(list.Count+1 + ". [ ] " + newTodo);
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
            string elementToModify = list[(inputNumber-1)];
            StringBuilder sb = new StringBuilder(elementToModify);
            sb[4] = 'X';
            elementToModify = sb.ToString();
            list[(inputNumber - 1)] = elementToModify;
        }
    }
}
