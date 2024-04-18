# ST1002295FavourAjayiProg6221Part1
This is a read me file of how to use the code and this is a read me file for programmers on how the classes and functionality works
Classes:

Ingredients: Represents an ingredient with properties for name, quantity, and unit of measurement.
Steps: Represents a step in a recipe with a description.
Receipe: Represents a recipe with arrays for ingredients and steps. It has methods to add ingredients and steps, clear data, reset data, and display the recipe.
Array Usage:

The Ingredients and Steps classes are used to create arrays within the Receipe class.
The arrays are initialized with sizes based on the number of ingredients and steps provided by the user.
Main Functionality:

The Manager class contains the Main method, which is the entry point of the application.
It allows the user to:
Enter recipe details (name, ingredients, steps).
View recipe details.
Clear data (reset arrays).
Reset data (set all ingredient quantities to 1).
Return to the main menu.
The user can input the number of ingredients and steps for each recipe and then enter the details for each.
Key Points:

The code demonstrates basic console-based interaction for managing recipes.
It uses arrays to store ingredient and step details.
It provides methods to add ingredients and steps, clear and reset data, and display the recipe.

How to run the application.

Download the provided code file containing the Part1 namespace.

Open Visual Studio and create a new console application project.

Copy the Ingredients, Steps, Receipe, and Manager classes from the downloaded code and paste them into your console application project.

Compile and run the application in Visual Studio.

The application will display a menu with options:
Enter recipe details
View recipe details
Clear data
Reset data
Return to menu
Follow the on-screen instructions to:
Enter a recipe name.
Specify the number of ingredients and steps in the recipe.
Enter details for each ingredient (name, quantity, unit of measurement).
Enter details for each step (description).
View the recipe details.
Clear or reset the data as needed.
Exiting the Application:
To exit the application, select the "Return to Menu" option and then select option 5.
Additional Notes:
The application may have some logical issues, such as not correctly incrementing step indices when adding steps. You may need to adjust the code to address these issues.
Enjoy Managing Recipes!
