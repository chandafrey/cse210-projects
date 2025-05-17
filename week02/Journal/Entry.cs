// start the file with "using System;" to use the DateTime class
using System;

// 1.  CLASS DECLARATION...public class Entry
public class Entry
{
// These lines below are field declarations...I am telling the class:
// "This class has a variable called _date, and it is a string"
// At this point _date exists but it doesn't have a defined value yet....
// That will happen in the constructor

    // 2.  Class ATTRIBUTES/VARIABLES
    // I need to create three variables to hold the entry details:
    // *remember this is just declaring what the variable will be called
    // I am not setting a value for it yet
    // -date of the entry
    // -prompt text
    // -entry text
    public string _date;
    public string _promptText;
    public string _entryText;


    // 3.  I need to create a constructor that will take in the date, prompt text, and entry text
    // Same name as the class...public Entry()
    // **the () can be empty or have parameters
    public Entry()
    // I am going to leave the () empty for now because I won't know the values ahead of time
    {
// Now that my variable _date, _promptText, and _entryText exist, 
// I need to create default values for them ..
// This INITIALIZES them to empty strings...in my mind I have a blank journal entry
// no date, prompt or entry yet, the page exists and is ready to be filled in later
        // For the _date, use the DateTime class and ToShortDateString method to get the current date
        // For the _promptText and _entryText, I will set them to empty strings to be filled in later
        
        // **the DateTime class is part of the System namespace, so I need to make sure I have that at the top of my file
        // **by setting the _date to the current date in my constructor,
        //  I am saying that every time I create a new Entry object, it will have the current date   
        // This means I won't have to set it in my main Program.cs file
        _date = DateTime.Now.ToShortDateString();
        _promptText = "";
        _entryText = "";
    }

    // 4.  I need to create a method that will display the entry details

    public void Display()
    {
        Console.WriteLine($"Date:  {_date} - Prompt:  {_promptText}");
        Console.Write($"Entry:  {_entryText}");
        // Add a blank space between entries
        Console.WriteLine();
        Console.WriteLine();

    }
 
}