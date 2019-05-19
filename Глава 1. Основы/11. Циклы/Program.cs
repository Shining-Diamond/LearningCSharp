using System;

namespace _11.Циклы
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i < 9; i++)
            {
                Console.WriteLine($"Квадрат числа {i} равен {i * i}");
            }

            // Выводит числа от 6 до 1
            int t = 6;
            do
            {
                Console.WriteLine(t);
                t--;
            }
            while (t > 0);

            // Выводит числа от 6 до 1
            int f = 6;
            while (f > 0)
            {
                Console.WriteLine(f);
                f--;
            }

            // Цикл прерывается, при a = 5
            for (int a = 0; a < 9; a++)
            {
                if (a == 5)
                    break;
                Console.WriteLine(a);
            }

            // Цикл переходит на следующую итерацию при b = 5
            for (int b = 0; b < 9; b++)
            {
                if (b == 5)
                    continue;
                Console.WriteLine(b);
            }
        }
    }
}