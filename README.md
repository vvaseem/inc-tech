# Solar System Explorer

Welcome to the Solar System project. This project consists of two main components: a .NET Core API for the backend, and a React application for the frontend. Here's how you can set up and run the project on your local development environment.
Prerequisites

Before you start, make sure you have the following software installed on your machine:

    Git
    .NET Core SDK
    Node.js and npm
    An IDE of your choice (e.g., Visual Studio, VS Code, etc.)

Getting Started
Clone the Repository

First, clone the repository to your local machine. Open your terminal and navigate to the directory where you want to clone the project, then run the following command:

git clone https://github.com/vvaseem/inc-tech/tree/main

# Run the Backend

The .NET Core API is located in the \Backend\SolarSystem.Backend\SolarSystem.Backend.sln directory. To run it, either open the .sln, or navigate to this directory using your terminal:

cd /Backend/SolarSystem.Backend

Then, you can run the API using the following command:

dotnet run

You should see output indicating the API has started, typically listening on http://localhost:7292.

# Install the necessary node modules:

npm install

Then, you can start the React application with:

npm start

The application should now be running and accessible at http://localhost:3000.

# Run the Frontend

The React application is located in the \Frontend\SolarSystem.Frontend directory. Open a new terminal window and navigate to this directory:

cd /Frontend/SolarSystem.Frontend