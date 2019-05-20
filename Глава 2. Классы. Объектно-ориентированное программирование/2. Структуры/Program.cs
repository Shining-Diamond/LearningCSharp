using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * При создании экземпляра структуры, необходимо проинициализировать её поля.
 */

namespace _2.Структуры
{
    // Структура пользователя
    struct User
    {
        public string name;
        public int age;
 
        public User(string name, int age)
        {
            this.name = name;
            this.age = age;
        }

        public void DisplayInfo()
        {
            Console.WriteLine($"Name: {name}  Age: {age}");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            User tom = new User("Tom", 34);
            tom.DisplayInfo(); // Name: Tom Age: 34
 
            User bob = new User();
            bob.DisplayInfo(); // Name: Age: 0
             
            Console.ReadKey();
        }
    }
}
