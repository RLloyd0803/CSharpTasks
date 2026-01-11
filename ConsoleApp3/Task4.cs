using System;

class CalculatorApp
{
    static void Main()
    {
        char choice = 'Y';

        while (choice == 'Y' || choice == 'y')
        {
            Console.WriteLine("Press any following key to perform an arithmetic operation:");
            Console.WriteLine("1 - Addition");
            Console.WriteLine("2 - Subtraction");
            Console.WriteLine("3 - Multiplication");
            Console.WriteLine("4 - Division");

            Console.Write("Enter your choice: ");
            int operation = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter Value 1: ");
            double value1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter Value 2: ");
            double value2 = Convert.ToDouble(Console.ReadLine());

            double result = 0;
            bool validOperation = true;

            switch (operation)
            {
                case 1:
                    result = Add(value1, value2);
                    Console.WriteLine($"{value1} + {value2} = {result}");
                    break;

                case 2:
                    result = Subtract(value1, value2);
                    Console.WriteLine($"{value1} - {value2} = {result}");
                    break;

                case 3:
                    result = Multiply(value1, value2);
                    Console.WriteLine($"{value1} * {value2} = {result}");
                    break;

                case 4:
                    if (value2 == 0)
                    {
                        Console.WriteLine("Error: Division by zero is not allowed.");
                    }
                    else
                    {
                        result = Divide(value1, value2);
                        Console.WriteLine($"{value1} / {value2} = {result}");
                    }
                    break;

                default:
                    Console.WriteLine("Invalid choice.");
                    validOperation = false;
                    break;
            }

            Console.Write("Do you want to continue again (Y/N)? ");
            choice = Convert.ToChar(Console.ReadLine());

            Console.WriteLine();
        }
    }

    // Separate methods for arithmetic operations
    static double Add(double a, double b)
    {
        return a + b;
    }

    static double Subtract(double a, double b)
    {
        return a - b;
    }

    static double Multiply(double a, double b)
    {
        return a * b;
    }

    static double Divide(double a, double b)
    {
        return a / b;
    }
}
