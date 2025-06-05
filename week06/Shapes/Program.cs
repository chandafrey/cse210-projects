using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Shapes Project.");
    
        // Notice that the list is a list of "Shape" objects. That means
        // you can put any Shape objects in there, and also, any object where
        // the class inherits from Shape
        List<Shape> shapes = new List<Shape>();

        
        // --------------------------------------
        // 🔍 Line-by-Line Breakdown:
        // ✅ Square s1 = new Square("Red", 3);
        // This line is doing three things:

        // new Square("Red", 3)

        // This creates a new object of the Square class.

        // It passes "Red" as the color, and 3 as the side length.

        // This calls the Square constructor:

        //******************* 
        // public Square(string color, double side) : base(color)
        // {
        //     _side = side;
        // }
        // Square s1 = ...

        // This declares a variable named s1 of type Square.

        // It holds a reference to the new Square object.

        // So now, s1 points to a red square with a side length of 3.

        // ✅ shapes.Add(s1);
        // This adds the s1 object to a List<Shape> called shapes.

        // Since Square inherits from Shape, it's allowed — the list can hold any object that is a Shape or a subclass of Shape.
        // ----------------------------------------------

        Square s1 = new Square("red", 3);
        shapes.Add(s1);

        Rectangle r1 = new Rectangle("yellow", 5, 2);
        shapes.Add(r1);

        Circle s3 = new Circle("blue", 4);
        shapes.Add(s3);

        foreach (Shape s in shapes)
        {
            // Notice that all shapes have a GetColor method from the base class
            string color = s.GetColor();

            // Notice that all shapes have a GetArea method, but the behavior is
            // different for each type of shape
            double area = s.GetArea();

            Console.WriteLine($"The {color} shape has an area of {area}.");
        }
    }
}