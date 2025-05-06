using System;
// add this line to use the CultureInfo class and convert names to title case
using System.Globalization;
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Exercise5 Project.");
        // Call the functions in the order specified in the assignment
        // 1. DisplayWelcome    
        DisplayWelcome();
        // 2. PromptUserName
        string userName = PromptUserName();
        // 3. PromptUserNumber
        int userNumber = PromptUserNumber();
        // 4. SquareNumber
        int squaredNumber = SquareNumber(userNumber);
        // 5. DisplayResult
        DisplayResult(userName, squaredNumber);
    }
// For this assignment, write a C# program that has several simple functions:

// DisplayWelcome - Displays the message, "Welcome to the Program!"
// PromptUserName - Asks for and returns the user's name (as a string)
// PromptUserNumber - Asks for and returns the user's favorite number (as an integer)
// SquareNumber - Accepts an integer as a parameter and returns that number squared (as an integer)
// DisplayResult - Accepts the user's name and the squared number and displays them.
// Your Main function should then call each of these functions saving the return values and passing data to them as necessary.

    static void DisplayWelcome()
    {
        Console.WriteLine("Welcome to the Program!");
    }

    static string PromptUserName()
    {
        Console.Write("Please enter your name:  ");
        string name = Console.ReadLine();
        return name;
    }

    static int PromptUserNumber ()
    {
        Console.Write("Please enter your favorite number:  ");
        string input = Console.ReadLine();
        int number;

        // Validate input BEFORE parsing.
        // This is a simple way to check if the input is a valid integer
        while (!int.TryParse(input, out number))
        {
            Console.Write("Invalid input. Please enter a valid number:  ");
            input = Console.ReadLine();
        }
        return number;
    }

    static int SquareNumber(int number)
    {
        int square = number * number;
        return square;
    }

    static void DisplayResult(string name, int squaredNumber)
    {
        // Convert the name to title case using CultureInfo
        // This will ensure that the first letter of each word is capitalized
        // and the rest are in lowercase, regardless of how the user entered it.
        // name.ToLower() ensures the whole string is lowercase first
        // ToTitleCase(...) capitalizes the first letter of each word
        // and TextInfo is used to get the culture-specific text information
        TextInfo textInfo = CultureInfo.CurrentCulture.TextInfo;
        string formattedName = textInfo.ToTitleCase(name.ToLower());
        // Don't forget to use formattedName in the name space below
        Console.WriteLine($"Hello {formattedName}, your favorite number squared is {squaredNumber}.");

    }

   
}