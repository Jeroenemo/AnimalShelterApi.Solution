<br>
<p align="center">
  <u><big>|| <b>Animal Shelter API</b> ||</big></u>
</p>
<p align="center">
    <!-- Project Avatar/Logo -->
    <br>
    <a href="https://github.com/Jeroenemo">
        <img width="200" .circle src="https://avatars.githubusercontent.com/u/64109457?v=4">
    </a>
    <p align="center">
      ___________________________
    </p>
    <!-- GitHub Link -->
    <p align="center">
        <a href="https://github.com/Jeroenemo">
            <strong>Jeroenemo</strong>
        </a>
    </p>
    <!-- Project Shields -->
    <p align="center">
        <a href="https://github.com/Jeroenemo/AnimalShelterAPI.Solution/graphs/contributors">
            <img src="https://img.shields.io/github/contributors/Jeroenemo/AnimalShelterAPI.Solution.svg?style=plastic">
        </a>
        ¨
        <a href="https://github.com/Jeroenemo/AnimalShelterAPI.Solution/stargazers">
            <img src="https://img.shields.io/github/stars/Jeroenemo/AnimalShelterAPI.Solution.svg?color=yellow&style=plastic">
        </a>
        ¨
        <a href="https://github.com/Jeroenemo/AnimalShelterAPI.Solution/issues">
            <img src="https://img.shields.io/github/issues/Jeroenemo/AnimalShelterAPI.Solution?style=plastic">
        </a>
        ¨
        <a href="https://github.com/Jeroenemo/Best-ReadMe-Template/blob/master/LICENSE.txt">
            <img src="https://img.shields.io/badge/License-MIT-yellow.svg">
        </a>
        ¨
        <a href="https://linkedin.com/in/Jeroenemo">
            <img src="https://img.shields.io/badge/-LinkedIn-black.svg?style=plastic&logo=linkedin&colorB=2867B2">
        </a>
    </p>    
</p>

<p align="center">
  <small>Initiated April 2nd, 2021, Updated April 4th, 2021</small>
</p>

<!-- Project Links -->
<p align="center">
    <a href="https://github.com/Jeroenemo/AnimalShelterAPI.Solution"><big>Project Docs</big></a> ·
    <a href="https://github.com/Jeroenemo/AnimalShelterAPI.Solution/issues"><big>Report Bug</big></a> ·
    <a href="https://github.com/Jeroenemo/AnimalShelterAPI.Solution/issues"><big>Request Feature</big></a>
</p>

------------------------------


## 🌐 About the Project

### 📖 Description
An API that functions as a animal archive for an animal shelter. It utilizes RESTful principles, swagger documentation, version control, and the user is able to see the in-use version of the API when using Postman.

### 🦠 Known Bugs

* No full CRUD for species controller, yet. 

