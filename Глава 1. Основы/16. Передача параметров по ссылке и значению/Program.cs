using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _16.Передача_параметров_по_ссылке_и_значению
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 5;
            Console.WriteLine($"Начальное значение переменной a = {a}");

            /**
             * Передача переменных по значению
             * После выполнения этого кода по-прежнему a = 5, так как мы передали лишь ее копию
             */
            IncrementVal(a);
            Console.WriteLine($"Переменная a после передачи по значению равна = {a}");

            IncrementRef(ref a);
            Console.WriteLine($"Переменная a после передачи ссылке равна = {a}");

            // Модификатор out
            int x = 10;

            int area;
            int perimetr;

            GetData(x, 15, out area, out perimetr);

            Console.WriteLine($"Площадь : {area}");
            Console.WriteLine($"Периметр : {perimetr}");

            Console.ReadKey();
        }

        static void IncrementVal(int x)
        {
            x++;
            Console.WriteLine($"Инкремент по значению: {x}");
        }

        static void IncrementRef(ref int x)
        {
            x++;
            Console.WriteLine($"Инкремент по ссылке: {x}");
        }

        static void GetData(int x, int y, out int area, out int perim)
        {
            area = x * y;
            perim = (x + y) * 2;
        }
    }
}
