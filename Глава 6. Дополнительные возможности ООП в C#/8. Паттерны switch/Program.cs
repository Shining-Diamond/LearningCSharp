using System;

namespace _8.Паттерны_switch
{
    /// <summary>
    /// Данный паттерн находится в стадии preview
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                int x = Select(1, 4, 10);
                Console.WriteLine(x);

                x = Select(12, 4, 10);
                Console.WriteLine(x);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        static int Select(int op, int a, int b)
        {
            switch (op)
            {
                case 1: return a + b;
                case 2: return a - b;
                case 3: return a * b;
                default: throw new ArgumentException("Недопустимый код операции");
            }
        }
    }

    class Person
    {
        public string Name { get; set; }        // имя пользователя
        public string Status { get; set; }      // статус пользователя
        public string Language { get; set; }    // язык пользователя
    }
}
