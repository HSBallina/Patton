namespace Patton.Factory;

public class Hero
{
    public string Name { get; set; }
    public string Address { get; set; }
    public bool MemberOfAvengers { get; set; }

    public static Hero CreateStatic() => new();

    public static Hero CreateStatic(string name, string address, bool memberOfAvengers)
        => new()
        {
            Name = name,
            Address = address,
            MemberOfAvengers = memberOfAvengers
        };

    private Hero()
    {
        Name = string.Empty;
        Address = string.Empty;
        MemberOfAvengers = false;
    }

    private string GetMemberStatus()
        => MemberOfAvengers ? "Avengers member." : "Not an Avenger.";

    public override string ToString() => $"{Name}, {Address}. {GetMemberStatus()}";
}
