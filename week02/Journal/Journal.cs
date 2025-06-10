// Use this line pretty much everywhere in your code...also used for:
// Console, Random, DateTime List, etc.
using System;

// Use this line if you're using a List<string> in your class
using System.Collections.Generic;

// Use this line if you're Reading or Writing to files
// Don't forget to put this at the top, so C# knows where to find the StreamWriter class
using System.IO;


// Purpose of the Journal class:
// Add a new entry to the journal
// Store the entries in a list
// Display all the entries in the journal
// Save the journal entries to a file   
// Load the journal entries from a file

// 1.  CLASS DECLARATION...public class Journal
public class Journal 
{
    // 2.  Class ATTRIBUTES/VARIABLES
    // Create one variable to hold the list of entries:
    // Data type is List<Entry>
    // *remember this is just a field declaration declaring
    // what the variable will be called and its data type
    // I am not setting a value for it yet - that happens in the constructor
    public List<Entry> _entries;

    // 3.  CONSTRUCTOR - Job: Create a new list of entries and assign it to the _entries variable
    // **The constructor is used to Initialize the Object"
    // This constructor will create a new empty list of Entry objects
    public Journal()
    {
        // The List class is part of the System.Collections.Generic namespace
        // Writing this line as _entries = new List<Entry>() is a
        // "collection initializer" - this will allow each of the entries
        // to be added to the list in the constructor
        // I am saying "here is my list - its ready to use
        _entries = new List<Entry>();
    }

    // 4.  Class BEHAVIORS-FUNCTIONS/METHODS 
    // -AddEntry(), DisplayAll(), SaveToFile(), LoadFromFile()
    // These methods will be used to add, display, save, and load entries

    // ----Create a method to Add anEntry to the _entries List.
    
    // This method will take in a new entry and add it to the list
    // Inside the Parentheses(Start with type of the parameter)
    // I will use the Entry class as the data type for the parameter
    // This means I will be passing in an Entry object to this method
    // Second, I will give the parameter a name
    // I will call it newEntry
    // This method will take in a new entry and add it to the list
    // The method will not return anything, so the return type is void
    public void AddEntry(Entry newEntry)
    {
        // Add the new entry to the _entries list
        // This is where I will add the new entry to the list
        // I will use the Add method to add the new entry to the list
        _entries.Add(newEntry);
    }

    // ----Create a method to DisplayAll entries in the _entries list.

    // This method will loop through each entry in the _entries list and call the Display method on each one
    // This method will not take in any parameters and will not return anything     
    // The return type is void
    public void DisplayAll()
    {
        // Do I need a line here before the foreach loop to check if the _entries list is empty?
        // Loop through each entry in the _entries list and call the Display method on each one
        foreach (Entry entry in _entries)
        {
            entry.Display();
            // Console.WriteLine();
        }
    }
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
        using (StreamWriter outputFile = new StreamWriter(fileName, true))
        {
            // Loop through each entry in the _entries list and write it to the file
            foreach (Entry entry in _entries)
            {
                // outputFile.WriteLine($"The file saved is {filename}");

                // Write the entry to the file in the format: date, prompt, entry text
                outputFile.WriteLine($"{entry._date}, {entry._promptText}, {entry._entryText}");
            }
        }
    }


    // ----Create a method to Load the entries from a file.
    
    // This method will load the journal entries from a file
    // The file name will be passed in as a parameter
    public void LoadFromFile(string fileName)

    // The file will be read line by line
    // Each line will be split into the date, prompt, and entry text
    // The entries will be added to the _entries list
    // The LoadFromFile() method will not return anything, so the return type is void
    // The LoadFromFile() method will take in a file name as a parameter

    {
        // START with checking if the file exists
        // The File class is part of the System.IO namespace
        // The File.Exists() method will check if the file exists
        // The file name will be passed in as a parameter
        // Check if the file exists
        if (File.Exists(fileName))
        {
            // Read the file and display the contents
            // The File.ReadAllLines() method will read the file line by line
            // The file name will be passed in as a parameter
            // The lines will be stored in a string array
            // The string array will be used to loop through each line in the file
            // The string array will be used to split each line into parts
            // The parts will be used to create a new Entry object

            // **You can write this line with System.IO.File... to be more explicit
            // and if you don't want to use the "using" statement at the top
            // string[] lines = System.IO.File.ReadAllLines(filename);
            
            // This line will need the "using System.IO;" at the top of the file
            // Read all lines from the file and store them in a string array
            string[] lines = File.ReadAllLines(fileName);
            foreach (string line in lines)
            {
                // Split the line into parts using the comma as a delimiter
                string[] parts = line.Split(",");

                // Create a new Entry object and set its properties
                Entry entry = new Entry();
                entry._date = parts[0];
                entry._promptText = parts[1];
                entry._entryText = parts[2];

                // Add the entry to the _entries list
                _entries.Add(entry);
            }
        }
    
        // If the file does not exist, display a message
        else
        {
            Console.WriteLine("File not found.");
        }
    }
}