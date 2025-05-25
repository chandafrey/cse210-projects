// ***EXCEEDING requirements
// I made it so my HideRandomWords method will only hide words that are not already hidden.



using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the ScriptureMemorizer Project.");
        // Your program must do the following:

        // Store a scripture, including both the reference (for example "John 3:16") and the text of the scripture.
        // Accommodate scriptures with multiple verses, such as "Proverbs 3:5-6".
        // Clear the console screen and display the complete scripture, including the reference and the text.
        // Prompt the user to press the enter key or type quit.
        // If the user types quit, the program should end.
        // If the user presses the enter key (without typing quit), the program should hide a few random words in the scripture, 
        // clear the console screen, and display the scripture again. (Hiding a word means that the word should be replace by 
        // underscores (_) and the number of underscores should match the number of letters in that word.)
        // The program should continue prompting the user and hiding more words until all words in the scripture are hidden.
        // When all words in the scripture are hidden, the program should end. (The final display of the scripture should show 
        // the scripture with all words hidden.)
        
        // When selecting the random words to hide, for the core requirements, you can select any word at random, even if the 
        // word was already hidden. 
        
        // *******(As a stretch challenge, try to randomly select from only those words that are not already hidden.)
                
        // In addition your program must:

        // Use the principles of Encapsulation, including proper use of classes, methods, public/private access modifiers, and follow good style throughout.
        // Contain at least 3 classes in addition to the Program class: one for the scripture itself, one for the reference (for example "John 3:16"), and to represent a word in the scripture.
        // Provide multiple constructors for the scripture reference to handle the case of a single verse and a verse range ("Proverbs 3:5" or "Proverbs 3:5-6").
        // --------------------------------------------------        
        
        
        
        // Put the information here before the while loop, then it will be available to the whole program

        // Create a new instance of the REFERENCE and pass in the book, chapter, verse, and end verse as parameters
            // Don't forget to use "" for the book name
            // Use commas to separate the parameters
            // type 0 for the end verse if there is no end verse
        Reference reference = new Reference ("Isaiah", 41, 10, 13);

        // Create a string variable to hold the text of the scripture
        string text = "Fear thou not; for I am with thee: be not dismayed; for I am thy God: I will strengthen thee; yea, I will help thee; yea, I will uphold thee with the right hand of my righteousness." + " For I the Lord thy God will hold thy right hand, saying unto thee, Fear not; I will help thee.";

        // Creata a new instance of the Scripture class and pass in the reference and text
        Scripture scripture = new Scripture(reference, text);


        // -----------------------------------------------
        // Display a welcome message to the console
        // This is a good place to put the welcome message so it is displayed only once     
        Console.WriteLine("Welcome to the Scripture Memorizer!");

        // Display the scripture reference and text to the console
        Console.WriteLine($"The reference and scripture is: {reference.GetDisplayText()}  {scripture.GetDisplayText()}");

        // Declare a string variable to hold the user's input
        // Initialize it to an empty string so it has a starting value that allows
        // the while loop to begin.
        string input = "";
        while (input != "quit")
        { 
            // Console.WriteLine("Welcome to the Scripture Memorizer!");

            // Display the scripture reference and text to the console
            // Console.WriteLine($"The reference and scripture is: {reference.GetDisplayText()}  {scripture.GetDisplayText()}");

            // Prompt the user to press 'enter' to continue or type 'quit' to finish
            // Use Console.ReadLine() to get the user's input 
            Console.WriteLine();
            Console.WriteLine("Please press 'enter' to continue or type 'quit to finish:");
            input = Console.ReadLine();
    
            // Check if the user pressed "enter" or "quit" - 
            // Use the string.IsNullOrEmpty method to check if the input is empty
            // If the user pressed "enter" the input will be empty
            if (string.IsNullOrEmpty(input))
            {

                if (scripture.IsCompletelyHidden() == true)
                {
                    // If the scripture is completely hidden, we will display a message and exit the loop
                    Console.WriteLine("All words have been hidden. Goodbye!");
                    break;
                }
                // If the user pressed "enter", Hide a few random words in the scripture
                // We will use the HideRandomWords method from the Scripture class
                scripture.HideRandomWords(5);
                // Clear the console screen
                Console.Clear();
                // Display the scripture reference and text again
                Console.WriteLine($"Update with hidden words: {reference.GetDisplayText()}  {scripture.GetDisplayText()}");
              
            
            }
            else if (input == "quit")
            {
                Console.WriteLine("Goodbye!");
            }
            // is this where I would put another else if "all the words have been hidden" 
            // quite the program or is that above somewhere else?
            else
            {
                Console.WriteLine("Invalid input.  Please type 'enter' to continue or 'quit' to finish:");
            }
        }
    }
}