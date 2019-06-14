using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TodoApp
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] todoList = System.IO.File.ReadAllLines(@"C:\Test.txt");
            for ( int i = 0; i < todoList.Length; i++)
            {
                Console.WriteLine(i+1 + ". " + todoList[i]);
            }
            Console.ReadLine();
        }
    }
}
