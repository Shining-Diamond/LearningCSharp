using System;

namespace _10.Переменные_ссылки_и_возвращение_ссылки
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 5;
            ref int xRef = ref x;
            Console.WriteLine(x); // 5
            xRef = 125;
            Console.WriteLine(x); // 125
            x = 625;
            Console.WriteLine(xRef); // 625

            int a = 5;
            int b = 8;
            ref int pointer = ref a;
            pointer = 34;
            pointer = ref b;
            pointer = 6;

            Console.WriteLine(a + " " + b); // 34 6

            int[] numbers = { 1, 2, 3, 4, 5, 6, 7 };
            ref int numberRef = ref Find(4, numbers); // ищем число 4 в массиве
            numberRef = 9; // заменяем 4 на 9
            Console.WriteLine(numbers[3]); // 9

            int a1 = 5;
            int b1 = 8;
            ref int pointer1 = ref Max(ref a1, ref b1);
            pointer1 = 34; // меняем значением максимального числа
            Console.WriteLine($"a: {a1}  b: {b1}"); // a: 5   b: 34
        }

        static ref int Find(int number, int[] numbers)
        {
            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] == number)
                {
                    return ref numbers[i];
                }
            }
            throw new IndexOutOfRangeException("число не найдено");
        }

        static ref int Max(ref int n1, ref int n2)
        {
            if (n1 > n2)
                return ref n1;
            else
                return ref n2;
        }
    }
}
