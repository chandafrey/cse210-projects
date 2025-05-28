using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the YouTubeVideos Project.");

// Once you have the classes in place, write a program that:
// - creates 3-4 videos, 
// - sets the appropriate values, 
// - and for each one add a list of 3-4 comments (with the commenter's name and text). 
// Put each of these videos in a list.
    
    // Create comments with commenter's name
    // These must be declared and assigned BEFORE THEY ARE USED!
    Comment comment1 = new Comment("Alice", "Great video!");
    Comment comment2 = new Comment("Bob", "Thanks for sharing!");   
    Comment comment3 = new Comment("Charlie", "Very informative!");
    Comment comment4 = new Comment("Dave", "I learned a lot from this!");
    Comment comment5 = new Comment("Eve", "This was helpful, thanks!");
    Comment comment6 = new Comment("Frank", "I appreciate the effort you put into this video!");


    // Create some video objects with comments
    // Each video will have a title, author, length in seconds, and a list of comments ADDED
    Video video1 = new Video("Understanding C# Classes", "Jane Doe", 300);
    video1.AddComment(comment1);
    video1.AddComment(comment2);
    video1.AddComment(comment3);
    
    Video video2 = new Video("Advanced C# Programming", "John Smith", 600);
    video2.AddComment(comment4);
    video2.AddComment(comment5);
    video2.AddComment(comment6);

    Video video3 = new Video("C# for Beginners", "Alice Johnson", 450);
    video3.AddComment(comment1);
    video3.AddComment(comment3);
    video3.AddComment(comment5);

// -------------------------------------------------------------
  
//  Then, have your program iterate through the list of videos and for each one, 
// - display the title, author, length, 
// - number of comments (from the method) 
// - and then list out all of the comments for that video. 
// - Repeat this display for each video in the list.
   
    // Create a LIST OF VIDEOS and loop through them to display their data
    // we can add the videos {video1, ...like this when we know all the items 
    // we want to add at the time of creating the list}
    List<Video> videos = new List<Video> {video1, video2, video3};
    foreach (Video video in videos)
    {
        Console.WriteLine(video.GetVideoData());
        Console.WriteLine($"Number of Comments: {video.GetNumberOfComments()}");
        // ALSO display a list of comments for each video
        foreach (string comment in video.GetDisplayComments())
        {
            Console.WriteLine(comment);          
        }

        // Add visual separation between videos
        Console.WriteLine(new string('-', 40));
    }



    }
}