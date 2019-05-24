using System;

/**
 * И есть ряд операторов, которые нельзя перегрузить, например, операцию равенства = или тернарный оператор ?:, а также ряд других.
 * Полный список перегружаемых операторов можно найти в документации msdn
 */

namespace _9.Перегрузка_операторов
{
    class Program
    {
        static void Main(string[] args)
        {
            Counter c1 = new Counter() { Value = 23 };
            Counter c2 = new Counter() { Value = 45 };

            bool result = c1 > c2;

            Console.WriteLine(result); // false

            Counter c3 = c1 + c2;

            Console.WriteLine(c3.Value); // 23 + 45 = 68

            Counter c4 = new Counter() { Value = 55 };

            int res = c4 + 100;

            Console.WriteLine(res); // 55 + 100 = 155
            
            Counter increment = new Counter() { Value = 5 };

            // Прибавляем значение в объекте на единицу
            increment++;

            Console.WriteLine(increment.Value); // 6

            if (increment)
            {
                Console.WriteLine($"Значение объекта increment не равен нулю");
            }

            Console.ReadKey();
        }
    }

    class Counter
    {
        public int Value { get; set; }
        
        // Перегрузка оператора +. Возвращает новый объект складывающий значения обоих объектов.
        public static Counter operator +(Counter c1, Counter c2)
        {
            return new Counter { Value = c1.Value + c2.Value };
        }

        // Перегрузка оператора >. Возвращает сравнение значений с1 > c2 обоих объектов.
        public static bool operator >(Counter c1, Counter c2)
        {
            return c1.Value > c2.Value;
        }

        // Перегрузка оператора <. Возвращает сравнение значений с1 < c2 обоих объектов.
        public static bool operator <(Counter c1, Counter c2)
        {
            return c1.Value < c2.Value;
        }

        // Перегрузка оператора <. Возвращает сложения значения объекта со значением некоторого числа.
        public static int operator +(Counter c1, int value)
        {
            return c1.Value + value;
        }

        // Перегрузка оператора <. Возвращает инкремент значения объекта
        public static Counter operator ++(Counter c1)
        {
            return new Counter { Value = c1.Value + 1 }; 
        }

        // Перегрузка оператора true. Возвращает true, если значение объекта не равно нулю.
        public static bool operator true(Counter c1)
        {
            return c1.Value != 0;
        }

        // Перегрузка оператора false. Возвращает false, если значение объекта равно нулю.
        public static bool operator false(Counter c1)
        {
            return c1.Value == 0;
        }
    }
}
