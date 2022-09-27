namespace Patton.Behavioral.Command;

public class AddCommand : OrderCommand
{
    public override void Execute(List<MenuItem> currentItems, MenuItem item)
        => currentItems.Add(item);
}
