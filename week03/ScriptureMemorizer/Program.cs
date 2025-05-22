using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the ScriptureMemorizer Project.");


        string input = "";
        while (input != "quit")
        {
        // The Scripture Memorizor program will display a random scripture from the list of scriptures.
        // 
        // The user inputs are either "enter" to continue or "quite" to finish the program.
        // The output will be:
        // - a random scripture from  the list of scriptures.
        // - a prompt to press "enter" to continue or "quite" to finish the program.
        // - if the user inputs "enter" the program will display the verse with random words hidden.
        // - if the user inputs "quit" the program will finish.
        // - if the user "inputs "enter" until "all the words have been hidden" the program will finish.
        // The program ends when the user inputs "quit" or "all the words have been hidden".

        // What are good candidates for the classes? - Is there just one? ScriptureMemorizer
        // What are the main jobs or functions of the classes? - read a list of scriptures, display a random scripture, hide a random word
        // THE MENTOR SECTION SAYS I NEED 3 classes
        // -Scripture (word, reference class)
        // -Reference (book, chapter, verse class) John 3:16
        // -Word (every word in the verse)
        
        
            Console.WriteLine("Please press 'enter' to continue or type 'quit to finish:");
            input = Console.ReadLine();

            // I want to check if the user pressed "enter" or "quit" - 
            // Use the string.IsNullOrEmpty method to check if the input is empty
            // If the user pressed "enter" the input will be empty

            if (string.IsNullOrEmpty(input))
            {
                Console.WriteLine("You pressed enter...memorizer is starting.");

                // Here you would call the method to start the memorization process  
                // Start with the reference and then the word text

                // Create a new instance of the Reference class and pass in the book, chapter, and verse
                // Don't forget to use "" for the book name
                // Use commas to separate the parameters
                // type 0 for the end verse if there is no end verse
                Reference reference = new Reference("1 Nephi", 2, 15, 0);

                // Create a new instance of the Word class and pass in the word
                // Use the word "tent" as an example
                // Use the constructor that has one parameter for the word
                Word word = new Word("tent");

                // Call the GetDisplayText method to display the reference and word
                // Console.WriteLine($"The reference is: {reference.GetDisplayText()}");
                // Console.WriteLine($"The word is: {word.GetDisplayText()}");
                Console.WriteLine($"{reference.GetDisplayText()} {word.GetDisplayText()}");
            
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