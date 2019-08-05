using System;

namespace _6.Ковариантность_и_контравариантность_обобщенных_интерфейсов
{
    class Program
    {
        static void Main(string[] args)
        {
            IBank<DepositAccount> depositBank = new Bank<DepositAccount>();
            Account acc1 = depositBank.CreateAccount(34);

            IBank<Account> ordinaryBank = new Bank<DepositAccount>();
            Account acc2 = ordinaryBank.CreateAccount(45);

            ITransaction<Account> accTransaction = new Transaction<Account>();
            accTransaction.DoOperation(acc1, 400);

            ITransaction<DepositAccount> depAccTransaction = new Transaction<Account>();
            depAccTransaction.DoOperation((DepositAccount)acc2, 450);

            Console.ReadKey();
        }
    }

    class Account
    {
        public virtual void DoTransfer(int sum)
        {
            Console.WriteLine($"Клиент положил на счет {sum} долларов");
        }
    }

    class DepositAccount : Account
    {
        public override void DoTransfer(int sum)
        {
            Console.WriteLine($"Клиент положил на депозитный счет {sum} долларов");
        }
    }

    interface IBank<out T>
    {
        T CreateAccount(int sum);
    }

    class Bank<T> : IBank<T> where T : Account, new()
    {
        public T CreateAccount(int sum)
        {
            T acc = new T();
            acc.DoTransfer(sum);
            return acc;
        }
    }

    interface ITransaction<in T>
    {
        void DoOperation(T account, int sum);
    }

    class Transaction<T> : ITransaction<T> where T : Account
    {
        public void DoOperation(T account, int sum)
        {
            account.DoTransfer(sum);
        }
    }
}
