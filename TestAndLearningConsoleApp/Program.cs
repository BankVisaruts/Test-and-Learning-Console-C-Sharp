using System;

class Program
{
    static void Main()
    {
        // Get the width of the console window
        int consoleWidth = Console.WindowWidth;
        string line = new string('-', consoleWidth);

        // Main
        Console.WriteLine("--- Hello Welcome to Test and Learning Console App C# ---");
        Console.WriteLine(line);

        bool keepRunning = true;

        while (keepRunning)
        {
            // Function Detail
            Console.WriteLine("Please select function Test and Learning");
            Console.WriteLine("Input '1' : Even numbers, odd numbers");
            Console.WriteLine("Input '0' : Exit");

            // Function Input
            Console.WriteLine(line);
            Console.Write("Input the number of the function you want to select: ");
            string? option = Console.ReadLine();

            // Function Option
            switch (option)
            {
                case "1":
                    Console.Write("Input your number: ");
                    string? number = Console.ReadLine();
                    Functions.funcEvenNumberAndOddNumber(number);
                    break;
                case "0":
                    keepRunning = false;
                    Console.WriteLine("Exiting the program. Goodbye!");
                    break;
                default:
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Invalid option. Please try again.");
                    Console.ResetColor();
                    break;
            }
        }
    }
}

public class Functions
{
    public static void funcEvenNumberAndOddNumber(string? number)
    {
        //Convert int
        if (int.TryParse(number, out int cvNumber))
        {
            if (cvNumber % 2 == 0)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("{0} is an Even Number", cvNumber);
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("{0} is an Odd Number", cvNumber);
            }
        }
        else
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Invalid input. Please enter a valid number.");
        }

        Console.ResetColor();
    }
}