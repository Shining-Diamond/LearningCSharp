using System;

namespace _1.Конструкция_try_catch_finally
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                int x = 5;
                int y = x / 0;
                Console.WriteLine($"Результат: {y}");
            }
            catch
            {
                Console.WriteLine("Возникло исключение!");
            }
            finally
            {
                Console.WriteLine("Блок finally");
            }

            Console.WriteLine("Введите число");
            int x2;
            string input = Console.ReadLine();

            if (Int32.TryParse(input, out x2))
            {
                x2 *= x2;
                Console.WriteLine("Квадрат числа: " + x2);
            }
            else
            {
                Console.WriteLine("Некорректный ввод");
            }

            Console.ReadKey();
        }
    }
}
