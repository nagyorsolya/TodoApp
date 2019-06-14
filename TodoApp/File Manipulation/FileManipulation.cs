using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TodoApp.File_Manipulation
{
    class FileManipulation
    {
       public void ListFiles(string[] list)
        {
            for (int i = 0; i < list.Length; i++)
            {
                Console.WriteLine(i + 1 + ". " + list[i]);
            }
        }
        public void AddItem(string newTodo, string[] list)
        {
            Array.Resize(ref list, list.Length + 1);
            list[list.Length - 1] = newTodo;
            Console.WriteLine("New todo is added to the list.");
            Console.WriteLine(list);
        }
    }
}
