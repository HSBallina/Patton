namespace Patton.Behavioral.Command;

public class ModifyCommand : OrderCommand
{
    public override void Execute(List<MenuItem> currentItems, MenuItem item)
    {
        var menuItem = currentItems.First(x => x.Name == item.Name);
        menuItem.Price = item.Price;
        menuItem.Amount = item.Amount;
    }
}
