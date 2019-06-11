using System;

namespace _6.Генерация_исключения_и_оператор_throw
{
    class Program
    {
        static void Main(string[] args)
        {
            // Оператор throw переходит к внешнему блоку catch
            try
            {
                try
                {
                    Console.Write("Введите строку: ");
                    string message = Console.ReadLine();
                    if (message.Length > 6)
                    {
                        throw new Exception("Длина строки больше 6 символов");
                    }
                }
                catch
                {
                    Console.WriteLine("Возникло исключение");
                    throw;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            Console.ReadKey();
        }
    }
}
