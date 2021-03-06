# Eau Claire's Hair Salon

#### An Application that allow the salon's owner to add, edit or delete their stylists and clients to the salon 
#### Database Basic with C# 
#### By Kate Kiatsiri
---

## Technologies Used

- C#
- .Net 5
- ASP.NET Core
- Entity Framework Core
- MySql and MySql workbench
- Razor View Engine
- LINQ
- Lambda

## Description

This is an independent project week 10th at Epicodus creating the web application that allow the user to create and modify the list of their hair stylists and each of their clients. This project is created to practice with one to many relationship in ASP.NET Core MVC, Entity Core Framework, and MySql.

User Stories
As the salon owner, I need to be able to see a list of all stylists.
As the salon owner, I need to be able to select a stylist, see their details, and see a list of all clients that belong to that stylist.
As the salon owner, I need to add new stylists to our system when they are hired.
As the salon owner, I need to be able to add new clients to a specific stylist. I should not be able to add a client if no stylists have been added.

## Setup & Technology requirements 

* Text Editor such as <a href="https://code.visualstudio.com"> VS Code </a>
* Install <a href="https://dotnet.microsoft.com/en-us/download/dotnet/5.0"> .NET 5</a>
* Set up <a href="https://dev.mysql.com/downloads/file/?id=484391"> MySql Workbench </a>

## Database Setup

* _Download MySQL and MySQL Workbench to set up a local database_

* _Once installed, open MyMql Workbench and open a local server_

* _In the Navigator, select the Administration tab and then select Data Import/Restore_

* _Under Import Options, select Import From Self-Contained File, and then select the "kate_kiatsiri.sql" file which can be found in HairSalon.Solution_

* _In the Default Schema to be Imported To option, select New_

* _Enter a name for your database and select OK_

* _Click Start Import to begin database import_

## Installation Instructions

![Alt text](HairSalon/wwwroot/img/sql.jpg?raw=true "Title")

* Clone github repository to local machine in desired directory <a href="https://github.com/keidsiri/HairSalon"> Click here! </a>
*  In the terminal navigate to HairSalon.Solutions/HairSalon directory and run the following commands:
    * `$ dotnet add package Microsoft.EntityFrameworkCore -v 5.0.0`
    * `$ dotnet add package Pomelo.EntityFrameworkCore.MySql -v 5.0.0-alpha.2`
    * `$ dotnet add package Microsoft.EntityFrameworkCore.Proxies -v 5.0.0`

*  Create .gitignore file in root directory add `*/appsettings.json` `*/bin/` `*/obj/` to the file
* Create file appsettings.json in HairSalon directory and add the following code to the appsettings.json file
```{
    "ConnectionStrings": {
        "DefaultConnection": "Server=localhost;Port=3306;database=kate_kiatsiri;uid=root;pwd=[YOUR-PASSWORD-HERE];"
    }
}
```
* Replace your database name and password with your unique MySql password.
5. In the terminal open the directory,navigate to directory `HairSalon.Solution/HairSalon` run the command `$ dotnet restore` to create obj and bin directories
6. Run the command `$ dotnet build` to build and compile the project
7. To run the console application run the command `dotnet run` to see the web application.



## Known Bugs

No known issues

## License

#### [MIT](https://opensource.org/licenses/MIT) Copyright (c) _2021_ _Kate Kiatsiri_

## Contact Information

_If you have any questions please feel free to [Contact me](mailto:keidsiri@gmail.com)_

[![GitHub Badge](https://img.shields.io/badge/GitHub-100000?style=for-the-badge&logo=github&logoColor=white)](https://github.com/keidsiri)
[![LinkedIn Badge](https://img.shields.io/badge/LinkedIn-0077B5?style=for-the-badge&logo=linkedin&logoColor=white)](https://www.linkedin.com/in/kiatsiri)
