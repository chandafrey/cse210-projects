// Use this line pretty much everywhere in your code...also used for:
// Console, Random, DateTime List, etc.
using System;

// Use this line because you're using a List<string> in your Listing class
using System.Collections.Generic;

// CLASS DECLARATION
public class CyclingActivity : ActivityBase
{
    // ******Attributes Already In ActivityBase*****
    // private DateTime _date;
    // private int _minutes;
    // ******************************************
    private double _speed;

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
    // while '_speed' is specific to this sub class.
    // ------------------------------------------------
    public CyclingActivity(DateTime date, int minutes, double speed) : base(date, minutes)
    {
        _speed = speed;
    }


    // METHODS

    // For each activity you're only Storing certain information - and everything else is calculated from that
    // Cycling - stored: speed, calculate: distance, pace 

    // 1.  GetDistance()
    // *Calculate
    public override double GetDistance()
    {
        // Distance = Speed * Time (minues) / 60
        return _speed * ((double)GetMinutes() / 60);
    }

    // 2.  GetSpeed()
    // *Stored
    public override double GetSpeed()
    {
        return _speed;
    }

    // 3.  GetPace()
    // *Calculate
    public override double GetPace()
    {
        // Pace = 60 / speed
        return 60.0 / _speed;
    }
}