using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12.Массивы
{
    class Program
    {
        static void Main(string[] args)
        {
            // Объявление и инициализация массивов
            int[] nums = new int[4];

            int[] nums2 = new int[4] { 1, 2, 3, 5 };

            int[] nums3 = new int[] { 1, 2, 3, 5 };

            int[] nums4 = new[] { 1, 2, 3, 5 };

            int[] nums5 = { 1, 2, 3, 5 };

            nums[0] = 1;
            nums[1] = 2;
            nums[2] = 3;
            nums[3] = 5;
            Console.WriteLine(nums[3]); // 5

            int[] numbers = new int[] { 1, 2, 3, 4, 5 };

            foreach (int i in numbers)
            {
                Console.WriteLine(i);
            }

            for (int i = 0; i < numbers.Length; i++)
            {
                Console.WriteLine(numbers[i]);
            }

            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = numbers[i] * 2;
                Console.WriteLine(numbers[i]);
            }

            // Многомерные массивы
            int[,] mnums1;
            int[,] mnums2 = new int[2, 3];
            int[,] mnums3 = new int[2, 3] { { 0, 1, 2 }, { 3, 4, 5 } };
            int[,] mnums4 = new int[,] { { 0, 1, 2 }, { 3, 4, 5 } };
            int[,] mnums5 = new[,] { { 0, 1, 2 }, { 3, 4, 5 } };
            int[,] mnums6 = { { 0, 1, 2 }, { 3, 4, 5 } };
            int[,,] mnums7 = new int[2, 3, 4];

            int[,] mas = { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 }, { 10, 11, 12 } };
            foreach (int i in mas)
                Console.Write($"{i} ");
            Console.WriteLine();

            int[,] mas2 = { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 }, { 10, 11, 12 } };

            int rows = mas2.GetUpperBound(0) + 1;
            int columns = mas2.Length / rows;
            // или так
            // int columns = mas.GetUpperBound(1) + 1;

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    Console.Write($"{mas2[i, j]} \t");
                }
                Console.WriteLine();
            }

            // Зубчатый массив
            int[][] teathMas = new int[3][];
            teathMas[0] = new int[2] { 1, 2 };          // Выделяем память для первого подмассива
            teathMas[1] = new int[3] { 1, 2, 3 };       // Выделяем память для второго подмассива
            teathMas[2] = new int[5] { 1, 2, 3, 4, 5 }; // Выделяем память для третьего подмассива

            // Перебор многомерного массива
            int[][] numbers2 = new int[3][];
            numbers2[0] = new int[] { 1, 2 };
            numbers2[1] = new int[] { 1, 2, 3 };
            numbers2[2] = new int[] { 1, 2, 3, 4, 5 };

            foreach (int[] row in numbers2)
            {
                foreach (int number in row)
                {
                    Console.Write($"{number} \t");
                }
                Console.WriteLine();
            }

            // Перебор с помощью цикла for
            for (int i = 0; i < numbers2.Length; i++)
            {
                for (int j = 0; j < numbers2[i].Length; j++)
                {
                    Console.Write($"{numbers2[i][j]} \t");
                }
                Console.WriteLine();
            }
        }
    }
}
