using System;

namespace Sharp
{
    class Program
    {
        private const int variant = 14;
        static void Main(string[] args)
        {
            tab();
        }
        static void tab()
        {
            Console.WriteLine("[x]\t[y]");

            double y;
            double x1 = 0, x2 = 0, maxY = 0, minY = 0;

            for (double x = 0; x < 14; x += 0.1 * variant)
            {
                y = 3.8 * Math.Cos(x + 2.3) / (Math.Sin(x) + 6);

                Console.WriteLine($"{(float)x}\t{(float)y}");

                if (maxY == 0 && minY == 0)
                {
                    minY = y;
                    maxY = y;
                }
                else if (minY > y)
                {
                    minY = y;
                    x1 = x;
                }
                else if (maxY < y)
                {
                    maxY = y;
                    x2 = x;
                }
            }

            Console.WriteLine($"\nResult of multiplication = {(float)(x1 * x2)}");
            Console.ReadLine();
            Console.ReadLine();
            Console.ReadLine();
            Console.ReadLine();
            Console.ReadLine();
        }
    }
}
