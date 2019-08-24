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
  - Enter the command: dotnet run
- MySQL Setup
  - Execute the following via the terminal: mysql -uroot -pepicodus
    - Note: If you have a different password for MySQLWorkBench, append the command -p.
  - If successful, you'll see the following returned: mysql>
  - Execute the following via the terminal: dotnet ef database update
- Browse to http://localhost:5000/

## Specs

| Behaviors                              |                                                   Input                                                    |                Output                 |
| -------------------------------------- | :--------------------------------------------------------------------------------------------------------: | :-----------------------------------: |
| User can register. | User clicks "Create an account", fills out form, and clicks "Register". | New registration is created. |
| User can login. | User clicks "Log in", fills out form with previously created user info, and clicks "Log in". | User is logged on. |
| User can read all flavors they created if logged on. | User clicks, "See all flavors". | All previously created flavors by that user are listed. |
| User can read all treats they created if logged on. | User clicks, "See all treats". | All previously created treats by that user are listed. |
| User can create new flavors if logged on. | User clicks, "See all flavors", "Add a new flavor", fills out form and clicks "Add". | New flavor is created. |
| User can create new treats to the flavor if logged in. | User clicks, "See all treats", clicks "Add a new treat", fills out form and clicks "Add treat". | New treat for that flavor is created. |
| User can update a particular treat or flavor. | User clicks, "See all treats", clicks a previously created line item, clicks "Edit Flavor/Treat", fills out form and clicks "Save".  | Flavor or treat is updated. |
| User can delete a particular treat or flavor. | User clicks, "See all treats", clicks a previously created line item, clicks "Delete Flavor/Treat", clicks "Delete".  | Flavor or treat is deleted. |

## Known Bugs

- No known bugs at this time.

## Support and contact details

_Please contact Jessica Munoz with questions and comments._

### License

_GNU GPLv3_

Copyright (c) 2019 **_Jessica Munoz_**
