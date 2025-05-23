// Start the file with "using System" to use the Random class
using System;

// Start the file with "using System.Collections.Generic" to use the List class
using System.Collections.Generic;

// 1.  CLASS DECLARATION...public class Scripture
// Responsibilities: keeps track of both the reference and the text of the scripture. 
// Can hide words and get the rendered display of the text.
public class Scripture
{
    // 2.  Class ATTRIBUTES/VARIABLES...We are just naming the variables
    // We want these variables to be private so that they are not accessible from outside the class
    //----------------------------------
    // The word "string" or "int" is a data type of an object like "
    // private string _book;
    // But when we are using information from anther class, we use the name
    // of the class as the data type like this:
    // private Reference _reference; ("Reference is the data type)
    // -----------------------------------
    
    // We want a variable to hold the reference to the scripture
    // private Reference _reference;

    // We want a variable to hold the list of words in the scripture   
    // we used "_words", as in multiple words because a verse is made up of multiple words 
    private List<Word> _words;


    // 3. CONSTRUCTOR - Job: 
    // **The constructor is used to Initialize the Object"
    // meaning - to set up variables, prepare lists, or 
    // do anything else needed BEFORE the object is used
    // It's what makes sure all the parts are in place before you use the object.

   // Same name as the class...public Scripture()
    // **the () can be empty or have parameters

    // For this constructor, we need 2 parameters: 
    // -"Reference reference" so we can pass in something like "John 3:16"
    // Using "Reference reference" represents a complete usable unit of multiple parts of data
    
    // -"string text" so we can pass in the text of the scripture verse(s)
    // Using "string text" means we pass in a whole sentence or verse, made up of
    // multiple words...it is the job of the Scripture class to split the text
    // into individual words and store them in the _words list.
    // --------------------------------------------------
    // If we had used "Word word" instead of "string text",
    // we would only pass in a single word like "tent" and the constructor
    // would not be able to split the text into individual words
    public Scripture(Reference reference, string text)
    {

        Console.WriteLine("Constructor: values assigned to attributes");
    }

    // 3  BEHAVIORS...
    // -HIDE Random words
    // -GET the display text(as a string)
        // The "display text" refers to the text with some words shown 
        // normally and some words replaced with underscores
    // -CHECK if scriptures is completely hidden (so we know to end the program)
   

    // 1.  In order to hide random words, we need to create a Method
    // that will randomly select or GET a word from the list of words and
    // SET the word to "hidden" or look hidden by replacing it with underscores
    // Each time the "enter" key is pressed, the program will call this
    // method again to get the update text with more words hidden
    // public void HideRandomWords(int numberToHide)
    // {
    //     return "HideRandomWords";
    // }


    // 2.  We need to create a method to get the display text
    // that will return the text with some words shown normally and 
    // some words replaced with underscores
    // Each time the "enter" key is pressed, the program will call this
    // method again to get the update text with the new words hidden
    public string GetDisplayText()
    {
        return "GetDisplayText";
    }


    // 3.  We need to create a method to check if the scripture 
    // is completely hidden, and if so, we will end the program.
    public bool IsCompletelyHidden()
    {
        return false;
    }

}