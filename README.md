This is based on ASP.NET Core Crash Course - C# App in One Hour
https://www.youtube.com/watch?v=BfEjDD8mWYg&t=684s

It teaches you the basics of ASP.NET Core in one hour. It is a great starting point for beginners.

This tutorial will show you how to :
-Use the MVC (Model View Controller) design pattern.
-Configure database tables using the Entity framework.
-Setup of classes as models. Customize Razor forms.
-Create methods inside a controller.
-Style an ASP.NET page with CSS.
-Use Bootstrap classes.
-Create a search function to filter database results.

✏️ Course developed by Shad Sluiter. Check out his YouTube channel:    / shadsluiter 

## Getting Started

### Prerequisites

- [.NET 8 SDK](https://dotnet.microsoft.com/download/dotnet/8.0)
- [Visual Studio 2022](https://visualstudio.microsoft.com/vs/)

### Installation
1. cd task-manager
2. Restore the dependencies:
`dotnet restore`


### Database Setup

1. Update the connection string in appsettings.json to point to your database.
2. Apply the migrations to create the database schema:


`dotnet ef database update`


### Running the Application

1. Build the project:

2. Run the project:

`dotnet run`


### Usage

- Navigate to https://localhost:5001 in your browser.
- Use the navigation menu to access the tasks and jokes sections.
- Create, edit, and delete tasks and jokes as needed.

## Project Structure

- Controllers/: Contains the ASP.NET Core MVC controllers.
- Data/: Contains the Entity Framework Core DbContext and migrations.
- Models/: Contains the data models.
- Views/: Contains the Razor views for the MVC application.
- wwwroot/: Contains static files such as CSS, JavaScript, and images.

## Contributing

Contributions are welcome! Please open an issue or submit a pull request.

## License

This project is licensed under the MIT License. See the [LICENSE](LICENSE) file for details.

## Acknowledgements

- [Blazor](https://dotnet.microsoft.com/apps/aspnet/web-apps/blazor)
- [Entity Framework Core](https://docs.microsoft.com/en-us/ef/core/)
- [ASP.NET Core](https://docs.microsoft.com/en-us/aspnet/core/))

├── Controllers/   → MVC controllers (handles routes & logic)  
├── Data/         → Entity Framework DbContext & migrations  
├── Models/       → Data models (C# classes)  
├── Views/        → Razor views for frontend rendering  
└── wwwroot/      → Static assets (CSS, JS, images)  
