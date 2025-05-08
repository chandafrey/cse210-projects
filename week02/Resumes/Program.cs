using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Resumes Project.");

// Create a new job instance named job1 .
// Set the member variables using the dot notation (for example, job1._jobTitle = "Software Engineer";
// Verify that you can display the company of this job on the screen, again using the dot notation to access the member variable.
// Create a second job, set its variables, display this company on the screen as well.


// Return to your Program.cs. Add the end of the Main function, create a new instance of the Resume class.
// Add the two jobs you created earlier, to the list of jobs in the resume object.
// Verify that you can access and display the first job title using dot notation similar to myResume._jobs[0]._jobTitle .

// Return to your main function, remove any code that is displaying information, and instead, add a call at the end to the 
// Display method from your Resume class to display the name and all the jobs in one line.


//  from the Job class-----------------------
        // Create a new Job object
        Job job1 = new Job();
        job1._company = "Microsoft";
        job1._jobTitle = "Software Engineer";
        job1._startYear = 2019;
        job1._endYear = 2022;
        
        // Display the job details
        job1.Display();


        // Create another Job object
        Job job2 = new Job();
        job2._company = "Apple";
        job2._jobTitle = "Manager";
        job2._startYear = 2022;
        job2._endYear = 2023;
        // Display the job details
        job2.Display();

// from the Resume class------------------------
        // Create a new Resume object
        Resume myResume = new Resume();
        myResume._name = "Allison Rose";
        
        myResume._jobs.Add(job1);
        myResume._jobs.Add(job2);
        
        // Display the resume details
        myResume.Display();
    
        

    }
}