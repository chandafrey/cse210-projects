// Use this line pretty much everywhere in your code...also used for:
// Console, Random, DateTime List, etc.
using System;

// Use this line if you're using a List<string> in your class
using System.Collections.Generic;

// Use this line if you're Reading or Writing to files
// Don't forget to put this at the top, so C# knows where to find the StreamWriter class
using System.IO;


// Purpose of the ListingActivity Class:
// -Prompt the user with a question from the _prompts List
// -All the user to enter as many entries as they can in a specific duration in seconds
// -Add the date of entry, current prompt, and entries from the user to a new list called _entries
// -Save the _entries object with the above information into a file called listing_journal.txt
// -Count and return how many entries were added in a session

// CLASS DECLARATION...public class Listing
// This class will generate random prompts for the user to think about and 
// THEN the user will LIST as many good things as they can 
// for a specific duration 
public class ListingActivity : ActivityBase
{
    // Class ATTRIBUTES/VARIABLES
    // 1.  Create a variable to hold the prompts list:
    // *remember this is just a field declaration declaring 
    // what the variable will be called and its data type
    // I am not setting a value for it yet - that happens in the constructor
    private List<string> _prompts;

    
    //-------------------------------------
    //--------------------------------------
    // EXCEEDINGING REQUIREMENTS
    // 2.  Create a variable to hold the list of user inputs
    // use<ListingEntry> because:...
    private List<ListingEntry> _entries;

    // 3.  Create a variable to hold the current prompt
    private string _currentPrompt;
    //----------------------------------- 

    // 3. Create a variable for the number of inputs the user enters  
    private int _count;

    // CONSTRUCTOR - 
    // -------------------------------------------
    // *****Constructor Already in Assignment*****
    // *remember in the parameters just write the name of the attribute without the underscore_
    // public ActivityBase(string name, string description, int duration)
    // {
    //     _name = name;
    //     _description = description;
    //     _duration = duration; 
    // }
    // ******************************************
    
    // This is a child class that inherits from the base (parent) class ActivityBase.
    // To inherit the parent class's constructor parameters, include them in the child class's constructor.
    // Then, use a colon (:) followed by the keyword 'base', passing the inherited parameters to the base constructor.
    // Example:
    // public MathAssignment(string inherited1, string inherited2, string childParam1, string childParam2) 
    //     : base(inherited1, inherited2)
    //
    // In this constructor, 'name', 'description' and 'duration' are passed to the base ActivityBase class,
    // while 'prompts' and '_userInputs' are specific to this ListingActivity class.
    // ------------------------------------------------
    public ListingActivity(string name, string description, int duration) : base(name, description, duration)
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
            "Who are people that you appreciate?",
            "What are personal strengths of yours?",
            "Who are people that you have helped this week?",
            "When have you felt the Holy Ghost this month?",
            "Who are some of your personal heroes?",
            "How did you help someone today?",
            "What is one thing you are proud of today?",
            "Who helped you today and how?",
            "What are you grateful for today?",
        };
    
        //---------------------------------------------- 
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
        // --------------------------------------------------------
    
        
        // Initialize the _entries to a new list
        _entries = new List<ListingEntry>();
        // -------------------------------
        // Because we are just storing a list of "strings"
        // we are good to set the new list to <string>
        // If we were storing more complex data, like from another class
        // then it would make sense to put <UserInput>
        // ALSO, we do not set it to empty "" because 
        // "" is a string type and List<string> is a list type
        // ---------------------------------

        // Initialize _count to 0, not "count"
        _count = 0;
        _currentPrompt = "";
    }

    // METHODS
    // 1.  Create a Run() method to run the Breathing Activity
    public void Run()
    {  
        // Display Starting message: 
        // Welcome, Name of Activity, Description, Get duration of session
        // "Get ready..."
        DisplayStartingMessage();
        
        // Display Prompt
        // List as many responses as you can to the following prompt.
        // call GetRandomPrompt to generate a prompt
        // --Who are some of your personal heroes?--
        // You may begin in: ___countdown
        DisplayPrompt();

        // Display ">"
        // Get respones from user and...
        // Add Date, Prompt, Entries into the ListingEntry object
        
        ListingEntry entry = GetListFromUser();
  
        AddEntry(entry);

 
        Console.WriteLine();
        Console.WriteLine($"You listed {_count} item(s).");

        
        // AddEntry(entry);
        SaveToFile("listing_journal.txt");

        // Display Ending message: 
        // - Well done!
        // "spinner"
        // - You have completed another "x" seconds of the Reflecting Activity.
        // "spinner"
        DisplayEndingMessage();
   }

