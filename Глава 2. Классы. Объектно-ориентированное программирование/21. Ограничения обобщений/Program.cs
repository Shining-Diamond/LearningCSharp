using System;

namespace _21.Ограничения_обобщений
{
    class Program
    {
        static void Main(string[] args)
        {
            Account<int> account = new Account<int>(5);
            Account<int> account2 = new Account<int>(6);

            account.Sum = 1500;
            account2.Sum = 5000;

            Transaction<Account<int>> transaction = new Transaction<Account<int>>()
            {
                FromAccount = account2,
                ToAccount = account,
                Sum = 1000
            };

            transaction.Execute();

            Transact<Account<int>>(account, account2, 500);

            Console.ReadKey();
        }

        public static void Transact<T>(T acc1, T acc2, int sum) where T : Account<int>
        {
            if (acc1.Sum > sum)
            {
                acc1.Sum -= sum;
                acc2.Sum += sum;
            }

            Console.WriteLine($"FromAccount: {acc1.Sum} ToAccount: {acc2.Sum}");
        }
    }

    class Account<T>
    {
        public T Id { get; private set; } // номер счета

        public int Sum { get; set; }

        public Account(T _id)
        {
            Id = _id;
        }
    }

    class Transaction<T> where T : Account<int>
    {
        public T FromAccount { get; set; } // с какого счета перевод

        public T ToAccount { get; set; } // на какой счет перевод

        public int Sum { get; set; } // сумма перевода

        public void Execute()
        {
            if (FromAccount.Sum > Sum)
            {
                FromAccount.Sum -= Sum;
                ToAccount.Sum += Sum;

                Console.WriteLine($"Перевод с аккаунта {FromAccount.Id} на аккаунт {ToAccount.Id} в размере {Sum}$");
                Console.WriteLine($"Счет {FromAccount.Id}: {FromAccount.Sum}$ \nСчет {ToAccount.Id}: {ToAccount.Sum}$");
            }
            else
            {
                Console.WriteLine($"Недостаточно денег на счете {FromAccount.Id}");
            }
        }
    }
}
