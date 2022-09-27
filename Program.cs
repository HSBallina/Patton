using Microsoft.Extensions.DependencyInjection;
using Patton.Behavioral.Command;
using Patton.Create;
using Patton.Dep;
using Patton.Factory;

namespace Patton;

public static class Program
{
    public static void Main()
    {
        Builder();
        DependencyInjection();
        StaticFactory();
        AbstractFactory();
        Facade();
        Adapter();
        Command();
        Console.ReadKey();
    }

    public static void Builder()
    {
        var uglyBurger = new Burger(true, true, false, false, false);

        var burgerBuilder = new BurgerBuilder();
        var awesomeBurger = burgerBuilder
            .WithBacon()
            .WithCheese()
            .WithPatties(2)
            .Build();

        Console.WriteLine($"Ugly burger; {uglyBurger}");
        Console.WriteLine($"Awesome burger; {awesomeBurger}");
    }

    public static void DependencyInjection()
    {
        var serviceProvider = new ServiceCollection()
            .AddSingleton<IWorker, Worker2>()
            .BuildServiceProvider();

        var currentWorker = serviceProvider.GetService<IWorker>();
        currentWorker!.Work();
    }

    public static void StaticFactory()
    {
        var hero = Hero.CreateStatic();
        hero.Name = "Jennifer Walters";
        hero.Address = "Los Angeles";
        Console.WriteLine(hero);

        var anotherHero = Hero.CreateStatic("Bruce Banner", "Unknown", true);
        Console.WriteLine(anotherHero);
    }

    public static void AbstractFactory()
    {
        var authCaller = ApiCallerCreator.CreateCaller("Doctor Strange");
        var anonCaller = ApiCallerCreator.CreateCaller(string.Empty);

        Console.WriteLine($"I'm an {authCaller.GetType().Name}. Calling {authCaller.Call()[0]}");
        Console.WriteLine($"I'm an {anonCaller.GetType().Name}. Calling {anonCaller.Call()[0]}");
    }

    public static void Facade()
    {
        var subsystem1 = new SubSys1();
        var subsystem2 = new SubSys2();
        var facade = new Facade(subsystem1, subsystem2);
        Client.ClientCode(facade);
    }

    public static void Adapter()
    {
        var sparrow = new Sparrow();
        var toyDuck = new PlasticToyDuck();

        var birdAdapter = new BirdAdapter(sparrow);

        sparrow.Fly();
        sparrow.MakeSound();

        toyDuck.Squeak();

        birdAdapter.Squeak();
    }

    public static void Command()
    {
        Patron patron = new();
        patron.ExecuteCommand(CommandType.Add, new MenuItem("French Fries", 2, 1.99));

        patron.ExecuteCommand(CommandType.Add, new MenuItem("Hamburger", 2, 2.59));

        patron.ExecuteCommand(CommandType.Add, new MenuItem("Drink", 2, 1.19));

        patron.ShowCurrentOrder();

        //Remove the french fries
        patron.ExecuteCommand(CommandType.Remove, new MenuItem("French Fries", 2, 1.99));

        patron.ShowCurrentOrder();

        //Now we want 4 hamburgers rather than 2
        patron.ExecuteCommand(CommandType.Modify, new MenuItem("Hamburger", 4, 2.59));

        patron.ShowCurrentOrder();
    }
}
