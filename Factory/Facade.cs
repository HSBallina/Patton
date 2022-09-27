namespace Patton.Factory
{
    public class Facade
    {
        protected SubSys1 SubSys1;
        protected SubSys2 SubSys2;

        public Facade(SubSys1 subSys1, SubSys2 subSys2)
        {
            SubSys1 = subSys1;
            SubSys2 = subSys2;
        }

        public string Operation()
        {
            var result = "Facade initializes subsystems:\n";
            result += SubSys1.Op1();
            result += SubSys2.Op1();
            result += "Facade orders subsystems to perform the action:\n";
            result += SubSys1.OpN();
            result += SubSys2.OpZ();
            return result;
        }
    }

    public class SubSys1
    {
        public static string Op1() => "Subsystem1: Ready!\n";
        public static string OpN() => "Subsystem1: Go!\n";
    }

    public class SubSys2
    {
        public static string Op1() => "Subsystem2: Get ready!\n";
        public static string OpZ() => "Subsystem2: Fire!\n";
    }

    public class Client
    {
        public static void ClientCode(Facade facade)
        {
            Console.Write(facade.Operation());
        }
    }
}
