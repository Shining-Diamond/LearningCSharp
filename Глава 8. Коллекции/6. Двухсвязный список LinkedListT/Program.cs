using System;
using System.Collections.Generic;

namespace _6.Двухсвязный_список_LinkedListT
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * Этот класс имеет следующие свойства:
             * Value: само значение узла, представленное типом T
             * Next: ссылка на следующий элемент типа LinkedListNode<T> в списке. Если следующий элемент отсутствует, то имеет значение null
             * Previous: ссылка на предыдущий элемент типа LinkedListNode<T> в списке. Если предыдущий элемент отсутствует, то имеет значение null
            */

            /*
             * AddAfter(LinkedListNode < T > node, LinkedListNode < T > newNode): вставляет узел newNode в список после узла node.
             * AddAfter(LinkedListNode < T > node, T value): вставляет в список новый узел со значением value после узла node.
             * AddBefore(LinkedListNode < T > node, LinkedListNode < T > newNode): вставляет в список узел newNode перед узлом node.
             * AddBefore(LinkedListNode < T > node, T value): вставляет в список новый узел со значением value перед узлом node.
             * AddFirst(LinkedListNode < T > node): вставляет новый узел в начало списка
             * AddFirst(T value): вставляет новый узел со значением value в начало списка
             * AddLast(LinkedListNode < T > node): вставляет новый узел в конец списка
             * AddLast(T value): вставляет новый узел со значением value в конец списка
             * RemoveFirst(): удаляет первый узел из списка.После этого новым первым узлом становится узел, следующий за удаленным
             * RemoveLast(): удаляет последний узел из списка
            */

            LinkedList<int> numbers = new LinkedList<int>();

            numbers.AddLast(1);
            numbers.AddFirst(2);
            numbers.AddAfter(numbers.Last, 3);

            foreach (int i in numbers)
            {
                Console.WriteLine(i);
            }

            LinkedList<Person> persons = new LinkedList<Person>();

            // добавляем persona в список и получим объект LinkedListNode<Person>, в котором хранится имя Tom
            LinkedListNode<Person> tom = persons.AddLast(new Person() { Name = "Tom" });
            persons.AddLast(new Person() { Name = "John" });
            persons.AddFirst(new Person() { Name = "Bill" });

            Console.WriteLine(tom.Previous.Value.Name); // получаем узел перед томом и его значение
            Console.WriteLine(tom.Next.Value.Name); // получаем узел после тома и его значение
        }
    }

    class Person
    {
        public string Name { get; set; }
    }
}
