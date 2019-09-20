using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7.Деконструкторы
{
    class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person()
            {
                Name = "Tom",
                Age = 23
            };

            (string name, int age) = person;

            Console.WriteLine(name);
            Console.WriteLine(age);
        }
    }

    class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }

        // Можно применять с 2 и более параметрами
        public void Deconstruct(out string name, out int age)
        {
            name = this.Name;
            age = this.Age;
        }
    }
}
