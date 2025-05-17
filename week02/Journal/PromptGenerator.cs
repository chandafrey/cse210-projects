// Start the file with "using System" to use the Random class
using System;

// Start the file with "using System.Collections.Generic" to use the List class
using System.Collections.Generic;

// 1.  CLASS DECLARATION...public class PromptGenerator
// This class will generate random prompts for the journal entries from a list
public class PromptGenerator
{
    // 2.  Class ATTRIBUTES/VARIABLES
    // I need to create one variable to hold the promt list:
    // *remember this is just a field declaration declaring 
    // what the variable will be called and its data type
    // I am not setting a value for it yet - that happens in the constructor
    // -promt list
    public List<string> _prompts;


    // 3. CONSTRUCTOR - Job: Create a new list of prompts and assign it to the _prompts variable
    // **The constructor is used to Initialize the Object"
    // meaning - to set up variables, prepare lists, or 
    // do anything else needed BEFORE the object is used
    // It's what makes sure all the parts are in place before you use the object.

    // Same name as the class...public PromptGenerator()
    // **the () can be empty or have parameters
    // I want this to = new List<string> because I am making a 
    // new list of strings and will fill it with the prompts below
    // I am saying "here is my list - its ready to use
 
    public PromptGenerator()
    {
        // This constructor will create a new empty list of prompts
        // The List class is part of the System.Collections.Generic namespace
        // Writing this line as _prompts = new List<string> is a
        // "collection initializer" - this will allow each of the prompts
        // to be added to the list in the constructor
        _prompts = new List<string>
        {
            "What was the best part of your day?",
            "What did you learn today?", 
            "Who was your favorite person to talk to today?",
            "What was the most challenging part of your day?",
            "How did you help someone today?",
            "What is one thing you are proud of today?",
            "Who helped you today and how?",
            "What are you grateful for today?",
            "What is one thing you would change about your day?",
        };
    }
        // OTHERWISE>>> 
        // Writing this line as _prompts = new List<string>();
        // (with the parentheses and colon)
        // I would need to use .Add() if I'm assigning the list 
        // and filling it after
        // This is a more flexible option if adding prompts conditionally
        // or from another source later

        // _prompts = new List<string>();
        //     _prompts.Add("What was the best part of your day?");
        //     _prompts.Add("What did you learn today?");
        //     _prompts.Add("Who was your favorite person to talk to today?");
        //     _prompts.Add("What was the most challenging part of your day?");
        //     _prompts.Add("What are you grateful for today?");
        //     _prompts.Add("If you could change one thing about today, what would it be?");

// }


    // Now I need a method to randomly select a prompt from my list to give the user
    
    public string GetRandomPrompt()
    {
//         // Create a new Random object
        Random random = new Random();
//         // Generate a random index based on the number of prompts
        int index = random.Next(_prompts.Count);
//         // Return the prompt at the random index
        return _prompts[index];
    }

}