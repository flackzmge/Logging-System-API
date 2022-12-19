# Logger File Web API

Welcome to the Logger File Web API application! This application is designed to allow users to write log messages to a file and retrieve log messages from a file.

## SOLID Principles

In this application, we have followed the SOLID principles of software design in order to make the code easy to maintain and extend. Specifically, we have followed the Single Responsibility Principle (SRP) and the Dependency Inversion Principle (DIP).

### Single Responsibility Principle (SRP)
The Single Responsibility Principle (SRP) states that a class should have only one reason to change. This means that each class in the application should have a single, well-defined responsibility. We have followed this principle by assigning specific responsibilities to each class in the application. For example, the Logger class is responsible for writing log messages, the LoggerFactory class is responsible for creating logger objects, and the LogController class is responsible for handling HTTP requests to write or retrieve log messages.

### Dependency Inversion Principle (DIP)
The Dependency Inversion Principle (DIP) states that high-level modules should not depend on low-level modules; both should depend on abstractions. This means that the high-level modules in the application should depend on interfaces rather than on concrete implementations. We have followed this principle by using interfaces to decouple the high-level modules from the low-level implementation details. For example, the LogController class depends on the ILogger and IGetLogger interfaces rather than on specific logger implementations like FileLogger. This makes the code more flexible and easier to maintain.

### Importance

The importance of this program lies in its ability to allow users to easily write and retrieve log messages. Logging is an essential part of any application because it allows developers to track what is happening within the application and to troubleshoot any issues that may arise. By using this application, developers can quickly and easily write log messages to a file and retrieve those log messages when needed. This can save a lot of time and effort when debugging and maintaining the application.

### Usage

To use this application, you will need to make HTTP requests to the /log endpoint. There are two available methods: POST and GET.

Writing Log Messages
To write a log message, you will need to make a POST request to the /log endpoint. The request body should include the following parameters:

`type`: The type of logger to use (currently only "file" is supported)
`filePath`: The path to the file where the log message should be written
`message`: The log message to write
An example request might look like this:

```
POST /log
{
  "type": "file",
  "filePath": "/Users/nathangilbert/Logs/Hello.txt",
  "message": "Hello World"
}
 ```
 
 ### Retrieving Log Messages
To retrieve log messages, you will need to make a GET request to the /log endpoint. The request should include the following parameters:

`type`: The type of logger to use (currently only "file" is supported)
`filePath`: The path to the file where the log messages are stored
An example request might look like this:

```
GET /log?type=file&filePath=/Users/nathangilbert/Logs/Hello.txt
```
The response to this request will be a JSON object containing the log messages retrieved from the file.

## Questions or Suggestions

If you have any questions or suggestions, please don't hesitate to let me know.
