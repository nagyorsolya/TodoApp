using System;
using System.Collections.Generic;

namespace TodoApp.File_Manipulation
{
    class FileManipulation
    {
        public static void WriteToFile(string pathToFile, List<string> lines)
        {
            System.IO.File.WriteAllLines(pathToFile, lines);

        }
        public static string[] ReadFile(string pathToFile)
        {
            if (pathToFile == "")
            {
                throw new MissingFieldException("Missing input");
            }
            Console.WriteLine("What would you like to do today?: \nl - list todos\na - add todo\nr - remove todo\nc - complete todo\nq - exit");
            return System.IO.File.ReadAllLines(pathToFile);
        }
    }
}
