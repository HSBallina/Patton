namespace Patton.Behavioral.Command;

public class Patron
{
    private readonly FastFoodOrder _order;

    public Patron()
        => _order = new FastFoodOrder();

    public void ExecuteCommand(CommandType commandType, MenuItem menuItem)
        => _order.ExecuteCommand(new CommandFactory().GetCommand(commandType), menuItem);

    public void ShowCurrentOrder()
        => _order.ShowCurrentItems();
}
