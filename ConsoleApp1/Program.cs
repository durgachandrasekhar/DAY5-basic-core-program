using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {

            int year;
            Console.WriteLine("Check weather the Year is Leap Year or Not");
            year = Convert.ToInt32(Console.ReadLine());
            if ((year % 4 == 0) && (year % 100 != 0) || (year % 400 == 0)) 
            Console.WriteLine("It is a LeapYear");
            else
                Console.WriteLine("Not a LeapYear");

        }
    }
}