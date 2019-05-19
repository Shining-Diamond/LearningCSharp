namespace _9.Условные_выражения
{
    class Program
    {
        static void Main(string[] args)
        {
            // Операции сравнения
            int a = 10;
            int b = 4;

            bool c = a == b; // false
            bool c2 = a != b; // true
            bool c3 = a < b; // false
            bool c4 = a > b; // true
            bool c5 = a <= b; // false
            bool c6 = a >= b; // true

            // Логические операции
            /*
             * |, & - вычисляют все операции.
             * ||, && - вычисляют до необходимой операции, в результате которой будет инвестно решение.
             */
            bool x1 = (5 > 6) | (4 < 6); // 5 > 6 - false, 4 < 6 - true, поэтому возвращается true
            bool x2 = (5 > 6) | (4 > 6); // 5 > 6 - false, 4 > 6 - false, поэтому возвращается false

            bool x3 = (5 > 6) & (4 < 6); // 5 > 6 - false, 4 < 6 - true, поэтому возвращается false
            bool x4 = (5 < 6) & (4 < 6); // 5 < 6 - true, 4 < 6 - true, поэтому возвращается true

            bool x5 = (5 > 6) || (4 < 6); // 5 > 6 - false, 4 < 6 - true, поэтому возвращается true
            bool x6 = (5 > 6) || (4 > 6); // 5 > 6 - false, 4 > 6 - false, поэтому возвращается false

            bool x7 = (5 > 6) && (4 < 6); // 5 > 6 - false, 4 < 6 - true, поэтому возвращается false
            bool x8 = (5 < 6) && (4 < 6); // 5 < 6 - true, 4 > 6 - true, поэтому возвращается true

            bool x9 = true;
            bool x10 = !x9; // false

            bool x11 = (5 > 6) ^ (4 < 6); // 5 > 6 - false, 4 < 6 - true, поэтому возвращается true
            bool x12 = (50 > 6) ^ (4 / 2 < 3); // 50 > 6 - true, 4/2 < 3 - true, поэтому возвращается false
        }
    }
}
