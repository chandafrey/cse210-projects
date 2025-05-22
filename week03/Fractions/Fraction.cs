public class Fraction
{
    // 1.  Attribute/Variable Declaration...We are just naming the variables
    // We want these variables to be private so that they are not accessible from outside the class
    private int _top;
    private int _bottom;

// --------------------------------------------------
    // We want the attributes to be private, but we need the constructors to be pubblic
    // so we can allow code outside the class to create instances or objects of the class.
// --------------------------------------------------


    // 2.  CONSTRUCTORS...This is a special method that is called when we create an object
    // The constructor has the same name as the class and does not have a return type
    // We are going to have 3 constructors:
        // 1.  Constructor that has no parameters that initializes the number to 1/1.
        // "initializes" means we are setting the values of the variables here
        public Fraction()
        {
            _top = 1;
            _bottom = 1;
        }
        // 2.  Constructor that has one parameter for the top and that initializes 
        // the denominator to 1. So that if you pass in the number 5, the fraction 
        // would be initialized to 5/1.
        // we are initializing or setting the value of just the bottom to 1
        // so we will only need to have one parameter to pass in for the top
        public Fraction(int top)
        {
            // setting the _top value to "top" is a good choice because my parameter
            // is also called "top" so it is easy to remember and make the connection
            // between the two
            _top = top;
            _bottom = 1;
        }
        
        // 3.  Constructor that has two parameters, one for the top and one for the bottom.
        public Fraction(int top, int bottom)
        {
            // We are going to set the _top and _bottom values to the parameters
            // that are passed in.  This is a good choice because it is easy to remember
            // and make the connection between the two.
            _top = top;
            _bottom = bottom;
        }

        // In your Program.cs file, verify that you can create fractions using all three 
        // of these constructors. For example, create an instance for 1/1 (using the first constructor), 
        // for 6/1 (using the second constructor), for 6/7 (using the third constructor).
        // 3.  Method to display the fraction
        // This method will return a string that is the fraction in the form of "top/bottom"
        public string GetFractionString()
        {
            // I need to use the "return" keyword and I do NOT need
            // to use () because the word "return" doesn't require parentheses
            return $"{_top}/{_bottom}";
        }  
        


        // 1. Create GETTERS and SETTERS for both the top and the bottom values.
        // 2. In your Program.cs file, verify that you can call all of these methods and get the 
        // correct values, using setters to change the values and then getters to retrieve these 
        // new values and then display them to the console.
        
        // This is a GETTER for the top value
        // Purpose: This method returns the current value of the private field _top.
        // Why you need it: Since _top is private, code outside the class cannot access it directly. 
        // This getter method gives outside code a way to read _top safely.
        // ---------------------------------------------------
        // This method’s job is to simply return the value of _top.
        // It doesn’t need any additional input or data to do that.
        //  Since you're not passing in a value, there's no need for a parameter.
        public int GetTop()
        {
            return _top;
        }

        // This is a SETTER for the top value
        // Purpose: This method allows code outside the class to set or update the value of _top.
        // The parameter top: This is the new value being passed in.
        // Assignment: _top = top; sets the private _top field to the value that was passed in.
        // ---------------------------------------------------
        // This method needs a value in order to do its job — it can’t just "guess" what to set _top to.
        // You're saying:
        //  “Hey object, set your _top to 5 (or some other number).”
        // So it takes that number as a parameter.
        // ----------------------------------------------------
        // ALSO>>>>>>>>>>>>>>>>>>>>
        // The word **void** means:
        // 👉 “This method does not return a value.”
        // The purpose of a setter is to change or update a value (like _top) — not to return anything.
        // So we use void because:
        // You're just giving the object information.
        // You're not asking it to give you anything back.
        public void SetTop(int top)
        {
            _top = top;
        }

        // This is a GETTER for the bottom value
        public int GetBottom()
        {
            return _bottom;
        }

        // This is a SETTER for the bottom value
        public void SetBottom(int bottom)
        {
            _bottom = bottom;
        }


        // Create a method called GetDecimalValue that returns a double that is the 
        // result of dividing the top number by the bottom number, such as 0.75.}
        public double GetDecimalValue()
        {
            // This method will return a double that is the result of dividing the top number by the bottom number
            // We need to cast the _top and _bottom to double so that we get a decimal value
            // If we don't cast it, we will get an integer value
            return (double)_top / (double)_bottom;
        }
}