using System;
using System.IO;

namespace LoggerExcercise;

public class Logger
{
    private readonly string path = "log.txt";

    public void LogInformation(string message)
    {
        using StreamWriter sw = File.AppendText(path);
        sw.WriteLine($"{DateTime.Now} {message}");
    }
}
