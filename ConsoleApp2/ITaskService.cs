using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp2
{
    public interface ITaskService
    {
        void AddTask(string title);
        List<TaskItem> GetAllTasks();
        void MarkTaskAsCompleted(int id);
        void RemoveTask(int id);
        TaskItem GetTaskById(int id); 
    }
}
