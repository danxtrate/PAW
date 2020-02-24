using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PAW1_2
{
    class Person : IComparable<Person>   //IComparable - interfata
    {
        private int age;

        //********Getteri si setter ca in C++ - nu se folosesc
        //public int GetAge()
        //{
        //    return age;
        //}
        //public void SetAge(int age)
        //{
        //    this.age = age;
        //}

        public int Age
        {
            get { return age; }
            set { age = value; }
        }

        public string Name { get; set; } // getter si setter declarate pentru nume public

        public Person(string name) //constructor cu un singur parametru
        {
            Name = name;
        }

        public Person(string name, int age):this(name) //apeleaza constructorul de mai sus pentru nume
        {
            Age = age;
        }

        //constructor de copiere
        public Person(Person other):this(other.Name, other.Age)
        {

        }

        //destructor - nu se implementeaza niciodata in C#
        ~Person()
        {
            Console.WriteLine("Destructor");
        }

        //override ToString
        public override string ToString()
        {
            //return base.ToString(); //apeleaza ToString in clasa parinte
            return "Name: " + Name + "Age: " + Age;
        }

        public int CompareTo(Person other)     //interfata ICompareble implementata
        {
            if (this.Name == other.Name)
            {
                return (-1) * this.Age.CompareTo(other.Age);
            }
            else
                return this.Name.CompareTo(other.Name);

        }

    

    }

    class PersonComparerASC : IComparer<Person>
    {
        public int Compare(Person x, Person y)
        {
            return x.Name.CompareTo(y.Name); //sorteaza crescator
        }
    }
    class PersonComparerDSC : IComparer<Person>
    {
        public int Compare(Person x, Person y)
        {
            return - x.Name.CompareTo(y.Name); // sorteaza descrescator
        }
    }
}
