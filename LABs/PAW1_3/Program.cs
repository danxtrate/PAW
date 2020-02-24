using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PAW1_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Person p1 = new Person(21);
            p1.Marks = new[] { 10, 10 }; //trebuie creat vectorul de note inainte de clonare
            Person p2 = (Person)p1.Clone();

            p1.Age = 10;
            Console.WriteLine(p1.Age);
            Console.WriteLine(p2.Age);

            p1.Marks[0] = 9;

            Console.WriteLine(p1);
            Console.WriteLine(p2);
            Console.WriteLine((int)p1);

            List<string> stringList;
            stringList = new List<string>();
            stringList.Add("a1");
            stringList.Add("a2");
            stringList.Insert(1, "a3");

            foreach(var element in stringList)
            {
                Console.WriteLine(element);
            }

            List<Person> people = new List<Person>();
            people.Add(p1);
            people.Add(p2);

            foreach(Person person in people)
            {
                Console.WriteLine(person);
            }

        }
    }
}
