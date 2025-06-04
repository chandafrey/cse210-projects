using System;
using System.Collections.Generic;

// CLASS DECLARATION...public class ActivityBase
// This class will display starting and ending messages
// and show a spinner and countdown method

// Each activity should start with a common starting message that provides 
// the NAME of the activity, a DESCRIPTION, and asks for and sets the 
// DURATION of the activity in seconds. Then, it should tell the user 
// to prepare to begin and pause for several seconds.
public class ReflectingActivity : ActivityBase
{
    // ATTRIBUTES NAMES
    // ******Attributes Already In ActivityBase*****
    // private string _name;
    // private string _description;
    // private int _duration;
    // ******************************************
    private List<string> _prompts;
    private List<string> _questions;

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
    // while '_prompts' and '_questions' are specific to this ReflectingActivity class.
    // ------------------------------------------------
    public ReflectingActivity(string name, string description, int duration) : base(name, description, duration)
    {
        _prompts = new List<string>
        {
            "Think of a time when you stood up for someone else.",
            "Think of a time when you did something really difficult.",
            "Think of a time when you helped someone in need.",
            "Think of a time when you did something truly selfless.",
        };

        _questions = new List<string>
        {
            "Why was this experience meaningful to you?",
            "Have you ever done anything like this before?",
            "How did you get started?",
            "How did you feel when it was complete?",
            "What made this time different than other times when you were not as successful?",
            "What is your favorite thing about this experience?",
            "What could you learn from this experience that applies to other situations?",
            "What did you learn about yourself through this experience?",
            "How can you keep this experience in mind in the future?",
        };
    }



    // METHODS
    // 1.  Create a Run() method to run the Breathing Activity
    public void Run()
    {
        // Private fields stay hidden are accessed through public methods
        // or properties..You CANNOT write it like this:
        // - with calling _duration because you are trying to access
        // the private field directly...
        // DateTime finishTime = DateTime.Now.AddSeconds(_duration);
        // ----INSTEAD---
        // Access the _duration field with a public method
        // GetDuration() - which should work because 
        // we added a GETTER/SETTER for this in ActivityBase
        DateTime finishTime = DateTime.Now.AddSeconds(GetDuration());
        
        while (DateTime.Now < finishTime)
        {
            // Display Starting message: 
            // Welcome, Name of Activity, Description, Get duration of session
            DisplayStartingMessage();
           
             // Display Prompt
            // --Think of a time when you helped someone in need.--
            // When you have something in mind, press enter to continue.
            DisplayPrompt();
            // Program needs to wait until user keys "enter"
            // Console.ReadKey();
            
            // Display Questions
            // Now ponder on each of th following questions as they related to this experience.
            // You may begin in: 4(Count Down Seconds HERE)
            // Display carrot And then Question like this
            // >  Have you ever done anything like this before?
            DisplayQuestions();
            // ***HOW TO GET REPEAT QUESTIONS UNTIL TIME RUNS OUT

            // Display Ending message: 
            // - Well done!
            // "spinner"
            // - You have completed another "x" seconds of the Reflecting Activity.
            // "spinner"
            DisplayEndingMessage();

        }
    }
        
    public string GetRandomPrompt()
    {
        Random random = new Random();
        int index = random.Next(_prompts.Count);
        return _prompts[index];
    }

    public string GetRandomQuestion()
    {
        Random random = new Random();
        int index = random.Next(_questions.Count);
        return _questions[index];
    }
   
    public void DisplayPrompt()
    {
        Console.WriteLine("Consider the following prompt:");
        Console.WriteLine();
        Console.WriteLine($"--{GetRandomPrompt()}--");
        Console.WriteLine();        
        Console.Write("When you have something in mind, press enter to continue.");
        
        // Program needs to wait until user keys "enter"
        Console.ReadKey();
        Console.WriteLine();

    }



      public void DisplayQuestions()
    {
        Console.WriteLine("Now ponder on each of the following questions as they related to this experience.");
        Console.Write("You may begin in: ");
        ShowCountDown();
        Console.WriteLine();

        DateTime finishTime = DateTime.Now.AddSeconds(GetDuration());
        while (DateTime.Now < finishTime)
        {
            Console.Write(">  ");
            Console.Write($"{GetRandomQuestion()}");
            // ShowSpinner(10);
            ShowDotDotDot(10);
            Console.WriteLine();   
            Console.WriteLine();
        }
    }
}