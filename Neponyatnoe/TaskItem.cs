using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Neponyatnoe
{
    public class TaskItem
    {
        public int Id { get; set; } 
        public string Title {  get; set; }
        public bool IsCompleted { get; set; }
        public TaskItem(int id, string title)
        {
            Id = id;
            Title = title;
            IsCompleted = false;

        }
    }
}
