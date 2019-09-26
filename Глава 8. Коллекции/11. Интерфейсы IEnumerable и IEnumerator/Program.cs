using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11.Интерфейсы_IEnumerable_и_IEnumerator
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = { 0, 2, 4, 6, 8, 10 };

            IEnumerator ie = numbers.GetEnumerator();

            while (ie.MoveNext())
            {
                int item = (int)ie.Current;
                Console.WriteLine(item);
            }

            ie.Reset();

            Week week = new Week();

            foreach (string day in week)
            {
                Console.Write(day + " ");
            }
        }
    }

    class Week : IEnumerable
    {
        string[] days =
        {
            "Monday",
            "Tuesday",
            "Wednesday",
            "Thursday",
            "Friday",
            "Saturday",
            "Sunday"
        };

        public IEnumerator GetEnumerator()
        {
            return new WeekEnumerator(days);
        }
    }

    class WeekEnumerator : IEnumerator
    {
        string[] days;
        int position = -1;

        public WeekEnumerator(string[] days)
        {
            this.days = days;
        }

        public object Current
        {
            get
            {
                if (position == -1 || position >= days.Length)
                    throw new InvalidOperationException();

                return days[position];
            }
        }

        public bool MoveNext()
        {
            if (position < days.Length - 1)
            {
                position++;
                return true;
            }

            return false;
        }

        public void Reset()
        {
            position = -1;
        }
    }
}