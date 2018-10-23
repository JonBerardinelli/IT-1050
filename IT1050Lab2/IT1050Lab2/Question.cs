using System;
using System.Collections.Generic;
using System.Text;

namespace IT1050Lab2
{
    class Question
    {
        public static string AskForString(string prompt)
        {
            System.Console.Write(prompt.PadRight(33) + " : ");
            return System.Console.ReadLine();
        }

        public static int AskForInteger(string prompt)
        {
            return int.Parse(AskForString(prompt));
        }

    }
}
