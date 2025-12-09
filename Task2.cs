using System;

namespace CSharpTasks
{
    public class Task2
    {
        public static void Main(string[] args)
        {
            // Declare and initialize the 2D jagged array
            int[][] numberMatrix = new int[][]
            {
                // Row 0: Even numbers
                new int[] { 2, 4, 6, 8, 10},

                //Row 1: Odd numbers
                new int [] { 1, 3, 5, 7, 9}
            };
            
            Console.WriteLine("The number matrix has ben initialized.");

            //Puzzle clues:
            //Digit 1 Row 1, Index 3 (7)
            //Digit 2 Row 0, Index 0 (2)
            //Digit 3 Row 1, Index 4 (9)
            
            int digit1 = numberMatrix[1][3]; // 7
            int digit2 = numberMatrix[0][0]; // 2
            int digit3 = numberMatrix[1][4]; // 9

            // Combine digits into a 3-digit key
            string finalKey = $"{digit1}{digit2}{digit3}";

            // Output
            Console.WriteLine("The fina; 3-digit password is: " + finalKey);
        }
    }
}