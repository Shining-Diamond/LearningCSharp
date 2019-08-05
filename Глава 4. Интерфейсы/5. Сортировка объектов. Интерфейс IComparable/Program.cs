using System;
using System.Collections.Generic;

namespace _5.Сортировка_объектов.Интерфейс_IComparable
{
    class Program
    {
        static void Main(string[] args)
        {
            Person p1 = new Person { Name = "Bill", Age = 34 };
            Person p2 = new Person { Name = "Tom", Age = 23 };
            Person p3 = new Person { Name = "Alice", Age = 21 };

            Person[] people = new Person[] { p1, p2, p3 };
            Array.Sort(people, new PeopleComparer());

            foreach (Person p in people)
            {
                Console.WriteLine("{0} - {1}", p.Name, p.Age);
            }

            Console.ReadKey();
        }
    }

    /// <summary>
    /// Интерфейс сравнивает текущий объект с объектом Person
    /// </summary>
    class Person : IComparable<Person>
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public int CompareTo(Person p)
        {
            if (p != null)
            {
                return Name.CompareTo(p.Name);
            }
            else
            {
                throw new Exception("Невозможно сравнить два объекта");
            }
        }
    }

    /// <summary>
    /// Интерфейс сравнивает два объекта Person
    /// </summary>
    class PeopleComparer : IComparer<Person>
    {
        public int Compare(Person p1, Person p2)
        {
            if (p1.Name.Length > p2.Name.Length)
            {
                return 1;
            }
            else if (p1.Name.Length < p2.Name.Length)
            {
                return -1;
            }
            else
            {
                return 0;
            }
        }
    }
}
