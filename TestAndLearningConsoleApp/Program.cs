using System;

class Program
{
    static void Main()
    {
        //Main
        Console.WriteLine("--- Hello Welcome to Test and Learning Console App C# ---");
        Console.WriteLine("---------------------------------------------------------");
        Console.WriteLine("Please select function Test and Learning");

        //Functon Detail
        Console.WriteLine("Input '1' : Even numbers, odd numbers");

        //Function Input
        Console.WriteLine("---------------------------------------------------------");
        Console.Write("Input the number of the function you want to select : ");
        string? option = Console.ReadLine();

        //Functoin Option
        switch (option)
        {
            case ("1"):
                Console.Write("Input your number : ");
                string? number = Console.ReadLine();
                Functions.funcEvenNumberAndOddNumber(number);
                break;
            default:
                Console.WriteLine("Invalid option. Please try again.");
                break;
        }

        // Wait process
        Console.ReadLine();
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
                Console.WriteLine("{0} is an Even Number", cvNumber);
            }
            else
            {
                Console.WriteLine("{0} is an Odd Number", cvNumber);
            }
        }
        else
        {
            Console.WriteLine("Invalid input. Please enter a valid number.");
        }
    }
}