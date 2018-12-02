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
            GatherInfo concessions = new GatherInfo();
            GatherInfo discounts = new GatherInfo();
            tickets.MovieTicketsInfo();
            concessions.ConcessionsInfo();
            discounts.DiscountInfo();


        }
    }
}
