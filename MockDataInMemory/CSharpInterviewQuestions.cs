using Quiz_Api.Models;

namespace Quiz_Api.MockDataInMemory
{
    public static class CSharpInterviewQuestions
    {
       
        public static List<Question> GenerateMockCSharpQuestions()
        {
            return new List<Question>
        {
            new Question { QId = 21, QnInWords = "What is the difference between .NET Core and .NET Framework?", Option1 = ".NET Core is cross-platform, .NET Framework is Windows-only", Option2 = ".NET Core is for web applications, .NET Framework is for desktop applications", Option3 = ".NET Core is open-source, .NET Framework is proprietary", Option4 = "Both A and C", Answer = 4 },
            new Question { QId = 22, QnInWords = "How do you create a new .NET Core project?", Option1 = "Using Visual Studio only", Option2 = "Using the dotnet new command", Option3 = "Using the .NET Core CLI", Option4 = "Both B and C", Answer = 4 },
            new Question { QId = 23, QnInWords = "What is dependency injection and how is it used in .NET Core?", Option1 = "A design pattern to manage dependencies", Option2 = "A way to inject dependencies at runtime", Option3 = "A method to improve code maintainability", Option4 = "All of the above", Answer = 4 },
            new Question { QId = 24, QnInWords = "How do you handle configuration in a .NET Core application?", Option1 = "Using app.config file", Option2 = "Using web.config file", Option3 = "Using appsettings.json file", Option4 = "Using environment variables", Answer = 3 },
            new Question { QId = 25, QnInWords = "What is middleware in .NET Core?", Option1 = "A component that handles HTTP requests and responses", Option2 = "A service that runs in the background", Option3 = "A library for managing dependencies", Option4 = "A tool for debugging applications", Answer = 1 },
            new Question { QId = 26, QnInWords = "How do you create a RESTful API in .NET Core?", Option1 = "Using ASP.NET Core MVC", Option2 = "Using ASP.NET Core Web API", Option3 = "Using WCF", Option4 = "Using SignalR", Answer = 2 },
            new Question { QId = 27, QnInWords = "What is the purpose of the Startup class in a .NET Core application?", Option1 = "To configure services and the app's request pipeline", Option2 = "To manage database connections", Option3 = "To handle user authentication", Option4 = "To manage application settings", Answer = 1 },
            new Question { QId = 28, QnInWords = "How do you perform dependency injection in .NET Core?", Option1 = "Using the IServiceCollection interface", Option2 = "Using the IApplicationBuilder interface", Option3 = "Using the IConfiguration interface", Option4 = "Using the ILogger interface", Answer = 1 },
            new Question { QId = 29, QnInWords = "What is Entity Framework Core?", Option1 = "A lightweight, extensible, open-source ORM", Option2 = "A tool for managing database migrations", Option3 = "A library for handling HTTP requests", Option4 = "A framework for building web applications", Answer = 1 },
            new Question { QId = 30, QnInWords = "How do you handle exceptions in a .NET Core application?", Option1 = "Using try-catch blocks", Option2 = "Using middleware", Option3 = "Using the IExceptionHandler interface", Option4 = "All of the above", Answer = 4 },
            new Question { QId = 31, QnInWords = "What is the purpose of the Program class in a .NET Core application?", Option1 = "To configure services", Option2 = "To define the entry point of the application", Option3 = "To manage database connections", Option4 = "To handle user authentication", Answer = 2 },
            new Question { QId = 32, QnInWords = "How do you create a custom middleware in .NET Core?", Option1 = "By implementing the IMiddleware interface", Option2 = "By creating a class with an Invoke or InvokeAsync method", Option3 = "By registering the middleware in the Startup class", Option4 = "All of the above", Answer = 4 },
            new Question { QId = 33, QnInWords = "What is the purpose of the appsettings.json file in a .NET Core application?", Option1 = "To store application settings", Option2 = "To manage database connections", Option3 = "To handle user authentication", Option4 = "To configure services", Answer = 1 },
            new Question { QId = 34, QnInWords = "How do you perform logging in a .NET Core application?", Option1 = "Using the ILogger interface", Option2 = "Using the ILoggingBuilder interface", Option3 = "Using the LogManager class", Option4 = "Using the Log4Net library", Answer = 1 },
            new Question { QId = 35, QnInWords = "What is the purpose of the ConfigureServices method in the Startup class?", Option1 = "To configure the app's request pipeline", Option2 = "To configure services for dependency injection", Option3 = "To manage database connections", Option4 = "To handle user authentication", Answer = 2 },
            new Question { QId = 36, QnInWords = "How do you create a database migration in Entity Framework Core?", Option1 = "Using the Add-Migration command", Option2 = "Using the Update-Database command", Option3 = "Using the Scaffold-DbContext command", Option4 = "Using the dotnet ef migrations add command", Answer = 4 },
            new Question { QId = 37, QnInWords = "What is the purpose of the Configure method in the Startup class?", Option1 = "To configure services for dependency injection", Option2 = "To configure the app's request pipeline", Option3 = "To manage database connections", Option4 = "To handle user authentication", Answer = 2 },
            new Question { QId = 38, QnInWords = "How do you handle user authentication in a .NET Core application?", Option1 = "Using ASP.NET Core Identity", Option2 = "Using JWT (JSON Web Tokens)", Option3 = "Using OAuth", Option4 = "All of the above", Answer = 4 },
            new Question { QId = 39, QnInWords = "What is the purpose of the dotnet restore command?", Option1 = "To restore NuGet packages", Option2 = "To build the application", Option3 = "To run the application", Option4 = "To publish the application", Answer = 1 },
            new Question { QId = 40, QnInWords = "How do you create a unit test in a .NET Core application?", Option1 = "Using the xUnit testing framework", Option2 = "Using the NUnit testing framework", Option3 = "Using the MSTest testing framework", Option4 = "All of the above", Answer = 4 }
        };
        }

    }
}
