namespace Singleton
{
    public class LazySingleton
    {

        private readonly object _locker = new object();

        private LazySingleton _instance;

        public LazySingleton Instance
        {
            get
            {
                lock (_locker)
                {
                    if (_instance == null)
                    {
                        _instance = new LazySingleton();                       
                    }
                    return _instance;
                }
            }
        }

        private LazySingleton()
        {         
        }
    }
}
