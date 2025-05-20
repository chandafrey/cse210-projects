using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Fractions Project.");
    
    // Create or call a new instance for first constructor - no parameters
    Fraction fraction1 = new Fraction();
    // Create or call a new instance for second constructor - one parameter
    Fraction fraction2 = new Fraction(6);
    // Create or call a new instance for third constructor - two parameters
    Fraction fraction3 = new Fraction(6, 7);

// this set is for the GetDecimalValue method
    Fraction fraction4 = new Fraction();
    Fraction fraction5 = new Fraction(3,4);
    Fraction fraction6 = new Fraction(1,3);

    // OR change the values of the _top and _bottom values using the getter and setter methods
    fraction1.SetTop(1);
    fraction1.SetBottom(1);
    fraction5.SetTop(3);
    fraction5.SetBottom(4);
    fraction6.SetTop(1);
    fraction6.SetBottom(3);




    
    // In your Program.cs file, verify that you can create fractions using 
    // all three of these constructors. For example, create an instance 
    // for 1/1 (using the first constructor), for 6/1 (using the second constructor), 
    // for 6/7 (using the third constructor).

    // Display the fraction using the GetFrationString() method
    Console.WriteLine($"Fraction 1: {fraction1.GetFractionString()}");
    Console.WriteLine($"Fraction 2: {fraction2.GetFractionString()}");
    Console.WriteLine($"Fraction 3: {fraction3.GetFractionString()}");


    // In your Program.cs file, verify that you can call all of these methods 
    // and get the correct values, using setters to change the values and then 
    // getters to retrieve these new values and then display them to the console.

 
    Console.WriteLine($"Fraction 4: {fraction4.GetDecimalValue()}");
    Console.WriteLine($"Fraction 5: {fraction5.GetDecimalValue()}");
    Console.WriteLine($"Fraction 6: {fraction6.GetDecimalValue()}");
    // Console.WriteLine($"Fraction 6: {fraction3.GetDecimalValue(1,3)}");
    
    
    
    }
}