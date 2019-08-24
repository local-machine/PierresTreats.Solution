# Project

### By Jessica Munoz

#### _A web application to record a bakery's treats and their respective flavors. - August 16th, 2019_

---

## Description

Pierre's Bakery has many treats of various flavors for resale. This website helps document them with a many to many relational database that impliments user authentication.

## Technologies Used

- C#
- .NET
- MSTesting
- EntityFrameworkCore
- MySQL
- MySQLWorkBench
- Identity

## Installation

- Install .NET locally if it isn't already installed
- Open the terminal, clone down this repository.
- Via the terminal, navigate to the project folder PierresTreats.Solution/PierresTreats
  - Enter the command: dotnet restore
  - Enter the command: dotnet ef database update
  - Enter the command: dotnet run
- Browse to http://localhost:5000/

## Specs

| Behaviors                              |                                                   Input                                                    |                Output                 |
| -------------------------------------- | :--------------------------------------------------------------------------------------------------------: | :-----------------------------------: |
| Users can register. | User clicks "Create an account", fills out the form, and clicks "Register". | New registration is created. |
| Users can login. | User clicks "Log in", fills out the form with previously created user info, and clicks "Log in". | User is logged on. |
| Users can logoff. | User clicks "Log off". | User is logged off. |
| Users can read all the flavors they created if logged on. | User clicks, "See all flavors". | All previously created flavors by that user are listed. |
| Users can read all the treats they created if logged on. | User clicks, "See all treats". | All previously created treats by that user are listed. |
| Users can create new flavors if logged on. | User clicks, "See all flavors", "Add a new flavor", fill out the form and clicks "Add". | New flavor is created. |
| Users can create new treats with a flavor if logged in. | User clicks, "See all treats", clicks "Add a new treat", fill out a form and clicks "Add treat". | New treat for that flavor is created. |
| Users can update a particular treat or flavor. | User clicks, "See all treats", clicks a previously created line item, clicks "Edit Flavor/Treat", fills out a form and clicks "Save".  | Flavor or treat is updated. |
| Users can delete a particular treat or flavor. | User clicks, "See all treats", clicks a previously created line item, clicks "Delete Flavor/Treat", clicks "Delete".  | Flavor or treat is deleted. |



## Known Bugs

- No known bugs at this time.

## Support and contact details

_Please contact Jessica Munoz with questions and comments._

### License

_GNU GPLv3_

Copyright (c) 2019 **_Jessica Munoz_**
