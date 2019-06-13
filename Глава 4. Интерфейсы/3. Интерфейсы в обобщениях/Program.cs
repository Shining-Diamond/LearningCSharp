using System;

namespace _3.Интерфейсы_в_обобщениях
{
    class Program
    {
        static void Main(string[] args)
        {
            Client client1 = new Client("Иван", 5000);
            Client client2 = new Client("Василий", 4000);

            Transaction<Client>.Operate(client1, client2, 1000);

            Console.WriteLine($"Остаток на счету {client1.Name}: {client1.CurrentSum}\n\rОстаток на счету {client2.Name}: {client2.CurrentSum}");

            // Обобщенный интерфейс
            User<int> user = new User<int>(10);

            Console.WriteLine(user.Id); // 10

            Console.ReadKey();
        }
    }

    interface IAccount
    {
        int CurrentSum { get; }
        void Put(int sum);
        void Withdraw(int sum);
    }

    interface IClient
    {
        string Name { get; set; }
    }

    class Client : IAccount, IClient
    {
        int _sum;

        public Client(string name, int sum)
        {
            Name = name;
            _sum = sum;
        }

        public string Name { get; set; }

        public int CurrentSum
        {
            get { return _sum; }
        }

        public void Put(int sum)
        {
            _sum += sum;
        }

        public void Withdraw(int sum)
        {
            if (sum <= _sum)
            {
                _sum -= sum;
            }
        }
    }

    static class Transaction<T> where T : IAccount, IClient
    {
        public static void Operate(T account1, T account2, int sum)
        {
            if (account1.CurrentSum >= sum)
            {
                account1.Withdraw(sum);
                account2.Put(sum);

                Console.WriteLine($"Клиент {account1.Name} перевел {sum}$ {account2.Name}");
            }
        }
    }

    interface IUser<T>
    {
        T Id { get; }
    }

    class User<T> : IUser<T>
    {
        T _id;

        public User(T id)
        {
            _id = id;
        }

        public T Id { get { return _id; } }
    }
}
