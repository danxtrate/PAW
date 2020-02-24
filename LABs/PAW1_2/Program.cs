using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PAW1_2 // seminarul 2 de pe GitHub
{
    class Program
    {
        static void Main(string[] args)
        {
            //Person p = new Person("Ionescu"); //trebuie creata o instanta a clasei, nu se apeleaza constructor implicit
            //p.Age = 21;
            //Console.WriteLine(p.Age);
            //Console.WriteLine(p);

            //Person p2 = new Person(p);
            //Console.WriteLine(p2);


            var p1 = new Person("Name 1 ", 10);
            var p2 = new Person("Name 2 ", 20);
            var p3 = new Person("Name 2 ", 30);

            var pArray = new[] { p1, p2, p3 };
            var descComparer = new PersonComparerDSC();
            Array.Sort(pArray);
            
            foreach (var p in pArray)
                Console.WriteLine(p);
            

        }
    }
}
