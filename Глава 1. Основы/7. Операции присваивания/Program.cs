namespace _7.Операции_присваивания
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = 10;

            number += 10; // 20
            number -= 4; // 16
            number *= 2; // 32
            number /= 8; // 4
            number <<= 4; // 100 -> 1000000 => 64
            number >>= 2; // 1000000 -> 10000 => 16

            // Операции присвоения выполняются справа налево
            int a = 8;
            int b = 6;
            int c = a += b -= 5; // 9
        }
    }
}
