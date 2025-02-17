ASP.NET Order Processing Application

Overview :

This is a simple ASP.NET web application that processes customer orders and applies a discount based on the order amount and customer type. 
The application calculates a discount for "Loyal" customers who place orders of $100 or more, applying a 10% discount. If the customer is "New" or the order amount is less than $100, no discount is applied.

Features :

Customer can enter an order amount and select their customer type (New or Loyal).
The discount is calculated based on the order amount and customer type.
The application displays the discount applied and the final order total.

Technologies Used :

ASP.NET Core MVC
xUnit (for unit testing)
GitHub Actions (for CI/CD pipeline)
Visual Studio (or Visual Studio Code)

Prerequisites :

.NET SDK 8.0 or later
Visual Studio or Visual Studio Code
Git (for version control)
GitHub account (for hosting the repository)

Installation :

1. Clone the repository to your local machine:
git clone https://github.com/KruthikaNadiger/OrderProcessingApp.git

2. Open the project in Visual Studio.

3. Restore the project dependencies:
dotnet restore

4. Build the project:
dotnet build

5. Run the application:
dotnet run

6. Open your browser and navigate to http://localhost:5000 to use the application.

Usage:
Order Entry View: Enter the order amount and select the customer type (either "New" or "Loyal").
Results View: The discount (if any) will be displayed along with the final total amount after the discount is applied.

Automated Testing:

 Test Setup :
* The application includes unit tests using xUnit to ensure the discount logic is correctly implemented.
* The tests are located in the /tests folder in the repository.
* To run the tests locally, navigate to the /tests directory and run:  dotnet test

Test Coverage: 

 Tests ensure that the discount is applied correctly for:
* Loyal customers with an order amount of $100 or more.
* Non-loyal customers and orders below $100.
* Edge cases like exactly $100 and invalid inputs.
  
Version Control Strategy
* Master branch: The main branch contains the stable, production-ready code.
* Feature branches: New features are developed in separate feature branches, which are created from the main branch. Example: feature/add-discount-calculation.
* Merge strategy: Feature branches are merged back into main after code reviews and successful tests.

CI/CD Pipeline : 
The CI/CD pipeline is set up using GitHub Actions. Whenever new code is pushed to the repository, the pipeline will automatically:

1. Run unit tests to ensure that the code is working as expected.
2. Deploy the application to a test environment (optional).

Workflow Configuration :
The pipeline configuration file (.github/workflows/dotnet.yml) is included in the repository. 
It contains the following steps:

1. Checkout the code.
2. Install .NET dependencies.
3. Run the tests.
4. Notify on test results (optional).
