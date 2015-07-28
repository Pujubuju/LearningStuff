namespace Singleton
{
    public class Singleton
    {

        private readonly Singleton _instance = new Singleton();

        public Singleton Instance { get { return _instance; } }

        private Singleton()
        {         
        }
    }
}
