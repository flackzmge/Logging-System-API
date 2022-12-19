using NathanLoggingSystem_API.Interfaces;
using ILogger = NathanLoggingSystem_API.Interfaces.ILogger;

namespace NathanLoggingSystem_API.Classes;

// The Logger class is responsible for writing log messages
public class Logger : ILogger
{
    // The _logger field is used to store the logger object that will be used to write log messages
    private readonly ILogger _logger;
    
    // The Logger constructor takes an ILogger object as an argument and stores it in the _logger field
    public Logger(ILogger logger)
    {
        
        _logger = logger;
    }

    // The WriteLog method writes a log message using the _logger object
    public void WriteLog(string message)
    {
        // 
        _logger.WriteLog(message);
    }

    // The Log method is not implemented
    public void Log(string thisIsATestMessage)
    {
        throw new NotImplementedException();
    }
}
