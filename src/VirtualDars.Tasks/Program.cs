using VirtualDars.Tasks;

namespace TaskManagement
{
	public class Program
	{
		public static void Main(string[] args)
		{
            TaskManager taskManager = new TaskManager();
            while (true)
            {
                Console.WriteLine("Menyuni tanlang:" +
                    "\n1.Task qo'shish" +
                    "\n2.Tasklarni ko'rish"
                    );
                int choseenMenu = int.Parse(Console.ReadLine());
                if (choseenMenu == 1)
                {
                    taskManager.AddTask();
                }
                else if (choseenMenu == 2)
                {
                    taskManager.DisplayTask();
                }
            }
        }
	}
}
