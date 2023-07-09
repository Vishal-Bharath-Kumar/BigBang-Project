# Hotel Booking API

## Description

This repository contains the code for a Hotel Booking API, providing a comprehensive solution for managing hotel reservations and bookings. The API allows customers to search and book hotels, hotel staff to manage room availability, and ensures secure access through JWT token authentication. It includes features such as CRUD operations for managing hotel information, filtering capabilities based on location, price range, and amenities, count functionality to obtain available room counts, and JWT token authentication for secure access to the API endpoints.

The project is built using ASP.NET Core and Entity Framework Core, following a code-first approach. It utilizes the Repository Pattern to separate the data access layer from the business logic, ensuring modularity and maintainability. The API provides a set of endpoints for creating, updating, retrieving, and deleting hotel information, as well as filtering hotels based on various criteria.



## Authors

This project is developed and maintained by the following individual:

- Vishal Bharath Kumar - [@vishal-bharath-kumar](https://github.com/Vishal-Bharath-Kumar)

I appreciate the contributions and support from the open-source community. 

For any inquiries or collaboration opportunities, feel free to reach out to us via email at [vishalbharathkumar@gmail.com](mailto:vishalbharathkumar@gmail.com).



## Deployment

To deploy Hotel Booking API in a production environment, follow these steps:

1. Build the Application: Run the following command to build the application:

dotnet build


2. Configure the Database

Set up the database connection string in the appsettings.json file. Make sure to provide the correct database server, credentials, and database name.


3. Apply Database Migrations: Run the following command to apply the database migrations and create the necessary tables:

dotnet ef database update


4. Configure Environment Variables: 

Set the required environment variables for the deployed application, such as the database connection string, JWT secret key, and any other configuration specific to your deployment environment.


5. Run the Application:

 Use the appropriate command or method for your deployment environment to run the published application. Make sure to set the necessary environment variables.


6. Access the API: Once the application is running, you can access the API by making HTTP requests to the provided endpoint URLs. Refer to the API documentation for details on the available endpoints and their usage.

## Features

Hotel Booking API offers a range of powerful features to enhance your healthcare experience:

1. CRUD Operations:  The API supports Create, Read, Update, and Delete operations for managing hotel information. You can create new hotels, update hotel details, retrieve hotel information, and delete hotels.

2. Filtering: Easily search and filter hotels based on location, price range, or amenities. The API provides flexible filtering capabilities to facilitate the booking process.

3. Count Functionality: Obtain counts of available rooms in specific hotels. This feature provides insights into room availability for better decision-making.

4. JWT Token Authentication: Secure authentication mechanism using JWT tokens. Only authorized users can access the API endpoints, safeguarding customer and hotel data.

5. One-to-Many Relationship: Efficiently handle the one-to-many relationship between hotels and rooms. Each hotel can have multiple rooms, and the API provides endpoints to manage and retrieve room information associated with each hotel.

6. Exception Handling: Gracefully handle exceptions with try-catch blocks. Meaningful error messages are returned to ensure stability and a smooth user experience.

7. Repository Pattern: Follows the repository pattern to separate the data access layer from the business logic. Promotes code modularity, maintainability, and testability.

These features combine to provide a robust and user-friendly API for hotel booking and management. Whether you are a customer searching for hotels or a hotel staff member managing room availability, the Hotel Booking API offers the necessary functionality to streamline the process and enhance the overall booking experience.



## Screenshots

Here is screenshot showcasing the DB Schema of Hotel Booking API:


![2023-07-09](https://github.com/Vishal-Bharath-Kumar/BigBang-Project/assets/127297563/407088c8-46f7-41ac-a42b-9970e06777cf)
DB Schema



