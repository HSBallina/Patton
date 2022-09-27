namespace Patton.Behavioral.Command;

public abstract class OrderCommand
{
    public abstract void Execute(List<MenuItem> order, MenuItem item);
}
