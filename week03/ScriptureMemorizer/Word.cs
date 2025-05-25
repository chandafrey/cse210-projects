// start the file with "using System;" to use the DateTime class
using System;

// ---------------------------------------------------
// A class for a Word will need a constructor as well. 
// This constructor should accept the text of the word to save it as an attribute. 
// In addition, the constructor will need to set the initial visibility of the word 
// (whether it is shown or hidden). Notice that you should not need to pass in the 
// visibility of the word. It can be set to be visible by default.
// ----------------------------------------------------


// 1.  CLASS DECLARATION...public class Word
// Responsibilities: keeps track of a single word and whether it is shown or hidden.

public class Word
{
    // 2.  Attribute/Variable Declaration...We are just naming the variables
    // We want these variables to be private so that they are not accessible from outside the class
    // --------------------------------------------------
    // These lines below are field declarations...I am telling the class:
    // "This class has a variable called _text, and it is a string"
    // At this point _text exists but it doesn't have a defined value yet....
    // That will happen in the constructor
    // ---------------------------------------------------
    private string _text;

    // This is a private field that stores the status of the text (hidden or not)
    private bool _isHidden;

    // --------------------------------------------------
    // We want the attributes to be private, but we need the constructors to be public
    // so we can allow code outside the class to create instances or objects of the class.
    // --------------------------------------------------


    // 3.  CONSTRUCTORS...This is a special method that is called when we create an object
    // The constructor has the same name as the class and does not have a return type
    // We are going to have 1 constructors:
        
        // 1.  Constructor that has one parameter for the text and that initializes 
        // the _isHidden to false. So that if you pass in the word "tent", the text
        // would be initialized to "tent" and _isHidden would be false(so the word would be displayed). 
        // "initializes" means we are setting the values of the variables here
    public Word (string text)
    {
        // setting the _text value to "text" is a good choice because my parameter
        // is also called "text" so it is easy to remember and make the connection
        // between the two
        _text = text;
        // by default we are going to set it to false so the word is NOT hidden
        _isHidden = false;
    }


      
    // 3  BEHAVIORS...
        // 1. Method to hide the word
        // The purpose of this method is to set the _isHidden variable to true
        // This means that the word will be hidden when we call the GetDisplayText method
        // The method is called Hide() because it is hiding the word
        // The method does not return anything, it just changes the value of _isHidden
    public void Hide()
    {
        _isHidden = true;
    }

        // 2. Method to show the word(is not hidden)
        // The purpose of this method is to set the _isHidden variable to false
        // This means that the word will be shown when we call the GetDisplayText method
        // The method is called Show() because it is showing the word
        // The method does not return anything, it just changes the value of _isHidden
    public void Show()
    {
        _isHidden = false;
    }

        // 3. Method to check if the word is hidden
        // The purpose of this method is to check if the _isHidden variable is true or false    
        // This means that the word is hidden or not
        // The method is called IsHidden() because it is checking if the word is hidden
        // The method returns a boolean value (true or false)
    public bool IsHidden()
    {
        // The method returns the value of _isHidden
        // If _isHidden is true, then the word is hidden
        // If _isHidden is false, then the word is not hidden
        return _isHidden;
    }
    
        // 4.  Method to Get the text
        // When we use the word "Get" in the method name, 
        // it is a good indication that we are going to RETURN something
        // The purpose is to return a value (specifically a string), not to print it.
        // ----------------------------------------------------
        // Rule of Thumb:
        // If a method is called **GetSomething()**, then its job is to return data, not display it.
        // Let the caller (e.g., your Main method) decide whether to print, store, or manipulate that data.
        // -----------------------------------------------------

    public string GetDisplayText()
    {
        // If the word is hidden, we will return a string of underscores
        // The number of underscores will be the same as the length of the word
        // Otherwise, we will return the word itself
        // -----------------------------------------------------
        // We need to use an if/else statement so we can print the correct format
        // for a hidden word or a visible word...if we didn't, then the output for a hidden
        // word would be the same as a visible word and look something like this:
        // "tent" which is not correct
        // -----------------------------------------------------
        // the condition inside the if statement needs to have
        // == instead of =.
        // = means "assign" a value to a variable
        // == means "check if the value is equal to"
        // 
        if (_isHidden == true)
        // we can also write: if (_isHidden)
        {
            // We are using "return" because our method is begins with "Get"
            // We can use the "new" keyword to create a new string
            // The string constructor takes a char and an int as parameters
            // The char is the character we want to use (in this case, an underscore)
            // The int is the number of times we want to repeat the character
            // The string constructor will create a new string with the specified character
            // repeated the specified number of times
            // The length of the string is the same as the length of the word
            // So if the word is "tent", the length is 4, and the string will be "____"
            return new string('_', _text.Length);
        }
        else
        {
            return _text;
        }
    }
}