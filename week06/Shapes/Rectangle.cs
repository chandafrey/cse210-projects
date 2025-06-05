using System;

// In a new file, create the Rectangle class.
// Make sure this class inherits from the base class.
// Create a constructor that accepts the color and the side, 
// and then call the base constructor with the color.
// Create the _side attribute as a private member variable.
// Override the GetArea() method from the base class and fill 
// in the body of this function to return the area.

// Area of a Rectangle is _length * _width

// CLASS DECLARATION
public class Rectangle : Shape
{
    // ATTRIBUTES
    private double _length;
    private double _width;

    // CONSTRUCTOR
    public Rectangle(string color, double length, double width) : base(color)
    {
        _length = length;
        _width = width;
    }

    // METHODS
    public override double GetArea()
    {
        return _length * _width;
    }

}