# Project Name

#### DESCRIPTION -

#### By Zuri Gallegos 👩🏾‍💻

## Technologies Used

* C#
* MS TEST
* .NET
* VScode


## Description: 
### description


## Setup/Installation Requirements ⚙️ 🖥️

* _You can clone this repository, you can do this by going to this link https://github.com/ZuriGa/PROJECTURL
* _follow the link above and click on the <>Code button then click on the copy button. Wherever you are storing your projects on your computer, use this git command: git clone url-of-remote-repo. A new folder should be created on your computer and you can navigate it now._
* _You can also fork this repository by clicking the "Fork" button in the remote repository._
* _Click "create new fork" and then select your account as the "Owner", after this you have your own copy of this repository to your GitHub Account._
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
* Tests can be found in Bakery.Tests directory. You can run test by navigating to the test directory and running `dotnet test`


## Known Bugs

* _Current bug won't let you go back to confirm order._


## License

MIT License

Copyright (c) 2024 Zuri Gallegos
