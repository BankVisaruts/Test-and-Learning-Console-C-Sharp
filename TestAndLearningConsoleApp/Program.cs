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
            Console.WriteLine("Input '2' : Random Number");
            Console.WriteLine("Input 'exit' : Exit");

            // Function Input
            Console.WriteLine(line);
            Console.Write("Input the number of the function you want to select : ");
            string? option = Console.ReadLine();

            // Function Option
            switch (option)
            {
                case "1":
                    bool keepRunningOption = true;
                    Console.WriteLine("Welcome to Function Even number and Odd Number.");
                    while (keepRunningOption)
                    {
                        Console.Write("Input your number : ");
                        string? number = Console.ReadLine();
                        if (number == "exit")
                        {
                            keepRunningOption = false;
                            Console.ForegroundColor = ConsoleColor.Blue;
                            Console.WriteLine("Exiting to main menu.");
                            Console.ResetColor();
                            Console.WriteLine(line);
                        }
                        else
                        {
                            Functions.funcEvenNumberAndOddNumber(number);
                        }
                    }
                    break;
                case "2":
                    bool keepRunningOption2 = true;
                    while (keepRunningOption2)
                    {
                        Console.Write("Input Random Length : ");
                        string? lengthRd = Console.ReadLine();
                        Console.Write("Input Random Count : ");
                        string? countRd = Console.ReadLine();
                        if(lengthRd == "exit" || countRd == "exit")
                        {
                            keepRunningOption2 = false;
                            Console.ForegroundColor = ConsoleColor.Blue;
                            Console.WriteLine("Exiting to main menu.");
                            Console.ResetColor();
                            Console.WriteLine(line);
                        }
                        else
                        {
                            Functions.funcRandom(lengthRd, countRd);
                        }
                    }
                    break;
                case "exit":
                    keepRunning = false;
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.WriteLine("Exiting the program. Goodbye!");
                    Console.ResetColor();
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

    public static void funcRandom(string? randomCount, string? randomLength)
    {
        // Try to parse the input strings to integers
        if (int.TryParse(randomCount, out int count) && int.TryParse(randomLength, out int length))
        {
            Random random = new Random();

            for (int i = 0; i < length; i++)
            {
                string randomNumber = "";
                for (int j = 0; j < count; j++)
                {
                    // Generate a random digit between 0 and 9
                    randomNumber += random.Next(0, 10);
                }
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine(randomNumber);
                Console.ResetColor();
            }
        }
        else
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Invalid input. Please enter valid numbers for both the count and length.");
            Console.ResetColor();
        }
    }
}