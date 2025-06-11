// Use this line pretty much everywhere in your code...also used for:
// Console, Random, DateTime List, etc.
using System;

// Use this line because you're using a List<string> in your Listing class
using System.Collections.Generic;

// CLASS DECLARATION
public class RunningActivity : ActivityBase
{
    // ******Attributes Already In ActivityBase*****
    // private DateTime _date;
    // private int _minutes;
    // ******************************************
    private double _distance;

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
    // while '_distance' is specific to this sub class.
    // ------------------------------------------------
    public RunningActivity(DateTime date, int minutes, double distance) : base(date, minutes)
    {
        _distance = distance;
    }


    // METHODS

    // For each activity you're only Storing certain information - and everything else is calculated from that
    // Running - stored: distance, calculate: speed, pace 

    // 1.  GetDistance()
    // *Stored
    public override double GetDistance()
    {
        return _distance;
    }

    // 2.  GetSpeed()
    // *Calculate
    public override double GetSpeed()
    {
        // Speed = (distance / minutes) * 60
        return (_distance / GetMinutes()) * 60.0;
    }

    // 3.  GetPace()
    // *Calculate
    public override double GetPace()
    {
        // Pace = minutes / distance
        return GetMinutes() / _distance;
    }

}