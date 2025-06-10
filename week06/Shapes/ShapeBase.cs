using System;

// Add the color member variable and a getter and setter for it.
// Create a constructor that accepts the color and set its.
// Create a virtual method for GetArea().

// CLASS DECLARATION
// * See the comment below about the abstract method. Because we have an abstract method,
// this class must also be declared as an abstract class.
public abstract class Shape
{
    private string _color;

    // CONSTRUCTOR
    public Shape(string color)
    {
        _color = color;
    }

    // GETTER
    public string GetColor()
    {
        return _color;
    }

    // SETTER
    public void SetColor(string color)
    {
        _color = color;
    }

    // METHODS
    // Because it does not make sense to define a default body for this method in the
    // base class, rather than make a "virtual" function here like this:
    //
    // public virtual double GetArea()
    // {
    //     return 0;
    // }
    //
    // We can instead declare the function as an "abstract" function. That means
    // that it is an empty virtual function that must be implemented or "filled in" by
    // any class that inherits from Shape. Then, any class that has an abstract method
    // must also be declared to be abstract.
    public abstract double GetArea();
}