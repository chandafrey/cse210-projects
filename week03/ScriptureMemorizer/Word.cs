// start the file with "using System;" to use the DateTime class
using System;

// 1.  CLASS DECLARATION...public class Word
// Responsibilities: keeps track of a single word and whether it is shown or hidden.

public class Word
{
    // 2.  Attribute/Variable Declaration...We are just naming the variables
    // We want these variables to be private so that they are not accessible from outside the class
    // --------------------------------------------------
    // These lines below are field declarations...I am telling the class:
    // "This class has a variable called _date, and it is a string"
    // At this point _date exists but it doesn't have a defined value yet....
    // That will happen in the constructor
    // ---------------------------------------------------
    private string _text;

    // This is a private field that stores the status of the text (hidden or not)
    // private bool _isHidden;

    // --------------------------------------------------
    // We want the attributes to be private, but we need the constructors to be pubblic
    // so we can allow code outside the class to create instances or objects of the class.
    // --------------------------------------------------


    // 3.  CONSTRUCTORS...This is a special method that is called when we create an object
    // The constructor has the same name as the class and does not have a return type
    // We are going to have 1 constructors:
        
        // 1.  Constructor that has one parameter for the text and that initializes 
        // the _isHidden to false. So that if you pass in the word "tent", the text
        // would be initialized to "tent" and _isHidden would be false. 
        // "initializes" means we are setting the values of the variables here
    public Word (string text)
    {
        // setting the _text value to "text" is a good choice because my parameter
        // is also called "text" so it is easy to remember and make the connection
        // between the two
        _text = text;
        // be default we are going to set it to false so the word is not hidden
        // _isHidden = false;
    }


      
    // 3  BEHAVIORS...
        // 1.  Method to Get the text
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
        return $"{_text}";
    }

        // 2. Method to hide the word
    // public void Hide()
    // {
    //     _isHidden = true;
    // }

    //     // 3.Method to show the word
    // public void Show()
    // {
    //     _isHidden = false;
    // }

    // // Method to get the text (returns the text if not hidden, otherwise returns "****")
    // public string GetWord()
    // {
    //     return _isHidden ? "****" : _text;
    // }
}