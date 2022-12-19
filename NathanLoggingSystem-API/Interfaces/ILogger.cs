using NathanLoggingSystem_API.Classes;

namespace NathanLoggingSystem_API.Interfaces;
// The ILogger interface defines a method for writing log messages
public interface ILogger
{
    void WriteLog(string message);
}
// The FileLogger class is responsible for writing log messages to a file and for retrieving log messages from a file
public class FileLogger : ILogger, IGetLogger
{
    // The _logFilePath field is used to store the path to the file where log messages will be written
    private readonly string _logFilePath;

    // The FileLogger constructor takes a filePath argument and stores it in the _logFilePath field
    public FileLogger(string logFilePath)
    {
        _logFilePath = logFilePath;
    }

    // The WriteLog method writes a log message to the file specified by the _logFilePath field
    public void WriteLog(string message)
    {
        // C# create Log file - give a path and write the message
        using (var streamWriter = new StreamWriter(_logFilePath, true))
        {
            streamWriter.WriteLine(DateTime.Now + ": " + message);
        }

        Console.WriteLine("FileLogger: " + message);
    }
    
    public string GetLog()
    {
        // Read the log file and return the contents as a string
        using (var streamReader = new StreamReader(_logFilePath))
        {
            
            return streamReader.ReadToEnd();
        }
    }
}


