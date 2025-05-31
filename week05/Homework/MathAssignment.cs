using System;

// Create the MathAssignment class
// Create a new file for the MathAssignment class.
// Create this class and make sure to specify that it inherits from the base Assignment class.
// Add the attributes as private member variables. Make sure that you do not create new member variables for the ones you inherited from the base class.
// Create a constructor for your class that accepts all four parameters, have it call the base class constructor to set the base class attributes that way.
// Add the GetHomeworkList() method.
// Test your class by returning to the Main method and creating a new MathAssignment object and set its values. Make sure to test both the GetSummary() and the GetHomeworkList() methods.


// CLASS DECLARATION - WITH INHERITANCE FROM BASE(parent) CLASS - Assignment

public class MathAssignment : Assignment
{
    // ATTRIBUTE NAMES
    // ******Attributes Already In Assignment*****
    // private string _studentName;
    // private string _topic;
    // ******************************************
    private string _textbookSection;
    private string _problems;

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
    public MathAssignment(string studentName, string topic, string textbookSection, string problems) : base(studentName, topic)
    {
        _textbookSection = textbookSection;
        _problems = problems;
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
    public string GetHomeworkList()
    {
        return $"Section:  {_textbookSection} Problems:  {_problems}"; 
    }
}