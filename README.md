# Project Name

#### an app for a University Registrar to keep track of students and courses.

#### By Brianca Knight, Chris Quattrocchi & Zuri Gallegos 👩🏾‍💻

## Technologies Used

* C#
* HTML
* CSS
* Bootstrap
* .NET
* VScode
* Entity Framework Core 6.0
* Pomelo.EntityFrameworkCore.MySql


## Description: 
A MVC web application for a University Registrar to keep track of students, courses and departments.
* Users can see a list of all students enrolled and add new students.
* Users can see a list of all the courses and add new courses by course name and course number.
* Users can assign students to courses. A course can have many students and a student can take many courses at the same time.
* Users can create new departments and students can be assigned to a department.


## Setup/Installation Requirements ⚙️ 🖥️

## Setup/Installation Requirements ⚙️ 💻

* _You can clone this repository, you can do this by going to this link https://github.com/ZuriGa/UniversityRegistrar.Solution.git

* _follow the link above and click on the <>Code button then click on the copy button. Wherever you are storing your projects on your computer, use this git command: git clone url-of-remote-repo. A new folder should be created on your computer and you can navigate it now._

* _You can also fork this repository by clicking the "Fork" button in the remote repository._

* _Click "create new fork" and then select your account as the "Owner", after this you have your own copy of this repository to your GitHub Account._

### Setting up your database 
*  Install MySQL Server (if you haven't already)
* Connect to MySQL Server - <br />
Use a MySQL client or command-line tool to connect. <br /> 

      For example: mysql -u[YOUR-USERNAME] -p[YOUR-PASSWORD];

* Create a new database - <br />

      CREATE DATABASE [yourdbname];
    Replace yourdbname with your preferred database name.

* Creating Tables in a Database - <br />
Next create a table in our database

      CREATE TABLE Stylists (Name VARCHAR (255), PhoneNumber string, HireDate DATETIME);
    This creates a table called Stylist with columns for name, phone number, and hire. Each column name has a datatype appended to it. Create one for Clients as well.

### Installation
* Open your terminal (e.g., Terminal or GitBash) and navigate to this project's production directory called "PROJECT NAME"

* once is clone create your .gitignore file by running `touch .gitignore`. Add bin and obj to your file.

* Create your `appsettings.json` file within the projects production directory to protect the sensitive data within our database connection string by adding it to our `.gitignore`

* Add your appsettings.json with the following contents, replacing the following values with your own:

      [YOUR-USER-HERE] with your username
      [YOUR-PASSWORD-HERE] with your password
      [YOUR-DB-NAME] with the name of your database


      ProjectName.Solution/ProjectName/appsettings.json
        {
          "ConnectionStrings": {
          "DefaultConnection": "Server=localhost;Port=3306;database=[YOUR-DB-NAME];uid=[YOUR-USER-HERE];pwd=[YOUR-PASSWORD-HERE];"
        }
      }
* In the command line, run the command `dotnet run` to compile and execute the console application. Since this is a console application, you'll interact with it through text commands in your terminal.

* Optionally, you can run `dotnet build` to compile this console app without running it.

* Tests can be found in ProjectName.Tests directory. You can run test by navigating to the test directory and running `dotnet test`



## Known Bugs

* _Current bug won't let you go back to confirm order._


## License

MIT License

Copyright (c) 2024 Zuri Gallegos


