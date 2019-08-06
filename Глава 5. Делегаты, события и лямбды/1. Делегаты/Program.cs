using System;

namespace _1.Делегаты
{
    class Program
    {
        delegate void Message();
        delegate int Operation(int x, int y);
        delegate T Operation<T, K>(K val);

        static void Main(string[] args)
        {
            Message mes;

            if (DateTime.Now.Hour < 12)
            {
                mes = GoodMorning;
            }
            else
            {
                mes = GoodEvening;
            }
            mes();

            Operation del = Add; // Делегат указывает на метод Add
            int result = del(4, 5); // Фактически Add(4, 5)
            Console.WriteLine(result);

            del = Multiply; // Делегат указывает на метод Multiply
            result = del(4, 5); // Фактически Multiply(4, 5)
            Console.WriteLine(result);

            // Вывоз метода из другого класса (Math)

            Math math = new Math();
            del = math.Sum;
            result = del(4, 5); // math.Sum(4, 5)
            Console.WriteLine(result);  // 9

            // Присвоение нескольких методов делегату
            Message mes1 = Hello;
            mes1 += HowAreYou;  // теперь mes1 указывает на два метода
            mes1(); // вызываются оба метода - Hello и HowAreYou
            mes1 -= HowAreYou;  // удаляем метод HowAreYou. Удаляется первое вхождение с конца
            mes1();

            Message mes2 = HowAreYou;

            Message mes3 = mes1 + mes2; // объединяем делегаты
            mes3(); // вызываются все методы из mes1 и mes2

            // Вызов делегата через метод Invoke

            Message mesInvoke = null; // Если делегат равен null, вызывается исключение, чтобы это избежать необходимо проверить его на null.
            mesInvoke?.Invoke(); // ошибки нет, делегат просто не вызывается

            // Если делегат содержит в себе несколько методов, которые возвращают значение, то при вызове вернётся значение последнего метода.
            Operation op = Subtract;
            op += Multiply;
            op += Add;
            Console.WriteLine(op(7, 2));    // Add(7,2) = 9

            // Делегаты как параметры методов

            if (DateTime.Now.Hour < 12)
            {
                Show_Message(GoodMorning);
            }
            else
            {
                Show_Message(GoodEvening);
            }

            // Обобщеные делегаты

            Operation<decimal, int> opSquare = Square;

            Console.WriteLine(opSquare(5)); // 25

            Console.ReadKey();
        }

        private static void Show_Message(Message _del)
        {
            _del?.Invoke();
        }

        static decimal Square(int n)
        {
            return n * n;
        }

        private static void GoodMorning()
        {
            Console.WriteLine("Good Morning");
        }

        private static void GoodEvening()
        {
            Console.WriteLine("Good Evening");
        }

        private static int Add(int x, int y)
        {
            return x + y;
        }

        private static int Multiply(int x, int y)
        {
            return x * y;
        }

        private static int Subtract(int x, int y)
        {
            return x - y;
        }

        private static void Hello()
        {
            Console.WriteLine("Hello");
        }

        private static void HowAreYou()
        {
            Console.WriteLine("How are you?");
        }
    }

    class Math
    {
        public int Sum(int x, int y) { return x + y; }
    }
}
