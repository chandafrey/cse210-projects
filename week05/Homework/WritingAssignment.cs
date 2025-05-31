using System;

// Create the WritingAssignment class
// Follow the same pattern as before by creating a new file for the WritingAssignment class.
// Create the class and set up the inheritance relationship.
// Add the member variables and set up the constructor as you did for the MathAssignment class.
// Add the GetWritingInformation() method.
// Notice that this method needs to access the _studentName variable defined in the base class. Even though WritingAssignment class inherited this attribute, it is private, so you cannot access it directly in the derived class.

// To get the data you need for the method you can either make the variable protected in the base class, or you can create a public GetStudentName method to return it.

// Return to Main and test your new class.


// CLASS DECLARATION - WITH INHERITANCE FROM BASE(parent) CLASS - Assignment

public class WritingAssignment : Assignment
{
    // ATTRIBUTE NAMES
    // ******Attributes Already In Assignment*****
    // private string _studentName;
    // private string _topic;
    // ******************************************
    private string _title;

    // CONSTRUCTOR
    // *****Constructor Already in Assignment*****
    // *remember in the parameters just write the name of the attribute without the underscore_
    // public Assignment(string studentName, string topic)
    // {
    //     _studentName = studentName;
    //     _topic = topic;
    // }
    // ******************************************
    
    // This is a child class that inherits from the base (parent) class Assignment.
    // To inherit the parent class's constructor parameters, include them in the child class's constructor.
    // Then, use a colon (:) followed by the keyword 'base', passing the inherited parameters to the base constructor.
    // Example:
    // public MathAssignment(string inherited1, string inherited2, string childParam1, string childParam2) 
    //     : base(inherited1, inherited2)
    //
    // In this constructor, 'studentName' and 'topic' are passed to the base Assignment class,
    // while 'textbookSection' and 'problems' are specific to this MathAssignment class.
    public WritingAssignment(string studentName, string topic, string title) : base(studentName, topic)
    {
        _title = title;
    }


    // METHODS
    // *****Method Already in Assignment*****
    // public string GetSummary()
    // {
    //     // *remember you are using underscores _ here, because:
    //     //  we are refering to the private fields _studentName and _topic...
    //     // They are like labeled "boxes" that store the values inside the object
    //     return $"Student Name:  {_studentName} - Topic:  {_topic}";
    // }
    // ******************************************
    public string GetWritingInformation()
    {
        return $"Title:  {_title} by {GetStudentName()}"; 
    }
}
