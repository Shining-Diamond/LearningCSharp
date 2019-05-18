using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15.Параметры_методов
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 25;
            int b = 35;
            int result = Sum(a, b);

            Console.WriteLine(result); // 60

            result = Sum(a + b + 12, 18); // "a + b + 12" представляет значение параметра x

            Console.WriteLine(result); // 90

            Display("Tom", 24); // Name: Tom  Age: 24

            Console.WriteLine(OptionalParam(5, 20)); // 34

            Console.WriteLine(OptionalParam(5, 5, 3, 2)); // 15

            // Именованные параметры. Параметр z используется по умолчанию
            Console.WriteLine(OptionalParam(y: 2, x: 3, s: 10)); // 20

            Console.ReadKey();
        }

        /// <summary>
        /// Суммирует два числа
        /// </summary>
        /// <param name="x">Первое число</param>
        /// <param name="y">Второе число</param>
        /// <returns>Сумму чисел</returns>
        static int Sum(int x, int y)
        {
            return x + y;
        }

        /// <summary>
        /// Отображает имя и возраст
        /// </summary>
        /// <param name="name">Имя</param>
        /// <param name="age">Возраст</param>
        static void Display(string name, int age)
        {
            Console.WriteLine($"Name: {name}  Age: {age}");
        }

        /// <summary>
        /// Складывает числа x, y, z, s
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <param name="z"></param>
        /// <param name="s"></param>
        /// <returns></returns>
        static int OptionalParam(int x, int y, int z = 5, int s = 4)
        {
            return x + y + z + s;
        }
    }
}
