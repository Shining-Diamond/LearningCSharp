using System;

namespace _14.Методы
{
    class Program
    {
        static void Main(string[] args)
        {
            // Вывод сообщения Hello
            SayHello();

            // Вывод сообщения GoodBye
            SayGoodbye();

            string message = GetHello();

            Console.WriteLine(message); // Hello

            int summa = GetSum();

            Console.WriteLine(summa); // 5

            Console.ReadKey();
        }

        static void SayHello()
        {
            Console.WriteLine("Hello");
        }

        static void SayGoodbye()
        {
            Console.WriteLine("GoodBye");
        }

        static string GetHello()
        {
            return "Hello";
        }

        /// <summary>
        /// Получаем сумму чисел 2 и 3
        /// </summary>
        /// <returns></returns>
        static int GetSum()
        {
            int x = 2;
            int y = 3;
            return x + y;
        }

        // Сокращенная запись метода
        static void SayHelloMiniman() => Console.WriteLine("Hello");
    }
}
