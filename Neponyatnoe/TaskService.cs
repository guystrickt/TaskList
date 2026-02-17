using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Neponyatnoe
{
    public class TaskService : ITaskService
    {     
        List<TaskItem> _tasks = new List<TaskItem>();
        int _nextId = 1;

        public void AddTask(string title)
        { 
            var  task = new TaskItem(_nextId++, title);
            _tasks.Add(task);
        }
        public List<TaskItem> GetAllTasks()
        {
            return _tasks;
        }
        public void DoneOrNot(int id)
        {
            var task = _tasks.Find(t => t.Id == id);
            if (task != null) task.IsCompleted = true;
            
        }
        public void DeleteTask(int id)
        {
            _tasks.RemoveAll(t => t.Id == id);
        }
    }


}

