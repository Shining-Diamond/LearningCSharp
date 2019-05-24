using System;

namespace _10.Значение_null
{
    class Program
    {
        static void Main(string[] args)
        {
            // ?? оператор устанавливает значение по умолчанию, если значение ссылочного типа равно null
            object x = null;
            object y = x ?? 100;  // равно 100, так как x равен null

            object z = 200;
            object t = z ?? 44; // равно 200, так как z не равен null

            User user = new User();

            // Оператор ? проверяет равен ли объект null.
            string companyName = user?.Phone?.Company?.Name ?? "не установлено";

            Console.WriteLine(companyName);

            Console.ReadKey();
        }
    }

    class User
    {
        public Phone Phone { get; set; }
    }

    class Phone
    {
        public Company Company { get; set; }
    }

    class Company
    {
        public string Name { get; set; }
    }
}
