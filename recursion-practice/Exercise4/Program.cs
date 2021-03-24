using System;

namespace Exercise4
{
    class Program
    //Spiderman
    {
        static int spider(int n)
        {
            if (n <= 1)
            {
                return n;
            }
            return spider(n - 1) + spider(n - 2);
        }

        static int ways(int w)
        {
            return spider(w + 1);
        }

        static void Main(string[] args)
        {
            int s = 3;
            Console.WriteLine("Number of ways spiderman can jump over the buildings = " + ways(s));
        }
    }
}
