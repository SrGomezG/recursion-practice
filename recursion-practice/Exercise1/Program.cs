using System;

namespace Exercise1
{
    class Program
    //Write a program in C# to calculate the sum of numbers from 1 to n using recursion.
    {
        static int sum(int n)

        {
            if (n == 1)
            {
                return n;
            }
            return sum(n - 1) + n;
        }
        static void Main(string[] args)
        {
            int n = 5;
            Console.WriteLine("The summary of numbers from 1 to 5 is = " + sum(n));

        }
    }
}
