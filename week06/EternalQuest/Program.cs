// EXCEEDING REQUIREMENTS
// I created 2 more options for the menu - Create Reward, Display Rewards 
// 1. Create Reward:
// User has 4 levels of Reward they can Define and set points required to achieve
// 2. Display Rewards:
// User can display the 4 levels of rewards and point required as a reminder of their 
// goals they are reaching for.

using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the EternalQuest Project.");
        GoalManager goalManager = new GoalManager();
        goalManager.Start();
    }
}