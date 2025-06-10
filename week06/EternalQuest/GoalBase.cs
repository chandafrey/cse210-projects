// Use this line pretty much everywhere in your code...also used for:
// Console, Random, DateTime List, etc.
using System;

// Use this line because you're using a List<string> in your Listing class
using System.Collections.Generic;

// GoalBase - 
// Add the goal member variable and a getter and setter for it.
// Create a constructor that accepts the goal and sets it


// CLASS DECLARATION
// * See the comment below about the abstract method. Because we have an abstract method,
// this class must also be declared as an abstract class.
public abstract class GoalBase
{    
    // ATTRIBUTES
    private string _name;
    private string _description;
    private int _points;
  
    // CONSTRUCTOR
    public GoalBase(string name, string description, int points)
    {
        _name = name;
        _description = description;
        _points = points;
    }

    // GETTERS/SETTERS
    public string GetName()
    {
        return _name;
    }
    public void SetName(string name)
    {
        _name = name;
    }
    // *******
    public string GetDescription()
    {
        return _description;
    }
    public void SetDescription(string description)
    {
        _description = description;
    }
    // *******
    // MAKE THIS VIRTUAL so we can OVERRIDE in sub classes
    public virtual int GetPoints()
    {
        return _points;
    }
    public void SetPoints(int points)
    {
        _points = points;
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
    // why would i say GoalBase goal = new SimpleGoal() instead of SimpleGoal goal = new SimpleGoal()
        // ChatGPT said:
        // Great question — both are valid, but they serve different purposes depending on 
        // what you're trying to do. Here's a breakdown:

        // ~~~~~~~~~~~~~~~~~~~~~~~~~~`
        // ✅ SimpleGoal goal = new SimpleGoal();
        // You're declaring a specific type.

        // You can call any method that belongs to SimpleGoal or its base GoalBase.

        // Use this when you know you're only working with SimpleGoal-specific behavior.

        // SimpleGoal goal = new SimpleGoal("Run", "Run 5 miles", 100);
        // goal.CheckIfSimpleOnly(); // you can call methods specific to SimpleGoal
        // ✅ GoalBase goal = new SimpleGoal();
        // ********You're using polymorphism: the variable is of the base class,
        //  but the object is actually a SimpleGoal.*******

        // You can only call methods defined in the base class (GoalBase), 
        // even if the object is a SimpleGoal.

        // Use this when you want to treat different types of goals the same way, 
        // like when storing them in a list.

        // ~~~~~~~~~~~~~~~~~~~~~~~~~
        // GoalBase goal = new SimpleGoal("Run", "Run 5 miles", 100);
        // goal.RecordEvent(); // this works if RecordEvent is an abstract/virtual method in GoalBase
        // 🧠 Why Use the Base Type?
        // When you're working with multiple goal types:

        // List<GoalBase> goals = new List<GoalBase>();
        // goals.Add(new SimpleGoal(...));
        // goals.Add(new EternalGoal(...));
        // goals.Add(new ChecklistGoal(...));

        // // Loop through all and treat them generically
        // foreach (GoalBase g in goals)
        // {
        //     g.RecordEvent(); // calls the correct override automatically
        // }
        // This lets you treat all the goal types interchangeably when you're working at the GoalBase level — even though each has its own behavior underneath.
        // -----------------------------------------------------------------


    // // This method should do whatever is necessary for each specific kind of goal, 
    // - such as marking a simple goal complete 
    // - and adding to the number of times a checklist goal has been completed. 
    // - It should return the point value associated with recording the event 
    // (keep in mind that it may contain a bonus in some 
    // cases if a checklist goal was just finished, for example).
    public abstract void RecordEvent();

    // 2.  IsComplete()
    // This method should return true if the goal is completed. 
    // The way you determine if a goal is complete is different for each type of goal.
    public abstract bool IsComplete();

    // 3.  GetDetalsString()
    // In addition to recording the event and checking if it is complete. 
    // - Each goal will need to be shown in a list (with the checkbox etc), 
    
    // - Also each one will need a string representation: 
    // that can be saved to a text file. 
    // These should also be declared in the base class and overridden in the derived classes as needed:

    // This method is not abstract and needs more details
    //  This method should return the details of a goal that could be 
    // shown in a list. 
    // -It should include the checkbox, the short name, and description. 
    // Then in the case of the ChecklistGoal class, it should be
    // overridden to shown the number of times the goal has been accomplished so far.
    
    // the GetDetailsString method has a default implementation and is 
    // only overridden by the ChecklistGoal class.
    // and not the other two derived classes.
    public virtual string GetDetailsString()
    {
        // Use [X] if complete, [] if not

        // This line is using a ternary conditional operator and reads like this
        // If IsComplete() return true, then status = "[X]". Otherwise, status = "[]"
        // The syntax is this:
        // condition ? result_if_true : result_if_false;
        string status = IsComplete() ? "[X]" : "[]";

        // ---------------------------------
        // That was shorthand for an if/else statement
            // string status;
            // if (IsComplete() == true)
            // {
            //     status = "[X]";
            // }
            // else
            // {
            //     status = "[ ]";
        // ------------------------------------

        // The directions said to show the checkbox, name and description
        // It also said to show the details that could be shown in a list
        // so I don't know if I should also include a {GetPoints()}
        // 1.  [ ] Give a talk  (Speak in Sacrament when asked)
        return $"{status} {GetName()} ({GetDescription()})";
    }
    
    // 4.  GetStringRepresentation()
    // This method should provide all of the details of a goal in a way 
    // that is easy to save to a file, and then load later.
    public abstract string GetStringRepresentation();
    
}