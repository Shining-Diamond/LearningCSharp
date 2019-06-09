using System;

namespace _20.Обобщенные_типы
{
    class Program
    {
        static void Main(string[] args)
        {
            Account<int> account1 = new Account<int> { Sum = 5000 };
            Account<string> account2 = new Account<string> { Sum = 4000 };

            // Статические поля
            Account<int>.session = 5436;

            Account<string>.session = "45245";

            account1.Id = 2; // упаковка не нужна
            account2.Id = "4356";

            int id1 = account1.Id; // распаковка не нужна
            string id2 = account2.Id;

            Console.WriteLine(id1); // 2
            Console.WriteLine(id2); // 4356

            Account<int> acc1 = new Account<int> { Id = 1857, Sum = 4500 };
            Account<int> acc2 = new Account<int> { Id = 3453, Sum = 5000 };

            Transaction<Account<int>, string> transaction1 = new Transaction<Account<int>, string>
            {
                FromAccount = acc1,
                ToAccount = acc2,
                Code = "45478758",
                Sum = 900
            };

            int a = 10;
            int b = 24;

            Swap<int>(ref a, ref b); // a = 24, b = 10

            Console.WriteLine($"a={a}, b={b}");

            Console.ReadKey();
        }

        public static void Swap<T>(ref T x, ref T y)
        {
            T temp = x;
            x = y;
            y = temp;
        }
    }

    class Account<T>
    {
        public static T session;

        public T Id { get; set; }
        public int Sum { get; set; }
    }

    class Transaction<U, V>
    {
        public U FromAccount { get; set; } // с какого счета перевод
        public U ToAccount { get; set; } // на какой счет перевод
        public V Code { get; set; } // код операции
        public int Sum { get; set; } // сумма перевода
    }
}
