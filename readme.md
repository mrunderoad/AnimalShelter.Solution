# _Animal Shelter API_
#### _By: **Isaac Overstreet**_

## Short Description 
_This API application is made to add cats and dogs to an api using C#. This app is strictly meant to demonstrate knowledge of making an api using postman and sql._

## Further Exploration Documentation
_Further exploration on this project was using Swagger and Versioning. Swagger is an api endpoint documentation tool, when this application is running you may open a browser and type in `localhost:5001/swagger` and see all available endpoints. Versioning is to have many versions of an api controller. By using versioning you may have different features for the different versions of controllers._

## Technologies Used

* _C#_
* _Postman_
* _Swagger_
* _SQL_
* _Versioning_
* _.NET_
* _Entity_

## API Endpoints 

| Usage | METHOD | URL | Params |
| :---  | :---:  | :--- | ---: |
| See all Cats | GET | `localhost:5000/api/cats` | _NA_ |
| See all Dogs | GET | `localhost:5000/api/dogs` | _NA_ |
| See all Monkeys | GET | `localhost:5000/api/monkeys` | _NA_ |
| See a specific Cat | GET | `localhost:5000/api/cats/id` | _ID_ |
| See a specific Dog | GET | `localhost:5000/api/dogs/id` | _ID_ |
| See a specific Monkey | GET | `localhost:5000/api/monkeys/id` | _ID_ |
| Create a Cat | POST | `localhost:5000/api/cats` | _name, breed, age, gender_ |
| Create a Dog | POST | `localhost:5000/api/dogs` | _name, breed, age, gender_ |
| Create a Monkey| POST | `localhost:5000/api/monkeys` | _name, age, gender_ |
| Update a Cat | PUT | `localhost:5000/api/cats/id` | _name, breed, age, gender, ID_ |
| Update a Dog | PUT | `localhost:5000/api/dogs/id` | _name, breed, age, gender, ID_ |
| Update a Monkey | PUT | `localhost:5000/api/monkeys/id` | _name, age, gender, ID_ |
| Delete a Cat | DELETE | `localhost:5000/api/cats/id` | _ID_ |
| Delete a Dog | DELETE | `localhost:5000/api/dogs/id` | _ID_ |
| Delete a Monkey | DELETE | `localhost:5000/api/monkeys/id` | _ID_ |
| Search for Cat by name/breed/minAge/gender | GET | `localhost:5000/api/cats?[name/breed/minAge/gender]=[name/breed/minAge/gender Here]` | _name, breed, minAge, gender_ |
| Search for Dog by name/breed/age/gender | GET | `localhost:5000/api/dogs?[name/breed/minAge/gender]=[name/breed/minAge/gender Here]` | _name, breed, minAge, gender_ |
| Search for Monkey by name/age/gender | GET | `localhost:5000/api/monkeys?[name/minAge/gender]=[name/minAge/gender Here]` | _name, minAge, gender_ |
| V2 Controller Route | GET | `localhost:5000/api/2.0/dogs` | Add `2.0` to the endpoint like: `api/2.0/[cats/dogs/monkeys]` to use version 2 |
##### Notes for endpoints: For Searching, do NOT include the []'s around the parameters. You may also string them together with and & symbol. ex: `localhost:5000/api/cats?name=[name]&breed=[breed]`. Also, minAge searches for any results with ages over your input. For Versioning, the example provided is only for a GET route, but versioning covers all the routes available.

### Using postman for this project
_To use Postman for this project, first:_
* _Make sure you have Postman installed on your computer_
* _Make sure the project is running in vsCode._
* _Put the endpoints in the input area next to the dropdown with the route options(GET, POST, PUT, DELETE)_
* _Make sure you are calling the right route from the list above._

## Responses 
_Expect responses for Cats/Dogs to look like this:_
```
{
  "id": integer,
  "name": string,
  "breed": string,
  "age": integer,
  "gender": string
}
```
## Setup / Installation Requirements
* _Make sure you have Postman and MySQL installed._
* _Clone this repository from ``_
* _Navigate into the `Shelter` directory using `cd Shelter`_
* _In the `Shelter` directory, create a new file called `appsettings.json`_
* _Inside `appsettings.json` place this code with your chosen database name and username and password for mysql._
``` C#
{
  "Logging": {
    "LogLevel": {
      "Default": "Warning",
      "System": "Information",
      "Microsoft": "Information"
    }
  },
  "AllowedHosts": "*",
  "ConnectionStrings": {
    "DefaultConnection": "Server=localhost;Port=3306;database=DATABASENAME;uid=USERNAME;pwd=PASSWORD;"
  }
}
```
* _Inside the `Shelter` directory, run `dotnet ef database update` to create the database based off the migrations included in this repo._
* _Run `dotnet restore` to restore the obj and bin folders._
* _Run `dotnet build` to build the project._
* _Run `dotnet run` to have the local host live and able to check the api in Postman._
* _To check routes with swagger, open a new page in your browser and enter this as the url: `https://localhost:5001/swagger`_


## Known Bugs: 
 
 _None so far._

 ## License - [MIT](https://opensource.org/licenses/MIT)

 Copyright (c) _2022 Isaac Overstreet._