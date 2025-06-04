using System;
using System.Collections.Generic;

// CLASS DECLARATION...public class ActivityBase
// This class will display starting and ending messages
// and show a spinner and countdown method

// Each activity should start with a common starting message that provides 
// the NAME of the activity, a DESCRIPTION, and asks for and sets the 
// DURATION of the activity in seconds. Then, it should tell the user 
// to prepare to begin and pause for several seconds.
public class BreathingActivity : ActivityBase
{
    // ATTRIBUTES NAMES
    // ******Attributes Already In ActivityBase*****
    // private string _name;
    // private string _description;
    // private int _duration;
    // ******************************************
    // We do not have any new Attributes other than from the ActivityBase class
    
    
    // CONSTRUCTOR
    // *****Constructor Already in ActivityBase*****
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
    public BreathingActivity(string name, string description, int duration) : base(name, description, duration)
    {
        // Because we did not have any new attributes
        // There is nothing else to go here
    }
        

    //  METHODS
    // 1.  Create a Run() method to run the Breathing Activity
    public void Run()
    {
        DisplayStartingMessage();
        // ------------------------------------
        // Private fields stay hidden and are accessed through public methods
        // or properties..You CANNOT write it like this:
        // - with calling _duration because you are trying to access
        // the private field directly...
        // DateTime finishTime = DateTime.Now.AddSeconds(_duration);

        // ----INSTEAD---
        // Access the _duration field with a public method
        // GetDuration() - which should work because 
        // we added a GETTER/SETTER for this in ActivityBase
        // -------------------------------------
        DateTime finishTime = DateTime.Now.AddSeconds(GetDuration());

        while (DateTime.Now < finishTime)
        {
            // Display "Breathe In"
            Console.Write("Breathe in...");
            // Display a ShowCountDown() for 5 seconds
            ShowCountDown();
            Console.WriteLine();
            Console.Write("Now breathe Out...");
            ShowCountDown();
            Console.WriteLine();
            Console.WriteLine();
        }

        DisplayEndingMessage();

    }
}
