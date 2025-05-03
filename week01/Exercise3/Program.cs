using System;
using System.Net;
using System.Runtime.InteropServices;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Exercise3 Project.");
// 1.  Start by asking the user for the magic number. (In future steps, we will change this to have the computer 
// generate a random number, but to get started, we'll just let the user decide what it is.)

// Ask the user for a guess.
// Using an if statement, determine if the user needs to guess higher or lower next time, or tell them if they guessed it.
// At this point, you won't have any loops.

// 2.  Add a loop that keeps looping as long as the guess does not match the magic number.
// At this point, the user should be able to keep playing until they get the correct answer.

// 3.  Instead of having the user supply the magic number, generate a random number from 1 to 100.
// Play the game and make sure it works!

// Stretch Challenge:
// 1.  Add a counter to keep track of how many guesses the user has made.  When they guess the magic number, tell them how many guesses it took.
// 2.  After the game is over, ask the user if they want to play again. Then, loop back and play the whole game again and continue this loop as long as they keep saying "yes".
// 3.  Add a way to keep track of the best score (the lowest number of guesses) and display that to the user when they finish playing.
        
        // This is how it is written in my lesson.  Chatgpt says this is fine, but may be more
        // wordy than necessary for just numbers
        // Random randomGenerator = new Random();
        // int number = randomGenerator.Next(1, 11);
        
        
        
        
        Random random = new Random();
        int magicNumber = random.Next(1, 11); // Generate a random number between 1 and 100
        int guess = 0;
        int attempts = 0;
        string playAgain = "yes";

        while (playAgain.ToLower() == "yes")
        {
            Console.WriteLine("Guess the magic number between 1 and 100:");
            while (guess != magicNumber)
            {
                guess = Convert.ToInt32(Console.ReadLine());
                attempts++;

                if (guess < magicNumber)
                {
                    Console.WriteLine("Higher! Try again.");
                }
                else if (guess > magicNumber)
                {
                    Console.WriteLine("Lower! Try again.");
                }
                else
                {
                    Console.WriteLine($"Congratulations! You guessed the magic number {magicNumber} in {attempts} attempts.");
                }
            }

            Console.WriteLine("Do you want to play again? (yes/no)");
            playAgain = Console.ReadLine();
            if (playAgain.ToLower() == "yes")
            {
                magicNumber = random.Next(1, 101); // Generate a new random number for the next game
                guess = 0;
                attempts = 0;
            }        
        
    }
    }
}



        
            
        
