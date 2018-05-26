using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace 阐述lambda
{
    public class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }
    }
    class Program
    {

        public static List<Person> PersonsList()
        {
            List<Person> persons = new List<Person>();
            for (int i = 0; i < 8; i++)
            {
                Person p = new Person() { Name = i + "儿子", Age = 8 - i, };
                persons.Add(p);
            }
            return persons;
        }
        public static void Console_data(List<Person> data)
        {
            Console.WriteLine(data);
            foreach (var i in data)
            {
                Console.WriteLine(i.Name + "  " + i.Age);
            }
            Console.WriteLine();
        }

        static void Main(string[] args)
        {
            List<Person> persons = PersonsList();
            Person d = new Person();
            Console_data(persons);
            Console.WriteLine(Math.Abs(9 - 4) <= 3);
            //d = persons.Where(p => p.Age == 6);     //所有Age>6的Person的集合
            Console_data(persons);
            Person per = persons.SingleOrDefault(p => p.Age == 1);  //Age=1的单个people类
            persons = persons.Where(p => p.Name.Contains("儿子")).ToList();   //所有Name包含儿子的Person的集合
            Console_data(persons);

            Console.ReadKey();
        }
    }
}