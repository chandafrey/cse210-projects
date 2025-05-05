using System;
using System.Drawing;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Sandbox Project.");
        Random randomGenerator = new Random();
        int number = randomGenerator.Next(1, 20);

        Console.Write("enter a number between 1 and 20: ");
        string answer = Console.ReadLine();
        int guess = int.Parse(answer);
        
        while (guess != number)
        {
            Console.Write ("what is your guess? ");
            // answer = Console.ReadLine();
            if (guess > number)
            {
                Console.Write("lower");
            }
            else if (guess < number)
            {
                Console.Write("higher");
            }
            else
            {
                Console.Write("correct");
            }
            // how do break out of the loop?
         
        }
    }
}