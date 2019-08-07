using System;

namespace _3.События
{
    class Program
    {
        static void Main(string[] args)
        {
            Account account = new Account(200);
            // Добавляем обработчики события
            account.Added += Show_Message;
            account.Withdrawn += Show_Message;

            account.Withdraw(100);
            // Удаляем обработчик события
            //account.Withdrawn -= Show_Message;

            account.Withdraw(50);
            account.Put(150);

            Console.ReadKey();
        }

        private static void Show_Message(object sender, AccountEventArgs e)
        {
            Console.WriteLine($"Сумма транзакции: {e.Sum}");
            Console.WriteLine(e.Message);
        }
    }

    class AccountEventArgs
    {
        // Сообщение
        public string Message { get; }
        // Сумма, на которую изменился счет
        public int Sum { get; }

        public AccountEventArgs(string mes, int sum)
        {
            Message = mes;
            Sum = sum;
        }
    }

    class Account
    {
        // Объявляем делегат
        public delegate void AccountStateHandler(object sender, AccountEventArgs e);
        // Событие, возникающее при выводе денег
        public event AccountStateHandler Withdrawn;
        // Событие, возникающее при добавление на счет
        public event AccountStateHandler Added;

        public Account(int sum)
        {
            CurrentSum = sum;
        }

        public int CurrentSum { get; private set; }

        public void Put(int sum)
        {
            CurrentSum += sum;
            Added?.Invoke(this, new AccountEventArgs($"На счет поступило {sum}", sum));
        }

        public void Withdraw(int sum)
        {
            if (sum <= CurrentSum)
            {
                CurrentSum -= sum;
                Withdrawn?.Invoke(this, new AccountEventArgs($"Сумма {sum} снята со счета", sum));
            }
            else
            {
                Withdrawn?.Invoke(this, new AccountEventArgs("Недостаточно денег на счете", sum));
            }
        }
    }
}
