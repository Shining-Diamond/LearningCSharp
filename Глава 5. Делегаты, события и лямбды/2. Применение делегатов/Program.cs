using System;

namespace _2.Применение_делегатов
{
    class Program
    {
        static void Main(string[] args)
        {
            Account account = new Account(200);
            Account.AccountStateHandler colorDelegate = new Account.AccountStateHandler(Color_Message);

            // Добавляем в делегат ссылку на методы
            account.RegisterHandler(Show_Message);
            account.RegisterHandler(colorDelegate);

            // Два раза подряд пытаемся снять деньги
            account.Withdraw(100);
            account.Withdraw(150);

            // Удаляем делегат
            account.UnregisterHandler(colorDelegate);
            account.Withdraw(50);

            Console.ReadKey();
        }

        private static void Show_Message(string message)
        {
            Console.WriteLine(message);
        }

        private static void Color_Message(string message)
        {
            // Устанавливаем красный цвет символов
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(message);
            // Сбрасываем настройки цвета
            Console.ResetColor();
        }
    }

    class Account
    {
        public int CurrentSum { get; private set; }

        // Объявляем делегат
        public delegate void AccountStateHandler(string message);
        // Создаем переменную делегата
        AccountStateHandler _del;

        // Регистрируем делегат
        public void RegisterHandler(AccountStateHandler del)
        {
            _del += del;
        }

        // Отмена регистрации делегата
        public void UnregisterHandler(AccountStateHandler del)
        {
            _del -= del;
        }

        public Account(int sum)
        {
            CurrentSum = sum;
        }

        public void Put(int sum)
        {
            CurrentSum += sum;
        }

        public void Withdraw(int sum)
        {
            if (sum <= CurrentSum)
            {
                CurrentSum -= sum;

                _del?.Invoke($"Сумма {sum} снята со счета");
            }
            else
            {
                _del?.Invoke("Недостаточно денег на счете");
            }
        }
    }
}
