using System;

namespace _6.Перегрузка_методов
{
    class Program
    {
        static void Main(string[] args)
        {
            Calculator method = new Calculator();

            method.Add(5.2, 3.4); // 8.6
            method.Add(5, 3); // 8
            method.Add(5, 3, 2); // 10
            method.Add(5, 4, 3, 2); // 14

            Console.ReadKey();
        }
    }

    class Calculator
    {
        public void Add(int a, int b)
        {
            int result = a + b;
            Console.WriteLine($"Result is {result}");
        }

        public void Add(int a, int b, int c)
        {
            int result = a + b + c;
            Console.WriteLine($"Result is {result}");
        }

        public int Add(int a, int b, int c, int d)
        {
            int result = a + b + c + d;

            Console.WriteLine($"Result is {result}");

            return result;
        }

        public void Add(double a, double b)
        {
            double result = a + b;

            Console.WriteLine($"Result is {result}");
        }
    }
}
