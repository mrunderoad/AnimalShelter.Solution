# _Animal Shelter API_
#### _By: **Isaac Overstreet**_

## Short Description 
_This API application is made to add cats and dogs to an api using C#. This app is strictly meant to demonstrate knowledge of making an api using postman and sql._

## Further Exploration Documentation
_Further exploration on this project was using Swagger and Versioning. Swagger is an api endpoint documentation tool, when this application is running you may open a browser and type in `localhost:5000/swagger` and see all available endpoints. Versioning is to have many versions of an api controller. By using versioning you may have different features for the different versions of controllers._

## Technologies Used

* _C#_
* _Postman_
* _Swagger_
* _SQL_
* _

## API Endpoints 

| Usage | METHOD | URL | Params |
| :---  | :---:  | :--- | ---: |
| See all Cats | GET | `localhost:5000/api/cats` | _NA_ |
| See all Dogs | GET | `localhost:5000/api/dogs` | _NA_ |
| See a specific Cat | GET | `localhost:5000/api/cats/id` | _ID_ |
| See a specific Dog | GET | `localhost:5000/api/dogs/id` | _ID_ |
| Create a Cat | POST | `localhost:5000/api/cats` | _name, breed, age, gender_ |
| Create a Dog | POST | `localhost:5000/api/dogs` | _name, breed, age, gender_ |
| Update a Cat | PUT | `localhost:5000/api/cats` | _name, breed, age, gender_ |
| Update a Dog | PUT | `localhost:5000/api/dogs` | _name, breed, age, gender_ |
| Delete a Cat | DELETE | `localhost:5000/api/cats/id` | _ID_ |
| Delete a Dog | DELETE | `localhost:5000/api/dogs/id` | _ID_ |
| Search for Cat by name/breed/minAge/gender | GET | `localhost:5000/api/cats?[name/breed/minAge/gender]=[name/breed/minAge/gender Here]` | _name, breed, minAge, gender_ |
| Search for Dog by name/breed/age/gender | GET | `localhost:5000/api/dogs?[name/breed/minAge/gender]=[name/breed/minAge/gender Here]` | _name, breed, minAge, gender_ |
##### Notes for endpoints: For Searching, do NOT include the []'s around the parameters. You may also string them together with and & symbol: `localhost:5000/api/cats?name=[name]&breed=[breed]`. Also, minAge searches for any results with ages over your input. 

### Using postman for this project
* 

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


## Known Bugs: 
 
 _None so far._

 ## License - [MIT](https://opensource.org/licenses/MIT)

 Copyright (c) _2022 Isaac Overstreet._