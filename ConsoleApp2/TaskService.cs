using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp2
{
    public class TaskService : ITaskService
    {
        private List<TaskItem> _tasks = new List<TaskItem>();
        private int _nextId = 1;

        public void AddTask(string title)
        {
            var newTask = new TaskItem(_nextId++, title);
            _tasks.Add(newTask);
        }

        public List<TaskItem> GetAllTasks()
        {
            return new List<TaskItem>(_tasks); 
        }

        public void MarkTaskAsCompleted(int id)
        {
            var task = GetTaskById(id);
            if (task != null)
            {
                task.IsCompleted = true;
            }
        }

        public void RemoveTask(int id)
        {
            var taskToRemove = GetTaskById(id);
            if (taskToRemove != null)
            {
                _tasks.Remove(taskToRemove);
            }
        }

        public TaskItem GetTaskById(int id)
        {
            return _tasks.FirstOrDefault(t => t.Id == id);
        }
    }
}
