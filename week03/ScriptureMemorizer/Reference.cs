// start the file with "using System;" to use the DateTime class
using System;

// ---------------------------------------------------
// A class for a Reference should have two different constructors to account for cases 
// where there is a single verse or multiple verses. Notice that you can have two 
// different constructors as long as the parameter list is different. 
// The first constructor would just receive a book, chapter, and verse, 
// whereas the second would receive a book, chapter, start verse and end verse. 
// (This ability to have multiple versions of a function, as long as the parameters 
// are different is called Function Overloading, and it is possible with any 
// function not just constructors.)
// ---------------------------------------------------


// 1.  CLASS DECLARATION...public class Reference
// Responsibilities: keeps track of the book, chapter, verse and end verse information.
public class Reference
{
    // 1.  Attribute/Variable Declaration...We are just naming the variables
    // We want these variable to be private so they are not accessible from outside the class
    private string _book;
    private int _chapter;
    private int _verse;
    private int _endVerse;

    // --------------------------------------------------
    // We want the attributes to be private, but we need the constructors to be public
    // so we can allow code outside the class to create instances or objects of the class.
    // --------------------------------------------------

    // 2.  CONSTRUCTORS...This is a special method that is called when we create an object
    // The constructor has the same name as the class and does not have a return type

        // We need to specify the TYPE of each parameter and the NAME of each parameter
        // We will name the parameters the same as the attributes, only without the underscore
        // This is a good choice because it is easy to remember and make the connection
    
        // We are going to create 2 Constructors:
        // This allows us to create a Reference object for each option below:
        // -1 for the book, chapter, and verse
        // -1 for the book, chapter, verse, and end verse
        // It would look like this:
    public Reference(string book, int chapter, int verse)
    {
        _book = book;
        _chapter = chapter;
        _verse = verse;
        _endVerse = 0;
    }
    public Reference(string book, int chapter, int verse, int endVerse)
    {
        _book = book;
        _chapter = chapter;
        _verse = verse;      
        _endVerse = endVerse;
    }
     

        // 3  BEHAVIORS...
        // -GET the display text(as a string)
            // 1.  Method to Get the reference
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
            // If the _endVerse is 0, we will just return the book, chapter, and verse
            // Otherwise, we will return the book, chapter, verse, and end verse
            // -----------------------------------------------------
            // We need to use an if/else statement so we can print the correct format
            // for 1 verse or a range of verses...if we didn't, then the output for a single
            // verse would be the same as a range of verses and look something like this:
            // "John 3:16-0" which is not correct
            // -----------------------------------------------------
            if (_endVerse == 0)
            {
                return $"{_book} {_chapter}:{_verse}";
            }
            else
            {
                return $"{_book} {_chapter}:{_verse}-{_endVerse}";
            }
        }
}