// Use this line pretty much everywhere in your code...also used for:
// Console, Random, DateTime List, etc.
using System;

// Use this line because you're using a List<string> in your Listing class
using System.Collections.Generic;


// This class purpose is to DEFINE what a reward is...The tracking of reward names and points required are in GoalManager
// CLASS DECLARATION
public class Reward
{
    
    // ATTRIBUTES
    private string _rewardDescription;
    private int _pointsRequired;

    // CONSTRUCTOR
    public Reward (string rewardDescription, int pointsRequired)
    {
        _rewardDescription = rewardDescription;
        _pointsRequired = pointsRequired;
    }

    // GETTERS/SETTERS
     public string GetRewardDescription()
    {
        return _rewardDescription;
    }
    public void SetRewardDescription(string rewardDescription)
    {
        _rewardDescription = rewardDescription;
    }
    // *******
    public int GetPointsRequired()
    {
        return _pointsRequired;
    }
    public void SetPointsRequired(int pointsRequired)
    {
        _pointsRequired = pointsRequired;
    }
    // *******

    public string GetStringRepresentation()
    {
        return $"{_rewardDescription}, {_pointsRequired}";
    }

   
}
