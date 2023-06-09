﻿namespace Calculator
{
    internal class Program
    {
        static void Addition()
        {
            Console.WriteLine("Addition");
            Console.Write("Enter the first number: ");
            double num1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter the second number: ");
            double num2 = Convert.ToDouble(Console.ReadLine());

            double result = num1 + num2;
            Console.WriteLine("Result: " + result);
        }

        static void Subtraction()
        {
            Console.WriteLine("Subtraction");
            Console.Write("Enter the first number: ");
            double num1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter the second number: ");
            double num2 = Convert.ToDouble(Console.ReadLine());

            double result = num1 - num2;
            Console.WriteLine("Result: " + result);
        }

        static void Multiplication()
        {
            Console.WriteLine("Multiplication");
            Console.Write("Enter the first number: ");
            double num1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter the second number: ");
            double num2 = Convert.ToDouble(Console.ReadLine());

            double result = num1 * num2;
            Console.WriteLine("Result: " + result);
        }

        static void Division()
        {
            Console.WriteLine("Division");
            Console.Write("Enter the dividend: ");
            double dividend = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter the divisor: ");
            double divisor = Convert.ToDouble(Console.ReadLine());

            if (divisor != 0)
            {
                double result = dividend / divisor;
                Console.WriteLine("Result: " + result);
            }
            else
            {
                throw new ArgumentException("Division by zero is not possible!");
            }
        }

        static void Main(string[] args)
        {
            bool exit = false;

            
            while (!exit)
            {
                Console.WriteLine("===== Calculator =====");
                Console.WriteLine("1. Addition ( + )");
                Console.WriteLine("2. Subtraction ( - )");
                Console.WriteLine("3. Multiplication ( * )");
                Console.WriteLine("4. Division ( / )");
                Console.WriteLine("5. Exit");
                Console.WriteLine("--------------------");
                Console.Write("Select an operation: ");

                int input = Convert.ToInt32(Console.ReadLine());

                Console.Clear();
                switch (input)
                {
                    case 1:
                        Addition();
                        break;
                    case 2:
                        Subtraction();
                        break;
                    case 3:
                        Multiplication();
                        break;
                    case 4:
                        Division();
                        break;
                    case 5:
                        exit = true;
                        break;
                    default:
                        throw new ArgumentException("Invalid choice. Please try again");
                }

                Console.WriteLine();
            }
        }
    }
}