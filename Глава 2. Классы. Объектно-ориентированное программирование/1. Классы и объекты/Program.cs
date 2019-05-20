using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.Классы_и_объекты
{
    class Person
    {
        public string name;
        public int age;
 
        // Пустой конструктор
        public Person() : this("Неизвестно")
        {
        }

        // Конструктор с инициализацией имени и возраста 18 лет
        public Person(string name) : this(name, 18)
        {
        }

        // Конструктор с инициализацией имени и возраста
        public Person(string name, int age)
        {
            this.name = name;
            this.age = age;
        }

        // Получаем имя и возраст
        public void GetInfo()
        {
            Console.WriteLine($"Имя: {name}  Возраст: {age}");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Person tom = new Person(); // Вызов 1-ого конструктора без параметров
            Person bob = new Person("Bob"); // Вызов 2-ого конструктора с одним параметром
            Person sam = new Person("Sam", 25); // Вызов 3-его конструктора с двумя параметрами
     
     
            bob.GetInfo(); // Имя: Bob  Возраст: 18
            tom.GetInfo(); // Имя: Неизвестно  Возраст: 18
            sam.GetInfo(); // Имя: Sam  Возраст: 25

            Console.ReadKey();
        }
    }
}
