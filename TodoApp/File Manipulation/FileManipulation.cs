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
    }
}
