using System;

namespace _21.Кортежи
{
    class Program
    {
        static void Main(string[] args)
        {
            // Неявное определение
            var tuple = (5, 10);
            Console.WriteLine(tuple.Item1); // 5
            Console.WriteLine(tuple.Item2); // 10
            tuple.Item1 += 26;
            Console.WriteLine(tuple.Item1); // 31

            // Определение с типами
            (string, int, double) person = ("Tom", 25, 81.23);

            // Задаем имена полям кортежа
            var tupleNames = (count: 5, sum: 10);
            Console.WriteLine(tupleNames.count); // 5
            Console.WriteLine(tupleNames.sum); // 10

            // Объявление имен полей для кортежа
            var (name, age) = ("Tom", 23);
            Console.WriteLine(name);    // Tom
            Console.WriteLine(age);     // 23

            // Использование с функцией
            var tupleF = GetNamedValues(new int[] { 1, 2, 3, 4, 5, 6, 7 });
            Console.WriteLine(tupleF.count);
            Console.WriteLine(tupleF.sum);

            // Передача кортежа в параметр
            var (nameF, ageF) = GetTuple(("Tom", 23), 12);
            Console.WriteLine(nameF); // Tom
            Console.WriteLine(ageF); // 35

            Console.ReadKey();
        }

        private static (int sum, int count) GetNamedValues(int[] numbers)
        {
            var result = (sum: 0, count: 0);

            for (int i = 0; i < numbers.Length; i++)
            {
                result.sum += numbers[i];
                result.count++;
            }

            return result;
        }

        private static (string name, int age) GetTuple((string n, int a) tuple, int x)
        {
            var result = (name: tuple.n, age: tuple.a + x);
            return result;
        }
    }
}
