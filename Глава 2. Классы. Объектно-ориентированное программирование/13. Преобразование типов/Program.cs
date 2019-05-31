using System;

namespace _13.Преобразование_типов
{
    class Program
    {
        static void Main(string[] args)
        {
            // Нисходящие преобразования. Downcasting
            object obj = new Employee("Bill", "Microsoft");

            // Чтобы обратиться к возможностям типа Employee, приводим объект к типу Employee
            Employee emp = (Employee)obj;

            // объект Client также представляет тип Person
            Person person = new Client("Sam", "ContosoBank");

            // преобразование от типа Person к Client
            Client client = (Client)person;

            Person person2 = new Employee("Tom", "Kek");

            Employee emp2 = (Employee)person2;

            if (emp2 == null)
            {
                Console.WriteLine("Преобразование прошло неудачно");
            }
            else
            {
                Console.WriteLine(emp.Company);
            }

            Person person3 = new Person("Tom");

            if (person is Employee)
            {
                Employee emp3 = (Employee)person;
                Console.WriteLine(emp.Company);
            }
            else
            {
                Console.WriteLine("Преобразование не допустимо");
            }

            Console.ReadKey();
        }
    }

    class Person
    {
        public string Name { get; set; }
        public Person(string name)
        {
            Name = name;
        }
        public void Display()
        {
            Console.WriteLine($"Person {Name}");
        }
    }

    class Employee : Person
    {
        public string Company { get; set; }
        public Employee(string name, string company) : base(name)
        {
            Company = company;
        }
    }

    class Client : Person
    {
        public string Bank { get; set; }
        public Client(string name, string bank) : base(name)
        {
            Bank = bank;
        }
    }
}
