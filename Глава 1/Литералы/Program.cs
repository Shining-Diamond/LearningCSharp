using System;

namespace Литералы
{
    class Program
    {
        static void Main(string[] args)
        {
            // Логические литералы
            Console.WriteLine(true);
            Console.WriteLine(false);

            // Целочисленные
            Console.WriteLine(-11);
            Console.WriteLine(5);

            // Числа в двоичной форме
            Console.WriteLine(0b11);
            Console.WriteLine(0b1011);

            // Числа в шестнадцатеричной форме
            Console.WriteLine(0x0A);
            Console.WriteLine(0xFF);

            // Вещественные литералы
            Console.WriteLine(3.14);
            Console.WriteLine(-101.11);

            // Строковые
            Console.WriteLine("Hello");
            Console.WriteLine("Привет");

            Console.ReadKey();
        }
    }
}
