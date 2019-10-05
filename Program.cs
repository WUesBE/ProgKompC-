
using System;

namespace wykladzik
{
    class Program
    {
        static void Main(string[] args)
        {
            int i=1, j= 1, n = 24;
            while (i <= n)
            {
                j = 1;
                while (j <= i)
                {
                    
                    Console.Write("*");
                    j++;
                }
                Console.WriteLine("");
                ++i;
            }
        }
    }
}