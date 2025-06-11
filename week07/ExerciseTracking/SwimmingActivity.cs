// Use this line pretty much everywhere in your code...also used for:
// Console, Random, DateTime List, etc.
using System;

// Use this line because you're using a List<string> in your Listing class
using System.Collections.Generic;

// CLASS DECLARATION
public class SwimmingActivity : ActivityBase
{
    // ******Attributes Already In ActivityBase*****
    // private int _date;
    // private int _minutes;
    // ******************************************
    private int _swimmingLaps;

    // CONSTRUCTOR
    // *****Constructor Already in Base*****
    // public ActivityBase(DateTime date, int minutes)
    // {
        // _date = date;
        // _minutes = minutes;
    // }
    // ******************************************

    // This is a child class that inherits from the base (parent) class.
    // To inherit the parent class's constructor parameters, include them in the child class's constructor.
    // Then, use a colon (:) followed by the keyword 'base', passing the inherited parameters to the base constructor.
    // Example:
    // public MathAssignment(string inherited1, string inherited2, string childParam1, string childParam2) 
    //     : base(inherited1, inherited2)
    //
    // In this constructor, 'date', 'minutes' are passed to the base ActivityBase class,
    // while '_swimmingLaps' is specific to this sub class.
    // ------------------------------------------------
    public SwimmingActivity(DateTime date, int minutes, int swimmingLaps) : base(date, minutes)
    {
        _swimmingLaps = swimmingLaps;
    }

    // GETTERS/SETTERS
    public int GetSwimmingLaps()
    {
        return _swimmingLaps;
    }
    public void SetSwimmingLaps(int swimmingLaps)
    {
        _swimmingLaps = swimmingLaps;
    }
    // *******

    // METHODS

    // For each activity you're only Storing certain information - and everything else is calculated from that
    // Swimming - stored: laps, calculate: distance, speed, pace 

    // 1.  GetDistance()
    // *Calculate
    public override double GetDistance()
    {
        // Distance = swimmingLaps * 50 / 1000.0 * 0.62
        return _swimmingLaps * 50 / 1000 * 0.62;
    }

    // 2.  GetSpeed()
    // *Calculate
    public override double GetSpeed()
    {
        // Speed = distance/minutes * 60
        return GetDistance() / GetMinutes() * 60;
    }

    // 3.  GetPace()
    // *Calculate
    public override double GetPace()
    {
        // Pace = minutes/distance
        return GetMinutes() / GetDistance();
    }
}