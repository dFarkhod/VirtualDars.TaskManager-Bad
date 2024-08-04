using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VirtualDars.Tasks
{
    public class TaskManager
    {
        private List<Task> _tasks = new List<Task>();
        private string _filePath = string.Empty;

        public TaskManager() {
            _filePath = Constants.TASKS_FILE_PATH;
            _tasks = DataManager.ReadFromFile<Task>(_filePath);
        }

        public void AddTask()
        {
            Console.WriteLine("Task nomini kiriting");
            string title = Console.ReadLine();
            Console.WriteLine("Taskga description qo'shing");
            string desc = Console.ReadLine();
            Console.WriteLine("Task didlini");
            bool isInt = int.TryParse(Console.ReadLine(), out int didline);
            Task task = new Task(title, desc, DateTime.Now.AddDays(didline));
            _tasks.Add(task);
            DataManager.WriteToFile<Task>(_filePath, _tasks);

        }

        public void DisplayTask() {
            foreach (var item in _tasks)
            {
                Console.WriteLine($"{item.Title} \n{item.Description} \nDidlini tugash vaqti: {item.DueDate}" );
                Console.WriteLine("############################################ \n");
            }
        }


        public void CreateTask(string title, string description, DateTime dueDate)
        {
            // Create a new task object
            Task task = new Task(title, description, dueDate);
            if (task != null)
            {
                _tasks.Add(task);
                DataManager.WriteToFile<Task>(_filePath, _tasks);
            }
       
            // Send a notification about the new task (replace with actual notification logic)
            Console.WriteLine("Sending notification about new task...");
            // ... (code to send notification)
        }

        public List<Task> GetTasks()
        {
            return _tasks;
        }
    }
}
