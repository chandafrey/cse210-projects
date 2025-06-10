// Use this line pretty much everywhere in your code...also used for:
// Console, Random, DateTime List, etc.
using System;

// Use this line because you're using a List<string> in your Listing class
using System.Collections.Generic;

// Use this line if you're Reading or Writing to files
// Don't forget to put this at the top, so C# knows where to find the StreamWriter class
using System.IO;

// Use this line if you have lists and use features like .Any(), .Count(), or .Where()
using System.Linq;


// GoalManager - Manage all the classes and create a Start() to run the program...
// THEN IN PROGRAM.CS  - create a new instance of GoalManager and call goalManager.Start(); 
public class GoalManager
{
    // Create new object instances of my classes:
    // GoalBase goalBase = new GoalBase();
 
    // ATTRIBUTES
    // create a list that holds GoalBase objects
    private List<GoalBase> _goals;
    private int _score;

    // Create a list to hold Reward Descriptions for each level
    private List<Reward> _rewards;
    // Create a list to hold Points Required for each level
    private List<int> _pointsRequired;
    // create a list that tracks award milestones
    private List<int> _awardsGiven;

    // CONSTRUCTOR
    // - Initializes an empty list of goals and sets the player's score to be 0.
    public GoalManager()
    {
        _goals = new List<GoalBase>();
        _score = 0;

        _rewards = new List<Reward>();
        _pointsRequired = new List<int>();
        _awardsGiven = new List<int>();
    }

    
    // METHODS
    // ==========================================================================
    // THIS METHOD IS MY Start() To RUN THE WHOLE PROGRAM AND CALLED IN Program.cs
    // 1.  Start()
    //  - This is the "main" function for this class. 
    // It is called by Program.cs, and then runs the menu loop.
    public void Start()
    {
         // Display Welcome
        Console.WriteLine("This project is to help you create and achieve goals.");
        Console.WriteLine("Press any key to continue...");
        Console.ReadKey();
        Console.Clear();

        // Start with reading the string input from user
        // THIS NEEDS TO HAPPEN BEFORE THE WHILE LOOP STARTS
        string input = "";

        // AFTER the user keys "enter", begin the WHILE LOOP
        // - use a WHILE LOOP to keep asking the user for input until they select "8" to quit
        while (input != "8")
        {
            // Display Menu
                // "You have 0 points"
                // 
                // Menu Options:
                // 1.  Create New Goal
                // 2.  List Goals
                // 3.  Save Goals
                // 4.  Load Goals
                // 5.  Record Event
                // 6.  Create Reward
                // 7.  Display Rewards
                // 8.  Quit
                // Select a choice from the menu: (choice here)
            GetMenu();
            input = Console.ReadLine();

            // Create New Goal:
            if (input == "1")
            {
                // IF user keys "1" (CREATE NEW GOAL)
                // The types of Goals are:
                //     1.  Simple Goal
                //     2.  Eternal Goal
                //     3.  Checklist Goal
                // Which type of goal would you like to create?  (choice here- 2. Eternal Goal)
                                
                // If user keys "1", "2" or "3" - these questions display:
                // What is the name of your goal?  (answer here)
                // What is a short description of it?  (answer here)
                // What is the amount of points associated with this goal?  (answer here)
                
                // User input is read and Added to _goals list
                Console.WriteLine("Create New Goal");
                CreateGoal();
            }

            // List Goals:
            else if (input == "2")
            {
                // IF user keys "2" (LIST GOALS)
                // The goals are:
                // 1.  [ ] Give a talk  (Speak in Sacrament when asked)
                // 2.  [ ] Study the scriptures (Study for at least 10 minutes)
                // 3.  [ ] Attend the temple (Attend and perform any ordinance) -- Currently completed 0/3
                Console.WriteLine("List Goals");
                ListGoalDetails();
            }

            // Save Goals:
            else if (input == "3")
            {
                Console.WriteLine("Save Goals");
                SaveGoals();
            }

            // Load Goals:
            else if (input == "4")
            {
                Console.WriteLine("Load Goals");
                LoadGoals();
            }

            // Record Event:
            else if (input == "5")
            {
                // IF user keys "5" (RECORD EVENT)
                // The goals are:
                // 1.  Give a talk
                // 2.  Study the scriptures
                // 3.  Attend the temple
                // Which goal did you accomplish?  (answer here - 3)
                // Congratulations!  You have earned 550 points!
                // You now have 850 points.
                Console.WriteLine("Record event");
                RecordEvent();
                DeliverAward();
            }
            else if (input == "6")
            {
                Console.WriteLine("Create a Reward");
                CreateReward();
            }
            else if (input == "7")
            {
                Console.WriteLine("Display Rewards");
                DisplayRewards();
            }
            // Quit:
            else if (input == "8")
            {
                Console.WriteLine("Goodbye");
            }            
            else
            {
                Console.WriteLine("Invalid input. Please select a valid option.");
            }
        }
    }
    // End Start()======================================================

