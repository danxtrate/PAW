using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace PAW1 //seminar 1 din github
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.Write("Name ");
            //string name = Console.ReadLine();
            //Console.WriteLine("Hello " + name +"!");
            //Console.WriteLine("Hello {0}!", name); //tot ce e intre {} e placeholder pentru parametru, unde intre {} se pune indexul parametrului de dupa virgula
            //Console.WriteLine($"Hello {name}!"); //se poate apela si parametru ca placeholder punand $ in fata sirului de caractere
            //int a = new int();
            //Console.WriteLine(a);

            //string s1 = "ab";
            //string s2 = s1; // in C# nu exista constructor de copiere si nici = suprascris
            //s1 += "c";
            //Console.WriteLine(s1);
            //Console.WriteLine(s2);
            //s2 = "abc";
            //Console.WriteLine(s1 == s2);
            //Console.WriteLine((object)s1==s2); //cast la = din object, compara adresele celor doua string-uri

            ////****Concatenare fara StringBuilder
            //int n = 200000;
            //string regularString = string.Empty;
            //Stopwatch watch = Stopwatch.StartNew();  //clasa dedicata pentru controlul timpului de executie. Foloseste namespace-ul System.Diagnostics
            //for (int i = 0; i < n; i++)
            //    regularString += "a";
            //watch.Stop();
            //Console.WriteLine(watch.ElapsedMilliseconds);

            ////******Concatenare cu StringBuilder
            //StringBuilder sb = new StringBuilder();
            //watch = Stopwatch.StartNew();
            //for (int i = 0; i < n; i++)
            //    sb.Append("a"); //nu exista += supraincarcat in StringBuilder
            //watch.Stop();
            //Console.WriteLine(watch.ElapsedMilliseconds);


            //******Array-uri

            int[] intArray; //se aloca in stack cu valoare null
            intArray = new int[3]; // se aloca in heap valorile implicite pentru int - 0
            for (int i = 0; i < intArray.Length; i++)
                Console.WriteLine(intArray[i]);

            intArray = new [] { 3, 2, 1 }; // nu e nevoie sa se precizeze lungimea vectorului si tipul sau daca se face initializarea la declarare
            Array.Sort(intArray);
            foreach (int element in intArray) //alternativa la for
                Console.WriteLine(element);
            
        }
    }
}
