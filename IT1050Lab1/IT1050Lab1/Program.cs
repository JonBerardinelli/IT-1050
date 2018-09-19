using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IT1050Lab1
{
    class Program
    {
        static void Main(string[] args)
        {
            string firstName;
            string middleInitial;
            string lastName;
            string fullName;
            int age;
            bool isCitizen;
            bool canVote;
            int heightFeet;
            double heightInches;
            double totalHeightCM;

            System.Console.WriteLine("Hello, what is your first name? ");
            firstName = System.Console.ReadLine();

            System.Console.WriteLine("What is your middle initial? ");
            middleInitial = System.Console.ReadLine();

            System.Console.WriteLine("What is your last name? ");
            lastName = System.Console.ReadLine();

            fullName = firstName + " " + middleInitial + " " + lastName;

            System.Console.WriteLine("How many full feet tall are you? (Round down to whole feet) ");
            heightFeet = int.Parse(System.Console.ReadLine());

            System.Console.WriteLine("How many inches beyond your base hieght are you? " +
                "(Example, If you are 6 foot 1 and a quarter inches, then please input 1.25)) ");
            heightInches = double.Parse(System.Console.ReadLine());

            totalHeightCM = ((heightFeet * 12) + heightInches) * 2.54;

            System.Console.WriteLine("What is your age? ");
            age = int.Parse(System.Console.ReadLine());

            System.Console.WriteLine("true or false: You are a citizen of the US? ");
            isCitizen = bool.TryParse(Console.ReadLine(), out bool result);

            if ((isCitizen == true) && (age >= 18))
            {
                canVote = true;
            }
            else
            {
                canVote = false;
            }

            System.Console.WriteLine("Thank you for your input: " + fullName);
            System.Console.WriteLine("Your height in centimeters is: " + totalHeightCM + " cm");

            if (canVote == true)
            {
                System.Console.WriteLine("You are able to vote ");
            }
            else
            {
                System.Console.WriteLine("You aren't eligible to vote");
            }

            System.Console.WriteLine("Press any key to continue... ");  
            System.Console.ReadKey();                              

        }
    }
}
