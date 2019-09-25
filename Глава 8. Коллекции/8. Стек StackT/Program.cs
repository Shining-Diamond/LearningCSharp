using System;
using System.Collections.Generic;

namespace _8.Стек_StackT
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            * Push: добавляет элемент в стек на первое место
            * Pop: извлекает и возвращает первый элемент из стека
            * Peek: просто возвращает первый элемент из стека без его удаления
            */
            Stack<int> numbers = new Stack<int>();

            numbers.Push(3); // в стеке 3
            numbers.Push(5); // в стеке 5, 3
            numbers.Push(8); // в стеке 8, 5, 3

            // так как вверху стека будет находиться число 8, то оно и извлекается
            int stackElement = numbers.Pop(); // в стеке 5, 3
            Console.WriteLine(stackElement);

            Stack<Person> persons = new Stack<Person>();
            persons.Push(new Person() { Name = "Tom" });
            persons.Push(new Person() { Name = "Bill" });
            persons.Push(new Person() { Name = "John" });

            foreach (Person p in persons)
            {
                Console.WriteLine(p.Name);
            }

            // Первый элемент в стеке
            Person person = persons.Pop(); // теперь в стеке Bill, Tom
            Console.WriteLine(person.Name);
        }
    }

    class Person
    {
        public string Name { get; set; }
    }
}
