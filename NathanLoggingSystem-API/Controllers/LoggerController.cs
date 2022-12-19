using NathanLoggingSystem_API.Interfaces;
using Microsoft.AspNetCore.Mvc;
//using LoggingSystem.Interfaces;
using ILogger = NathanLoggingSystem_API.Interfaces.ILogger;
using LoggerFactory = NathanLoggingSystem_API.Classes.LoggerFactory;


namespace NathanLoggingSystem_API.Controllers;
// The LogController class is responsible for handling HTTP requests to write or retrieve log messages

[ApiController]
[Route("[controller]")]


public class LogController : Controller
{
    // The _loggerFactory field is used to store the LoggerFactory object that will be used to create logger objects
    private readonly LoggerFactory _loggerFactory;

    // The LogController constructor creates a new LoggerFactory object and stores it in the _loggerFactory field
    public LogController()
    {
        _loggerFactory = new LoggerFactory();
    }
    
    // The WriteLog method writes a log message using a logger object created by the LoggerFactory
    [HttpPost]
    public IActionResult WriteLog(string type, string filePath, string message)
    {
        // Create an ILogger instance using the LoggerFactory and the file path
        ILogger logger = _loggerFactory.CreateLogger(type, filePath);

        // Write the log message using the ILogger instance
        logger.WriteLog(message);

        return Ok();
    }
    
    [HttpGet]
    public IActionResult GetLog(string type, string filePath)
    {
        // Create an IGetLogger instance using the LoggerFactory and the file path
        IGetLogger getLogger = _loggerFactory.CreateGetLogger(type, filePath);

        // Get the log messages using the IGetLogger instance
        string logMessages = getLogger.GetLog();
        // Return the log messages in a Json format
        return Json(logMessages);
        
    }


}

// Example: "file", "/Users/nathangilbert/Logs/Hello.txt"
// Example: "file", "/Users/nathangilbert/Logs/Hello.txt", "Hello World"

    
    

    
    