// End Run ()---------------------------------------------------------

    // 2. Create a method to RANDOMLY select and return a prompt 
    // from _prompt list to give the user
    // ***Changing this method from "void" because I want to get a prompt stored in my txt file
    public string GetRandomPrompt()
    {
        // Create a new Random object
        Random random = new Random();

        // Generate a random index based on the number of prompts
        int index = random.Next(_prompts.Count);
        //THIS LINE MEANS:
        // pick a random number between 0 and one less than the 
        // total number of prompts and store that in the variable "index"   
        // --------------------------------

        // Return the prompt at the random index
        return _prompts[index];
    }


     public void DisplayPrompt()
    {
        // Get a random prompt and store it in _currentPrompt
        // Then use it when displaying the prompt to user
        // It will also be stored for saving to a txt file
        _currentPrompt = GetRandomPrompt();
        Console.WriteLine("List as many responses as you can to the following prompt:");

        // Give a little delay for user to actually read prompt directions
        Thread.Sleep(3000);
        Console.WriteLine();
        Console.WriteLine($"--{_currentPrompt}--");
        Console.WriteLine();   
        
        // Give a little delay for user to actually read prompt
        Thread.Sleep(3000);

        Console.Write("You may begin in: ");
        ShowCountDown();
        Console.WriteLine();

    }

        // “This method will collect the data for a single journaling session 
        // and return a ListingEntry object containing all of that.”
        public ListingEntry GetListFromUser()
        {
            // Reset count at the start of every new session
            _count = 0;

            // Create a Local Temporary list to hold userResponses
            List<string> responses = new List<string>();
       
            //-------------------------------------    
            // Summary: Why they’re next
            // These two lines capture important context about the session:
            // now: when the session happened.
            // prompt: what the user was responding to.

            // They go before the while loop, so you're capturing the session 
            // state at the beginning, before the user starts entering responses.
            // --------------------------------------------
            // Also notice this first part is naming the variable "now" and NOT 
            // DateTime.NOW   
            DateTime now = DateTime.Now;
            string prompt = _currentPrompt;

            DateTime finishTime = now.AddSeconds(GetDuration());

            // Now start the While Loop and TIMER for duration user gave for session activity
            // Use the current time (DateTime.Now)
            while (DateTime.Now < finishTime)
            {
                Console.Write("> ");
                string input = Console.ReadLine();
                // if the string input is not null or empty
                if (!string.IsNullOrWhiteSpace(input))
                {
                    // add input to responses LIST
                    responses.Add(input);
                    _count++;
                }
            }

            // After the endTime is reached, create a new ListingEntry 
            // It should hold date, prompt, responses(from responses list)
            ListingEntry entry =  new ListingEntry();
            entry.SetDate(now.ToShortDateString());
            entry.SetPrompt(prompt);
            foreach (string response in responses)
            {
              entry.AddEntry(response);
            }
            // Return completed entry
            return entry;

        }




    // 3. AddEntry() 
    // Create a method to Add anEntry to the _entries List.
    // This method will take in a new entry and add it to the list
    // Inside the Parentheses(Start with type of the parameter)
    // I will use the ListingEntry class as the data type for the parameter
    // This means I will be passing in an ListingEntry object to this method
    // Second, I will give the parameter a name
    // I will call it newEntry
    // This method will take in a new entry and add it to the list
    // The method will not return anything, so the return type is void
    public void AddEntry(ListingEntry newEntry)
    {

        // Add the new entry to the _entries list
        // This is where I will add the new entry to the list
        // I will use the Add method to add the new entry to the list
        _entries.Add(newEntry);

    }       
   


    // ===========================================================
       // 3.  Create a method to COUNT how many inputs are on the list
    //WE DO NOT NEED A FOREACH LOOP HERE BECAUSE:
    //c# has a built-in property called .Count that gives you the total
    // number of items in the list, so we can just write it like this:
    // public int GetInputCount()
    // {
    //     return _userInputs.Count;
    // } 


   

 

    // ----Create a method to Save the entries to a file.

    // SaveToFile() method needs to take in a file name as a parameter
    public void SaveToFile(string fileName)
    {
        // This method will save the journal entries to a file
        // The file name will be passed in as a parameter
        // The file will be created if it does not exist
        // If the file already exists, it will be overwritten
        // The entries will be saved in the format: date, prompt, entry text

        // Create a StreamWriter object to write to the file
        // The StreamWriter class is part of the System.IO namespace
        // "outputFile" will allow us to write the entries to the file(instead of the console)
        // The file name will be passed in as a parameter
        // The using statement will ensure that the file is closed after writing
        using (StreamWriter outputFile = new StreamWriter(fileName, append: true))
        {
            // Loop through each entry in the _entries list and write it to the file
            foreach (ListingEntry entry in _entries)
            {  
                outputFile.WriteLine($"Date: {entry.GetDate()}");
                outputFile.WriteLine($"Prompt:  {entry.GetPrompt()}");
                outputFile.WriteLine($"Entries: ");
                
                foreach (string userResponse in entry.GetEntries())
                {
                    outputFile.WriteLine($" - {userResponse}");
                }
                outputFile.WriteLine(new string('-', 50));
                outputFile.WriteLine();
            }
                // Write the entry to the file in the format: date, prompt, entry text
                // outputFile.WriteLine($"{entry._date}, {entry._promptText}, {entry._entryText}");
                // outputFile.WriteLine($"Date of Entry:  {DateTime.Now}, Prompt:  {_currentPrompt}, Entries:  {_entry}");
            
        }
    }
   
}

