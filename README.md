# Animal Shelter API

#### An API for use by an Animal Shelter to keep track of what i'm calling "Residents" of the shelter. The API comes in two versions. Version 1 is the legacy version and can handle basic CRUD functionality but nothing more. Version 2 handles CRUD as well as queryable GET functionality as well as simple pagination.

## Authored by:
Hans Ellis February 2023

***

## Table of Contents
1. [Technologies Used](#technologies-used)
2. [Setup Instructions](#installation-and-setup)
3. [API Documentation](#api-documentation)
4. [Known Bugs](#known-bugs)
5. [License Information](#license)


## Technologies Used

- C#
- .NET
- Bootstrap
- Git
- Github
- Markdown
- MySQL Workbench
- Razor
- Identity
- Notepad
- VS Code


## Installation And Setup

### Installation Steps
1. To begin, the user must install a compatible version of .NET 6. An acceptable version can be found [here](https://dotnet.microsoft.com/en-us/download/dotnet/6.0).
2. Follow the prompts throught the installation of the program. Using default settings as they originally appear in the setup.
3. In the terminal (ex: Git Bash) install dotnet-script by runing the following command
```bash
$ dotnet tool install -g dotnet-script
```
4. Configure your local environment to use this. Details for which can be found [here](https://www.learnhowtoprogram.com/c-and-net/getting-started-with-c/installing-dotnet-script).
5. Then, install MySQL. Follow further detailed instructions on accomplishing that [here](https://www.learnhowtoprogram.com/c-and-net/getting-started-with-c/installing-and-configuring-mysql).

### Repository Setup
1. Clone this repository.
2. Open your shell (e.g. Terminal or GitBash) and navigate to this project's production directory called "AnimalShelterApi.Solution".
3. Within the AnimalShelterApi.Solution/AnimalShelterApi folder, create a file titled appsettings.json
4. Open your file editor and navigate to appsettings.json
5. In the appsettings.json file, paste the following code:
```javascript
{
  "ConnectionStrings": {
      "DefaultConnection": "Server=localhost;Port=3306;database=animal_shelter_api;uid=[uid];pwd=[pwd];"
  }
}
```
6. Replace [uid] and [pwd] with your created SQL username and password respectively (including the braces).

### Create a local schema
1. With appsettings.json set up, in your terminal navigate to the root directory of your project.
2. Type ```ef database update```
3. This will create a schema on your machine with the seed data inserted for you

### Execute the Program
1. Open the terminal and navigate to the production directory titled "AnimalShelterApi.Solution."
2. Run `dotnet run` in the command line to run the program.

### Access the API
You may use whatever API viewer you prefer. The API is set up to work in Swagger. Please refer to the [documentation](#api-documentation) for further instructions.


## API Documentation

### Endpoints
<br>

---
<br>

```GET/api/v2/residents```

#### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| name | string | Filters residents by name. |
| species | string | Filters residents by species. |
| sex | string | Filters residents by sex. |
| chipped | boolean | Filters residents by whether they are chipped. |
| admissionDate | date | Filters residents by admission date. |
| pageNumber | int | The page number of the results to retrieve. Default is 1. |
| pageSize | int | The number of results to retrieve per page. Default is 5. |

#### Responses

- 200: Returns a list of residents that match the filter criteria.
- 404: Not found.
<br>
<br>
---     
<br>

```GET /api/v2/residents/{id}```

#### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| id | int | The id of the resident to retrieve. |

#### Responses

- 200: Returns the resident with the specified id.
- 204: No content.
- 404: Not found.
<br>
<br>
---
<br>

```POST /api/v2/residents```

#### Parameters


| Name | Type | Required? |
| ---- | ---- | ----------- |
| name | string | Yes. Max characters (20) |
| species | string | Yes |
| sex | string | Yes |
| chipped | boolean | No |
| notes | string | No

#### Responses

- 201: Returns the newly created resident object.
- 404: Not found.
<br>
<br>
---
<br>

```PUT /api/v2/residents/{id}```

#### Parameters

| Name | Type |
| ---- | ---- |
| name | string |
| species | string |
| sex | string |
| chipped | boolean |
| admissionDate | date |
| notes | string |

Note: All parameters must be entered and match existing results, only change the parameter you wish to change.

#### Responses

- 204: No content.
- 400: Bad request.
- 404: Not found.
<br>
<br>
---
<br>

```DELETE /api/v2/residents/{id}```
#### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| id | int | The id of the resident to delete. |

#### Responses

- 204: No content.
- 404: Not found.
<br>
<br>
---
<br>

## Known Bugs
- None at this time.



## License
*Hans Ellis, January 2023. Available for distribution, modification, inspection, and application under [GPLv3 License](https://www.gnu.org/licenses/gpl-3.0.en.html)*

This application makes previous work from the Epicodus staff as a reference for learning material. It has been used with permission of the staff.