    // 2. GetMenu()
    // DISPLAY CURRENT POINTS FIRST in DisplayPlayerInfo()
    public void GetMenu()
    {
        // Display the player's score
        DisplayPlayerInfo();
        // Display Menu
        Console.WriteLine();
        Console.WriteLine("Menu Options:");
        Console.WriteLine("1.  Create New Goal");
        Console.WriteLine("2.  List Goals");
        Console.WriteLine("3.  Save Goals");
        Console.WriteLine("4.  Load Goals");
        Console.WriteLine("5.  Record Event");
        Console.WriteLine("6.  Create Reward");
        Console.WriteLine("7.  Display Rewards");
        Console.WriteLine("8.  Quit");
        Console.Write("Select a choice from the menu: ");
    }
    
    // 3.  DisplayPlayerInfo()
    // Displays the players current score.
    // ****REMEMBER - Void means you don't "return" something
    // you can print(Console.WriteLine)
    public void DisplayPlayerInfo()
    {
        // Either do math here to calculate score or
        // Create another method to GetScore()
        // and just call it here
        // int totalScore = 0;
        // foreach (GoalBase goal in _goals)
        // {
        //     totalScore += goal.GetPoints();
        //     // this is the same as saying:
        //     // totalScore = totalScore + goal.GetPoints();
        // }
        Console.WriteLine($"You have {_score} points.");
    }

    // 4.  ListGoalNames()
    // IF user keys "2" (LIST GOALS)
    // The goals are:
    // 1.  [X] Give a talk  (Speak in Sacrament when asked)
    // 2.  [ ] Study the scriptures (Study for at least 10 minutes)
    // 3.  [ ] Attend the temple (Attend and perform any ordinance) -- Currently completed 0/3
    public void ListGoalNames()
    {
        Console.WriteLine("The goals are:");
        // Call a method here to display name list?
        int index = 1;
        foreach (GoalBase goal in _goals)
        {
            // Console.WriteLine($"{index}.  {goal.GetDetailsString()}");
            index++;
        }
        
    }

    // 5.  ListGoalDetails()
    // ***USE WITH - IF USER KEYS "2" (LIST GOALS)
    //  Lists the details of each goal 
    // (including the checkbox of whether it is complete).
    // This will be for Console Display and should look like this:
    // 1.  [X] Give a talk  (Speak in Sacrament when asked)
    public void ListGoalDetails()
    {
        // Start counter at 1 to number each goal in the list
        int index = 1;
        // Loop through each goal object stored in _goals list 
        foreach (GoalBase goal in _goals)
        {
            // Print each goal's number and its details string like this:
            // 1.  [X] Give a talk  (Speak in Sacrament when asked)
            Console.WriteLine($"{index}.  {goal.GetDetailsString()}");
            // Increase the number the next goal is labeled 2., then 3.
            index++;
        }    
    }
    
    // 6.  CreateGoal()
    // Asks the user for the information about a new goal. 
    // Then, creates the goal and adds it to the list.
    // --------------------
        // IF user keys "1" (CREATE NEW GOAL)
        // The types of Goals are:
        //     1.  Simple Goal
        //     2.  Eternal Goal
        //     3.  Checklist Goal
        // Which type of goal would you like to create?  (choice here- 2. Eternal Goal)
    // ---------------------
    public void CreateGoal()
    {
        Console.WriteLine("The types of Goals are:");
        Console.WriteLine("    1.  Simple Goal");
        Console.WriteLine("    2.  Eternal Goal");
        Console.WriteLine("    3.  Checklist Goal");

        Console.Write("Which type of goal would you like to create?  ");
        string goalType = Console.ReadLine();
        if (goalType != "1" && goalType != "2" && goalType != "3")
        {
            Console.WriteLine("Invalid input.  Please Enter 1, 2, or 3.");
            Console.Write("Which type of goal would you like to create?  ");
            goalType = Console.ReadLine();
        }

        // You need local variables (name, description, points) 
        // in your CreateGoal() method to temporarily store user input before 
        // passing it into your goal class constructors.

        string name;
        string description;
        int points;
        int target;
        int bonus;

        Console.Write("What is the name of your goal?  ");
        name = Console.ReadLine();
        Console.Write("What is a short description of it?  ");
        description = Console.ReadLine();
        Console.Write("What is the amount of points associated with this goal?  ");
        
        // points = int.Parse(Console.ReadLine());
        // to prevent program from crashing if user types something non-numeric
        // write it like this instead:
        while (!int.TryParse(Console.ReadLine(), out points))
        {
            Console.Write("Please enter a valid number for points:  ");
        }


        // ****ONCE WE HAVE name, description, points, bonus and target
        // THEN WE CAN CREATE INSTANCES of our subclasses - SimpleGoal, EternalGoal, and ChecklistGoal
        if (goalType == "1")
        {
            // Create Simple Goal
            // Now we CREATE OUR OBJECT/Instance for SimpleGoal
            SimpleGoal simpleGoal = new SimpleGoal(name, description, points);
            _goals.Add(simpleGoal);
        }
        else if (goalType == "2")
        {
            // Create Eternal Goal
             EternalGoal eternalGoal = new EternalGoal(name, description, points);
            _goals.Add(eternalGoal);
        }
        else if (goalType == "3")
        {
            // We need MORE INFORMATION before creating our ChecklistGoal object
            // Ask for the target and bonus points
            Console.Write("How many times does this goal need to be accomplished for a bonus? ");
            while (!int.TryParse(Console.ReadLine(), out target))
            {
                Console.Write("Please enter a valid number for target:  ");
            }
            
            Console.Write("What is the bonus for accomplishing it that many times?  ");
            while (!int.TryParse(Console.ReadLine(), out bonus))
            {
                Console.Write("Please enter a valid number for bonus:  ");
            }
            
            // Create Checklist Goal
            int amountCompleted = 0;
            ChecklistGoal checklistGoal = new ChecklistGoal(name, description, points, bonus, target, amountCompleted);
            _goals.Add(checklistGoal);
        }
        else
        {
            Console.WriteLine("Invalid input.");
        }

    }

