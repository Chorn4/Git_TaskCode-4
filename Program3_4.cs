using System;

namespace Prakt3_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter natural number: ");
            int g = int.Parse(Console.ReadLine());

            Console.Write($"{g} = ");

            method(g);

            Console.WriteLine();
        }
        static void method(int g)
        {
            if (g == 1)
            {
                Console.WriteLine("1");
            }

            if(g <= 0)
            {
                Console.WriteLine("Error");
            }

            for (int i = 2; i <= g; i++)
            {
                while (g % i == 0)
                {
                    Console.Write(i);

                    if (g != i)
                    {
                        Console.Write(" * ");
                    }

                    g /= i;
                }
            }
        }
    }
}
