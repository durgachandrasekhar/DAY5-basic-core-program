using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {

            int number1, number2, temp;
            Console.Write("enter the First Number : ");
            number1 = int.Parse(Console.ReadLine());
            Console.Write("enter the Second Number : ");
            number2 = int.Parse(Console.ReadLine());
            temp = number1;
            number1 = number2;
            number2 = temp;
            Console.WriteLine("After Swapping : ");
            Console.WriteLine("First Number : " + number1);
            Console.WriteLine("Second Number : " + number2);
            Console.ReadLine();
        }
    }

}
    

