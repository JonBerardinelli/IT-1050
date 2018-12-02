using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IT_1050_Lab4
{
    class Program
    {
        static void Main(string[] args)
        {

            GatherInfo tickets = new GatherInfo();
            tickets.MovieTicketsInfo();
            tickets.ConcessionsInfo();
            tickets.DiscountInfo();
            tickets.TotalPriceCalc();

            System.Console.WriteLine("Press any key to end program.");
            System.Console.ReadKey();

        }
    }
}
