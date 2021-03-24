using System;

namespace Exercise2
{
    class Program
    //Write a program in C# to find the sum of digits of a number using recursion.
    {
        static int sumDigits(int d)
        {
            if (d == 0)
            {
                return 0;
            }
            //el porcentaje y el slash son la misma operación de división, el porcentaje es para coger el residuo y el slash es para coger el cociente con el fin de separar los digitos
            return (d % 10 + sumDigits(d / 10));
        }

        static void Main(string[] args)
        {
            int n = 26;
            int result = sumDigits(n);
            Console.WriteLine("The summary of digits in " + n + " is " + result);
        }
    }
}
