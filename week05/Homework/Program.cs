using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Homework Project.");

        // Test your class by returning to the Main method in the Program.cs file. 
        // Create a simple assignment, call the method to get the summary, and then display it to the screen.
        Assignment assignment = new Assignment("Samuel Bennet", "Multiplication");
        Console.WriteLine(assignment.GetSummary());



        // Test your class by returning to the Main method and creating a new MathAssignment object 
        // and set its values. Make sure to test both the GetSummary() and the GetHomeworkList() methods.
        
        // As a Child class - using attributes and methods from the Base(parent) Assignment:
        // Include all the parameters you need from both parent and child classes in your instance like this:
        // MathAssignment mathAssignment = new MathAssignment("studentName", "topic", "textbookSection", "problems");
        MathAssignment mathAssignment = new MathAssignment("Samuel Bennet", "Multiplication", "7.3", "8-19");
        Console.WriteLine(mathAssignment.GetSummary());
        Console.WriteLine(mathAssignment.GetHomeworkList());

        // As a Child class - using attributes and methods from the Base(parent) Assignment:
        // Include all the parameters you need from both parent and child classes in your instance like this:
        // WritingAssignment(string studentName, string topic, string title)
        WritingAssignment writingAssignment = new WritingAssignment("Mary Waters", "European History", "The Causes of World War II");
        Console.WriteLine(writingAssignment.GetSummary());
        Console.WriteLine(writingAssignment.GetWritingInformation());


    }
}