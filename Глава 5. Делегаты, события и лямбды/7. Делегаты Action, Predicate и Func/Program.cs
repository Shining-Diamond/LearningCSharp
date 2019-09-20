using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7.Делегаты_Action__Predicate_и_Func
{
    class Program
    {
        static void Main(string[] args)
        {
            Action<int, int> op;
            op = Add;
            Operation(10, 6, op);
            op = Substract;
            Operation(10, 6, op);

            Predicate<int> isPositive = delegate (int x) 
            {
                return x > 0;
            };

            Console.WriteLine(isPositive(20));
            Console.WriteLine(isPositive(-20));

            Func<int, int> retFunc = Factorial;
            int n1 = GetInt(6, retFunc);
            Console.WriteLine(n1); // 720

            int n2 = GetInt(6, x => x * x);
            Console.WriteLine(n2); // 36
        }

        static int GetInt(int x1, Func<int, int> retF)
        {
            int result = 0;
            if (x1 > 0)
                result = retF(x1);
            return result;
        }

        static int Factorial(int x)
        {
            int result = 1;
            for (int i = 1; i <= x; i++)
            {
                result *= i;
            }
            return result;
        }

        static void Operation(int x1, int x2, Action<int, int> op)
        {
            if (x1 > x2)
                op(x1, x2);
        }

        static void Add(int x1, int x2)
        {
            Console.WriteLine("Сумма чисел: " + (x1 + x2));
        }

        static void Substract(int x1, int x2)
        {
            Console.WriteLine("Разность чисел: " + (x1 - x2));
        }
    }
}
