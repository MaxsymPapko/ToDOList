namespace ToDoList;

public class ActionHandler : TaskListHandler
{
    private int numberOfTask;
    public int NumberOfTask { set => numberOfTask = 1; }
    enum Action 

    {
        Add = 1,
        Show = 2,
        Delete = 3
    }

    public void checkSelectedOption(int selectedOption)
    {
        if (Enum.IsDefined(typeof(Action), selectedOption))
        {
            switch (selectedOption)
            {
                case 1:
                    Console.Write("Write an task to do:");
                    string newTask = Convert.ToString(Console.ReadLine());
                    TaskListHandler.AddTask(numberOfTask++, newTask);
                    TaskListHandler.SaveTasks();
                    Console.WriteLine(numberOfTask);
                    break;
                case 2:
                    TaskListHandler.ShowTasks();
                    break;
                case 3:
                    TaskListHandler.DeleteAllTasks();
                    break;
            }    
        }
        else
        {
            Console.WriteLine("Please select a valid option.");
        }
        
    }
}
