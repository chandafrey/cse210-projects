using System;
using System.Collections.Generic;

// CLASS DECLARATION...public class ActivityBase
// This class will display starting and ending messages
// and show a spinner and countdown method

// Each activity should start with a common starting message that provides 
// the NAME of the activity, a DESCRIPTION, and asks for and sets the 
// DURATION of the activity in seconds. Then, it should tell the user 
// to prepare to begin and pause for several seconds.
public class ActivityBase
{
    // ATTRIBUTES
    private string _name;
    private string _description;
    private int _duration;

    // CONSTRUCTOR
    public ActivityBase(string name, string description, int duration)
    {
        _name = name;
        _description = description;
        _duration = duration;
    }


    // GETTER/SETTER here so OTHER CLASSES can access "name"
        // Get method (GetName)
        // Purpose: Read the value of a private field (_name)
        // Without this, outside code can’t access the activity name because _name is private.
    public string GetName()
    {
        return _name;
    }
        // Set method (SetName)
        // Purpose: Write or update the value of a private field.
        // Without this, you can’t change _name after the object is created (except from inside the class).
    public void SetName(string name)
    {
        _name = name;
    }
    // --------------------
    // Since _duration is private, no other class can touch it directly.
    // But with GetDuration() and SetDuration(), you can safely 
    // read or update the duration from outside. 
    // Like in using DisplayStartingMessage()
    // ---------------------
       public int GetDuration()
    {
        return _duration;
    }
    public void SetDuration(int duration)
    {
        _duration = duration;
    }
    
    
    // METHODS
    // 1.  GetSummary()
    // Use this method to test in main
    // public string GetSummary()
    // {
    //     // *remember you are using underscores _ here, because:
    //     //  we are refering to the private fields _studentName and _topic...
    //     // They are like labeled "boxes" that store the values inside the object
    //     return $"Activity Name:  {_name} - Description:  {_description}, Duration: {_duration}";
    // }

    
    // 2.  DisplayStartingMessage()
    // "Welcome to the ____ Activity:
    // "This activity will...finish description
    // "How long in seconds, would you like for your session? ___user enters seconds here
    
    // ***Need to read input and apply seconds as duration of session

    // "Get ready..."
    // "spinner"
    public void DisplayStartingMessage()
    {
        Console.WriteLine($"Welcome to the {_name}.");
        Console.WriteLine();
        Console.WriteLine($"{_description}");
        Console.WriteLine();
        Console.Write($"How long, in seconds, would you like for your session?  ");
        
        // Read and convert user input to an integer
        // and store in class-level _duration
        string input = (Console.ReadLine());
        //------------------------------------------ 
        // TryParse() is used to avoid crashing the program
        // if the user types letters instead of numbers
        //  Parts explained:
            // int.TryParse(...)
            // This method tries to convert a string (like "30") into an int.
            // It returns true if the conversion was successful, and false if it failed (e.g., if the user typed "abc").

            // input
            // This is the string you're trying to convert — it's what the user typed in with Console.ReadLine().

            // out int duration
            // If the conversion works, the resulting integer is stored in this variable named duration.
        //------------------------------------------
        if (int.TryParse(input, out int duration))
        {
            _duration = duration;
        }
        else
        {
            Console.WriteLine("Invalid input.  Using default duration of 30 seconds.");
            _duration = 30;
        }

        Console.WriteLine();
        Console.WriteLine("Get ready...");
        // Show spinner for 5 seconds
        ShowSpinner(5);
        Console.WriteLine();
    }

   
    // 3.  DisplayEndingMessage()
    //   Each activity should end with a common ending message that: 
    // - tells the user they have done a good job, 
    // - and pause 
    // - and then tell them the activity they have completed 
    // - and the length of time 
    // - and pauses for several seconds before finishing.
    public void DisplayEndingMessage()
    {
        Console.WriteLine("Well done!!");
        // pause with spinner
        ShowSpinner(5);
        Console.WriteLine();

        // Display activity completed and time
        Console.WriteLine($"You have completed another {_duration} seconds of the {_name}.");
        // pause with spinner
        ShowSpinner(5);
        Console.WriteLine();
    }

    // 4. ShowCountDown()
    // Write a ShowCountDown method that:
    // displays the number 5, then 4, 3, 2, 1
    public void ShowCountDown()
    {
        for (int i = 5; i > 0; i--)
        {
            Console.Write(i);
            Thread.Sleep(1000);
            Console.Write("\b \b");
        }
    }

    // 5. ShowSpinner()
    // Create a method to show spinner with seconds parameter
    public void ShowSpinner(int seconds)
    {
        DateTime startTime = DateTime.Now;
        DateTime futureTime = startTime.AddSeconds(seconds);
        
        List<string> animationStrings = new List<string>();
        animationStrings.Add("|");
        animationStrings.Add("/");
        animationStrings.Add("-");
        animationStrings.Add("\\");
        animationStrings.Add("|");
                
        int i = 0;
        while (DateTime.Now < futureTime)
        {
            string s = animationStrings[i];
            Console.Write(s);
            Thread.Sleep(1000);
            Console.Write("\b \b");
            i++;

            if (i >= animationStrings.Count)
            {
                i = 0;
            }
        }
    }
      
            
    // 5.  ShowDotDotDot()
    // Create a method to display dots...like a timer
    public void ShowDotDotDot(int seconds)
    {
        // ------------------------------
        // Full Breakdown
            // int i = 0:
            // Start a counter variable i, and set it to 0.

            // i < seconds:
            // Keep looping as long as i is less than the value in seconds.

            // i++:
            // After each loop, increase i by 1 (i = i + 1).
        // “Repeat the code inside this block once per second, 
        // for the number of seconds given.”
        // -------------------------------
        for (int i = 0; i < seconds; i++)
        {
            Console.Write(".");
            // This line "sleeps" or pauses for the time in ()
            // 1000 is equal to 1 second
            Thread.Sleep(1000);
        }
        
    }
}