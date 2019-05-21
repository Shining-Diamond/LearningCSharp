using System;

namespace _5.Свойства_и_инкапсуляция
{
    class Program
    {
        static void Main(string[] args)
        {
            Person p = new Person("Tom", 24);

            // Ошибка - set объявлен с модификатором private
            //p.Name = "John";

            Console.WriteLine(p.LastName); // Иванов

            Console.WriteLine(p.Name); // Tom

            Console.ReadKey();
        }
    }

    class Person
    {
        private string name;
        private int age;
        private string lastName;

        // эквивалентно public string LastName { get { return lastName; } }
        public string LastName { get; private set; }

        /// <summary>
        /// Инициализация автоматического свойства значением по умолчанию.
        /// </summary>
        public int Money { get; set; } = 1000;

        public string Name
        {
            get
            {
                return name;
            }

            private set
            {
                if (!string.IsNullOrWhiteSpace(value))
                {
                    name = value;
                }
            }
        }

        public int Age
        {
            get;
            set;
        }

        public Person(string name, int age)
        {
            Name = name;
            Age = age;
        }
    }
}
