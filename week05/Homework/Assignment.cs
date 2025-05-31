using System;

// Create the base class
// Begin by creating a new file and a class for your base Assignment class.
// Add the attributes as private member variables.
// Create a constructor for this class that receives a student name and topic and sets the member variables.
// Add the method for GetSummary() to return the student's name and the topic.
// Test your class by returning to the Main method in the Program.cs file. Create a simple assignment, call the method to get the summary, and then display it to the screen.


// CLASS DECLARATION
public class Assignment
{
    // ATTRIBUTE NAMES
    private string _studentName;
    private string _topic;

    // CONSTRUCTOR
    // *remember in the parameters just write the name of the attribute without the underscore_
    public Assignment(string studentName, string topic)
    {
        _studentName = studentName;
        _topic = topic;
    }


    // METHODS
    public string GetSummary()
    {
        // *remember you are using underscores _ here, because:
        //  we are refering to the private fields _studentName and _topic...
        // They are like labeled "boxes" that store the values inside the object
        return $"Student Name:  {_studentName} - Topic:  {_topic}";
    }

    // Adding a GETTER/SETTER here so WritingAssignment can access studentName
        // Get method (GetStudentName)
        // Purpose: Read the value of a private field (_studentName)
        // Without this, outside code can’t access the student name because _studentName is private.
    public string GetStudentName()
    {
        return _studentName;
    }

        // Set method (SetStudentName)
        // Purpose: Write or update the value of a private field.
        // Without this, you can’t change _studentName after the object is created (except from inside the class).
    public void SetGetStudentName(string studentName)
    {
        _studentName = studentName;
    }



    
}