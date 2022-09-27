namespace Patton.Behavioral.Command;

public class FastFoodOrder
{
    public List<MenuItem> CurrentItems { get; set; }
    public FastFoodOrder()
    {
        CurrentItems = new List<MenuItem>();
    }

    public void ExecuteCommand(OrderCommand command, MenuItem item)
    {
        command.Execute(this.CurrentItems, item);
    }

    public void ShowCurrentItems()
    {
        foreach (var item in CurrentItems)
        {
            item.Display();
        }
        Console.WriteLine("-----------------------");
    }
}
