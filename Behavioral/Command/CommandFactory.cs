namespace Patton.Behavioral.Command;

public class CommandFactory
{
    public OrderCommand GetCommand(CommandType commandOption)
        => commandOption switch
        {
            CommandType.Add => new AddCommand(),
            CommandType.Modify => new ModifyCommand(),
            CommandType.Remove => new RemoveCommand(),
            _ => new AddCommand()
        };
}
