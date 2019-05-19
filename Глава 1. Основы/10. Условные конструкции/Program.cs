using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10.Условные_конструкции
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1 = 8;
            int num2 = 6;

            /**
             * Конструкция if/else проверяет истинность некоторого условия
             * и в зависимости от результатов проверки выполняет определенный код
             */
            if (num1 > num2)
            {
                Console.WriteLine($"Число {num1} больше числа {num2}");
            }
            else if (num1 < num2)
            {
                Console.WriteLine($"Число {num1} меньше числа {num2}");
            }
            else
            {
                Console.WriteLine("Число num1 равно числу num2");
            }

            int num3 = 8;
            int num4 = 6;

            if (num3 > num4 && num3 == 8)
            {
                Console.WriteLine($"Число {num1} больше числа {num2}");
            }

            int number = 1;
            switch (number)
            {
                case 1:
                    Console.WriteLine("case 1");
                    goto case 5; // переход к case 5
                case 3:
                    Console.WriteLine("case 3");
                    break;
                case 5:
                    Console.WriteLine("case 5");
                    break;
                default:
                    Console.WriteLine("default");
                    break;
            }

            // Тернарную операция имеет следующий синтаксис: [первый операнд - условие] ? [второй операнд] : [третий операнд].
            int x = 3;
            int y = 2;
            Console.WriteLine("Нажмите + или -");
            string selection = Console.ReadLine();

            int z = selection == "+" ? (x + y) : (x - y);
            Console.WriteLine(z);
        }
    }
}
