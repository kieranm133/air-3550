# air-3550
A flight reservation system for our EECS 3550 term project that allows the airline to schedule and manage flights, as well as allow customers to book flights and view various information about their flights. 

### Features ###
* Create a new customers and routes that persist in the database
* Search for flights based on criteria like date, time, and destination.
* Book or cancel a reservation.
* View customer information (flights booked, points earned, etc.) and change the password of a customer account
* Admin roles for managing the airline's schedule, routes, and finances.

### Getting Started ###
[Download the latest release here.](https://github.com/kieranm133/air-3550/releases/download/v1.0.0/Air3550.zip) After extracting the file, run the `air-3550.exe` executable in the main directory to start the application. 
The project uses SQLite (stored in the Database folder) to manage the persistence layer, so no additional setup is required.

The following is a list of the default debug admin users. Accounts with admin roles cannot be created through the application--these are the users that persist in the initial database state: 

|     Role                    |     UserID    |     Password    |
|-----------------------------|---------------|-----------------|
|     Load Engineer           |     100001    |     12345678    |
|     Flight   Manager        |     100002    |     12345678    |
|     Marketing   Manager     |     100003    |     12345678    |
|     Accounting   Manager    |     100004    |     12345678    |
|     Customer                |     100005    |     12345678    |

You may use the predefined user for the Customer role or create your own, but if you wish to access the menus for the other user roles, you must log in using the credentials listed above (or manually add new users to your local copy of the SQLite database). 

