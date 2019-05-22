using System;

namespace _8.Константы_и_поля_для_чтения
{
    class Program
    {
        static void Main(string[] args)
        {
            // Так как константа является статическим полем, для обращения к ней необходимо использовать имя класса
            // MathLib.E = 3.8; Ошибка, значение константы нельзя изменить

            double CircleArea = MathLib.GetCircleArea(10);

            Console.WriteLine(CircleArea);

            MathLib mathLib = new MathLib(3.8);
            Console.WriteLine(mathLib.K); // 3.8

            //mathLib.K = 7.6; // поле для чтения нельзя установить вне своего класса

            Console.ReadKey();
        }

        class MathLib
        {
            public const double PI = 3.141;
            public const double E = 2.81;

            public readonly double K = 23;  // Можно так инициализировать

            public MathLib(double _k)
            {
                K = _k; // поле для чтения может быть инициализировано или изменено в конструкторе после компиляции
            }

            public static double GetCircleArea(double radius)
            {
                return PI * radius * radius;
            }
        }
    }
}
