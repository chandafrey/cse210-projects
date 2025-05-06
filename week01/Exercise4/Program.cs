using System;
using System.Collections.Generic;
using System.Linq; // This is the same as saying import random in python


class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Exercise4 Project.");
// Ask the user for a series of numbers, and append each one to a list. Stop when they enter 0. 
// (Remember: You should not add 0 to the list. If you do, later calculations and operations will not be correct.)

// Once you have a list, have your program do the following:

// Core Requirements
    // 1.  Compute the sum, or total, of the numbers in the list.
    // 2.  Compute the average of the numbers in the list.
    // 3.  Find the maximum, or largest, number in the list.
    // ---------------------------------------------------------------------

    
    // Create an EMPTY list to store the numbers.
        List<int> numbers = new List<int>();
        // this is same as saying:
        // numbers = [] in python when you want to create an empty list

    // Start with asking the user for a number, and THEN use a while loop to keep asking for numbers until they enter 0.
        Console.WriteLine("Enter a list of numbers, type 0 when finished.");
    
    // Your int number variable should be declared outside of the loop, so that it can be used later in the program.
    // Also, it needs to be equal to something other than 0, so the loop will Run at least once.
        int number = -1;

    // NOW, use a while loop to keep asking for numbers until the user enters 0.
        while (number != 0)
        {
            // Ask the user for a number.
            Console.Write("Enter a number: ");
            // Read the number from the console.  This is the same as saying input() in python
            string input = Console.ReadLine();
            // number does not need int here, because it is already declared above
            // number = int.Parse(input); // This is the same as saying number = int(input) in python
            number = int.Parse(input);

    // If the user enters a number that is not 0, add it to the numbers list.
            if (number != 0)
            {
                numbers.Add(number);
                // This is the same as saying:
                // numbers.append(number) in python
            }
        }
    // Print the list of numbers to the console so we can see what we entered.
    // Console.WriteLine(numbers); // This will not work, because it will not print the list in a readable format.
    // Instead, we can use string.Join to convert the list to a string and print it.
    // This will print the list of numbers in a readable format.
        Console.WriteLine("You entered the following numbers: ");
        Console.WriteLine(string.Join(", ", numbers));
        // This is the same as saying print(", ".join(numbers)) in python


    // Now that we have a list of numbers, We can use a for loop to iterate through the list and do some calculations.
    // We can also use LINQ to do some calculations with the list.  

    // 1.  COMPUTE THE SUM OF THE NUMBERS IN THE LIST. 
    // Remember to declare the variable to store the sum outside of the loop, so it can be used later in the program.
        int sum = 0;
        // This is the same as saying sum = 0 in python

        for (int i = 0; i < numbers.Count; i++)
        // This is the same as saying for i in range(len(numbers)) in python
        // which means, start at 0 and go throught the list one by one until you reach the end of the list.
        // i is the loop counter and increases by 1 each time through the loop.
        // numbers.Count is the same as saying len(numbers) in python
        {
            sum += numbers[i]; 
            // This is the same as saying sum = sum + numbers[i] in python
            // which means "add the number at index i to the sum"
            // or in other words, "sum the numbers in the list"
        }
        // Print the sum to the console.
        Console.WriteLine($"The sum of the numbers is: {sum}");

    //  2.  COMPUTE THE AVERAGE OF THE NUMBERS IN THE LIST.
    // The average is the sum of the numbers divided by the number of numbers in the list.
        int average = sum / numbers.Count;
        // This is the same as saying average = sum / len(numbers) in python
        // Print the average to the console.
        Console.WriteLine($"The average of the numbers is: {average}");

    // 3.  FIND THE MAXIMUN NUMBER IN THE LIST.
        int max = numbers.Max();
        // print the largest number to the console.
        Console.WriteLine($"The largest number is: {max}");


