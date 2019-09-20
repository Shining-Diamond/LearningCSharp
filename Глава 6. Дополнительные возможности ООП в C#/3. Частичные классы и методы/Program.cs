using System;

namespace _3.Частичные_классы_и_методы
{
    class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person();

            person.Move();
            person.Eat();

            person.DoSomething();
        }
    }

    public partial class Person
    {
        public void Eat()
        {
            Console.WriteLine("I am eating");
        }

        partial void DoSomethingElse()
        {
            Console.WriteLine("I am reading a book");
        }
    }

    public partial class Person
    {
        partial void DoSomethingElse();

        public void DoSomething()
        {
            Console.WriteLine("Start");
            DoSomethingElse();
            Console.WriteLine("Finish");
        }

        public void Move()
        {
            Console.WriteLine("I'm moving");
        }
    }
}