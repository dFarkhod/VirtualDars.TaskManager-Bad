namespace TaskManagement
{
	public class Program
	{
		public static void Main(string[] args)
		{
			TaskManager taskManager = new();
			var tasks = taskManager.GetTasks();
			
			taskManager.CreateTask("Read Quran", "Surah Yasin", DateTime.Now);
		}
	}

	public class TaskManager
	{
		public void CreateTask(string title, string description, DateTime dueDate)
		{
			// Create a new task object
			Task task = new Task(title, description, dueDate);

			// Save the task to a database (replace with actual database implementation)
			Console.WriteLine("Saving task to database...");
			// ... (code to save task to database)

			// Send a notification about the new task (replace with actual notification logic)
			Console.WriteLine("Sending notification about new task...");
			// ... (code to send notification)
		}

		public List<Task> GetTasks()
		{
			// Simulate retrieving tasks from a database (replace with actual database access)
			List<Task> tasks = new List<Task>()
			{
				new Task("Task 1", "Description 1", DateTime.Now.AddDays(1)),
				new Task("Task 2", "Description 2", DateTime.Now.AddDays(2))
			};
			return tasks;
		}

	}
	
	public class Task
	{
		public string Title { get; set; }
		public string Description { get; set; }
		public DateTime DueDate { get; set; }

		public Task(string title, string description, DateTime dueDate)
		{
			Title = title;
			Description = description;
			DueDate = dueDate;
		}
	}


	
}
