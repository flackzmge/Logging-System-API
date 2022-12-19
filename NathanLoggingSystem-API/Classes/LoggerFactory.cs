
using NathanLoggingSystem_API.Interfaces;
using ILogger = NathanLoggingSystem_API.Interfaces.ILogger;

namespace NathanLoggingSystem_API.Classes;

// The LoggerFactory class is responsible for creating logger objects
    public class LoggerFactory
    {
        // The CreateLogger method creates a logger object based on the destination and logFilePathConnectionString arguments
        public ILogger CreateLogger(string destination, string logFilePathConnectionString)
        {
            ILogger logger = null;

            switch (destination)
            {
                case "file":
                    if (string.IsNullOrEmpty(logFilePathConnectionString))
                    {
                        throw new ArgumentException("Log file path must be provided for file logger.");
                    }
                    logger = new FileLogger(logFilePathConnectionString);
                    break;
                case "database":
                    if (string.IsNullOrEmpty(logFilePathConnectionString))
                    {
                        throw new ArgumentException("Connection string must be provided for database logger.");
                    }
                    break;
                default:
                    throw new ArgumentException("Invalid logging destination.");
            }

            return logger;
        }
       
        // The CreateGetLogger method creates a logger object based on the destination and logFilePathConnectionString arguments
        public IGetLogger CreateGetLogger(string type, string filePath = null)
        {
            switch (type)
            {
                case "file":
                    return new FileLogger(filePath);
                default:
                    throw new ArgumentException($"Invalid logger type: {type}");
            }
        }
    }
    
    

