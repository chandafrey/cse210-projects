// **EXCEEDINGING REQUIREMENTS**
// I exceeded requirements by adding to a new list in ListingEntry
// -date, current prompt, and responses from the Listing Activity
// -and then saved those "journal" entries to a text file... listing_journal.txt

// Use this line pretty much everywhere in your code...also used for:
// Console, Random, DateTime List, etc.
using System;

// Use this line because you're using a List<string> in your Listing class
using System.Collections.Generic;


class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Mindfulness Project.");

        Console.WriteLine("***************************************");
        Console.WriteLine("This project is to help you be more mindful.");
        Console.WriteLine("Press any key to continue...");
        Console.ReadKey();
        Console.Clear();


        // Start with reading the string input from user.  
        // THIS NEEDS TO HAPPEN BEFORE THE WHILE LOOP STARTS
        string input = "";

        // Create new object/instances of my classes:
        // DO I NEED ALL OF THESE HERE OR SOMEWHERE?
        // public ActivityBase(string name, string description, int duration)

        ActivityBase activityBase = new ActivityBase("Base Activity", "This is the base activity.", 5);
        // Console.WriteLine(activityBase.GetSummary());
        BreathingActivity breathingActivity = new BreathingActivity("Breathing Activity", "This activity will help you relax by walking your through breathing in and out slowly. Clear your mind and focus on your breathing.", 5);
        ReflectingActivity reflectingActivity = new ReflectingActivity("Reflecting Activity","This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.", 5);
        ListingActivity listingActivity = new ListingActivity("Listing Activity","This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.", 5);


        // AFTER the user keys "enter", begin WHILE LOOP 

        
        // - use an if/else statement to check if the user has selected one of the options
        // - keep asking the user for input UNTIL they select "4" to quit
        // - use a while loop to keep asking the user for input until they select "4" to quit
        while (input != "4")
        {
            // Provide a menu that allows the user to choose these options:
            // 1. Breathing, 2. Reflecting, 3. Listing, 4. Quit
            Console.WriteLine("Menu Options:");
            Console.WriteLine("    1.  Start breathing activity");
            Console.WriteLine("    2.  Start reflecting activity");
            Console.WriteLine("    3.  Start listing activity");
            Console.WriteLine("    4.  Quit");
            Console.WriteLine("Select a choice from the menu:");
            // Use Console.ReadLine() to read user's input
            input = Console.ReadLine();
            
            
            // Breathing Activity
            if (input == "1")
            {
                breathingActivity.Run();
                // Display Starting message: 
                // Welcome, Name of Activity, Description, Get duration of session

                // Display Breathing Activity:
                // Breathe in...
                // 5 second countdown
                // Breathe out...
                // 5 second countdown

                // Display Ending message: 
                // - Well done!
                // "spinner"
                // - You have completed another "x" seconds of the Reflecting Activity.
                // "spinner"
            }

            // Reflecting Activity
            else if (input == "2")
            {
                reflectingActivity.Run();
                // Display Starting message: 
                // Welcome, Name of Activity, Description, Get duration of session

                // Display Prompt:
                // --Think of a time when you helped someone in need.--
                // When you have something in mind, press enter to continue.
             
                // Display Questions:
                // Now ponder on each of th following questions as they related to this experience.
                // You may begin in: 4(Count Down Seconds HERE)
                // Display carrot And then Question like this
                // >  Have you ever done anything like this before?

                // Display Ending message: 
                // - Well done!
                // "spinner"
                // - You have completed another "x" seconds of the Reflecting Activity.
                // "spinner"
            }

            // Listing Activity
            else if (input == "3")
            {
                

                listingActivity.Run();
                // Display Starting message: 
                // Welcome, Name of Activity, Description, Get duration of session

                // Display Prompt:
                // Display directions for this activity
                // List as many responses as you can to the following prompt.
                // --Who are some of your personal heroes?--
             
                // Display :
                // Now ponder on each of th following questions as they related to this experience.
                // You may begin in: 4(Count Down Seconds HERE)
                // Display carrot And then Question like this
                // >  Have you ever done anything like this before?

                // Display Ending message: 
                // - Well done!
                // "spinner"
                // - You have completed another "x" seconds of the Reflecting Activity.
                // "spinner"
              
            


                

            }
            else
            {
                Console.WriteLine("Goodbye.");
            }
        }
    }
}