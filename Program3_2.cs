using System;
using System.Runtime.InteropServices.WindowsRuntime;

namespace Prakt3_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double Sum = 0;

            for(int i = 1; i <= 10; i++)
            {
                Console.WriteLine($"N({i}) = " + Operation(i));
                Sum += Operation(i);
            }

            Console.WriteLine("\nSum of 10 elements = " + Sum);
        }
        static double Operation(double n)
        {
            n = Math.Pow(-1,n)*( (n+1)/(Math.Pow(n,2)+2*n+1) );
            return n;
        }
    }
}
