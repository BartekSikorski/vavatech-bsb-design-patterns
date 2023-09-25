using System;
using System.IO;

namespace LoggerExcercise;

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

public class Logger : ThreadSafeSingleton<Logger>
{
    private readonly string path = "log.txt";

    private readonly object syncFileLock = new object();

    public void LogInformation(string message)
    {
        lock (syncFileLock)
        {
            using StreamWriter sw = File.AppendText(path);
            sw.WriteLine($"{DateTime.Now} {message}");
        }
    }
}
