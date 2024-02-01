
Prerequisites
Ensure you have the following installed:

.NET SDK
Entity Framework Core Tools
Database Setup


Open appsettings.json and modify the connection string to match your SQL Server details.

"ConnectionStrings": {
  "DefaultConnection": "Server=localhost;Database=YourDatabaseName;User=YourUsername;Password=YourPassword;MultipleActiveResultSets=true;"
}


Run the Entity Framework migrations to create the database:

dotnet ef database update
Running the Application


Execute the following command to run the application:

dotnet run
Access the application through your browser at the specified port (default is http://localhost:5000).

Project Structure
Models: Contains the data model classes representing Employee and Department.

Data Context: EmployeeDbContext.cs manages interactions with the SQL Server database.

Controllers: EmployeeController.cs and DepartmentController.cs handle HTTP requests and CRUD operations.

Views: Razor views for rendering the user interface.

Additional Tips
Explore and customize controllers and views to meet specific business requirements.

Always back up your database before applying major changes.



Keep your dependencies up-to-date. Run the following command to check for outdated packages:

dotnet outdated
Packages Used
Microsoft.EntityFrameworkCore.SqlServer
Microsoft.EntityFrameworkCore.Design
Microsoft.EntityFrameworkCore.Tools
Microsoft.AspNetCore.Mvc
Microsoft.AspNetCore.Mvc.Razor.RuntimeCompilation (for development)


To install or update packages, use the following command:

dotnet add package PackageName
