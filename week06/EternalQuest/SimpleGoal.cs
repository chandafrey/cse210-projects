using System;

// CLASS DECLARATION
public class SimpleGoal : GoalBase
{
  // ATTRIBUTES
  // ******Attributes Already In GoalBase*****
  // private string _name;
  // private string _description;
  // private int _points;
  // ******************************************
  private bool _isComplete;

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
  
  // 1.  Create constructor with _isComplete to false and 
  // NOT in constructor because the value is already false
  // since the goal was just created
  // Used for NEW GOALS
  public SimpleGoal(string name, string description, int points) : base(name, description, points)
  {
    // Set _isComplete to false
    _isComplete = false;
  }

  // 2.  Create constructor with _isComplete to isComplete is true
  // AND INLCUDE in Constructor
  // When loading goals from a saved file, some of them
  // may already be complete so then we need that value passed in
  // Used for LOADING FROM A FILE
  public SimpleGoal(string name, string description, int points, bool isComplete) : base(name, description, points)
  {
    // Set _isComplete to isComplete
    _isComplete = isComplete;
  }


  //  METHODS 
  // 1.  RecordEvent()
  //  Purpose of RecordEvent() in SimpleGoal:
  // Mark the goal as complete.
  // Return the point value awarded for completing the goal.
  // Optionally show a message like "You earned X points!"

  // This method should do whatever is necessary for each specific kind of goal, 
  // such as MARKING A SIMPLE GOAL COMPLETE. 
  // It should return the point value associated with recording the event 
  // I think this means saying in a WriteLine how many points earned
  // and not actually Returning points because this method type is void
  public override void RecordEvent()
  {
    // Has this goal Not been completed Yet?
    // _isComplete means completed
    // !_isCompleted means Not completed
    if (!_isComplete)
    {
      _isComplete = true;
      int points = GetPoints();
      Console.WriteLine($"Congratulations!  You have earned {points} points!");
    }
  }

  // 2.  IsComplete()
  // For a bool we are answering the question:
  // "Has this goal been completed yet?"
  // The attribute _isComplete above was set to false
  // and so we can just return that value as _isComplete

  // This method returns the current value of the _isComplete field,
  // which tracks whether the goal has been completed.
  // Other parts of the program can call this method to check status.
  public override bool IsComplete()
  {
      return _isComplete;
  }

  // 3.  Adding this SetIsComplete()
  // Not sure how this works...but currently my load goals needs it
  // public override void SetIsComplete(bool isComplete)
  // {
  //   _isComplete = isComplete;
  // }


  // 4.  GetStringRepresentation()
  //  This method should provide all of the details of a 
  // goal in a way that is easy to save to a file, and then load later.
  // **REMEMBER THIS IS FOR THE TEXT FILE FORMAT
  // It should look like this:
  // Simple Goal:  Give a talk, Speak in Sacrament meeting when asked, 100, True
  public override string GetStringRepresentation()
  {
    return $"Simple Goal:  {GetName()}, {GetDescription()}, {GetPoints()}, {IsComplete()}";
  }

  
}