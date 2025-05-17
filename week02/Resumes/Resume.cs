using System.Reflection.Metadata.Ecma335;

// Create a new file for your Resume class. Each class should be in its own file and the file name should match the name of the class.
// Create the Resume class.
// Create the member variable for the person's name.
// Create the member variable for the list of Jobs. (Hint: the data type for this should be List<Job> , 
// and it is probably easiest to initialize this to a new list right when you declare it..)

// Return to your Resume class and add a method to display its details.
// This method should not have any parameters and should not return anything.
// In the method body, you should display the person's name and then iterate through each Job instance in the list of jobs and display them.
// Hint: remember that you can call each job's Display method that you created earlier.
// Return to your main function, remove any code that is displaying information, and instead, add a call at the end to the Display method from your Resume class to display the name and all the jobs in one line.

public class Resume
{
    public string _name { get; set;}

    // Field declaration with initialization(this is not a constructor)
    // The constructor you are calling is "new List<Job>()"....This creates a new empty list of Job objects.
    public List<Job> _jobs = new List<Job>();

    public void Display()
    {
        // Display the name of the person
        Console.WriteLine($"Name: {_name}");
        Console.WriteLine("Jobs: ");
        // Loop through each job in the _jobs list and call the Display method on each one
        foreach (Job job in _jobs)
        {
            job.Display();
        }
    }
    

}