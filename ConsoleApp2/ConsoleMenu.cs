using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp2
{
    public class ConsoleMenu
    {
        private readonly ITaskService _taskService;

        public ConsoleMenu(ITaskService taskService)
        {
            _taskService = taskService ?? throw new ArgumentNullException(nameof(taskService));
        }

        public void Run()
        {
            bool exit = false;
            while (!exit)
            {
                ShowMenu();
                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        AddTask();
                        break;
                    case "2":
                        ShowAllTasks();
                        break;
                    case "3":
                        MarkTaskCompleted();
                        break;
                    case "4":
                        RemoveTask();
                        break;
                    case "0":
                        exit = true;
                        Console.WriteLine("Выход из программы.");
                        break;
                    default:
                        Console.WriteLine("Неверный ввод. Пожалуйста, выберите пункт из меню.");
                        break;
                }
                Console.WriteLine(); 
            }
        }

        private void ShowMenu()
        {
            Console.WriteLine("--- Меню списка задач ---");
            Console.WriteLine("1. Добавить задачу");
            Console.WriteLine("2. Показать все задачи");
            Console.WriteLine("3. Отметить задачу выполненной");
            Console.WriteLine("4. Удалить задачу");
            Console.WriteLine("0. Выход");
            Console.Write("Выберите действие: ");
        }

        private void AddTask()
        {
            Console.Write("Введите название задачи: ");
            string title = Console.ReadLine();
            try
            {
                _taskService.AddTask(title);
                Console.WriteLine("Задача добавлена.");
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine($"Ошибка: {ex.Message}");
            }
        }

        private void ShowAllTasks()
        {
            var tasks = _taskService.GetAllTasks();
            if (tasks.Count == 0)
            {
                Console.WriteLine("Список задач пуст.");
                return;
            }

            Console.WriteLine("--- Ваши задачи ---");
            foreach (var task in tasks)
            {
                Console.WriteLine($"[{task.Id}] {task.Title} {(task.IsCompleted ? "[Выполнено]" : "[В процессе]")}");
            }
        }

        private void MarkTaskCompleted()
        {
            Console.Write("Введите ID задачи для отметки как выполненной: ");
            if (int.TryParse(Console.ReadLine(), out int id))
            {
                var task = _taskService.GetTaskById(id);
                if (task != null)
                {
                    _taskService.MarkTaskAsCompleted(id);
                    Console.WriteLine($"Задача '{task.Title}' отмечена как выполненная.");
                }
                else
                {
                    Console.WriteLine($"Задача с ID {id} не найдена.");
                }
            }
            else
            {
                Console.WriteLine("Неверный формат ID.");
            }
        }

        private void RemoveTask()
        {
            Console.Write("Введите ID задачи для удаления: ");
            if (int.TryParse(Console.ReadLine(), out int id))
            {
                var task = _taskService.GetTaskById(id);
                if (task != null)
                {
                    _taskService.RemoveTask(id);
                    Console.WriteLine($"Задача '{task.Title}' удалена.");
                }
                else
                {
                    Console.WriteLine($"Задача с ID {id} не найдена.");
                }
            }
            else
            {
                Console.WriteLine("Неверный формат ID.");
            }
        }
    }
}
