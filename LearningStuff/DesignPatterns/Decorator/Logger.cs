using System;

namespace Decorator
{
    public class Logger
    {
        public void Log(string message)
        {
            Console.WriteLine(DateTime.Now + ": " + message);
        }
    }
}
