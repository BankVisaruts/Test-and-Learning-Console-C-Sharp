using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static TestAndLearningConsoleApp.Functions;
using TestAndLearningConsoleApp;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace TestAndLearningConsoleApp
{
    public class Handles
    {
        // Get the width of the console window
        private static readonly int consoleWidth = Console.WindowWidth;
        private static readonly string line = new string('-', consoleWidth);

        public static void HandleEvenOddNumber()
        {
            bool keepRunningOption = true;
            Console.WriteLine("Welcome to Function Even number and Odd Number.");
            while (keepRunningOption)
            {
                Console.Write("Input your number : ");
                string? number = Console.ReadLine();
                if (number.ToLower() == "exit")
                {
                    keepRunningOption = false;
                    Extensions.consoleBlue("Exiting to main menu.");
                    Console.WriteLine(line);
                }
                else
                {
                    funcEvenNumberAndOddNumber(number);
                }
            }
        }

        public static void HandleRandomNumber()
        {
            bool keepRunningOption = true;
            Console.WriteLine("Welcome to Function Random Number.");
            while (keepRunningOption)
            {
                Console.Write("Input Random Length : ");
                string? lengthRd = Console.ReadLine();
                Console.Write("Input Random Count : ");
                string? countRd = Console.ReadLine();
                if (lengthRd.ToLower() == "exit" || countRd.ToLower() == "exit")
                {
                    keepRunningOption = false;
                    Extensions.consoleBlue("Exiting to main menu.");
                    Console.WriteLine(line);
                }
                else
                {
                    funcRandom(lengthRd, countRd);
                }
            }
        }

        public static void HandleMultiplicationTable()
        {
            bool keepRunningOption = true;
            Console.WriteLine("Welcome to Function Multiplication Table.");
            while (keepRunningOption)
            {
                Console.Write("Input Multiplication Table Number : ");
                string? multiNumber = Console.ReadLine();
                if (multiNumber.ToLower() == "exit")
                {
                    keepRunningOption = false;
                    Extensions.consoleBlue("Exiting to main menu.");
                    Console.WriteLine(line);
                }
                else
                {
                    funcMultiplicationTable(multiNumber);
                }
            }
        }

        public static void HandleCalculator()
        {
            bool keepRunningOption = true;
            Console.WriteLine("Welcome to Function Calculator.");
            while (keepRunningOption)
            {
                Console.Write("Input number and mathematical operator : ");
                string? multiNumber = Console.ReadLine();
                if (multiNumber.ToLower() == "exit")
                {
                    keepRunningOption = false;
                    Extensions.consoleBlue("Exiting to main menu.");
                    Console.WriteLine(line);
                }
                else
                {
                    funcCalculator(multiNumber);
                }
            }
        }

        public static void HandleDrawPyramid()
        {
            bool keepRunningOption = true;
            Console.WriteLine("Welcome to Function Draw Pyramid.");
            while (keepRunningOption)
            {
                Console.Write("Input the height of the pyramid: ");
                string? multiNumber = Console.ReadLine();
                if (multiNumber.ToLower() == "exit")
                {
                    keepRunningOption = false;
                    Extensions.consoleBlue("Exiting to main menu.");
                    Console.WriteLine(line);
                }
                else
                {
                    funcDrawPyramid(multiNumber);
                }
            }
        }

        public static void HandleRandomIdCard()
        {
            bool keepRunningOption = true;
            Console.WriteLine("Welcome to Function Random ID Card.");
            while (keepRunningOption)
            {
                Console.Write("Please enter the number of rounds: ");
                string? count = Console.ReadLine();
                if (count.ToLower() == "exit")
                {
                    keepRunningOption = false;
                    Extensions.consoleBlue("Exiting to main menu.");
                    Console.WriteLine(line);
                }
                else
                {
                    funcRandomIdCard(count);
                }
            }
        }

        public static void HandleYesOrNo()
        {
            bool keepRunningOption = true;
            Console.WriteLine("Welcome to Function Yes or No.");
            while (keepRunningOption)
            {
                Console.Write("Please input rounds: ");
                string? choice = Console.ReadLine();
                if (choice.ToLower() == "exit")
                {
                    keepRunningOption = false;
                    Extensions.consoleBlue("Exiting to main menu.");
                    Console.WriteLine(line);
                }
                else
                {
                    funcYesOrNo(choice);
                }
            }
        }

        public static void HandlePrimeNumberCheck()
        {
            bool keepRunningOption = true;
            Console.WriteLine("Welcome to Function Prime Number Check.");
            while (keepRunningOption)
            {
                Console.Write("Please input number: ");
                string? number = Console.ReadLine();
                if (number.ToLower() == "exit")
                {
                    keepRunningOption = false;
                    Extensions.consoleBlue("Exiting to main menu.");
                    Console.WriteLine(line);
                }
                else
                {
                    funcPrimeNumberCheck(number);
                }
            }
        }

        public static void HandleCheckCountLotterySimulation()
        {
            bool keepRunningOption = true;
            Console.WriteLine("Welcome to Function Check Count Lottery Simulation.");
            while (keepRunningOption)
            {
                Console.Write("Please input Lottery number: ");
                string? number = Console.ReadLine();
                if (number.ToLower() == "exit")
                {
                    keepRunningOption = false;
                    Extensions.consoleBlue("Exiting to main menu.");
                    Console.WriteLine(line);
                }
                else
                {
                    funcCheckCountLotterySimulation(number);
                }
            }
        }

        public static void HandleCheckCountLotterySimulation2Digi()
        {
            bool keepRunningOption = true;
            Console.WriteLine("Welcome to Function Check Count Lottery Simulation.");
            while (keepRunningOption)
            {
                Console.Write("Please input Lottery number: ");
                string? number = Console.ReadLine();
                if (number.ToLower() == "exit")
                {
                    keepRunningOption = false;
                    Extensions.consoleBlue("Exiting to main menu.");
                    Console.WriteLine(line);
                }
                else
                {
                    funcCheckCountLotterySimulation(number);
                }
            }
        }
    }
}
