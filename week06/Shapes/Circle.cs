using System;

// In a new file, create the Circle class.
// Make sure this class inherits from the base class.
// Create a constructor that accepts the color and the side, 
// and then call the base constructor with the color.
// Create the _side attribute as a private member variable.
// Override the GetArea() method from the base class and fill 
// in the body of this function to return the area.

// Area of a Circle is _pi * (_radius)squared...
// We can use Math.PI to get more precision than 3.14

// CLASS DECLARATION
public class Circle : Shape
{
    // ATTRIBUTES
    private double _radius;
    // We do not need _pi, as an attribute, because we can just call 
    // it in the math calculations in the GetArea()

    // CONSTRUCTOR
    public Circle(string color, double radius) : base(color)
    {
        _radius = radius;
    }

    // METHODS
    public override double GetArea()
    {
        return _radius * _radius * Math.PI;
    }
}