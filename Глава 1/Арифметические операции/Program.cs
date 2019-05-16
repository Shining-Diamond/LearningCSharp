using System;

namespace Арифметические_операции
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 10;
            int b = a + 12; // 22

            int c = 10;
            int d = c - 6; // 4

            int e = 10;
            int f = e * 5; // 50

            int x = 10;
            int z = x / 5; // 2

            double a1 = 10;
            double b1 = 3;
            double c1 = a1 / b1; // 3.33333333

            // В результате деления двух целых чисел, результат будет преобразован в целое число
            double z1 = 10 / 4; // результат равен 2

            double z2 = 10.0 / 4.0; // результат равен 2.5

            // Получение остатка от числа
            double x1 = 10.0;
            double z3 = x1 % 4.0; //результат равен 2

            // Инкремент
            int x4 = 5;
            int z4 = ++x4; // z4=6; x4=6
            Console.WriteLine($"{x4} - {z4}");

            int x5 = 5;
            int z5 = x5++; // z5=5; x5=6
            Console.WriteLine($"{x5} - {z5}");

            // Декремент
            int x6 = 5;
            int z6 = --x6; // z6=4; x6=4
            Console.WriteLine($"{x6} - {z6}");

            int x7 = 5;
            int z7 = x7--; // z7=5; x7=4
            Console.WriteLine($"{x7} - {z7}");

            int at = 3;
            int bt = 5;
            int ct = 40;
            int dt = ct-- - bt * at;    // at=3  bt=5  ct=39  dt=25
            Console.WriteLine($"at={at}  bt={bt}  ct={ct}  dt={dt}");
        }
    }
}
