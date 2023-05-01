using System;
using System.Net;

namespace Prakt3_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            TryAgain:
            Console.WriteLine("Choose type of operation: \n1 - number/133 \n2 - number/134 \n3 - number/133 and /134 ");
            Console.Write("Enter type: ");

            int OperationType = int.Parse(Console.ReadLine());

            switch(OperationType)
            {
                case 1:
                    Num1();
                    break;

                case 2:
                    Num2();
                    break;

                case 3:
                    Num1and2();
                    break;

                default:
                    Console.WriteLine("\nError, wrong operation type\n");
                    goto TryAgain;
                    break;
            }
        }
        static void Num1()
        {
            for (int i = 1000; i < 9999; i++)
            {
                if (i % 133 == 125)
                {
                    Console.WriteLine($"({i})has a remainder of 125 when divided by 133");
                }
            }
         
        }
        static void Num2()
        {
            for (int i = 1000; i < 9999; i++)
            {
                if (i % 134 == 111)
                {
                    Console.WriteLine($"({i}) has a remainder of 111 when divided by 134");
                }
            }

        }
        static void Num1and2()
        {
            for (int i = 1000; i < 9999; i++)
            {
                if (i % 133 == 125 && i % 134 == 111)
                {
                    Console.WriteLine($"({i}) has a remainder of 125 and 111 when divided by 133 and 134");
                }
            }
        }
    }
}