### 🛠 Built With
* [Visual Studio Code](https://code.visualstudio.com/)
* [C#](https://docs.microsoft.com/en-us/dotnet/csharp/)
* [ASP.NET Core MVC](https://docs.microsoft.com/en-us/aspnet/core/mvc/overview?view=aspnetcore-3.1)
* [MySQL](https://dev.mysql.com/)
* [Entity Framework Core 2.2.6](https://docs.microsoft.com/en-us/ef/core/)
* [Swagger - Swashbuckle 5.6.3](https://docs.microsoft.com/en-us/aspnet/core/tutorials/getting-started-with-swashbuckle?view=aspnetcore-5.0&tabs=visual-studio)
* [Postman](postman.com)

<!-- ### 🔍 Preview -->

------------------------------

## 🏁 Getting Started

### 📋 Prerequisites

#### Install .NET Core
* On macOS Mojave or later
  * [Click here](https://dotnet.microsoft.com/download/thank-you/dotnet-sdk-2.2.106-macos-x64-installer) to download the .NET Core SDK from Microsoft Corp for macOS.
* On Windows 10 x64 or later
  * [Click here](https://dotnet.microsoft.com/download/thank-you/dotnet-sdk-2.2.203-windows-x64-installer) to download the 64-bit .NET Core SDK from Microsoft Corp for Windows.

#### Install dotnet script
 Enter the command ``dotnet tool install -g dotnet-script`` in Terminal for macOS or PowerShell for Windows.

#### Install MySQL Workbench
 [Download and install the appropriate version of MySQL Workbench](https://dev.mysql.com/downloads/workbench/).

#### Install Postman
(Optional) [Download and install Postman](https://www.postman.com/downloads/).

#### Code Editor

  To view or edit the code, you will need an code editor or text editor. The popular open-source choices for an code editor are Atom and VisualStudio Code.

  1) Code Editor Download:
     * Option 1: [Atom](https://nodejs.org/en/)
     * Option 2: [VisualStudio Code](https://www.npmjs.com/)
  2) Click the download most applicable to your OS and system.
  3) Wait for download to complete, then install -- Windows will run the setup exe and macOS will drag and drop into applications.
  4) Optionally, create a [GitHub Account](https://github.com)

### ⚙️ Setup and Use

  #### Cloning

  1) Navigate to the [Animal Shelter API repository here](https://github.com/Jeroenemo/AnimalShelterAPI.Solution).
  2) Click 'Clone or download' to reveal the HTTPS url ending with .git and the 'Download ZIP' option.
  3) Open up your system Terminal or GitBash, navigate to your desktop with the command: `cd Desktop`, or whichever location suits you best.
  4) Clone the repository to your desktop: `$ git clone https://github.com/Jeroenemo/AnimalShelterAPI.Solution.git`
  5) Run the command `cd AnimalShelterAPI.Solution` to enter into the project directory.
  6) View or Edit:
      * Code Editor - Run the command `atom .` or `code .` to open the project in Atom or VisualStudio Code respectively for review and editing.
      * Text Editor - Open by double clicking on any of the files to open in a text editor.

  #### Download

  1) Navigate to the [Animal Shelter API repository here](https://github.com/Jeroenemo/AnimalShelterAPI.Solution).
  2) Click 'Clone or download' to reveal the HTTPS url ending with .git and the 'Download ZIP' option.
  3) Click 'Download ZIP' and unextract.
  4) Open by double clicking on any of the files to open in a text editor.

  #### AppSettings

  1) Create a new file in the AnimalShelterAPI.Solution/AnimalShelter directory named `appsettings.json`
  2) Add in the following code snippet to the new appsettings.json file:
  
  ```
{
    "Logging": {
        "LogLevel": {
        "Default": "Warning"
        }
    },
    "AllowedHosts": "*",
    "ConnectionStrings": {
        "DefaultConnection": "Server=localhost;Port=3306;database=animal_shelter;uid=root;pwd=YourPassword;"
    }
}
  ```
  3) Change the server, port, and user id as necessary. Replace 'YourPassword' with relevant MySQL password (set at installation of MySQL).

  #### Database
  1) Navigate to AnimalShelterAPI.Solution/AnimalShelter directory using the MacOS Terminal or Windows Powershell (e.g. `cd Desktop/AnimalShelterAPI.Solution/AnimalShelter`).
  2) Run the command `dotnet ef database update` to generate the database through Entity Framework Core.
  3) (Optional) To update the database with any changes to the code, run the command `dotnet ef migrations add <MigrationsName>` which will use Entity Framework Core's code-first principle to generate a database update. After, run the previous command `dotnet ef database update` to update the database.

  #### Launch the API
  1) Navigate to AnimalShelterAPI.Solution/AnimalShelter directory using the MacOS Terminal or Windows Powershell (e.g. `cd Desktop/AnimalShelterAPI.Solution/AnimalShelter`).
  2) Run the command `dotnet run` to have access to the API in Postman or browser.

------------------------------

## 🛰️ API Documentation
Explore the API endpoints in Postman or a browser. You will not be able to utilize authentication in a browser.

### Using Swagger Documentation 
To explore the Animal Shelter API with Swashbuckle, launch the project using `dotnet run` with the Terminal or Powershell, and input the following URL into your browser: `http://localhost:5000/`

#### Example Query
```
https://localhost:5001/api/Animals?name=attila
```

To use default, _don't include_ `name`, `age`, or `gender`.

..........................................................................................

### Endpoints
Base URL: `https://localhost:5000`

#### HTTP Request Structure
For Animals:
```
GET /api/Animals
POST /api/Animals
GET /api/Animals/{id}
PUT /api/Animals/{id}
DELETE /api/Animals/{id}
```
For Species:
```
GET /api/Species
POST /api/Species
GET /api/Species/{type}
```

