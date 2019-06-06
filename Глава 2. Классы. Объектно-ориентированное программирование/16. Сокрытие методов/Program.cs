using System;

/**
 * Также можно делать сокрытие для свойст и переменных
 */

namespace _16.Сокрытие_методов
{
    class Program
    {
        static void Main(string[] args)
        {
            Person bob = new Person("Bob", "Robertson");
            bob.Display(); // Bob Robertson

            Employee tom = new Employee("Tom", "Smith", "Microsoft");
            tom.Display(); // Tom Smith работает в Microsoft

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

            public void Display()
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

            public new void Display()
            {
                Console.WriteLine($"{FirstName} {LastName} работает в {Company}");
            }
        }
    }
}
