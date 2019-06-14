using System;

namespace _4.Копирование_объектов.Интерфейс_ICloneable
{
    class Program
    {
        static void Main(string[] args)
        {
            Person p1 = new Person { Name = "Игорь", Age = 23, Work = new Company() { Name = "Google" } };

            Person p2 = (Person)p1.Clone();
            p2.Work.Name = "Microsoft";
            p2.Name = "Василий";

            Console.WriteLine(p1.Name); // Игорь
            Console.WriteLine(p1.Work.Name); // Google
            Console.WriteLine(p2.Name); // Василий
            Console.WriteLine(p2.Work.Name); // Microsoft

            Console.ReadKey();
        }
    }

    class Person : ICloneable
    {
        public string Name { get; set; }
        public int Age { get; set; }

        public Company Work { get; set; }

        // Поверхостное копирование затрагивает только примитивные свойства класс (MemberwiseClone).
        public object Clone()
        {
            Company company = new Company() { Name = this.Work.Name };

            return new Person
            {
                Name = Name,
                Age = Age,
                Work = company
            };
        }
    }

    class Company
    {
        public string Name { get; set; }
    }
}
