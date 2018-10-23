using System;

namespace IT1050Lab2
{
    class Program
    {

        static void Main(string[] args)
        {
            Person p1 = new Person();
            Person p2 = new Person();

            System.Console.WriteLine("[Gathering Info for Perosn 1]");
            p1.AskingUserInput();
            p1.SpouseEntry();

            System.Console.WriteLine("[Gathering Info for Perosn 2]");
            p2.AskingUserInput();
            p2.SpouseEntry();

            System.Console.WriteLine("[Perosn 1 Info]");
            p1.PrintNameAndAge();
            if (p1.Spouse != null)
            {
                p1.Spouse.PrintNameAndAge();
            }
            System.Console.WriteLine("\n");

            System.Console.WriteLine("[Perosn 2 Info]");
            p2.PrintNameAndAge();
            if (p2.Spouse != null)
            {
                p2.Spouse.PrintNameAndAge();
            }
            System.Console.WriteLine("\n");
            System.Console.WriteLine("The averagve age of the input people is:" + Person.AveragePeopleAge());

            System.Console.ReadKey();
        }

    }
}
