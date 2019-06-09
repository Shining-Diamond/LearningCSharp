using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _22.Наследование_обобщенных_типов
{
    class Program
    {
        static void Main(string[] args)
        {
            Account<string> account = new Account<string>("3");

            Account<int> accountInt = new Account<int>(5);

            UniversalAccount<int> universalAccount = new UniversalAccount<int>(3);

            AccountString accountString = new AccountString("43");

            IntAccount<string> intAccount = new IntAccount<string>(5, "43252345");

            MixedAccount<string, int> mixedAccount = new MixedAccount<string, int>("10", 234);

            Console.WriteLine(account.Id); // 3
            Console.WriteLine(accountInt.Id); // 5
            Console.WriteLine(universalAccount.Id); // 3
            Console.WriteLine(accountString.Id); // 43
            Console.WriteLine(intAccount.Id); // 5
            Console.WriteLine(intAccount.Code); // 43252345
            Console.WriteLine(mixedAccount.Id); // 10
            Console.WriteLine(mixedAccount.Code); // 234

            Console.ReadKey();
        }
    }

    /// <summary>
    /// Базовый класс. Если на базовый класс накладывается ограничение,
    /// то для наследника тоже должно быть такое же ограничение
    /// </summary>
    /// <typeparam name="T">Обобщение типа</typeparam>
    class Account<T>
    {
        public T Id { get; private set; }

        public Account(T id)
        {
            Id = id;
        }
    }

    /// <summary>
    /// Наследник базового класса с обобщенной типизацией
    /// </summary>
    /// <typeparam name="T">Типизация класса наследника UniversalAccount</typeparam>
    class UniversalAccount<T> : Account<T>
    {
        public UniversalAccount(T id) : base(id)
        {
        }
    }

    /// <summary>
    /// Наследник базового класс, без обобщенного типа
    /// </summary>
    class AccountString : Account<string>
    {
        public AccountString(string id) : base(id)
        {
        }
    }

    class IntAccount<T> : Account<int>
    {
        public T Code { get; set; }

        public IntAccount(int id, T code) : base(id)
        {
            Code = code;
        }

        public void DisplayCode()
        {
            Console.WriteLine(Code);
        }
    }

    class MixedAccount<T, K> : Account<T> where K : struct
    {
        public K Code { get; set; }

        public MixedAccount(T id, K code) : base(id)
        {
            Code = code;
        }
    }
}
