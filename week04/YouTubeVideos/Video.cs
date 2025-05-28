using System;
using System.Collections.Generic;

public class Video
{
    // ATTRIBUTE/VARIABLE DECLARATION
    // We need to track title, author, length(in seconds), and 
    // a list of comments for each video.
    // --------------------------------
    // include "using System.Collections.Generic;" at the top of the file if using List<>
    // --------------------------------
    // -Visibility of variable (private, public, protected, etc.)
    // -Type of variable (string, int, etc.)
    // -Name of variable
    private string _title;
    private string _author;
    private int _length; // in seconds
    private List<Comment> _comments;


    // CONSTRUCTOR
    // ----------------------------------
    // We are NOT going to add List<Comment> comments in the parameters because:
        // Encapsulation: You’re keeping control over how the comments list is managed inside the Video class.
        // Flexibility: You can start with an empty list and add comments later using your AddComment() method.
        // Cleaner constructor: Fewer parameters make the constructor easier to use and read.
        // Avoids confusion: If you always expect comments to be added after the video is created, it avoids needing to pass a list up front.
    // ----------------------------------
    public Video(string title, string author, int length)
    {
        // We are setting the _title, _author, and _length variables to the values
        // passed in as parameters. This is a good choice because it is easy to remember
        // and make the connection between the two.
        // The underscore is used to indicate that these are private member variables.
        _title = title;
        _author = author;
        _length = length;
        _comments = new List<Comment>(); // Initialize an empty list if no comments are provided
    }

    // METHODS

    // 1. GetVideoData()
    // This method returns a string that contains the video title, author, and length
    public string GetVideoData()
    {
        return $"Video Title: {_title}, Author: {_author}, Length: {_length} seconds";
    }

    // 2. AddComment()
    // Each video has responsibility to store a list of comments, 
    // This method will take in a new comment and add it to the list of comments
    // Inside the parentheses (type of parameter) - Use Comment class as data type
    // Inside the parentheses (name of parameter) - Use newComment
    // This method will not return anything, so return type is void
    public void AddComment(Comment newComment)
    {
        // use .Add to the _comments list that was created above in the Constructor
        _comments.Add(newComment);
    }

    // 3.  GetDisplayComments()
    // This method will loop through each comment in the _comments List and RETURN the list of comments
    public List<string> GetDisplayComments()
    {
        List<string> commentList = new List<string>();
        foreach (Comment comment in _comments)
        {
            commentList.Add(comment.GetCommentData());
        }
        // *** Notice the return is outside the foreach loop:
        // - We want to add ALL the comments to the list
        // - If we returned inside the loop, it would stop after the first comment
        return commentList;
    }

    // 4.  GetNumberOfComments()
    // Each video should have a method to return the number of comments
    // This method will Count and RETURN the number of comments in the list
    public int GetNumberOfComments()
    {
        // ✅ Rule of Thumb:
        // For counting items in a list → use .Count
        // For doing something with each item → use foreach
        return _comments.Count;
    }
    

}