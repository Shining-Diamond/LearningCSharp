using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6.Поразрядные_операции
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * Логическое умножение.
             * Умножение происходит поразрядно.
             */
            int x1 = 2; // 010
            int y1 = 5; // 101

            Console.WriteLine(x1 & y1); // 0

            /*
             * Логическое сложение
             * Возвращает единицу, при наличии единицы в разряде
             */
            int x2 = 2; // 010
            int y2 = 5; // 101

            Console.WriteLine(x2 | y2); // 7 - 111

            /*
             * Логическое исключающее ИЛИ
             */
            int x = 45; // Значение, которое надо зашифровать. 101101
            int key = 102; // Ключ. 1100110
            int encrypt = x ^ key; // Результат: 1001011 или 75

            Console.WriteLine("Зашифрованное число: {0}", encrypt);

            int decrypt = encrypt ^ key; // Результат: Исходное число 45

            Console.WriteLine("Расшифрованное число: {0}", decrypt);

            /*
             * Логическое отрицание или инверсия.
             * Поразрядно инвертирует все разряды.
             */
            int x3 = 12; // 00001100

            Console.WriteLine(~x3); // 11110011

            /*
             * Представление отрицательных чисел.
             * При изменении знака меняется старшый разряд
             * 0 - положительное число
             * 1 - отрицательное
             */
            int x4 = 12;
            int y4 = ~x4;

            y4 += 1;

            Console.WriteLine(y4); // -12

            /*
             * Операции сдвига.
             * Сдвигает разряды.
             */
            int x5 = 4; // 100
            int y5 = x5 << 1; // 1000;

            int x6 = 16; // 10000
            int y6 = x6 >> 1; // 1000;
        }
    }
}