    // 7.  RecordEvent()
    // Asks the user which goal they have done 
    // and then records the event by 
    // calling the RecordEvent method on that goal.

    // IF user keys "5" (RECORD EVENT)
    // The goals are:
    // 1.  Give a talk
    // 2.  Study the scriptures
    // 3.  Attend the temple
    // Which goal did you accomplish?  (answer here - 3)
    // Congratulations!  You have earned 550 points!
    // You now have 850 points.
    public void RecordEvent()
    {
        Console.WriteLine("The goals are:");

        for (int i = 0; i < _goals.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {_goals[i].GetName()}");
        }
        Console.Write("Which goal did you accomplish?   ");
        // use a string to read the user's input
        string goalAccomplished = Console.ReadLine();

        if (int.TryParse(goalAccomplished, out int goalIndex) && goalIndex >= 1 && goalIndex <= _goals.Count)
        {
            int actualIndex = goalIndex - 1;
            GoalBase selectedGoal = _goals[actualIndex];

            // Call the RecordEvent() for the chosen goal
            selectedGoal.RecordEvent();

            // Add points to the total _score
            _score += selectedGoal.GetPoints();
            Console.WriteLine($"You now have {_score} points.");
        }
        else
        {
            Console.WriteLine("Invalid input.");
        }
    }

    // 8.  SaveGoals()
    // Saves the list of goals to a file.
    // SaveGoals() method needs to take in a file name as a parameter
    public void SaveGoals()
    {
        // This method will save the journal entries to a file
        // The file name will be passed in as a parameter
        // The file will be created if it does not exist
        // If the file already exists, it will be overwritten

        // Ask the user for the filename
        Console.WriteLine("What is the filename for the goal file?  ");
        string filename = Console.ReadLine();

        // Create a StreamWriter object to write to the file
        // The StreamWriter class is part of the System.IO namespace
        // "outputFile" will allow us to write the entries to the file(instead of the console)
        // The file name will be passed in as a parameter
        // The using statement will ensure that the file is closed after writing
        using (StreamWriter outputFile = new StreamWriter(filename))
        {
            // Save the score first
            outputFile.WriteLine(_score);
            // Save awards given as a comma-separated string
            // string awardsLine = string.Join(",", _awardsGiven);
            // outputFile.WriteLine(awardsLine);


            // Save awards given (indexes of rewards already delivered)
            outputFile.WriteLine("AwardsGiven:" + string.Join(",", _awardsGiven));

            // Save points required per level
            outputFile.WriteLine("PointsRequired:" + string.Join(",", _pointsRequired));

  
            // Save rewards first
            foreach (Reward reward in _rewards)
            {
                outputFile.WriteLine($"Reward: {reward.GetStringRepresentation()}");
            }

            // Loop through each goal in the _goals list and write it to the file
            foreach (GoalBase goal in _goals)
            {
                // Write the entry to the file in the format specific to each subclass
                outputFile.WriteLine($"{goal.GetStringRepresentation()}");
            }
        }

    }

