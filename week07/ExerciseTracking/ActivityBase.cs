// Use this line pretty much everywhere in your code...also used for:
// Console, Random, DateTime List, etc.
using System;

// Use this line because you're using a List<string> in your Listing class
using System.Collections.Generic;

// CLASS DECLARATION
// * See the comment below about the abstract method. Because we have an abstract method,
// this class must also be declared as an abstract class.
public abstract class ActivityBase
{
    // ATTRIBUTES
    private DateTime _date;
    private int _minutes;

    // CONSTRUCTOR
    public ActivityBase(DateTime date, int minutes)
    {
        _date = date;
        _minutes = minutes;
    }

    // GETTERS/SETTERS
    public DateTime GetDate()
    {
        return _date;
    }
    public void SetDate(DateTime date)
    {
        _date = date;
    }
    public int GetMinutes()
    {
        return _minutes;
    }
    public void SetMinutes(int minutes)
    {
        _minutes = minutes;
    }

    // METHODS
    // Declare the function as an "abstract" function when:
    // it is an empty virtual function that must be implemented or "filled in" by
    // any class that inherits from the base class. 

    // An abstract method cannot be called directly from the base class,
    // because it has no implementation there.
    // It can only be called on an instance of a subclass that provides an override.
    // For example:
    // GoalBase goal = new SimpleGoal(...);
    // goal.RecordEvent(); // This works because goal actually refers to a SimpleGoal instance.

    // -----------------------------------------------------------------

    // 1.  GetDistance()
    public abstract double GetDistance();

    // 2.  GetSpeed()
    public abstract double GetSpeed();

    // 3.  GetPace()
    public abstract double GetPace();

    // 4.  GetSummary
    // Provide a GetSummary method to produce a string with all the summary information.
    // Remember that the summary method can make use of the other methods to produce its result.
    //  This method should be available for all classes, so it should be defined in the base class 
    // (you can override it in the derived classes if needed, but it may not need to be...).
    public virtual string GetSummary()
    {
        // Add an activityType property in derived classes
        // Because my class names are RunningActivity and I would rather "running" as the name in the summary
        // clean it like this:
        string activityType = this.GetType().Name.Replace("Activity", "");
        // Create a string variable for the date...this will display as 03 Nov 2022
        string dateFormatted = _date.ToString("dd MMM yyyy");
        // When working with decimals in this activity..
        // we specifically want Always 1 decimal place and a Second decimal Only if it's Non-Zero
        // add this to end of value you want decimals...    
        // :0.0#
        return $"{dateFormatted} {activityType} ({_minutes} min) - Distance {GetDistance():0.0#} miles, Speed {GetSpeed():0.0#} mph, Pace: {GetPace():0.0#} min per mile";
    }
}