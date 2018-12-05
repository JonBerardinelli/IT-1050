using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12_4_18
{
    class Program
    {
        static void Main(string[] args)
        {
            Person[] people;
            people = new Person[3];
            people[0] = new Person("Nick", "Smith");
            people[1] = new Person("Joe", "Smith");
            people[2] = new Person("Dianne", "Smith");

            foreach (Person names in people)
            {
                names.PrintFullName();
            }

            System.Console.ReadKey();

        }
    }
}
