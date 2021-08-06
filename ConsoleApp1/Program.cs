using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {

            int i, n;
            double s = 0.0;

            Console.WriteLine("Calculate the harmonic series and their sum: ");
            Console.WriteLine("enter the number of terms : ");
            n = Convert.ToInt32(Console.ReadLine());
            for(i=1;i<=n;i++)
            {
                Console.WriteLine("1/{0} + ",i);
                s+=1/(float)i;
            }
            Console.WriteLine("sum of series upto {0} terms : {1}",n,s);
        }
    }
}