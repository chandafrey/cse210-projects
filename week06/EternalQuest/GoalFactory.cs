// Use this line pretty much everywhere in your code...also used for:
// Console, Random, DateTime List, etc.
using System;

// CLASS DECLARATION
// Make sure GoalBase is defined somewhere in your project like this:
// public abstract class GoalBase { /* ... */ }

public static class GoalFactory
{
    public static GoalBase CreateGoalFromString(string line)
    {
        if (line.StartsWith("Simple Goal:"))
        {
            string content = line.Substring("Simple Goal:".Length).Trim();
            string[] parts = content.Split(", ");

            string name = parts[0];
            string description = parts[1];
            int points = int.Parse(parts[2]);
            bool isComplete = bool.Parse(parts[3]);

            return new SimpleGoal(name, description, points, isComplete);
        }
        else if (line.StartsWith("Eternal Goal:"))
        {
            string content = line.Substring("Eternal Goal:".Length).Trim();
            string[] parts = content.Split(", ");

            string name = parts[0];
            string description = parts[1];
            int points = int.Parse(parts[2]);

            return new EternalGoal(name, description, points);
        }
        else if (line.StartsWith("Checklist Goal:"))
        {
            string content = line.Substring("Checklist Goal:".Length).Trim();
            string[] parts = content.Split(", ");

            string name = parts[0];
            string description = parts[1];
            int points = int.Parse(parts[2]);
            int bonus = int.Parse(parts[3]);
            int target = int.Parse(parts[4]);
            int amountCompleted = int.Parse(parts[5]);

            return new ChecklistGoal(name, description, points, bonus, target, amountCompleted);
        }
        else
        {
            throw new Exception($"Unknown goal type: {line}");
        }
    }
}
