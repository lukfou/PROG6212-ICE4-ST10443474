# ICE Task 4 – ASP.NET Core RESTful API

## Overview
This project was created for ICE Task 4 and demonstrates how to build and test a RESTful API using ASP.NET Core Web API.
The API provides CRUD functionality for managing movie records. Entity Framework Core is used to communicate with a SQL Server LocalDB database, while Postman is used to test the API endpoints.

## Technologies Used
- C#
- ASP.NET Core Web API
- .NET 8
- Entity Framework Core
- SQL Server LocalDB
- Swagger / OpenAPI
- Postman
- Visual Studio

## Project Structure
```text
ICE4RestApi
│
├── Controllers
│   └── MoviesController.cs
│
├── Data
│   └── MovieContext.cs
│
├── Models
│   └── Movie.cs
│
├── Migrations
│   └── Database migration files
│
├── Properties
│   └── launchSettings.json
│
├── appsettings.json
├── Program.cs
└── ICE4RestApi.csproj
Features

The API allows users to:

Retrieve all movies
Retrieve a specific movie
Create a new movie
Update an existing movie
Delete a movie
Validate movie information
Store movie information in a SQL Server LocalDB database
Movie Model

Each movie contains the following properties:

Property	Description
Id	Unique movie identifier
Title	Movie title
Genre	Movie genre
Year	Movie release year
Rating	Movie rating from 0–10
API Endpoints
Method	Endpoint	Description
GET	/api/movies	Retrieves all movies
GET	/api/movies/{id}	Retrieves a specific movie
POST	/api/movies	Creates a new movie
PUT	/api/movies/{id}	Updates an existing movie
DELETE	/api/movies/{id}	Deletes a movie
Example Movie

A movie can be created using the following JSON:

{
    "title": "Inception",
    "genre": "Science Fiction",
    "year": 2010,
    "rating": 8.8
}
Database
The project uses SQL Server LocalDB with a database named: ICE4MovieDB

Entity Framework Core is responsible for creating and communicating with the database.

The database can be created using the following Package Manager Console commands:
Add-Migration InitialCreate
Update-Database

Running the Project
1. Open the Project - Open the ICE4RestApi project in Visual Studio.
2. Restore Dependencies -Visual Studio should automatically restore the required NuGet packages.
The main packages used are:
Microsoft.EntityFrameworkCore.SqlServer
Microsoft.EntityFrameworkCore.Tools

3. Create the Database
Open: Tools → NuGet Package Manager → Package Manager Console
Run: Add-Migration InitialCreate
Then run: Update-Database
4. Run the API -Run the project using Visual Studio.

The API runs locally using HTTPS. The port may vary depending on the Visual Studio configuration.
For example: https://localhost:7089
The main API endpoint is: https://localhost:7089/api/movies

Testing with Postman
The REST API was tested using Postman. A collection named ICE Task 4 - REST API was created to organise the API requests.

The following requests were used:

1. GET All Movies
GET https://localhost:7089/api/movies
Expected response: 200 OK

2. POST Create Movie
POST https://localhost:7089/api/movies
Request body:
{
    "title": "Inception",
    "genre": "Science Fiction",
    "year": 2010,
    "rating": 8.8
}
Expected response:
201 Created

3. GET Movie By ID
GET https://localhost:7089/api/movies/1
Expected response: 200 OK

4. PUT Update Movie
PUT https://localhost:7089/api/movies/1
Request body:
{
    "id": 1,
    "title": "Inception",
    "genre": "Science Fiction",
    "year": 2010,
    "rating": 9.0
}
Expected response: 204 No Content

5. GET Updated Movie
GET https://localhost:7089/api/movies/1
The response should show that the movie's rating has been changed to 9.0.
Expected response: 200 OK

6. DELETE Movie
DELETE https://localhost:7089/api/movies/1
Expected response: 204 No Content

7. GET After Delete
GET https://localhost:7089/api/movies
Expected response: 200 OK
The response should contain an empty array: []
This confirms that the movie was successfully deleted.

Postman Collection
The Postman collection contains the following requests:
ICE Task 4 - REST API
│
├── 01 - GET All Movies
├── 02 - POST Create Movie
├── 03 - GET Movie By ID
├── 04 - PUT Update Movie
├── 05 - GET Updated Movie
├── 06 - DELETE Movie
└── 07 - GET After Delete
Learning Outcomes

This project shows an understanding of:
RESTful API principles
HTTP methods
CRUD operations
ASP.NET Core Web API
Controllers and routing
Entity Framework Core
SQL Server LocalDB
Database migrations
JSON requests and responses
HTTP status codes
API testing using Postman
