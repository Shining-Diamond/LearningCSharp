using System;

namespace _19.Класс_System.Object_и_его_методы
{
    class Program
    {
        static void Main(string[] args)
        {
            Clock clock = new Clock() { Hours = 5, Minutes = 30, Seconds = 54 };

            Console.WriteLine(clock); // 5:30:54

            Person person = new Person();

            person.Name = "Ваня";

            Console.WriteLine(person); // Ваня

            Console.WriteLine(person.GetHashCode()); // Хеш код свойства Name

            Person person2 = new Person();

            person2.Name = "Ваня";

            Console.WriteLine(person2.GetHashCode()); // Выведет аналогичный хеш код как у объекта person

            Console.WriteLine(person2.GetType()); // Person

            Console.WriteLine(person.Equals(person2)); // true

            Console.ReadKey();
        }
    }

    class Clock
    {
        public int Hours { get; set; }

        public int Minutes { get; set; }

        public int Seconds { get; set; }

        /// <summary>
        /// Переопределенный метод базового класса Object, выводящий время.
        /// </summary>
        /// <returns>Строку с временем хранящемся в объекте.</returns>
        public override string ToString()
        {
            return $"{Hours}:{Minutes}:{Seconds}";
        }
    }

    class Person
    {
        public string Name { get; set; }

        /// <summary>
        /// Переопределенный метод, выводящий имя человека.
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            if (String.IsNullOrEmpty(Name))
                return base.ToString();

            return Name;
        }

        /// <summary>
        /// Возвращает Hash свойства Name
        /// </summary>
        /// <returns></returns>
        public override int GetHashCode()
        {
            return Name.GetHashCode();
        }

        /// <summary>
        /// Определяет равны ли свойства объектов.
        /// </summary>
        /// <param name="obj">Проверяемый объект</param>
        /// <returns>True - если равны, False - не равны</returns>
        public override bool Equals(object obj)
        {
            if (this.GetType() != obj.GetType()) return false;

            Person person = (Person)obj;

            return (this.Name == person.Name);
        }
    }
}
