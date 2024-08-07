﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestAndLearningConsoleApp;

namespace TestAndLearningConsoleApp
{
    public class Functions
    {
        public static void funcEvenNumberAndOddNumber(string? number)
        {
            if (int.TryParse(number, out int cvNumber))
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("{0} is an {1} Number", cvNumber, cvNumber % 2 == 0 ? "Even" : "Odd");
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
            if (int.TryParse(randomCount, out int count) && int.TryParse(randomLength, out int length))
            {
                Random random = new Random();
                for (int i = 0; i < length; i++)
                {
                    string randomNumber = "";
                    for (int j = 0; j < count; j++)
                    {
                        randomNumber += random.Next(0, 10);
                    }
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine(randomNumber);
                }
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Invalid input. Please enter valid numbers for both the count and length.");
            }
            Console.ResetColor();
        }

        public static void funcMultiplicationTable(string? number)
        {
            if (int.TryParse(number, out int cvNumber))
            {
                for (int i = 1; i <= 12; i++)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("{0} x {1} = {2}", cvNumber, i, cvNumber * i);
                }
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Invalid input. Please enter a valid number.");
            }
            Console.ResetColor();
        }

        public static void funcCalculator(string? input)
        {
            try
            {
                // ตรวจสอบว่า input มีตัวเลขและเครื่องหมายที่ถูกต้องหรือไม่
                if (string.IsNullOrEmpty(input) || !input.Any(char.IsDigit))
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Invalid input. Please enter a valid calculation (e.g., '1+2+3').");
                    Console.ResetColor();
                    return;
                }

                // คำนวณค่าที่ต้องการโดยใช้ DataTable.Compute ซึ่งจะจัดการลำดับความสำคัญของเครื่องหมายให้อัตโนมัติ
                var result = new DataTable().Compute(input, null);

                // แสดงผลลัพธ์
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("{0} = {1}", input, result);
            }
            catch (Exception ex)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("An error occurred: " + ex.Message);
            }
            finally
            {
                Console.ResetColor();
            }
        }
    }
}
