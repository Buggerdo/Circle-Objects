CIRCLE OBJECTS
Objectives: Objects, Methods, Member Variables

Task: Calculate a circle’s circumference and area.

What will the application do?
The application prompts the user to enter a radius; the user may enter a decimal number.
The application displays an error if the user enters invalid data and asks the user again for a radius.
When the user enters valid data, the application calculates the area and circumference of the circle and rounds to the nearest 2 decimal places and prints out both.
The application asks the user whether they want to do another.
The application displays a “goodbye” message that also indicates the number of circles the user built when the user chooses not to continue.

Build Specifications:
Create a class named Circle to store the data about this circle. This class should contain these constructors and methods:
public Circle(double radius)
public double CalculateCircumference()
public string CalculateFormattedCircumference()
public double CalculateArea()
public string CalculateFormattedArea()
private string FormatNumber(double x)
Define a member called radius. This member should be private. 
Define a property to get access to the class member: Radius 
For the value of pi, use the PI constant of the System.Math class.
In the Main method, get the user input, create a Circle object, and display the circumference and area.

Hints:
Don’t mess up the formulas for circumference or area of a circle!

Extra Challenges:
Create a class named Validator and use its static methods to validate the data in this application.

Console Preview:

Welcome to the Circle Tester
Enter radius: 3
Circumference: 18.85
Area:      	28.27
Continue? (y/n): n
Goodbye. You created 2 Circle object(s).


