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
                Console.WriteLine(i + 1 + ". " + list[i]);
            }
        }
        public static void AddItem(string newTodo, List<string> list)
        {
            list.Add(newTodo);
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
                Console.WriteLine("No such item was found in your list.");
            }
        }
    }
}
