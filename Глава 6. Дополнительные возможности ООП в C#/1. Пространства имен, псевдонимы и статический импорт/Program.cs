using printer = System.Console; // Псевдоним
using static System.Math; // Статический импорт
using static _1.Пространства_имен__псевдонимы_и_статический_импорт.Geometry;
/**
 * Выражение using static подключает в программу все статические методы и свойства,
 * а также константы. И после этого мы можем не указывать название класса при вызове метода.
 */

namespace _1.Пространства_имен__псевдонимы_и_статический_импорт
{
    class Program
    {
        static void Main(string[] args)
        {
            double radius = 50;
            double result = GetArea(radius); //Geometry.GetArea

            printer.WriteLine(result);

            // Использование класса из другого пространства имен
            AccountSpace.Account acc = new AccountSpace.Account(10);
            printer.WriteLine("Hello");
        }
    }

    class Geometry
    {
        public static double GetArea(double radius)
        {
            return PI * radius * radius; // Math.PI
        }
    }

    namespace AccountSpace
    {
        class Account
        {
            public int Id { get; private set; }
            public Account(int _id)
            {
                Id = _id;
            }
        }
    }
}
