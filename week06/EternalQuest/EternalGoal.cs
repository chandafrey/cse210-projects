using System;

// CLASS DECLARATION
public class EternalGoal : GoalBase
{
    // ATTRIBUTES
    // ******Attributes Already In GoalBase*****
    // private string _name;
    // private string _description;
    // private int _points;
    // ******************************************

    // CONSTRUCTOR
    // *****Constructor Already in GoalBase*****
        // public GoalBase(string name, string description, int points)
        // {
            // _name = name;
        // _description = description;
        // _points = points;
        // }
    // ******************************************

    // This is a child class that inherits from the base (parent) class GoalBase.
    // To inherit the parent class's constructor parameters, include them in the child class's constructor.
    // Then, use a colon (:) followed by the keyword 'base', passing the inherited parameters to the base constructor.
    // Example:
    // public MathAssignment(string inherited1, string inherited2, string childParam1, string childParam2) 
    //     : base(inherited1, inherited2)
    //
    // In this constructor, 'name', 'description' and 'points' are passed to the base GoalBase class,
    // while '_isComplete' is specific to this SimpleGoal class.
    // ------------------------------------------------

         
    public EternalGoal(string name, string description, int points) : base(name, description, points)
    {
        // no new attributes to set here
    }


    // METHODS
    // 1.  RecordEvent()
    // This method should do whatever is necessary for each specific kind of goal, 
    // It should return the point value associated with recording the event 
    // I think this means saying in a WriteLine how many points earned
    // and not actually Returning points because this method type is void
    public override void RecordEvent()
    {
        int points = GetPoints();
        Console.WriteLine($"Congratulations!  You have earned {points} points!"); 
    }

    // 2.  IsComplete()
    // For a bool we are answering the question:
    // "Has this goal been completed yet?"
    // EternalGoal is never done so set it to false
    public override bool IsComplete()
    {
        return false;
    }

    // 3.  GetStringRepresentation()
    // This method should provide all of the details of a 
    // goal in a way that is easy to save to a file, and then load later.
    // **REMEMBER THIS IS FOR THE TEXT FILE FORMAT
    // It should look like this:
    // Eternal Goal:  Study the scriptures, Study for at least 10 minutes, 50
    public override string GetStringRepresentation()
    {
        return $"Eternal Goal:  {GetName()}, {GetDescription()}, {GetPoints()}";
    }

}