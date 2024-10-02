using System;
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

                // result
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

        public static void funcDrawPyramid(string? height)
        {
            if (int.TryParse(height, out int heightOut))
            {
                for (int i = 1; i <= heightOut; i++)
                {
                    // สร้างช่องว่างด้านซ้าย
                    string spaces = new string(' ', heightOut - i);

                    // สร้างชั้นพีระมิดโดยใช้ตัวอักษร x (เพิ่มเป็น 2*i-1 เพื่อให้เป็นทรงพีระมิด)
                    string pyramidLevel = new string('x', 2 * i - 1);

                    // แสดงผลลัพธ์ในแต่ละชั้น
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine(spaces + pyramidLevel);
                }
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Invalid input. Please enter a valid number.");
            }
            Console.ResetColor();
        }

        public static void funcRandomIdCard(string? number)
        {
            if (int.TryParse(number, out int cvNumber))
            {
                Console.ForegroundColor = ConsoleColor.Green;
                for (int i = 0; i < cvNumber; i++)
                {
                    Random random = new Random();
                    int[] idCardArray = new int[13];

                    // สุ่มตัวเลข 12 หลักแรก
                    for (int j = 0; j < 12; j++)
                    {
                        idCardArray[j] = random.Next(0, 10);
                    }

                    // คำนวณเลขตรวจสอบหลักที่ 13
                    int sum = 0;
                    for (int k = 0; k < 12; k++)
                    {
                        sum += idCardArray[k] * (13 - k);
                    }

                    int checkDigit = (11 - (sum % 11)) % 10;
                    idCardArray[12] = checkDigit;
                    var result = string.Join("", idCardArray);

                    Console.WriteLine(result);
                }
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Invalid input. Please enter a valid number.");
            }
            Console.ResetColor();
        }

        public static void funcYesOrNo(string? input)
        {
            try
            {
                if (string.IsNullOrEmpty(input) || !input.Any(char.IsDigit))
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Invalid input. Please enter a rounds.");
                    Console.ResetColor();
                    return;
                }

                var resultYes = 0;
                var resultNo = 0;
                var resultAVG = "No";
                var rounds = int.Parse(input);
                Random random = new Random();
                for (int i = 0; i < rounds; i++)
                {
                    // สร้าง random เพื่อสุ่มระหว่าง 0 และ 1
                    var result = random.Next(2) == 1 ? resultYes++ : resultNo++;
                }
                
                //result avg
                if (rounds > 0)
                {
                    resultAVG = resultYes >= rounds / 2 ? "Yes" : "No";
                }

                //result response
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Rounds : {0}", rounds);
                Console.WriteLine("Yes : {0}", resultYes);
                Console.WriteLine("No : {0}", resultNo);
                Console.WriteLine("Result : {0}", resultAVG);
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

        public static bool IsPrime(int num)
        {
            if (num <= 1) return false; //จำนวนที่น้อยกว่าหรือเท่ากับ 1 ไม่ใช่จำนวนเฉพาะ
            for (int i = 2; i <= Math.Sqrt(num); i++)
            {
                if (num % i == 0) return false; //หากหารลงตัว แสดงว่าไม่ใช่จำนวนเฉพาะ
            }
            return true; //จำนวนเฉพาะ
        }

        public static void funcPrimeNumberCheck(string? number)
        {
            if (int.TryParse(number, out int cvNumber))
            {
                if (IsPrime(cvNumber))
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("{0} is a Prime Number", cvNumber);
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("{0} is not a Prime Number", cvNumber);
                }
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Invalid input. Please enter a valid number.");
            }
            Console.ResetColor();
        }

        public static void funcCheckCountLotterySimulation(string? input)
        {
            //ตรวจสอบว่า input เป็นเลข 6 หลักหรือไม่ (รวมถึงกรณีที่มี 0 นำหน้า)
            if (input != null && input.Length == 6 && int.TryParse(input, out int targetNumber))
            {
                Random random = new Random();
                int count = 0;
                int randomNumber = -1;  //ตั้งค่าเริ่มต้นให้ต่างจาก 0 เพื่อไม่ให้ชนกับตัวเลขที่สุ่มได้

                // สุ่มเลขตั้งแต่ 000000 ถึง 999999
                do
                {
                    randomNumber = random.Next(0, 1000000);  //สุ่มเลข 6 หลักรวมถึง 000000
                    count++;
                } while (randomNumber != targetNumber);

                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("It took {0} tries to match the lottery number {1:D6}.", count, targetNumber);
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Invalid input. Please enter a valid 6-digit number.");
            }
            Console.ResetColor();
        }

        public static void funcCheckCountLotterySimulation2Digit(string? input)
        {
            //ตรวจสอบว่า input เป็นเลข 2 หลักหรือไม่ (รวมถึงกรณีที่มี 0 นำหน้า)
            if (input != null && input.Length == 2 && int.TryParse(input, out int targetNumber))
            {
                Random random = new Random();
                int count = 0;
                int randomNumber = -1;  //ตั้งค่าเริ่มต้นให้ต่างจาก 0 เพื่อไม่ให้ชนกับตัวเลขที่สุ่มได้

                // สุ่มเลขตั้งแต่ 00 ถึง 99
                do
                {
                    randomNumber = random.Next(0, 100);  //สุ่มเลข 2 หลักรวมถึง 00
                    count++;
                } while (randomNumber != targetNumber);

                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("It took {0} tries to match the lottery number {1:D2}.", count, targetNumber);
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Invalid input. Please enter a valid 2-digit number.");
            }
            Console.ResetColor();
        }

        public static void funcFortuneTeller(string? input)
        {
            // ตรวจสอบว่า input เป็นเลข 1 หลักหรือไม่ (เลข 1 หลักเพื่อใช้เลือกคำทำนาย)
            if (input != null && input.Length == 1 && int.TryParse(input, out int targetNumber))
            {
                string[] fortunes = {
                "You will have a great day!",
                "Good luck is coming your way.",
                "You will find what you're looking for.",
                "Prepare for a surprise today!",
                "Challenges will make you stronger.",
                "Success is within your reach.",
                "An exciting opportunity will come your way.",
                "Take a chance today and it will pay off.",
                "Someone close to you has good news.",
                "A positive change is coming soon."
                };

                int index = 0;

                for (int i = 0; i < targetNumber; i++)
                {
                    // สุ่มคำทำนาย
                    Random random = new Random();
                    index = random.Next(fortunes.Length);  // สุ่ม index ระหว่าง 0 ถึง fortunes.Length - 1
                }

                // แสดงคำทำนาย
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Your fortune: {0}", fortunes[index]);
                Console.ResetColor();
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Invalid input. Please enter a single digit number (0-9).");
            }
            Console.ResetColor();
        }
    }
}
