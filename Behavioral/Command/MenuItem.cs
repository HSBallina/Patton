namespace Patton.Behavioral.Command;

public class MenuItem
{
    public string Name { get; set; }
    public int Amount { get; set; }
    public double Price { get; set; }

    public MenuItem(string name, int amount, double price)
    {
        Name = name;
        Amount = amount;
        Price = price;
    }

    public void Display()
    {
        Console.WriteLine($"Item; {Name}, Amount; {Amount}, Price; ${Price}");
    }
}
