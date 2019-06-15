using System;
using System.Collections.Generic;
using TodoApp.Tasks;

namespace TodoApp.Task_Operations
{
    public class TaskOperations
    {
        public static void ListTasks(List<Task> list)
        {
            if (list.Count == 0)
            {
                Console.WriteLine("No todos for today :)");
            }
            for (int i = 0; i < list.Count; i++)
            {
                Console.WriteLine(list[i].ToString());
            }
        }
        public static void AddItem(string newTodo, List<Task> list)
        {
            list.Add(new Task(newTodo, (list.Count + 1), false));
            Console.WriteLine("New todo is added to the list.");
        }
        public static void RemoveItem(int inputNumber, List<Task> list)
        {
            if (inputNumber <= list.Count)
            {
                list.RemoveAt((inputNumber - 1));
                Console.WriteLine("Task was succesfully removed!");
                for (int i = inputNumber - 1; i < list.Count; i++)
                {
                    list[i].number--;
                }
            }
            else
            {
                Console.WriteLine("Unable to check: index is out of bound.");
            }
        }
        public static void CompleteTask(int inputNumber, List<Task> list)
        {
            list[(inputNumber - 1)].isCompleted = true;
        }
        public static List<Task> FromStringToTask(List<string> list)
        {
            List<Task> taskList = new List<Task>();
            for (int i = 0; i < list.Count; i++)
            {
                taskList.Add(new Task(list[i], (i + 1)));
            }
            return taskList;
        }
        public static List<string> FromTaskToString(List<Task> list)
        {
            List<string> stringList = new List<string>();
            for (int i = 0; i < list.Count; i++)
            {
                stringList.Add(list[i].ToString());
            }
            return stringList;
        }
    }
}
