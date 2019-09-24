using System;
using System.Collections.Generic;
using System.Collections;

namespace _1.Введение_в_коллекции
{
    class Program
    {
        static void Main(string[] args)
        {
            // необобщенная коллекция ArrayList
            ArrayList objectList = new ArrayList() { 1, 2, "string", 'c', 2.0f };
 
            object obj = 45.8;
 
            objectList.Add(obj);
            objectList.Add("string2");
            objectList.RemoveAt(0); // удаление первого элемента

            foreach (object o in objectList)
            {
                Console.WriteLine(o);
            }

            Console.WriteLine("Общее число элементов коллекции: {0}", objectList.Count);

            // обобщенная коллекция List
            List<string> countries = new List<string>() { "Россия", "США", "Великобритания", "Китай" };

            countries.Add("Франция");
            countries.RemoveAt(1); // удаление второго элемента

            foreach (string s in countries)
            {
                Console.WriteLine(s);
            }
        }
    }
}
