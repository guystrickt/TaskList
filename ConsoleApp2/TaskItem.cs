using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp2
{
    public class TaskItem
    {
        public int Id { get; }
        public string Title { get; }
        public bool IsCompleted { get; set; }

        public TaskItem(int id, string title)
        {
            if (string.IsNullOrWhiteSpace(title))
            {
                throw new ArgumentException("Название задачи не может быть пустым.");
            }
            Id = id;
            Title = title;
            IsCompleted = false;
        }
    }
}
