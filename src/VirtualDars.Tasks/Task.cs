using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VirtualDars.Tasks
{
    interface ITask
    {
        public string Title { get; set; }
        public string Description { get; set; } 
        public DateTime DueDate { get; set; }
    }
    public class Task : ITask
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
