# Bookify

Clean Architecture application
* Rich domain models.
* CQRS pattern
* Authentication using an external identity provider (Key Cloak)
* Example of minimal API (Bookify.API.BookingsEndpoints)
* Some Unit tests + Architecture Tests
* and more..

### How to run this application
* Have Docker installed and .Net 7+
* If the first time running, open Program.cs and uncomment "app.SeedData();" to have some initial data for use. Remember to comment it back to avoid database growth.
* There's a docker-compose file with everything already set up to run (API, Database, Key cloak).

This project is a result of the learnings from Milan Jovanović Pragmatic Clean Architecture Course.
