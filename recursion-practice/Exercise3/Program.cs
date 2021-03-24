using System;

namespace Exercise3
{
    class Program
    //Write a program in C# to check a number is a prime number or not using recursion.
    {
        static Boolean primeNumber(int n1, int i)
        {
            if (n1 <= 2)
            {
                return (n1 == 2) ? true : false;
            }
            if (n1 % i == 0)
            {
                return false;
            }
            if (i * i > n1)
            {
                return true;
            }
            return primeNumber(n1, i + 1);
        }

        static void Main(string[] args)
        {
            int n = 27;
            if (primeNumber(n, 2))
            {
                Console.WriteLine("The number " + n + " is prime ");

            }
            else
            {
                Console.WriteLine("The number " + n + " isn´t prime ");
            }
        }

    }
}
