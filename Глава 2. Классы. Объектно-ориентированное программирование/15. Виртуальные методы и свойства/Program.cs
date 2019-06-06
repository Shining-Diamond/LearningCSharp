using System;

namespace _15.Виртуальные_методы_и_свойства
{
    class Program
    {
        static void Main(string[] args)
        {
            Person person1 = new Person("Игорь", "Иванов");

            person1.Display();
            person1.Age = 25;
            person1.DisplayAge();

            Employee person2 = new Employee("Петр", "Петров", "Google");

            person2.Display();
            person2.Age = 30;
            person2.DisplayAge();

            Console.ReadKey();
        }

        class Person
        {
            public string FirstName { get; set; }

            public string LastName { get; set; }

            public virtual int Age { get; set; }

            public Person(string firstName, string lastName)
            {
                FirstName = firstName;
                LastName = lastName;
            }

            public virtual void Display()
            {
                Console.WriteLine($"{FirstName} {LastName}");
            }

            public virtual void DisplayAge()
            {
                Console.WriteLine($"{Age} лет");
            }
        }

        class Employee : Person
        {
            public string Company { get; set; }

            public override int Age { get => base.Age * 2; set => base.Age = value; }

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

            public sealed override void DisplayAge()
            {
                Console.WriteLine($"Если вы работаете в нашей компании, то вам скорее всего {Age}");
            }
        }
    }
}
