using System;

namespace StudentReportCardApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter Total Students : ");
            int totalStudents;

            while (!int.TryParse(Console.ReadLine(), out totalStudents) || totalStudents <= 0)
            {
                Console.Write("Invalid input. Enter a valid number of students: ");
            }

            // Multi-dimensional array
            // Columns: 0 = Name, 1 = English, 2 = Math, 3 = Computer, 4 = Total
            object[,] students = new object[totalStudents, 5];

            for (int i = 0; i < totalStudents; i++)
            {
                Console.WriteLine("*********************************************");
                Console.Write("Enter Student Name : ");
                students[i, 0] = Console.ReadLine();

                students[i, 1] = GetMarks("English");
                students[i, 2] = GetMarks("Math");
                students[i, 3] = GetMarks("Computer");

                int total = (int)students[i, 1]
                          + (int)students[i, 2]
                          + (int)students[i, 3];

                students[i, 4] = total;
            }

            // Sort students by total marks (descending order)
            for (int i = 0; i < totalStudents - 1; i++)
            {
                for (int j = i + 1; j < totalStudents; j++)
                {
                    if ((int)students[i, 4] < (int)students[j, 4])
                    {
                        for (int k = 0; k < 5; k++)
                        {
                            object temp = students[i, k];
                            students[i, k] = students[j, k];
                            students[j, k] = temp;
                        }
                    }
                }
            }

            // Display report card
            Console.WriteLine("****************Report Card*******************");

            for (int i = 0; i < totalStudents; i++)
            {
                Console.WriteLine("****************************************");
                Console.WriteLine(
                    "Student Name: " + students[i, 0] +
                    ", Position: " + (i + 1) +
                    ", Total:"
                );
                Console.WriteLine(students[i, 4] + "/300");
            }

            Console.WriteLine("****************************************");
        }

        // Method to validate marks input
        static int GetMarks(string subject)
        {
            int marks;
            Console.Write("Enter " + subject + " Marks (Out Of 100) : ");

            while (!int.TryParse(Console.ReadLine(), out marks) || marks < 0 || marks > 100)
            {
                Console.Write("Invalid input. Enter " + subject + " Marks (0-100): ");
            }

            return marks;
        }
    }
}
