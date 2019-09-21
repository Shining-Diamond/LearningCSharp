using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9.Nullable_типы
{
    class Program
    {
        static void Main(string[] args)
        {
            int? x = 7;
            Console.WriteLine(x.Value); // 7
            Nullable<State> state = new State() { Name = "Narnia" };
            Console.WriteLine(state.Value.Name);    // Narnia

            if (x.HasValue)
            {
                Console.WriteLine(x.Value);
            }
            else
            {
                Console.WriteLine("x = null");
            }

            int? figure = null;

            // Значение по умолчанию
            Console.WriteLine(figure.GetValueOrDefault(10)); // 10

            // Равенство объектов
            int? x1 = null;
            int? x2 = null;

            if (x1 == x2)
            {
                Console.WriteLine("Объекты равны");
            }
            else
            {
                Console.WriteLine("Объекты не равны");
            }

            /*
             * Преобразование типов Nullable
             */

            // явное преобразование от T? к T
            int? x_1 = null;
            if (x_1.HasValue)
            {
                int x_2 = (int)x_1;
                Console.WriteLine(x_2);
            }

            // неявное преобразование от T к T?
            int xx = 4;
            int? xx2 = xx;
            Console.WriteLine(xx2);
        }
    }

    struct State
    {
        public string Name { get; set; }
    }
}
