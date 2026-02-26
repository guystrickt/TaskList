using ConsoleApp2;

public class Program
{
    static void Main(string[] args)
    {
        ITaskService taskService = new TaskService();

        var menu = new ConsoleMenu(taskService);

        menu.Run();
    }
}