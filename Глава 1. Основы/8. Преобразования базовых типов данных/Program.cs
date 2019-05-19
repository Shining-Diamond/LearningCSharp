using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8.Преобразования_базовых_типов_данных
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * Операции присваивания имеют тип int, если в операции
             * участвуют целочисленные типы данных с разрядностью меньше
             * или равно int (то есть типы byte, short, int).
             */
            byte a = 4;
            byte b = (byte)(a + 70);

            /*
             * Сужающие и расширяющие преобразования.
             * В данном примере переменной типа ushort присваивается
             * значение типа byte.
             */
            byte a2 = 4; // 00000100
            ushort b2 = a2; // 0000000000000100

            // Сужение
            ushort a3 = 4; // 0000000000000100
            byte b3 = (byte)a3; // 00000100

            /*
             * Если производится преобразование к знаковому типу,
             * то битовое представление дополняется нулями, если
             * число положительное, и единицами, если число отрицательное.
             */

            // Положительное число
            sbyte a5 = 4; // 00000100
            short b5 = a5; // 0000000000000100

            // Отрицательное число
            sbyte a6 = -4; // 11111100
            short b6 = a6; // 111111111111100

            // Явное преобразование
            int a7 = 4;
            int b7 = 6;
            byte c7 = (byte)(a7 + b7); // 10

            double a8 = 4.0;
            decimal b8 = (decimal)a8;

            // Потеря данных и ключевое слово checked
            try
            {
                /* 
                 * В данном случае byte имеет максимальный диапозон 255
                 * а значит при преобразовании числа 633 в byte произойдет ошибка
                 * которую можно проверить ключевым словом checked, которое вызовет
                 * исключение о переполнении
                 */
                int a9 = 33;
                int b9 = 600;
                byte c9 = checked((byte)(a9 + b9));
                Console.WriteLine(c9);
            }
            catch (OverflowException ex)
            {
                Console.WriteLine(ex.Message);
            }

            Console.ReadKey();
        }
    }
}
