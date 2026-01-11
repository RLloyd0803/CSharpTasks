using System;

class Task3
{
    static void Main()
    {
        // Declare and initialize the array
        int[] numbers = { 3, 7, 12, 19, 21, 25, 30 };

        // Ask the user for input
        Console.Write("Enter a number to search for: ");
        int searchNumber = Convert.ToInt32(Console.ReadLine());

        bool found = false;

        // Use a for loop to go through the array
        for (int i = 0; i < numbers.Length; i++)
        {
            // Compare the user input to each element
            if (numbers[i] == searchNumber)
            {
                Console.WriteLine($"Number found at position {i}!");
                found = true;
                break; // Exit the loop immediately
            }
        }

        // If the number was not found
        if (!found)
        {
            Console.WriteLine("Number not found in the list.");
        }
    }
}
