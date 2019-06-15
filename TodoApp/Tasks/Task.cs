using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TodoApp.Tasks
{
    public class Task
    {
        public string name;
        public bool isCompleted = false;
        public Task(string name, bool isCompleted)
        {
            this.name = name;
            this.isCompleted = isCompleted;
        }
    }
}
