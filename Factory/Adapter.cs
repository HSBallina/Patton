namespace Patton.Factory
{
    public interface IBird
    {
        void Fly();
        void MakeSound();
    }

    public class Sparrow : IBird
    {
        public void Fly()
        {
            Console.WriteLine($"{GetType().Name}; Flying");
        }

        public void MakeSound()
        {
            Console.WriteLine($"{GetType().Name}; Tweet tweet");
        }
    }

    public interface IToyDuck
    {
        void Squeak();
    }

    public class PlasticToyDuck : IToyDuck
    {
        public void Squeak()
        {
            Console.WriteLine($"{GetType().Name}; Squeak");
        }
    }

    public class BirdAdapter : IToyDuck
    {
        private readonly IBird _bird;

        public BirdAdapter(IBird bird)
        {
            _bird = bird;
        }

        public void Squeak()
        {
            _bird.MakeSound();
        }
    }
}
