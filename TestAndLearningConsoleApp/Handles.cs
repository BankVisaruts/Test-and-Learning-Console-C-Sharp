using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static TestAndLearningConsoleApp.Functions;
using TestAndLearningConsoleApp;

namespace TestAndLearningConsoleApp
{
    public class Handles
    {
        public static void HandleEvenOddNumber(string line)
        {
            bool keepRunningOption = true;
            Console.WriteLine("Welcome to Function Even number and Odd Number.");
            while (keepRunningOption)
            {
                Console.Write("Input your number : ");
                string? number = Console.ReadLine();
                if (number == "exit")
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

        public static void HandleRandomNumber(string line)
        {
            bool keepRunningOption = true;
            Console.WriteLine("Welcome to Function Random Number.");
            while (keepRunningOption)
            {
                Console.Write("Input Random Length : ");
                string? lengthRd = Console.ReadLine();
                Console.Write("Input Random Count : ");
                string? countRd = Console.ReadLine();
                if (lengthRd == "exit" || countRd == "exit")
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

        public static void HandleMultiplicationTable(string line)
        {
            bool keepRunningOption = true;
            Console.WriteLine("Welcome to Function Multiplication Table.");
            while (keepRunningOption)
            {
                Console.Write("Input Multiplication Table Number : ");
                string? multiNumber = Console.ReadLine();
                if (multiNumber == "exit")
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

        public static void HandleCalculator(string line)
        {

        }
    }
}
