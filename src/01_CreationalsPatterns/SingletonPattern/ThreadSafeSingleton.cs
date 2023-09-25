using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingletonPattern
{
    public class ThreadSafeSingleton<T>
        where T : class, new()
    {
        private static object syncLock = new object();

        private static T _instance;
        public static T Instance
        {
            get
            {
                lock (syncLock)                             // Monitor.Enter(syncLock);
                {
                    if (_instance == null)
                    {
                        _instance = new T();
                    }
                }                                           // Monitor.Exit(syncLock);

                return _instance;
            }
        }
    }
}
