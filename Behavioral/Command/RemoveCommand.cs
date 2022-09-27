namespace Patton.Behavioral.Command;

public class RemoveCommand : OrderCommand
{
    public override void Execute(List<MenuItem> currentItems, MenuItem item)
        => currentItems.Remove(currentItems.First(x => x.Name == item.Name));
}
