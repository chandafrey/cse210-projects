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
    private Reference _reference;

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
    // multiple words...
    
    // **** it is the JOB OF THE SCRIPTURE CLASS to split the text
    // into individual words and store them in the _words list.
    // --------------------------------------------------
    // If we had used "Word word" instead of "string text",
    // we would only pass in a single word like "tent" and the constructor
    // would not be able to split the text into individual words

    // ***The Value of "string text" is passed in when we create a new instance
    // of the Scripture class in the Program class....So we do not need to have a 
    // value for it here in this constructor. (just _reference and _words)
    public Scripture(Reference reference, string text)
    {
        // We are going to set the _reference variable to the reference parameter
        // Setting the _reference variable to Reference's reference parameter will get the values
        // for the book, chapter, verse, and end verse.  This way those values are able to stay private or
        // hidden in the Reference class but we can still use them in the Scripture class.
        _reference = reference;

        // We are going to set the _words variable to a new List that will hold Word objects
        // that are created from splitting the text(verse) into individual words.
        _words = new List<Word>();

    // ---------------------------------
    // We want to split the text into individual words here in the constructor because:

    // 1. Constructors = Setup Time
    // The constructor's job is to fully prepare the object. When someone creates a Scripture, you want it to already:
    // Know the reference (like “John 3:16”),
    // Have the verse text split into words,
    // Have a list of Word objects ready to go.
    // So when we write in our Program class:
    // Scripture scripture = new Scripture(reference, "And my father dwelt in a tent");
    // We can immediately start calling methods on that scripture object, like:
    // scripture.HideRandomWords(2);
    // scripture.GetDisplayText();

    // 2.  Encapsulation(Hiding Complex Details)
    // By doing the split in the constructor, you're saying:
    // "Hey user, just give me the reference and the verse. I’ll take care of the rest."
    // That’s a cleaner, more intuitive design.
    //--------------------------------- 

        // Split words:
        // declare data type string
        // use [] to declare an array of strings
        // name the variable...since it is a list of words, I will use "wordArray"
        // =
        // use .Split() method on the text variable
        // The Split method takes a character as a parameter, so we will use ' ' to split by spaces
        string[] wordArray = text.Split(' ');

        // Loop through the wordArray using a foreach loop:
        foreach (string word in wordArray)
        {
            // For each word in the wordArray, we will add it to the _words list 
            // we created above in this constructor
            // -----------------------
            // _words is the name of the list we created above
            // .Add() is a method that adds an item to the list
            // new Word() is the constructor for the Word class
            // and we are passing in the word as a parameter
            // I think this means we are starting with the text(verse) that
            // is passed in the Program class and then this Scripture constructor
            // will split the text into individual words, then add each word to the 
            // _words list, AND because we called the Word Constructor, 
            // each word will have be created as a Word object that looks like this:
            // _text = "tent"
            // _isHidden = false
            // So now we have a list of Word objects that can be hidden or shown
            _words.Add(new Word(word));
        }
        

    }

    // 3  BEHAVIORS...
    // -HIDE Random words
    // -GET the display text(as a string)
        // The "display text" refers to the text with some words shown 
        // normally and some words replaced with underscores
    // -CHECK if scriptures is completely hidden (so we know to end the program)
   

        // 1. Hide a specific number of words (numberToHide) randomly from the _words list.
        // Only hide words that aren't already hidden.
        // Avoid hiding more words than are available to hide.  
        // ----------------------------------------------
        // ✅ Your WORD class is responsible for ACTUALLY HIDING a word by 
        // setting _isHidden = true when Hide() is called.
        // ✅ Your SCRIPTURE class is responsible for choosing WHICH WORDS to 
        // hide (randomly), and THEN CALLS word.Hide() to actually hide them.
        // Your Word class is definitely hiding words — it’s the one carrying 
        // out the hiding. But your Scripture class is the one giving the
        // command: “hide these ones.”
            // Example Flow:
            // Scripture.HideRandomWords(3) is called.
            // It loops or picks 3 visible Word objects.
            // For each one, it calls word.Hide().
            // Inside the Word class, Hide() sets _isHidden = true.
            // Later, when you call word.GetDisplayText(), it knows to 
            // return underscores instead of the actual word if _isHidden is true.
        // -----------------------------------------------------
         
        // In order to hide random words, we need to create a Method
        // that will randomly select or GET a word from the list of words and
        // SET the word to "hidden" or look hidden by replacing it with underscores
        // Each time the "enter" key is pressed, the program will call this
        // method again to get the update text with more words hidden

    // This method will hide a specific number of words randomly from the _words list
    // the parameter will be a number telling how many words to hide
    public void HideRandomWords(int numberToHide)
    {
        // We will use a Random object to generate random numbers
        Random random = new Random();

        // Get all words that are still visible words
        
        List<Word> visableWords = _words.FindAll(word => !word.IsHidden());
        // The above line uses a lambda expression to filter the _words list
        // and create a new list called visableWords that contains only the words that are not hidden.
        // The FindAll method returns a new list containing all elements that match the condition
        // The condition is that the word is not hidden, which is checked by calling the IsHidden() method
        // The lambda expression "word => !word.IsHidden()" means:
        // "For each word in the _words list, check if it is not hidden."
        // This will give us a list of words that are still visible and can be hidden
        // This is important because we only want to hide words that are not already hidden
        // The FindAll method is used to filter the _words list and create a new list
        // called visableWords that contains only the words that are not hidden.

        // Now we have a list of visible words that we can use to hide random words
        // We will check if the numberToHide is greater than the number of words in the visableWords list
        if (numberToHide > visableWords.Count)
        {
            // If it is, we will set numberToHide to the number of words in the visableWords list
            numberToHide = visableWords.Count;
        }
        // This ensures we don't try to hide more words than we have available
        // Now we can proceed to hide the words

        
        // Loop through the _words list and randomly select words to hide
        // We will use a for loop to hide the numberToHide words
        // Note: We are not using a foreach loop here because we need to modify the words
        // by calling the Hide() method from the Word class, which requires access to the index
        // -----------------------------------------------------    
        // The foreach loop is used to iterate through a collection, but it does not allow modification of the collection
        // so we cannot use it to hide words in this case.
        for (int i = 0; i < numberToHide; i++)
        {
            // Generate a random index to select a word from the _words list
            int randomIndex = random.Next(visableWords.Count);
            
            // Get the word at the random index from the visableWords list
            // and Hide it
            visableWords[randomIndex].Hide();
            visableWords.RemoveAt(randomIndex);
            // The RemoveAt method is used to remove the word from the visableWords list
            // so that we don't select the same word again in the next iteration
            
            

        }
     
    }


        // 2.  We need to create a method to get the display text
        // that will return the text with some words shown normally and 
        // some words replaced with underscores
        // Each time the "enter" key is pressed, the program will call this
        // method again to get the update text with the new words hidden

        
        // -----------------------------------------------------
        // The verse(TEXT) was passed into the Constructor...that's how we can 
        // access the text in this method. The Constructor SPLIT the text into individual
        // words and added them to the _words list, so we will have to LOOP thru the list
        // and STRING them back together to return the display text.
        // -----------------------------------------------------

    public string GetDisplayText()
    {
        // Use a foreach loop to go through each word in the _words list and 
        // add or string them together and RETURN the DISPLAY.

        // Create a string variable to hold the result BEFORE the foreach loop
        // because we will be adding each word's display text to this string
        string result = "";
        foreach (Word word in _words)
        {
            // Use the += operator to add each word's display text to the result string
            // Use the GetDisplayText() method from the Word class to get the display text
            // -----------------------
            // When we call word.GetDisplayText(), we are using the Word class's method
            // which has already determined if the word is hidden or not.
            // If the word is hidden, it will return underscores, otherwise it will return the word itself.
            // ------------------------
            // Use " " to add a space between each word
            result += word.GetDisplayText() + " ";
            // --------------------
            // Loops through each Word object in _words.
            // Calls GetDisplayText() on each Word to either show the word or underscores.
            // Concatenates them into a single string and returns it.
            // --------------------
        }
        
        return result;
        // return result.Trim();
        // The Trim() method is used to remove any extra spaces at the end of the string
        // This is important because when we loop through the words, we add a space after each word
    }

        // 3.  We need to create a method to check if the scripture 
        // is completely hidden, and if so, we will end the program.
    public bool IsCompletelyHidden()
    {
        // We will loop through the _words list and check if each word is hidden
        // If all words are hidden, we will return true
        // If any word is not hidden, we will return false

        foreach (Word word in _words)
        {
            // If the word is not hidden, we will return false
            if (!word.IsHidden())
            {
                return false;
            }
        }

        // If we get here, it means all words are hidden, so we return true
        // ***Notice we are outside the foreach loop here, because:
        // -the loop needs to check every word and return false if it finds any word
        // not hidden.  After that, if it gets to the end of the loop, then we know
        // all words are hidden, so we return true.
        // OTHERWISE, if we returned true inside the loop, it would stop
        // checking the words after the first word that is hidden.
        return true;
    }

}