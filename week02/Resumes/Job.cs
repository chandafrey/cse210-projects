
// Create a new file for your job class. By convention this should be named Job.cs .
// Create the class (Hint this is the public class Job syntax).
// Create member variables in the class for each element that this class should contain. By convention these member variables should begin with an underscore and a lowercase letter such as _jobTitle 

// Return to your Job.cs file and add a method (member function) to display the job details. This method should not have any parameters and does not need to return anything. By convention, this method should begin with a capital letter, such as Display, and if you have multiple words each word should be capitalized, such as DisplayJobDetails .
// This method should display the job details on the screen in the correct format. Remember that the method can access the member variables directly, without needing them to be passed into it.
// Return to your Program.cs file. Remove the lines of code where you displayed the company earlier, and replace them with calls to your new method. Remember that you call the method using the same dot notation such as job1.Display(); .


public class Job
{
// Use public string _company { get; set; } when:
// You're exposing the value publicly
// You might need logic later (validation, events, etc.)
// You're working with frameworks like ASP.NET or WPF

// Use public string _company; when:
// You need something quick and simple
// It's internal to the class, and no one else touches it

// ***So in this exercise, we would be fine to just say 
// public string _company; but we will use the property syntax***
    public string _company { get; set; }
    public string _jobTitle { get; set; }
    public int _startYear { get; set; }
    public int _endYear { get; set; }
    
    
    public void Display()
    {
        Console.WriteLine($"{_jobTitle} ({_company}) {_startYear}-{_endYear}");
    }

}

