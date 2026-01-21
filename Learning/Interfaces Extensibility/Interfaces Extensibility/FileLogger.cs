namespace Interfaces_Extensibility;

public class FileLogger : ILogger
{
    private readonly String _path;

    public FileLogger(string path)
    {
        _path = path;
    }

    void ILogger.LogError(string message)
    {
        Log(message, "Error");
    }

    void ILogger.LogInfo(string message)
    {
        Log(message, "Info");
    }

    private void Log(string message, string messageType)
    {
        using (var streamWriter = new StreamWriter(_path, true))
        {
            streamWriter.WriteLine($"{messageType}: {message}");
        }
    }
}
