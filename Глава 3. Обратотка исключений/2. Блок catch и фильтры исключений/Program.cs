using System;

namespace _2.Блок_catch_и_фильтры_исключений
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 1;
            int y = 0;

            try
            {
                int result = x / y;
            }
            catch (DivideByZeroException) when (y == 0)
            {
                Console.WriteLine("y не должен быть равен 0");
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine(ex.Message);
            }

            Console.ReadKey();
        }
    }
}
