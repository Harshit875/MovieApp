# MovieApp

I have used repository pattern with 3 tier architecture while designing the application. I have created separate api layer, business layer, data layer. I have followed SOLID Design principles and created loosely coupled services with separate interface and classes for every domain. I have also used dependecy injection to inject services in the project. For ORM(Object relational mappting) I have used Entity framework core with code first approach. All the scripts generated are there in the migration folder in migration files. For mapping entities and DTO I have used Automapper package.


## API Documentation-

### Endpoints-

##### GET-

https://localhost:7008/api/Movies/GetAllMovies - To get all movies with actor and producer details

https://localhost:7008/api/Actors/GetAllActors  -To get all actors

https://localhost:7008/api/Producers/GetAllProducers - To get all producers

##### POST-

https://localhost:7008/api/Movies/CreateMovie - To create a movie with actors and producer

https://localhost:7008/api/Actors/CreateActor - To Create an actor

https://localhost:7008/api/Producers/CreateProducer - To create a Producer


#### PUT-

https://localhost:7008/api/Movies/UpdateMovie/id - To update a movie


### Response JSON schema-

#### api/Actors/GetAllActors


[{
    "actorId": 1,
    "actorName": "Matthew McConaughey",
    "bio": "Actor",
    "dateOfBirth": "1969-11-04T00:00:00",
    "sex": "Male"
  },
  {
    "actorId": 2,
    "actorName": "Jessica Chastain",
    "bio": "Actor",
    "dateOfBirth": "1977-03-24T00:00:00",
    "sex": "Female"
  },
  {
    "actorId": 3,
    "actorName": "Leonardo Dicaprio",
    "bio": "Actor",
    "dateOfBirth": "1977-11-04T00:00:00",
    "sex": "Male"
  }]
  
 -----------------------------------------------------------------------------------------------
 ####  api/Movies/GetAllMovies
 
 [
  {
    "movieId": 1,
    "title": "Interstellar",
    "plot": "When Earth becomes uninhabitable in the future, a farmer and ex-NASA pilot, Joseph Cooper, is tasked to pilot a spacecraft, along with a team of researchers, to find a new planet for humans.",
    "releaseDate": "2014-11-07T00:00:00",
    "producerId": 1,
    "producer": {
      "producerId": 1,
      "producerName": "Christoper Nolan",
      "bio": "Producer",
      "dateOfBirth": "1970-07-30T00:00:00",
      "sex": "Male",
      "company": null
    },
    "actors": [
      {
        "actorId": 1,
        "actorName": "Matthew McConaughey",
        "bio": "Actor",
        "dateOfBirth": "1969-11-04T00:00:00",
        "sex": "Male"
      },
      {
        "actorId": 2,
        "actorName": "Jessica Chastain",
        "bio": "Actor",
        "dateOfBirth": "1977-03-24T00:00:00",
        "sex": "Female"
      }
    ],
    "poster": null
  },
  {
    "movieId": 2,
    "title": "Inception",
    "plot": "Cobb steals information from his targets by entering their dreams. Saito offers to wipe clean Cobb's criminal history as payment for performing an inception on his sick competitor's son.",
    "releaseDate": "2010-07-16T00:00:00",
    "producerId": 1,
    "producer": {
      "producerId": 1,
      "producerName": "Christoper Nolan",
      "bio": "Producer",
      "dateOfBirth": "1970-07-30T00:00:00",
      "sex": "Male",
      "company": null
    },
    "actors": [
      {
        "actorId": 3,
        "actorName": "Leonardo Dicaprio",
        "bio": "Actor",
        "dateOfBirth": "1977-11-04T00:00:00",
        "sex": "Male"
      },
      {
        "actorId": 4,
        "actorName": "Cilian Murphy",
        "bio": "Actor",
        "dateOfBirth": "1977-03-24T00:00:00",
        "sex": "Male"
      }
    ],
    "poster": null
  },
  ]
  #### api/Producers/GetAllProducers
  
  [
  {
    "producerId": 1,
    "producerName": "Christoper Nolan",
    "bio": "Producer",
    "dateOfBirth": "1970-07-30T00:00:00",
    "sex": "Male",
    "company": null
  },
  {
    "producerId": 2,
    "producerName": "Denis Villeneuve",
    "bio": "producer",
    "dateOfBirth": "1967-10-03T11:30:55.943",
    "sex": "male",
    "company": null
  },
  {
    "producerId": 3,
    "producerName": "Deniss Villeneuve",
    "bio": "producer",
    "dateOfBirth": "1967-10-03T11:30:55.943",
    "sex": "male",
    "company": null
  }
  ]
  
 ### Request Schema Body
 
 #### api/Movies/CreateMovie
 
 {
  "title": "string",
  "plot": "string",
  "releaseDate": "2022-10-17T06:22:42.328Z",
  "producerId": 0,
  "actorIds": [
    0
  ]
}


####  api/Actors/CreateActor

{
  "actorName": "string",
  "bio": "string",
  "dateOfBirth": "2022-10-17T06:17:29.232Z",
  "sex": "string"
}

#### api/Producers/CreateProducer

{
  "producerName": "string",
  "bio": "string",
  "company": "string",
  "dateOfBirth": "2022-10-17T06:42:33.987Z",
  "sex": "string"
}

#### api/Movies/UpdateMovie/id
 {
  "title": "string",
  "plot": "string",
  "releaseDate": "2022-10-17T06:22:42.328Z",
  "producerId": 0,
  "actorIds": [
    0
  ]
}