#### Example Query
```
https://localhost:5000/api/Species/donkey
```

#### Sample JSON Response
```

  {
    "speciesId": 3,
    "type": "Donkey",
    "animals": [
      {
        "animalId": 5,
        "name": "Petunia",
        "age": 12,
        "gender": "Female",
        "admitted": "2021-04-04T12:31:57",
        "speciesId": 3
      }
    ]
  }

```

..........................................................................................

### Animals
Access information on animals in the shelter.

#### HTTP Request
```
GET /api/animal
POST /api/animal
GET /api/animal/{id}
PUT /api/animal/{id}
DELETE /api/animal/{id}
```

#### Path Parameters
| Parameter | Type | Default | Required | Description |
| :---: | :---: | :---: | :---: | --- |
| name | string | none | false | Return matches by name.
| age | integer | none | false | Return any animal with specific age. |
| gender | string | none | false | Return any animal with specific gender. |

#### Example Query
```
https://localhost:5000/api/animal/?age=3&gender=male
```

#### Sample JSON Response
```
{
    "animalId": 1,
    "name": "Attila",
    "age": 3,
    "gender": "Male",
    "admitted": "2021-04-04T12:31:57",
    "speciesId": 1
  }
```

..........................................................................................

### Species
Access animals associated with a Species.

#### HTTP Request
```
GET /api/Species
POST /api/Species
GET /api/Species/{type}
PUT /api/beverage/{type}
DELETE /api/beverage/{type}
```

#### Path Parameters
| Parameter | Type | Default | Required | Description |
| :---: | :---: | :---: | :---: | --- |
| type | string | none | false | Return list of matches by species.


#### Example Query
```
https://localhost:5000/api/species/chicken
```

#### Sample JSON Response
```
[
  {
    "speciesId": 2,
    "type": "Chicken",
    "animals": [
      {
        "animalId": 3,
        "name": "Maple",
        "age": 1,
        "gender": "Female",
        "admitted": "2021-04-04T12:31:57",
        "speciesId": 2
      },
      {
        "animalId": 4,
        "name": "Beatrix",
        "age": 2,
        "gender": "Female",
        "admitted": "2021-04-04T12:31:57",
        "speciesId": 2
      }
    ]
  }
]
```

------------------------------

### 🤝 Contributors

| Author | GitHub | Email |
|--------|:------:|:-----:|
| [Jeroen van Seeters](https://linkedin.com/in/jeroenvanseeters) | [Jeroenemo](https://github.com/jeroenemo) |  [vanseetersjeroen@gmail.com](mailto:vanseetersjeroen@gmail.com) |

------------------------------

### ✉️ Contact and Support

If you have any feedback or concerns, please contact one of the contributors.

<p>
    <a href="https://github.com/LunsfordSpace/CoffeeTrackerAPI.Solution-API-ReadMe-Example/issues">Report Bug</a> ·
    <a href="https://github.com/LunsfordSpace/CoffeeTrackerAPI.Solution-API-ReadMe-Example/issues">Request Feature</a>
</p>

------------------------------

### ⚖️ License

This project is licensed under the [MIT License](https://opensource.org/licenses/MIT). Copyright (C) 2021 Jeroen van Seeters. All Rights Reserved.

```
MIT License

Copyright (c) 2021 Jeroen van Seeters.

Permission is hereby granted, free of charge, to any person obtaining a copy
of this software and associated documentation files (the "Software"), to deal
in the Software without restriction, including without limitation the rights
to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
copies of the Software, and to permit persons to whom the Software is
furnished to do so, subject to the following conditions:

The above copyright notice and this permission notice shall be included in all
copies or substantial portions of the Software.

THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE
SOFTWARE.
```

------------------------------

### 🌟 Acknowledgments

#### [Epicodus](https://www.epicodus.com/)
>"A school for tech careers... to help people learn the skills they need to get great jobs."

#### [The Internet](https://webfoundation.org/)
> "...the first thing that humanity has built that humanity doesn't understand..."
> - Eric Schmidt, Google (Alphabet Inc.)

------------------------------

<center><a href="#">Return to Top</a></center>