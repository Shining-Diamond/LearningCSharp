using System;

namespace _19.Рекурсивные_функции
{
    class Program
    {
        static int Factorial(int x)
        {
            if (x == 0)
            {
                return 1;
            }
            else
            {
                return x * Factorial(x - 1);
            }
        }

        static int Fibonachi(int n)
        {
            if (n == 0)
            {
                return 0;
            }
            if (n == 1)
            {
                return 1;
            }
            else
            {
                return Fibonachi(n - 1) + Fibonachi(n - 2);
            }
        }

        static void Main(string[] args)
        {
            int fact5 = Factorial(5);

            int fibonachi5 = Fibonachi(5);

            Console.WriteLine(fact5); // 120
            Console.WriteLine(fibonachi5); // 5

            Console.ReadKey();
        }
    }
}
