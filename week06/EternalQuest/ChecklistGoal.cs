using System;

// CLASS DECLARATION
public class ChecklistGoal : GoalBase
{
    // ATTRIBUTES
    // ******Attributes Already In GoalBase*****
    // private string _name;
    // private string _description;
    // private int _points;
    // ******************************************
    private int _amountCompleted;
    private int _target;
    private int _bonus;

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
    // while '_amountCompleted', '_target', and '_bonus' are specific to this ChecklistGoal class.
    // ------------------------------------------------

    // ***REMEMBER to include the int target and int bonus in the Constructor
    // -------------------------
    // CheckListGoal(name : string, description : string, points : int, target : int, bonus : int) -
    //  In addition to the standard attributes, a checklist goal also needs the target and the bonus amounts. 
    // Then, it should set the amount completed to begin at 0.

    // I origionally set _amountComplete to 0 and it didn't work with the rest of my code.So its set to amountCompleted
    // and I included it in my constructor
    // --------------------------
    public ChecklistGoal(string name, string description, int points, int bonus, int target, int amountCompleted) : base(name, description, points)
    {
        _amountCompleted = amountCompleted;
        _target = target;
        _bonus = bonus;
    }
    
    
    // GETTERS/SETTERS
    public int GetAmountCompleted()
    {
        return _amountCompleted;
    }
    public void SetAmountCompleted(int amountCompleted)
    {
        _amountCompleted = amountCompleted;
    }
    // *******
    public int GetTarget()
    {
        return _target;
    }
    public void SetTarget(int target)
    {
        _target = target;
    }
    // *******
    public int GetBonus()
    {
        return _bonus;
    }
    public void SetBonus(int bonus)
    {
        _bonus = bonus;
    }



    // METHODS
    // 1  GetPoints()
    // Override GetPoints to return accumulated points as well as bonus points
    public override int GetPoints()
    {
        // if this goal is completed then return points + bonus
        if (IsComplete())
        {
            // -----------------------
            // ✅ What is base?
            // In C#, base refers to the parent class (also called the base class) from which a class inherits.
            // 🎯 Why use base?
            // Because you’re overriding the method in the child class, calling base.GetPoints() 
            // ensures you still use the original logic from the base, and then extend or modify it.
            // This is useful when you want to reuse the logic from the base class but add 
            // something extra in the subclass.
            // -----------------------
            return base.GetPoints() + _bonus;
        }
        // otherwise just return points for 1 time completed
        else
        {
            return base.GetPoints();
        }
    }

    // 2.  RecordEvent()
    // This method should do whatever is necessary for each specific kind of goal, 
    // It should return the point value associated with recording the event 
    // I think this means saying in a WriteLine how many points earned
    // and not actually Returning points because this method type is void
    public override void RecordEvent()
    {
        // Because this is a ChecklistGoal, 
        // increment _amountCompleted each time the event is recorded.  
        // You only mark it complete when the target is reached
        _amountCompleted++;

        int points = GetPoints();
        // Use if (_amountCompleted == _target) when:
        // You want to trigger something once, only when the goal is 
        // just now completed (like awarding bonus points).
        if (_amountCompleted == _target)
        {   
            Console.WriteLine($"Congratulations!  You have earned {points} points!");
            Console.WriteLine($"You completed the checklist and recieved a bonus of {_bonus} points");
        }
        else
        {
            Console.WriteLine($"Congratulations!  You have earned {points} points!");
        }
        
        // ⚠️ If you use if (IsComplete()), then:
        // That will be true every time after the goal is completed. 
        // So the bonus message might repeat if RecordEvent() gets called again.
        // SO THE POINT IS: 
        // use _amountCompleted >= _target
    }

    // 3.  IsComplete()
    // For a bool we are answering the question:
    // "Has this goal been completed yet?"
    // This method should return true if the goal is completed. 
    // It is true when:
    //  _amountCompleted is > =  _target
    public override bool IsComplete()
    {
        return _amountCompleted >= _target;
    }

    // 4.  GetDetailString()
    // This method should return :
    // the details of a goal that could be shown in a list. 
    // It should include the checkbox, the short name, and description. 
    
    // ****Then in the case of the ChecklistGoal class, it should be overridden 
    // to shown the number of times the goal has been accomplished so far.
    public override string GetDetailsString()
    {
        string status = IsComplete() ? "[X]" : "[ ]";
        return $"{status} {GetName()} ({GetDescription()}) ~ Currently completed {GetAmountCompleted()}/{GetTarget()})";
    }

    // 5.  GetStringRepresentation()
    // This method should provide all of the details of a 
    // goal in a way that is easy to save to a file, and then load later.
    // **REMEMBER THIS IS FOR THE TEXT FILE FORMAT
    // It should look like this:
    // Checklist Goal:  Attend the temple, Attend and perform any ordinance, 50, 500, 3, 0    public override string GetStringRepresentation()
    public override string GetStringRepresentation()
    {
        return $"Checklist Goal:  {GetName()}, {GetDescription()}, {GetPoints()}, {GetBonus()}, {GetTarget()}, {GetAmountCompleted()}";
    }
}