using System;

namespace _13.Программа_сортировки_массива
{
    class Program
    {
        static void Main(string[] args)
        {
            // ввод чисел
            int[] nums = new int[7];

            Console.WriteLine("Введите семь чисел");

            for (int i = 0; i < nums.Length; i++)
            {
                Console.Write("{0}-е число: ", i + 1);
                nums[i] = int.Parse(Console.ReadLine());
            }

            // Cортировка пузырьковая
            int temp;

            for (int i = 0; i < nums.Length - 1; i++)
            {
                for (int j = i + 1; j < nums.Length; j++)
                {
                    if (nums[i] > nums[j])
                    {
                        temp = nums[i];
                        nums[i] = nums[j];
                        nums[j] = temp;
                    }
                }
            }

            Console.WriteLine("Вывод отсортированного массива");

            foreach (int value in nums)
            {
                Console.Write($"{value}\t");
            }

            Console.ReadKey();
        }
    }
}
