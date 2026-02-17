using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Neponyatnoe
{
    public class ConsoleMenu
    {
       private readonly ITaskService _taskService;
        public void Menu(string[] args)
        {
            while (true)
            {
                Console.WriteLine("1.Показать задачи");
                Console.WriteLine("2.Добавить задачу");
                Console.WriteLine("3.Отметить как выполненную");
                Console.WriteLine("4.Удалить задачи");
                Console.WriteLine("0.Выход");
                string choise = Console.ReadLine();
                if (choise == null) ; 
            }
        }

    }
}
