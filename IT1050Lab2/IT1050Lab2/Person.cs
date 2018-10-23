using System;
using System.Collections.Generic;
using System.Text;

namespace IT1050Lab2
{
    class Person
    {
        public int Age;
        public string FirstName;
        public string LastName;
        public Person Spouse;
        public static double NumberOfPeople = 0;
        public static double SumOfAllAges;

        public string GetFullName()
        {
            return this.FirstName + " " + this.LastName;
        }

        public void PrintNameAndAge()
        {
            System.Console.WriteLine("My full name is " + this.GetFullName() + ".");
            System.Console.WriteLine("I am " + this.Age + " years old.");
        }
        public void AskingUserInput()
        {
            this.FirstName = Question.AskForString("What is your first name?");
            this.LastName = Question.AskForString("What is your last name?");
            this.Age = Question.AskForInteger("What is your age?");
            Person.SumOfAllAges += this.Age;
            Person.NumberOfPeople += 1;
        }

        public void SpouseEntry()
        {
            System.Console.Write("Do you have a spouse? (yes or no) : ");
            if (System.Console.ReadLine().ToLower().StartsWith("y"))
            {
                this.Spouse = new Person();
                this.Spouse.AskingUserInput();
                this.Spouse.Spouse = this;
            }
            System.Console.WriteLine("\n");
        }

        public static double AveragePeopleAge()
        {
            return Person.SumOfAllAges / Person.NumberOfPeople;
        }

    }
}
