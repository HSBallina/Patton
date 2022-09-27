namespace Patton.Factory
{
    public abstract class ApiCaller
    {
        public abstract List<string> Call();
    }
    public class AnonymousApiCall : ApiCaller
    {
        public override List<string> Call()
            => new() { "Anonymous" };
    }

    public class AuthApiCall : ApiCaller
    {
        public override List<string> Call()
            => new() { "Authenticated" };
    }

    public static class ApiCallerCreator
    {
        public static ApiCaller CreateCaller(string apiKey)
        {
            ApiCaller caller;

            if (string.IsNullOrEmpty(apiKey))
                caller = new AnonymousApiCall();
            else
                caller = new AuthApiCall();

            return caller;
        }
    }
}
