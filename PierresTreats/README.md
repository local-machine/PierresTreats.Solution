# Project

### By Jessica Munoz

#### _A web application to record a bakery's treats and their respective flavors. - August 16th, 2019_

---

## Description

Pierre's Bakery has many treats of various flavors for resale. This website helps document them with a many to many relational database that impliments user authintication.

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
| User can add new flavors.              |                      User clicks "Add a new flavor", fills out form and clicks "Add".                      |        New flavor is created.         |
| User can add new treats to the flavor. | User clicks on previously created flavor, clicks "Add a new treat", fills out form and clicks "Add treat". | New treat for that flavor is created. |
| User can view all flavors.             |                                         User clicks "View flavors"                                         |  List of previously created flavors.  |

## Known Bugs

- No known bugs at this time.

## Support and contact details

_Please contact Jessica Munoz with questions and comments._

### License

_GNU GPLv3_

Copyright (c) 2019 **_Jessica Munoz_**