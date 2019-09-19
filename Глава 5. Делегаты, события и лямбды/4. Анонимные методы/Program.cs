using System;

namespace _4.Анонимные_методы
{
    delegate void AccountStateHandler(object sender, AccountEventArgs e);
    delegate void MessageHandler(string message);
    delegate int Operation(int x, int y);

    class Program
    {
        static void Main(string[] args)
        {
            MessageHandler handler = delegate (string mes)
            {
                Console.WriteLine(mes);
            };

            handler("hello world!");

            ShowMessage("Rofl", delegate (string mes)
            {
                Console.WriteLine(mes);
            });

            int zz = 10;

            Operation operation = delegate (int x, int y)
            {
                return x + y + zz; // Также доступна переменная zz
            };

            int result = operation(10, 15);
            Console.WriteLine(result); // 35

            Account account = new Account(200);

            // Добавляем обработчики события
            account.Added += delegate (object sender, AccountEventArgs e)
            {
                Console.WriteLine($"Сумма транзакции: {e.Sum}");
                Console.WriteLine(e.Message);
            };
            account.Put(230);
        }

        static void ShowMessage(string mes, MessageHandler handler)
        {
            handler(mes);
        }
    }

    class AccountEventArgs
    {
        public string Message { get; }
        public int Sum { get; }
        public AccountEventArgs(string message, int sum)
        {
            Message = message; Sum = sum;
        }
    }

    class Account
    {
        int _sum;

        public event AccountStateHandler Added;
        public event AccountStateHandler Withdrawn;

        public Account(int sum)
        {
            _sum = sum;
        }

        public void Put(int sum)
        {
            _sum += sum;
            Added?.Invoke(this, new AccountEventArgs($"На счет пришло {sum}", sum));
        }

        public void Withdraw(int sum)
        {
            if (_sum >= sum)
            {
                _sum -= sum;
                Withdrawn?.Invoke(this, new AccountEventArgs($"Со счета снято {sum}", sum));
            }
            else
            {
                Withdrawn?.Invoke(this, new AccountEventArgs("На счете недостаточно средств", 0));
            }
        }
    }
}
