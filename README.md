# Bookify

Clean Architecture application
* Rich domain models.
* CQRS pattern
* Authentication using an external identity provider (Key Cloak)
* Authorization implementing Role-based, Permission-based, and Resource-based authorization
* Example of minimal API (Bookify.API.BookingsEndpoints)
* Domain and Application Layers Unit Testing
* Integration Testing (using Docker containers)
* Functional Testing (In Progress...)
* Architecture Testing (using NetArchTest)
* Structured Logging with Serilog and Seq
* Distributed Caching with Redis
* Health Checks in Clean Architecture (see {{baseUrl/health}} to see the status for the database, redis and keycloak services)
* API Versioning
  
### How to run this application
* Have Docker installed and .Net 7+
* If the first time running, open Program.cs and uncomment "app.SeedData();" to have some initial data for use. Remember to comment it back to avoid database growth.
* There's a docker-compose file with everything already set up to run (API, Database (Postgres), Key cloak, Seq, and Redis).

#### How to create a Database Migration
* Set the startup project as **Bookify.API**, open the Package Manager Console, and select **src/Bookify.Infrastructure**
* Add-Migration **Migration_Name**
* For this project, using DEVELOPMENT, it will apply automatically (see **Program.cs**) the migration when you run the API

This project is a result of the learnings from Milan Jovanović Pragmatic Clean Architecture Course.
