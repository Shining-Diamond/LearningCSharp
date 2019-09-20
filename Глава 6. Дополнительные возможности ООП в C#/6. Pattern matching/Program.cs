using System;

namespace _6.Pattern_matching
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee emp = new Manager();

            UseEmployee(emp);
        }

        static void UseEmployee(Employee emp)
        {
            if (emp is Manager manager && !manager.IsOnVacation)
            {
                manager.Work();
            }
            else
            {
                Console.WriteLine("Преобразование не допустимо");
            }
        }
    }

    class Employee
    {
        public virtual void Work()
        {
            Console.WriteLine("Да работаю я, работаю");
        }
    }
 
    class Manager : Employee
    {
        public override void Work()
        {
            Console.WriteLine("Отлично, работаем дальше");
        }

        public bool IsOnVacation { get; set; }
    }
}