// ---------------------------------------------------------------------
// Stretch Challenge
    // 1.  Have the user enter both positive and negative numbers, 
    // then find the smallest positive number (the positive number that is closest to zero).

    // 2.  Sort the numbers in the list and display the new, sorted list. 
    // Hint: There are C# libraries that can help you here, try searching the internet for them.
// ---------------------------------------------------------------------


    // 1.  FIND THE SMALLEST POSITIVE NUMBER IN THE LIST.
    // Create a variable to store the smallest positive number and set it to the largest possible integer value. 
        int smallestPositive = int.MaxValue;
        // int.MaxValue is the largest possible integer value in C#.

        // Now use a "for loop" to iterate through the list.
        // This is the same as saying for i in range(len(numbers)) in python
        // numbers.Count is the same as saying len(numbers) in python
        // int i = 0 means create a variable i (the loop counter) and start it at 0 which is the first index of the list.
        // i < numbers.count - This is the condition that keeps the loop going.  
        // numbers.Count is how many items are in the list, so keep looping while i is less than the number of items.
        // i++ means increase the value of i by 1 each time through the loop.
        for (int i = 0; i < numbers.Count; i++)
        {
            if (numbers[i] > 0 && numbers[i] < smallestPositive)
            // This is saying "if the number is greater than 0 (a positive number) and smaller than the 
            // smallest positive number found so far (which is initially set to the largest possible integer value),
            // then set smallestPositive to that number.
            {
                smallestPositive = numbers[i];
            }
        }
        // Print the smallest positive number to the console.
        Console.WriteLine($"The smallest positive number is: {smallestPositive}");
        
// ---------------------------------------------------------------------
        // Another way to do this is to use LINQ to find the smalles positive number.
        // We can use the WHERE method to filter the list and then use the MIN method to find the smallest number.
    
        // LINQ stands for Language Integrated Query.
        // It's a feature in C# that lets you query collections like lists (and databases, arrays, etc.) in a clean, 
        // readable way — almost like using filters or searches in natural language.
        
        // INCLUDE this line at the top of your code to use LINQ:
        // using System.Linq

        // .Where() is a LINQ method that filters a list and CREATES a new list that only contains items that match a condition you give it.
        // Using the numbers list from above, we can filter it to only include positive numbers.
        // My list might look like this: 
        // List<int> numbers = new List<int> {5, 6, -3, 7, -2};
       
        // Use .Where() to filter the list to only include positive numbers and create a new list called positiveNumbers.
        List<int> positiveNumbers = numbers.Where(n => n > 0).ToList(); 
        // This is the same as saying:
        // positiveNumbers = [n for n in numbers if n > 0] in python
        // This means "Create a new list called positiveNumbers that contains only the numbers from the original list that are greater than 0."
        // numbers is the original list
        // .Where(n => n > 0) means "Go through each number n in the list and keep it only if it's greater than 0."
        // .ToList() converts the result back into a normal list you can use.

        // print the positiveNumbers list to the console so we know it worked.
        Console.WriteLine("The positive numbers are: ");
        Console.WriteLine(string.Join(", ", positiveNumbers)); 

        // Before we can find the smallest positive number, we need to check if the list is empty.
        // If it is empty, we can't find the smallest positive number.
        // If it is not empty, we can use the .Min() method to find the smallest positive number.
        // .Min() is a LINQ method that finds the smallest number in a list.
        if (positiveNumbers.Count > 0)
        // .Count is a property that tells us how many items are in the list.
        // it is the same as saying len(positiveNumbers) in python
        {
            int smallestPositiveNumber = positiveNumbers.Min(); 
            Console.WriteLine($"The smallest positive number is: {smallestPositiveNumber}");
        }
        else
        {
            Console.WriteLine("No positive numbers were entered.");
        }


    // 2.  SORT THE LIST OF NUMBERS.
        numbers.Sort(); 
        // This is the same as saying numbers.sort() in python
        Console.WriteLine("The sorted list of numbers is: ");
        Console.Write(string.Join(", ", numbers));   
         
    }
}