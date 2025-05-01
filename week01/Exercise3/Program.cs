using System;

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

        int magicNumber = 20;
        string response = "yes";

        while (response == "yes")
        {
            Console.WriteLine("Guess the magic number between 1 and 100:");
            int guess = int.Parse(Console.ReadLine());

            
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
                    Console.WriteLine($"Congratulations! You guessed the magic number {magicNumber}.");
             }

            Console.Write("Do you want to play again? (yes/no)");
            response = Console.ReadLine();
        }
     

        
            
        



        // Random random = new Random();
        // int magicNumber = random.Next(1, 101); // Random number between 1 and 100
        // int guess = 0;
        // int attempts = 0;
        // bool playAgain = true;

        // while (playAgain)
        // {
        //     Console.WriteLine("Guess the magic number between 1 and 100:");
        //     while (guess != magicNumber)
        //     {
        //         guess = int.Parse(Console.ReadLine());
        //         attempts++;

        //         if (guess < magicNumber)
        //         {
        //             Console.WriteLine("Higher! Try again.");
        //         }
        //         else if (guess > magicNumber)
        //         {
        //             Console.WriteLine("Lower! Try again.");
        //         }
        //         else
        //         {
        //             Console.WriteLine($"Congratulations! You guessed the magic number {magicNumber} in {attempts} attempts.");
        //         }
        //     }

        //     Console.WriteLine("Do you want to play again? (yes/no)");
        //     string response = Console.ReadLine().ToLower();
        //     playAgain = response == "yes";

        //     if (playAgain)
        //     {
        //         magicNumber = random.Next(1, 101);
        //         guess = 0;
        //         attempts = 0;
        //     }
        // }
    }
}