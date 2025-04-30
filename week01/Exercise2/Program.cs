using System;
using System.Globalization;
using System.Reflection.Metadata;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Exercise2 Project.");
//Write a program that determines the letter grade for a course according to the following scale:

// A >= 90
// B >= 80
// C >= 70
// D >= 60
// F < 60

// Assignment
// Start by completing the core requirements, then when that part is complete, if you have time, 
// see if you can complete some of the stretch challenges as well.
// Please work through the requirements in order rather than jumping ahead to more complicated steps, 
// to ensure that everyone is following the concepts.

// Core Requirements
// 1.  Ask the user for their grade percentage, then write a series of if, else if, else statements to 
// print out the appropriate letter grade. (At this point, you'll have a separate print statement for 
// each grade letter in the appropriate block.)

// 2.  Assume that you must have at least a 70 to pass the class. After determining the letter grade and printing it out. 
// Add a separate if statement to determine if the user passed the course, and if so display a message 
// to congratulate them. If not, display a different message to encourage them for next time.

// 3.  Change your code from the first part, so that instead of printing the letter grade in the body of each if, else if, 
// or else block, instead create a new variable called letter and then in each block, set this variable to the appropriate value. 
// Finally, after the whole series of if, else if, else statements, have a single print statement that prints the letter grade once.

        Console.Write("What is your grade percentage? ");
        int grade = int.Parse(Console.ReadLine());

// This variable is for the Core Requirements #3
        string letter = "";

        // These 2 variable are for the Stretch Challenge
        string sign = "";
        int lastDigit = grade % 10;

// remember to use parentheses on the condition of the "if" statement in C#
        if (grade >= 90)
        {
            // Console.WriteLine("You got an A.");
            letter = "A";
        }
// remember to use "else if" in C# vs elif in Python
        else if (grade >= 80)
        {
            // Console.WriteLine("You got a B.");
            letter = "B";
        }
        else if (grade >= 70)
        {
            // Console.WriteLine("You got a C.");
            letter = "C";
        }
        else if (grade >= 60)
        {
            // Console.WriteLine("You got a D.");
            letter = "D";
        }
        else
        {
            // Console.WriteLine("You got an F.");
            letter = "F";
        }

// Stretch Challenge
//1.  Add to your code the ability to include a "+" or "-" next to the letter grade, such as B+ or A-. For each grade, you'll know it
// is a "+" if the last digit is >= 7. You'll know it is a minus if the last digit is < 3 and otherwise it has no sign.

// After your logic to determine the grade letter, add another section to determine the sign. Save this sign into a variable. 
// Then, display both the grade letter and the sign in one print statement.

// Hint: To get the last digit, you could divide the number by 10, and get the remainder. You might review the standard math operators 
// and find the one that does division and gives you the remainder.

// At this point, don't worry about the exceptional cases of A+, F+, or F-.

//2. Recognize that there is no A+ grade, only A and A-. Add some additional logic to your program to detect this case and handle it correctly.

//3. Similarly, recognize that there is no F+ or F- grades, only F. Add additional logic to your program to detect these cases and handle them correctly.

        if (lastDigit >= 7) 
        {
            sign = "+";
        }
        else if (lastDigit < 3)
        {
            sign = "-";
        }
        else
        {
            sign = "";
        }

// For stretch challenge #2 and #3, we need to check for the A+ and F+ or F- cases
        if (grade >= 93)
        {
            sign = " ";
        }
        if (letter == "F")
        {
            sign = " ";
        }
    

// Print the letter grade with sign
        if (grade >= 70)
        {
            Console.WriteLine($"Congratulations, You passed the course. Your grade is: {letter}{sign}.");
        }
        else
        {
            Console.WriteLine($"You did not pass the class.  Your grade is: {letter}{sign}, but you can always retake and try again.");
        }

// THIS IS THE SAMPLE SOLUTION FRM THE EXERCISE...
// It is mostly the same as above but this first part is different
        // Console.Write("What is your grade percentage? ");
        // string answer = Console.ReadLine();
        // int percent = int.Parse(answer);

        // string letter = "";

        // if (percent >= 90)
        // {
        //     letter = "A";
        // }
        // else if (percent >= 80)
        // {
        //     letter = "B";
        // }
        // else if (percent >= 70)
        // {
        //     letter = "C";
        // }
        // else if (percent >= 60)
        // {
        //     letter = "D";
        // }
        // else
        // {
        //     letter = "F";
        // }

        // Console.WriteLine($"Your grade is: {letter}");
        
        // if (percent >= 70)
        // {
        //     Console.WriteLine("You passed!");
        // }
        // else
        // {
        //     Console.WriteLine("Better luck next time!");

    }
}