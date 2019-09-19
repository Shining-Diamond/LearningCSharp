using System;

namespace _5.Лямбды
{
    delegate void AccountStateHandler(object sender, AccountEventArgs e);

    class Program
    {
        delegate int Operation(int x, int y);
        delegate int Square(int x);
        delegate void HelloWorld();
        delegate void ChangeHandler(ref int x);
        delegate bool IsEqual(int x);

        static void Main(string[] args)
        {
            Operation operation = (x, y) => x + y;

            Console.WriteLine(operation(10, 20)); // 30

            Square square = x => x * x;

            Console.WriteLine(square(5));

            HelloWorld helloWorld = () => Console.WriteLine("Hello World");

            helloWorld();

            int refX = 9;

            ChangeHandler changeHandler = (ref int n) => n = n * 2;

            changeHandler(ref refX);

            Console.WriteLine(refX); // 18

            Account account = new Account(230);

            account.Added += (sender, e) =>
            {
                Console.WriteLine($"Сумма транзакции: {e.Sum}");
                Console.WriteLine(e.Message);
            };

            account.Withdrawn += (sender, e) =>
            {
                Console.WriteLine($"Сумма снятия: {e.Sum}");
                Console.WriteLine(e.Message);
            };

            account.Put(120);

            account.Withdraw(100);

            Console.WriteLine(Sum(new int[4] { 1, 2, 3, 4 }, x => x % 2 == 0)); // 6
        }

        private static int Sum(int[] numbers, IsEqual func)
        {
            int result = 0;

            foreach (int i in numbers)
            {
                if (func(i))
                    result += i;
            }

            return result;
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
