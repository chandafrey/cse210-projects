using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the ExerciseTracking Project.");

        // Notice that the list is a list of "Activity" objects. That means
        // you can put any Activity objects in there, and also, any object where
        // the class inherits from ActivityBase
        List<ActivityBase> activities = new List<ActivityBase>();

        // Create each activity with appropriate constructors
        // ALSO for the date... say "new DateTime(2022, 11, 3)
        //Constructor: public RunningActivity(DateTime date, int minutes, double distance) : base(date, minutes)
        RunningActivity r1 = new RunningActivity(new DateTime(2022, 11, 3), 30, 3.0);
        activities.Add(r1);

        // Constructor: public CyclingActivity(DateTime date, int minutes, double speed) : base(date, minutes)
        CyclingActivity c1 = new CyclingActivity(new DateTime(2022, 11, 3), 30, 10.0);
        activities.Add(c1);

        // Constructor: public SwimmingActivity(DateTime date, int minutes, int swimmingLaps) : base(date, minutes)

        SwimmingActivity s1 = new SwimmingActivity(new DateTime(2022, 11, 3), 30, 20);
        activities.Add(s1);

        
        // Once you have the classes in place, write a program that creates at 
        // least one activity of each type. 
        // Put each of these activities in the same list. 
        // Then iterate through this list and call the GetSummary method 
        // on each item and display the results.
        foreach (ActivityBase activity in activities)
        {
            Console.WriteLine(activity.GetSummary());
        }
    }
}