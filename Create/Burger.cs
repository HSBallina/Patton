using System.Text;

namespace Patton.Create;

public class Burger
{
    public int NumPatties { get; set; }
    public bool Cheese { get; set; }
    public bool Bacon { get; set; }
    public bool Pickles { get; set; }
    public bool Lettuce { get; set; }
    public bool Tomato { get; set; }

    public Burger(int numPatties = 1)
    {
        NumPatties = numPatties;
    }

    public Burger(bool cheese, bool bacon, bool pickles,
        bool lettuce, bool tomato, int numPatties = 1)
    {
        Cheese = cheese;
        Bacon = bacon;
        Pickles = pickles;
        Lettuce = lettuce;
        Tomato = tomato;
        NumPatties = numPatties;
    }

    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.AppendLine($"Burger with {NumPatties} patties");
        if(Cheese) sb.AppendLine("Cheese");
        if(Bacon) sb.AppendLine("Bacon");
        if(Pickles) sb.AppendLine("Pickles");
        if(Lettuce) sb.AppendLine("Lettuce");
        if(Tomato) sb.AppendLine("Tomato");
        sb.AppendLine("Enjoy!");

        return sb.ToString();
    }
}
