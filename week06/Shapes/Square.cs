using System;

// In a new file, create the Square class.
// Make sure this class inherits from the base class.
// Create a constructor that accepts the color and the side, 
// and then call the base constructor with the color.
// Create the _side attribute as a private member variable.
// Override the GetArea() method from the base class and fill 
// in the body of this function to return the area.

// **Area of Square is _side * _side

// CLASS DECLARATION
public class Square : Shape
{
    // ATTRIBUTES
    //  double (default for decimals in C#)
    // Default type for floating-point literals (e.g., 3.14 is treated as a double)
    // Usage: Preferred for most scientific, financial, or general-purpose decimal calculations where accuracy matters
    private double _side;

    // CONSTRUCTOR
    public Square(string color, double side) : base(color)
    {
        _side = side;
    }
    // ---------------------------------------
    // About using "0" or "side"
    // ❌ _side = 0; — What’s wrong with this?
    // This sets the side length of every square to 0, 
    // no matter what value you pass in when you create a Square object.

    // As a result, calling GetArea() will always return 0 — because 0 * 0 = 0.

    // It completely ignores the side parameter, which defeats the purpose of 
    // accepting it in the constructor.

    // ✅ _side = side; — Why this is better:
    // This uses the value passed in when creating the square and stores it 
    // in the _side attribute.

    // It ensures that the Square object represents the correct real-world dimensions.

    // Then, the GetArea() method will correctly calculate the area using the actual side length.
    // ------------------------------------------
    
    // METHODS
    // ***Notice the use of "override" because we are overriding
    // the method in our base file Shape.cs
    public override double GetArea()
    {
        return  _side * _side;
    }
}