    // 9.  LoadGoals()
    // Start with a GoalFactory.cs file
    // Then write this method 
    // ✅ Notes:
    // This pattern centralizes the logic for building each goal.
    // If you change the file format or add a new goal type later, you only need to update GoalFactory — not your GoalManager.
    public void LoadGoals()
    {
        // Ask user for filename for the saved goals
        Console.Write("What is the filename for the goal file? ");
        string filename = Console.ReadLine();

        // Read lines and split part for _awardsGiven list
        if (File.Exists(filename))
        {
            // Read all lines of file into string array
            string[] lines = File.ReadAllLines(filename);

            // The first line of the file is assumed to be the score, so parse it into an int
            _score = int.Parse(lines[0]);

            _rewards.Clear(); // Clear any existing rewards
            _goals.Clear();   // Clear goals before loading new ones

            
            _awardsGiven.Clear();
            _pointsRequired.Clear();


            for (int i = 1; i < lines.Length; i++)
            {
                string line = lines[i];

                try
                {
                    if (line.StartsWith("AwardsGiven:"))
                    {
                        string[] givenParts = line.Substring("AwardsGiven:".Length).Split(',');
                        foreach (string part in givenParts)
                        {
                            if (int.TryParse(part.Trim(), out int index))
                                _awardsGiven.Add(index);
                        }
                    }
                    else if (line.StartsWith("PointsRequired:"))
                    {
                        string[] pointParts = line.Substring("PointsRequired:".Length).Split(',');
                        foreach (string part in pointParts)
                        {
                            if (int.TryParse(part.Trim(), out int points))
                                _pointsRequired.Add(points);
                        }
                    }
                    else if (line.StartsWith("Reward:"))
                    {
                        string rewardData = line.Substring(7).Trim();
                        string[] parts = rewardData.Split(',');

                        if (parts.Length == 2)
                        {
                            string description = parts[0].Trim();
                            int points = int.Parse(parts[1].Trim());
                            Reward reward = new Reward(description, points);
                            _rewards.Add(reward);
                        }
                        else
                        {
                            Console.WriteLine($"Invalid reward format on line {i + 1}: {line}");
                        }
                    }
                    else
                    {
                        GoalBase goal = GoalFactory.CreateGoalFromString(line);
                        _goals.Add(goal);
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Error reading line {i + 1}: {ex.Message}");
                }
            }
        }
    }

    // 10. CreateReward()
    // Create a method to get user input for a Reward and Points Required
    //  and put that information into a _rewards list 
    public void CreateReward()
    {

        // _rewards.Clear();
        // _pointsRequired.Clear();
        // Loop thru 4 levels and get the information
        Console.WriteLine("Create a Reward for each level you accomplish.\nThere are 4 levels.\nAn example would be 'Ice cream cone at Maces.'");

        for (int i = 1; i < 5; i++)
        {
            // Ask user for Reward Description
            Console.WriteLine($"Level {i}: What reward would you like to award yourself?");
            Console.Write(">");
            string rewardDescription = Console.ReadLine();

            // Ask user for Points Required
            Console.Write($"Enter points needed to earn Level {i} reward:  ");
            int pointsRequired;
            while (!int.TryParse(Console.ReadLine(), out pointsRequired))
            {
                Console.Write("Please enter a valid number for points needed:  ");
            }   
            
            Reward reward = new Reward(rewardDescription, pointsRequired);
            _rewards.Add(reward);
            _pointsRequired.Add(pointsRequired);
            Console.WriteLine("Rewards added.");
        }
    }

    // 11.  DeliverAward()
    // Create a method to check user score 
    // if score has met the points required for the level
    // and the award has NOT already been Delivered
    // then Deliver Award
    public void DeliverAward()
    {
        // Loop over each level
        for (int i = 0; i < _pointsRequired.Count; i++)
        {
            // check if user reached point threshold
            // AND check if they haven't already recieved that level's reward
            if (_score >= _pointsRequired[i] && !_awardsGiven.Contains(i))
            {   
                _awardsGiven.Add(i);
                string rewardDescription = _rewards[i].GetRewardDescription();
                // i + 1 shows level 1 instead of index 0
                ShowReward($"You accomplished level {i + 1}!\nYour award is:  {rewardDescription}");

            }
        }
    }

    // ShowReward method to display the reward message
    private void ShowReward(string rewardMessage)
    {
        Console.Clear();
        Console.WriteLine(rewardMessage);
        Console.WriteLine("Congratulations! Enjoy your reward!");
        Console.WriteLine("Press any key to continue...");
        Console.ReadKey();
        // Console.Clear();
    }
    
    // Create a method to Display the Rewards and point required as a reminder for motivation
    public void DisplayRewards()
    {
        Console.WriteLine("Rewards and Points Required:");
        for (int i = 0; i < _rewards.Count; i++)
        {
            Console.WriteLine($"Level {i + 1}: {_rewards[i].GetRewardDescription()} (Points Required: {_rewards[i].GetPointsRequired()})");
        }
    }           
}   


    