using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Neponyatnoe
{
    public interface ITaskService 
    {
        void AddTask(string title);
        List<TaskItem> GetAllTasks();
        void DoneOreNot(int id);
        void DeleteTask(int id);
    }
}
