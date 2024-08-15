using static TestAndLearningConsoleApp.Handles;
using TestAndLearningConsoleApp;

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
            Console.WriteLine("Input '3' : Multiplication Table");
            Console.WriteLine("Input '4' : Calculator");
            Console.WriteLine("Input 'exit' : Exit");

            // Function Input
            Console.WriteLine(line);
            Console.Write("Input the number of the function you want to select : ");
            string? option = Console.ReadLine();

            // Function Option
            switch (option.ToLower())
            {
                case "1":
                    HandleEvenOddNumber();
                    break;
                case "2":
                    HandleRandomNumber();
                    break;
                case "3":
                    HandleMultiplicationTable();
                    break;
                case "4":
                    HandleCalculator();
                    break;
                case "exit":
                    keepRunning = false;
                    Extensions.consoleBlue("Exiting the program. Goodbye!");
                    break;
                default:
                    Extensions.consoleRed("Invalid option. Please try again.");
                    break;
            }
        }
    }
}
