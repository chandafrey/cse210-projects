// **EXCEEDINGING REQUIREMENTS**
// I added an option for the user to choose to write their own entry
// or to use a random prompt from the PromptGenerator class.


// Use this line pretty much everywhere in your code...also used for:
// Console, Random, DateTime List, etc.
using System;

// Use this line if you're using a List<string> in your PromptGenerator class
using System.Collections.Generic;

// Use this line if you're Reading or Writing to files
using System.IO;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Journal Project.");

        Console.WriteLine("This project is to help you journal more effectively.");
        Console.WriteLine("You can view previouse entries add new ones and save them.");
        Console.WriteLine("Press any key to continue...");
        Console.ReadKey();
        Console.Clear();
        // Console.WriteLine("Please select one of the following choices:");
   


     //    Offer the user a choice of options: 1. Write, 2. Display, 3. Load, 4. Save, 5. Quit
        // Console.WriteLine("1.  Write a new entry");
        // Console.WriteLine("2.  Display all journal entries");
        // Console.WriteLine("3.  Load previous entries");
        // Console.WriteLine("4.  Save journal");
        // Console.WriteLine("5.  Quit");
        // Console.Write("Please enter your choice: ");

        
        // Start with reading the string input from the user.  
        // Then use an if/else statement to check if the user has selected one of the options.  
        // If they have, call the appropriate method.
        // string input = Console.ReadLine();
        string input = "";

  
        // I am going to create new objects/instances of my Journal class here 
        // AND - CALL THE CONSTRUCTOR "new Journal();""
        // The Constructor is the METHOD inside my class that runs when I create a new object
        // I will put it here before I start my if/else statements, so they only need called once
        Journal journal = new Journal();

        // I am going to use an if/else statement to check if the user has selected one of the options
        // And I want to keep asking the user for input until they select "5" to quit
        // I will use a while loop to keep asking the user for input until they select "5" to quit
        while (input != "5")
        // Provide a menu that allows the user choose these options
        {
            // After the user keys "enter" I want to ask them for input again
            // I will use Console.WriteLine to ask the user for input again
            Console.WriteLine("Please select one of the following choices:");
            // I will use Console.WriteLine to display the options again
            Console.WriteLine("1.  Write a new entry");
            Console.WriteLine("2.  Display all journal entries");   
            Console.WriteLine("3.  Load previous entries");
            Console.WriteLine("4.  Save journal");
            Console.WriteLine("5.  Quit");
            Console.Write("Please enter your choice: ");
            // I will use Console.ReadLine() to read the user's input
            input = Console.ReadLine();

           
            if (input == "1")
            // Console.WriteLine("1.  Write a new entry");

            // Write a new entry - Show the user a random prompt 
            // (from a list that you create), and save their response, the prompt, and the date as an Entry.
            // If user types "1", then Get and Write a random prompt from the PromptGenerator List
            {
            // Write a new entry...Offer the user a choice of writing 
            // a new entry on their own topic OR using a random prompt from the PromptGenerator class.


                // The CONSTRUCTORS for the Entry and PromptGenerator classes
                // will be placed here so they are called when the user selects "1"
                Entry newEntry = new Entry();
                PromptGenerator promptGenerator = new PromptGenerator();    


                // Do I need this line here?
                // string ownTopic = "";

            
                // I will use the Console.WriteLine method to ask the user for input
                // I will use the Console.ReadLine method to read the user's input
                Console.WriteLine("Would you like to write a new entry on your own topic? (y/n)");
                // I will use a string to read the user's input
                string ownTopic = Console.ReadLine();
                // I will use an if/else statement to check if the user has selected "y" or "n"
                if (ownTopic.ToLower() == "y")
                {   
                    Console.WriteLine("Begin writing your entry below:");
                //     // I will use Console.ReadLine() to read the user's input
                //     // I will use a string to read the user's input
                    string entry = Console.ReadLine();
                //     // I will set the _entryText to the entry variable
                    newEntry._entryText = entry;
                //     // I do not need to set the _date in the constructor because I am going to set it in the Entry class
                //     // Now I need to add the new entry to the journal
                //     // I will use the journal object to call the AddEntry method
                //     // I will pass in the newEntry object to the AddEntry method
                //     journal.AddEntry(newEntry);

                //     // I want to save the entry to a file so when the user quits, they can load it again
                //     // I will use the SaveToFile method from the Journal class to save the entry    
                //     // I will use the journal object to call the SaveToFile method
                //     // I will pass in the filename as a parameter
                //     journal.SaveToFile("journal.txt");    
                }


                // // Otherwise, if the user does not want to write a new entry on their own topic
                // // else (ownTopic == "n")
                // else
                // Console.WriteLine("You have selected to use a random prompt from the PromptGenerator class");    
                // }


                else
                {
                    // Start with data type - string
                    // Then use the name of the variable you want to create - prompt
                    // (because we want to give the user a prompt to write about)
                    // Then use = to assign it a value of what we want it to be or do
                    // We want it to go to the PromptGenerator class and use the GetRandomPrompt method
                    string prompt = promptGenerator.GetRandomPrompt();
                    // Now we need to display the promt to the user
                    Console.WriteLine(prompt);

                    // Now we need to get the user's entry and we will use a carrot > to 
                    // show the user where to type their entry
                    Console.Write("> ");
                    // I am going to use Console.ReadLine() to read the user's input
                    // I am going to use a string to read the user's input
                    string entry = Console.ReadLine();

                    // Now we need to get the promt and entry into the new entry object so it can be saved
                    // I will use the newEntry object to set the _promptText and _entryText
                    // I will use the dot notation to set the _promptText and _entryText
                    // I will set the _promptText to the prompt variable
                    newEntry._promptText = prompt;
                    // I will set the _entryText to the entry variable
                    newEntry._entryText = entry;
                

                    // I do not need to set the _date in the constructor because I am going to set it in the Entry class
                    
                    // OTHERWISE>>> I could set it here if I wanted to
                    // I will set the _date to the current date
                    // I will use the DateTime class and ToShortDateString method to get the current date
                    // I will set the _date to the current date
                    // newEntry._date = DateTime.Now.ToShortDateString();
                }


                // I want to display the entry to the console to make sure it is correct
                // I will use the Display method from the Entry class to display the entry
                // I will use the newEntry object to call the Display method
                // newEntry.Display();

                // Now I need to add the new entry to the journal
                // I will use the journal object to call the AddEntry method
                // I will pass in the newEntry object to the AddEntry method
                journal.AddEntry(newEntry);

                // I want to save the entry to a file so when the user quits, they can load it again
                // I will use the SaveToFile method from the Journal class to save the entry    
                // I will use the journal object to call the SaveToFile method
                // I will pass in the filename as a parameter
                journal.SaveToFile("journal.txt");  
                
            }
            else if (input == "2")
            // Console.WriteLine("2.  Display all journal entries");
            
            // Display the journal - Iterate through all entries 
            // in the journal and display them to the screen.
            
            {
                Console.WriteLine("Here are the journal entries:");

                // I will need to Load(or read) the entries from the file in order to display them
                // I will use the LoadFromFile method from the Journal class to load the entries
                // I will use the journal object to call the LoadFromFile method
                // I will pass in the filename as a parameter
                // journal.LoadFromFile("journal.txt");
                // I want to skip a line between each entry to make it easier to read
                // Console.WriteLine();
                // Console.WriteLine();
                // I will use the Display method from the Journal class to display the entry
                // I will use the journal object to call the Display method
                journal.DisplayAll();
            }
            else if (input == "3")
            // Console.WriteLine("3.  Load previous entries");

            // Load the journal from a file - Prompt the user for a filename 
            // and then load the journal (a complete list of entries) from that file. 
            // This should replace any entries currently stored the journal.
            
            {
                // We need to first ask the user for the filename
                // I will use the Console.WriteLine method to ask the user for the filename
                // I will use the Console.ReadLine method to read the filename from the user
                // I will use a string to read the user's input
                // I will use the filename variable to hold the filename
                Console.WriteLine("What is the filename you would like to load?");
                string filename = Console.ReadLine();

                // I will use the File.Exists method to check if the file exists
                // I will use the filename variable to check if the file exists
                if (File.Exists(filename))
                {
                    // We will call the LoadFromFile method from the Journal class to load the entries
                    // We will use the journal object to call the LoadFromFile method   
                    // We will pass in the filename as a parameter
                    journal.LoadFromFile(filename);

                    // I will use the Display method from the Journal class to display the entry
                    // I will use the journal object to call the Display method
                    journal.DisplayAll();
                }
                else
                {
                    // If the file does not exist, display a message
                    Console.WriteLine("File not found.");
                }
            
            }
            else if (input == "4")
            // Console.WriteLine("4.  Save journal");
            
            // Save the journal to a file - Prompt the user for a filename 
            // and then save the current journal (the complete list of entries) 
            // to that file location.
            
            {                
                string filename = "";

                // Ask the user for the filename
                Console.WriteLine("What is the filename you would like to save?");
                
                // Read the filename from the user
                filename = Console.ReadLine();

                // I want to save the entry to a file so when the user quits, they can load it again
                // I will use the SaveToFile method from the Journal class to save the entry    
                // I will use the journal object to call the SaveToFile method
                // I will pass in the filename as a parameter
                // journal.SaveToFile("journal.txt");
                journal.SaveToFile(filename);
                Console.WriteLine($"The journal has been saved to {filename}.");
            }
            else if (input == "5")
            // Console.WriteLine("5.  Quit");

            {        
                Console.Write("Goodbye!");
            }
            else
            {
                Console.WriteLine("Invalid option. Please try again.");
            }
            
        }
    }
}