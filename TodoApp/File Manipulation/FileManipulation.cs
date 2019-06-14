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
            for (int i = 0; i < list.Count; i++)
            {
                Console.WriteLine(i + 1 + ". " + list[i]);
            }
        }
        public static void AddItem(string newTodo, List<string> list)
        {
            List<string> converted = list.ToList<string>();
            converted.Add(newTodo);
            Console.WriteLine("New todo is added to the list.");
        }
    }
}
