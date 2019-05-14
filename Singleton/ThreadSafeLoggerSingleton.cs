using System;

namespace Singleton
{
    public class ThreadSafeLoggerSingleton
    {
        private ThreadSafeLoggerSingleton()
        {
            // _logCount = read log from file
        }
        private int _logCount = 0;
        private static ThreadSafeLoggerSingleton _loggerInstance;
        private static readonly object locker = new object();

        public static ThreadSafeLoggerSingleton GetInstance()
        {
            lock (locker)
            {
                if (_loggerInstance == null)
                {
                    _loggerInstance = new ThreadSafeLoggerSingleton();
                }
            }
            return _loggerInstance;
        }

        public void Log(String message)
        {
            Console.WriteLine(_logCount + ": " + message);
            _logCount++;
        }
    }
}
