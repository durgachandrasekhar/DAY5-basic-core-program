using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {

            double a, b;
            Console.WriteLine("Enter the Number : ");
            a = double.Parse(Console.ReadLine());
            Console.WriteLine("Give the Exponent : ");
            b = double.Parse(Console.ReadLine());
            double value1 = Math.Pow(a, b);
            Console.WriteLine("Result :" + value1);
            Console.ReadLine();

        }
    }
}