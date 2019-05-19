using System;
using System.Linq;

namespace _17.Массив_параметров_и_ключевое_слово_params
{
    class Program
    {
        // Передача params параметра
        static void Addition(params int[] integers)
        {
            int result = integers.Sum();

            Console.WriteLine(result);
        }

        // Передача массива
        static void AdditionMas(int[] integers, int k)
        {
            int result = 0;

            for (int i = 0; i < integers.Length; i++)
            {
                result += integers[i];
            }

            result *= k;

            Console.WriteLine(result);
        }

        static void Main(string[] args)
        {
            Addition(1, 2, 3, 4, 5);

            int[] array = new int[] { 1, 2, 3, 4, 5 };

            AdditionMas(array, 2);

            Console.ReadKey();
        }
    }
}
