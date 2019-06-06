using System;

namespace _15.Виртуальные_методы_и_свойства
{
    class Program
    {
        static void Main(string[] args)
        {
            Person person1 = new Person("Игорь", "Иванов");

            person1.Display();

            Employee person2 = new Employee("Петр", "Петров", "Google");

            person2.Display();

            Console.ReadKey();
        }

        class Person
        {
            public string FirstName { get; set; }

            public string LastName { get; set; }

            public Person(string firstName, string lastName)
            {
                FirstName = firstName;
                LastName = lastName;
            }

            public virtual void Display()
            {
                Console.WriteLine($"{FirstName} {LastName}");
            }
        }

        class Employee : Person
        {
            public string Company { get; set; }

            public Employee(string firstName, string lastName, string company)
                : base(firstName, lastName)
            {
                Company = company;
            }

            /// <summary>
            /// Переопределенный метод базового класса
            /// </summary>
            public override void Display()
            {
                Console.WriteLine($"{FirstName} {LastName} работает в {Company}");
            }
        }
    }
}
