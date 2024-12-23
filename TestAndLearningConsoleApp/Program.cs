﻿using static TestAndLearningConsoleApp.Handles;
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
            Console.WriteLine("Input '5' : Draw Pyramid");
            Console.WriteLine("Input '6' : Random ID Card");
            Console.WriteLine("Input '7' : Yes or No");
            Console.WriteLine("Input '8' : Prime Number Check");
            Console.WriteLine("Input '9' : Check Count Lottery Simulation");
            Console.WriteLine("Input '10' : Check Count Lottery Simulation 2 Digit");
            Console.WriteLine("Input '11' : Fortune Teller");
            Console.WriteLine("Input '12' : Countdown Timer");
            Console.WriteLine("Input '13' : Calculate BMI");
            Console.WriteLine("Input '14' : Number Guessing Game"); //
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
                case "5":
                    HandleDrawPyramid();
                    break;
                case "6":
                    HandleRandomIdCard();
                    break;
                case "7":
                    HandleYesOrNo();
                    break;
                case "8":
                    HandlePrimeNumberCheck();
                    break;
                case "9":
                    HandleCheckCountLotterySimulation();
                    break;
                case "10":
                    HandleCheckCountLotterySimulation2Digit();
                    break;
                case "11":
                    HandleFortuneTeller();
                    break;
                case "12":
                    HandleCountdownTimer();
                    break;
                case "13":
                    HandleCalculateBMI();
                    break;
                case "exit":
                    keepRunning = false;
                    Extensions.consoleBlue("Exiting the program. Goodbye!");
                    break;
                default:
                    Extensions.consoleRed("Invalid option. Please try again (e.g., '1').");
                    break;
            }
        }
    }
}
