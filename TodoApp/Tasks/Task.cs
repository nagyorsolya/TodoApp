
namespace TodoApp.Tasks
{
    public class Task
    {
        public string name;
        public bool isCompleted = false;
        public int number;
        public Task(string element, int number)
        {
            this.number = number;
            if (element[number.ToString().Length + 4] == 'X')
            {
                this.isCompleted = true;
            }
            this.name = element.Substring(number.ToString().Length + 6);
        }
        public Task(string name, int number, bool isCompleted)
        {
            this.name = name;
            this.number = number;
            this.isCompleted = isCompleted;
        }
        public override string ToString()
        {
            string isCompletedMark = isCompleted ? "X" : " ";
            return $"{number}. [{isCompletedMark}] {name}";
        }
    }
}
