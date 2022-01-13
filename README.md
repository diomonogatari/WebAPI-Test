Web API technical test
Technologies
For this test, I used.NET Core 3.x, Docker and SQL as a database.

Tasks
Task 1
Write a RESTful API for creating, updating and retrieving customer information. A customer consists of the following fields:
First name;
Surname;
E-mail address;
Password.
The API should satisfy the following requirements:
1. The API should support create, update and retrieval operations for customer information via different routes;
2. The customer data should be persisted in a database (you can choose which database engine);
3. The API should be unit tested;
4. The API should be well structured.
Task 2
This task involves building and running your application.
1. Write a script that can be used to build your API and package it in a container;
2. Create a docker-compose.yml file that will run your application as well as a valid database for it to use;
3. Document how the API can be run locally, using Docker, along with some sample web requests. You might do this via a
simple integration test, or via usage instructions. The final part of this task should illustrate your API running locally with its database and should be explicit enough for anyone else to follow the instructions and see the application working.