using System;

public class Comment
{
// ATTRIBUTE/VARIABLE DECLARATION
    // -Name of variable
    // -Type of variable (string, int, etc.)
    // -Visibility of variable (private, public, protected, etc.)
    private string _commenterName;
    private string _commentText;

// CONSTRUCTORS
    // Constructor that initializes the commenter name and comment text
    // This constructor is public so that it can be accessed from outside the class
    // It takes two parameters: commenterName and commentext
    // Don't forget types for the parameters
    public Comment(string commenterName, string commentText)
    {
        // We are setting the _commenterName and _commentText variables to the values
        // passed in as parameters. This is a good choice because it is easy to remember
        // and make the connection between the two.
        // The underscore is used to indicate that these are private member variables.
        _commenterName = commenterName;
        _commentText = commentText;
    }


// METHODS
    // This method returns a string that contains the commenter's name and the comment text
    // Don't forget to type the return type of the method (this one is string)
    // ------------------------------------------
    // We do not want to use Display() here because we do not want to display the 
    // comment on the screen, we want to return it as a string where another part 
    // of the program can use it and determine how it should output.
    // -------------------------------------------
    
    public string GetCommentData()
    {
        return $"{_commenterName}: {_commentText}";
    }
}

