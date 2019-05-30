using System;

namespace _12.Наследование
{
    class Program
    {
        static void Main(string[] args)
        {
            Person p = new Person("Bill");

            p.Display();

            Employee emp = new Employee("Tom", 22, "Microsoft");

            emp.Display();

            Console.ReadKey();
        }
    }

    class Person
    {
        string name;
        int age;
 
        public Person(string name)
        {
            this.name = name;
            Console.WriteLine("Person(string name)");
        }

        public Person(string name, int age) : this(name)
        {
            this.age = age;
            Console.WriteLine("Person(string name, int age)");
        }

        public void Display()
        {
            Console.WriteLine(name);
        }
    }

    class Employee : Person
    {
        string company;
 
        public Employee(string name, int age, string company) : base(name, age)
        {
            this.company = company;
            Console.WriteLine("Employee(string name, int age, string company)");
        }
    }
}
