using System;

/**
 * Переменные и свойства, которые хранят состояние, общее для всех объектов класса, 
 * следует определять как статические. И также методы, которые определяют общее для
 * всех объектов поведение, также следует объявлять как статические.
 */

namespace _7.Статические_члены_и_модификатор_static
{
    class Program
    {
        static void Main(string[] args)
        {
            Account.MinSum = 560;
            decimal result = Account.GetSum(1000, 10, 5);

            Console.WriteLine(result);

            Console.ReadKey();
        }
    }

    class Account
    {
        /// <summary>
        /// Минимальная допустимая сумма для всех счетов
        /// </summary>
        private static decimal minSum = 100;

        /// <summary>
        /// Cумма на счете
        /// </summary>
        public decimal Sum { get; private set; }

        /// <summary>
        /// Процентная ставка
        /// </summary>
        public decimal Rate { get; private set; }

        /// <summary>
        /// Количество созданных объектов
        /// </summary>
        private static int counter = 0;

        public Account(decimal sum, decimal rate)
        {
            if (sum < MinSum) throw new Exception("Недопустимая сумма!");
            Sum = sum; Rate = rate;

            counter++;
        }

        /// <summary>
        /// Минимальная допустимая сумма для всех счетов
        /// </summary>
        public static decimal MinSum
        {
            get { return minSum; }
            set { if (value > 0) minSum = value; }
        }

        /// <summary>
        /// Подсчет суммы на счете через определенный период по определенной ставке
        /// </summary>
        /// <param name="sum">Сумма</param>
        /// <param name="rate">Ставка</param>
        /// <param name="period">Период</param>
        /// <returns></returns>
        public static decimal GetSum(decimal sum, decimal rate, int period)
        {
            decimal result = sum;

            for (int i = 1; i <= period; i++)
            {
                result = result + result * rate / 100;
            }

            return result;
        }
    }
}
