using System;

class Program
{
    static void Main(string[] args)
    {
        // Here is how you declare a simple array of strings:
        string[] names = { "John", "Mario", "Hunter", "Gabe", "Layne" };

        /* To reference a value in the array all you do is follow this format:
        * array_name[index];
        * Here is a simple example of how to print the first and second element in the array
        */
        Console.WriteLine(names[0] + ", " + names[1]);

        // -------------------------------------------------------------------------------------------------------- //
        // You can also declare an array of integers like so:
        int[] numbers = { 0, 1, 2, 3, 4, 5, 6, 7 };

        /*
        * You reference the items in the array in the same way.
        * Here is an example of the last two items in this array summed up
        */
        int sum = numbers[7] + numbers[6];

        // Write the 'sum' variable to the Console to see the result!
        // -------------------------------------------------------------------------------------------------------- //
        // You can much make array with any data type.
        // Here's how you may print the day of the week depending on a number from the user
        // Create your array
        string[] daysOfTheWeek =
        {
            "Sunday",
            "Monday",
            "Tuesday",
            "Wednesday",
            "Thursday",
            "Friday",
            "Saturday"
        };
        Console.WriteLine("Give me a number 0-6."); // Prompt the user for a number

        int userNumber = Convert.ToInt32(Console.ReadLine()); // Store the user's input as an int

        if (userNumber >= 0 && userNumber <= 6) // Ensure the user's number is within the appropriate range
        {
            Console.WriteLine("You have selected " + daysOfTheWeek[userNumber]); // Print a message using the user's input as the index of the array
        }
        else
        {
            Console.WriteLine("Invalid number.");
        }

        // -------------------------------------------------------------------------------------------------------- //
        // ----------------------------------------- ASSIGNMENT START --------------------------------------------- //
        // -------------------------------------------------------------------------------------------------------- //
        WriteArrayMessage();

        FindSumOfElements();

        FindNegatives();

        FindMinimum();

        FindMaximum();

        FindAverage();

        CountEvenAndOdds();

        WriteReverse();

        WriteNames();
    }

    public static void WriteArrayMessage()
    {
        // Using the following array, write "I love learning about arrays" by referencing the items in the correct order
        string[] words = { "arrays", "I", "about", "learning", "love" };
    }

    public static void FindSumOfElements()
    {
        // Find the sum of all the elements of the array
        int[] nums = { 62, 21, 10, 2, 5 };
    }

    public static void FindNegatives()
    {
        // Write all of the negative numbers in the array to the console
        int[] nums = { -2, -10, 16, 10, 0, 1, -5, 6, -9 };
    }

    public static void FindMinimum()
    {
        // Find and write the minimum number in this array to the console
        int[] nums = { -2, -10, 16, 10, 0, 1, -5, 6, -9 };
    }

    public static void FindMaximum()
    {
        // Find and write the maximum number in this array to the console
        int[] nums = { -2, -10, 16, 10, 0, 1, -5, 6, -9 };
    }

    public static void FindAverage()
    {
        // Find and write the average of the array to the console
        int[] nums = { -2, -10, 16, 10, 0, 1, -5, 6, -9 };
    }

    public static void CountEvenAndOdds()
    {
        // Count the number of even and odd numbers in the array
        int[] nums = { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13 };
    }

    public static void WriteReverse()
    {
        // Write the array in reverse
        int[] nums = { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
    }

    public static void WriteNames()
    {
        /* Sorry guys, but I'm not going to give you the array for this one!
        *
        *  Your goal is to create an array whose elements are the the names of every student in the class.
        *  AM only needs to reference AM students; PM only needs to reference PM. Second years ARE part of the class.
        *  There are 24 total students in each class. You will be marked down 1 point for every classmate you miss do not include
        *  in your array.
        *
        *  After you create the array, your task is to output a message saying:
        *  "Here is the list of all students in our class: John, Mario, Hunter..."
        *
        *  I am not going to help you with this one.
        */
    }
}
