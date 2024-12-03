namespace ToDoList;

public class ActionHandler
{
    enum Action : byte

    {
        Add = 1,
        Show = 2,
        Delete = 3
    }

    public int checkSelectedOption(int selectedOption)
    {
        if (Enum.IsDefined(typeof(Action), selectedOption))
        {
                
        }
        return selectedOption;
    }
}
