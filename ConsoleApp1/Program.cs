using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {

            int num1, num2, num3;
            Console.WriteLine("enter the largest number among all Three numbers");
            Console.WriteLine("Enter the first number");
            num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the second number");
            num2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the third number");
            num3 = Convert.ToInt32(Console.ReadLine());
            if (num1 > num2) 
            {
             if (num1 > num3) 
                Console.WriteLine("Console the number1 is greatest among all 3numbers");
             else
                    Console.WriteLine("Console the number3 is greater among all 3numbers");
            }
             else if (num2 > num3) 
                Console.WriteLine("Console the number2 is greater among all 3numbers");
            else
                    Console.WriteLine("Console the number3 is greater among all 3numbers");
            }
        }
    }

