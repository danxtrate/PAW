using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PAW1_3
{
    class Person: Object, ICloneable
    {
        public int Age { get; set; }

        public int[] Marks { get; set; }
        public Person (int age)
        {
            Age = age;
        }
        public object Clone()
        {
            var clone = (Person) MemberwiseClone();
            clone.Marks = (int[])this.Marks.Clone();
            return clone;
        }

        public static explicit operator int(Person p)
        {
            return p.Age;
        }
        public override string ToString()
        {
            return string.Join(", ", Marks);
        }
    }
}
