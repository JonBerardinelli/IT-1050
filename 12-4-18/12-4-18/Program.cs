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
            #region Intructions 
            /*
            Loops and Arrays Practice Assignment

                Create a class named Person
                •	Every Person has a FirstName which is a string.
                •	Every Person has a LastName which is a string.
                •	Every Person is created with initial values for their FirstName and LastName.
                •	Every Person can Print their full name to the console.

                In the Main Program:
                •	Declare and instantiate at least 3 people with distinct names.
                •	Store all three people inside of a single array.
                •	Loop through the array and print each person’s full name.
            */
            #endregion

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
