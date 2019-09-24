using System;
using System.Collections.Generic;

namespace _5.Список_ListT
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * void Add(T item): добавление нового элемента в список
             * void AddRange(ICollection collection): добавление в список коллекции или массива
             * int BinarySearch(T item): бинарный поиск элемента в списке.Если элемент найден,
             * то метод возвращает индекс этого элемента в коллекции. При этом список должен быть отсортирован.
             * int IndexOf(T item): возвращает индекс первого вхождения элемента в списке
             * void Insert(int index, T item): вставляет элемент item в списке на позицию index
             * bool Remove(T item): удаляет элемент item из списка, и если удаление прошло успешно, то возвращает true
             * void RemoveAt(int index): удаление элемента по указанному индексу index
             * void Sort(): сортировка списка
             */

            List<int> numbers = new List<int>() { 1, 2, 3, 4, 5 };
            numbers.Add(6);

            numbers.AddRange(new int[] { 7, 8, 9 });

            numbers.Insert(0, 666);
            numbers.RemoveAt(1);

            foreach (int i in numbers)
            {
                Console.WriteLine(i);
            }

            List<Person> people = new List<Person>(3);
            people.Add(new Person() { Name = "Том" });
            people.Add(new Person() { Name = "Билл" });

            foreach (Person p in people)
            {
                Console.WriteLine(p.Name);
            }
        }
    }

    class Person
    {
        public string Name { get; set; }
    }
}
