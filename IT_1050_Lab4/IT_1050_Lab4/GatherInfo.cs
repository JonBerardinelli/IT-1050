using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IT_1050_Lab4
{
    public class GatherInfo
    {
        bool trueMatinee;
        int childTickets;
        int adultTickets;
        int seniorTickets;
        double ticketSum;
        int smallSodaNum;
        int largeSodaNum;
        int hotDognum;
        int popcornNum;
        int candyNum;
        double concessionSum;
        double popcornLSodaDiscount;
        double groupPopcornDiscount;
        double candyBulkDiscount;
        int totalTicketNum;
        double minvale1;
        double minvale2;
        double totalDiscount;
        double totalPrice;

        public void MovieTicketsInfo()
        {
            this.trueMatinee = Question.AskForBool("Hello, are you going to a Matinee (true) or an Eveninng (false) showing?");
            this.childTickets = Question.AskForInteger("How many Child tickets will  you need?");
            this.adultTickets = Question.AskForInteger("How many Adult tickets will  you need?");
            this.seniorTickets = Question.AskForInteger("How many Senior tickets will  you need?");

            if (trueMatinee == true)
            {
                this.ticketSum = (childTickets * Prices.childMatinee) + (adultTickets * Prices.adultMatinee) +
                    (seniorTickets * Prices.seniorMatinee);
            }
            else
            {
                this.ticketSum = (childTickets * Prices.childEvening) + (adultTickets * Prices.adultEvening) +
                    (seniorTickets * Prices.seniorEvening);
            }
        }
        public void ConcessionsInfo()
        {
            this.smallSodaNum = Question.AskForInteger("How many small sodas would you like?");
            this.largeSodaNum = Question.AskForInteger("How many large sodas would you like?");
            this.hotDognum = Question.AskForInteger("How many orders of hot dogs would you like?");
            this.popcornNum = Question.AskForInteger("How many orders of popcorn would you like?");
            this.candyNum = Question.AskForInteger("How many orders of candy would you like?");

            this.concessionSum = (smallSodaNum * Prices.smallSoda) + (largeSodaNum * Prices.largeSode) + 
                (hotDognum * Prices.hotDog) + (popcornNum * Prices.popcorn) + (candyNum * Prices.candy);
        }
        public void DiscountInfo()
        {
            //Discount 1: Each purchase of a popcorn and a large soda grants a $2 discount on one movie ticket.
            this.totalTicketNum = childTickets + adultTickets + seniorTickets;
            this.minvale1 = Math.Min(popcornNum, largeSodaNum);
            this.minvale2 = Math.Min(popcornNum, totalTicketNum);
            this.popcornLSodaDiscount = (minvale2 * 2.00);

            //Discount 2: If 3 or more people purchase tickets to an evening show, they get 1 free bag of popcorn.
            if (popcornNum > 0 && trueMatinee == false && totalTicketNum >= 3)
            {
                this.groupPopcornDiscount = 4.50;
            }
            else
                this.popcornLSodaDiscount = 0;

            //Discount 3: For each 3 candies you buy, you can get a 4th candy for free.
            if (candyNum % 3 != 0)
            {
                this.candyBulkDiscount = (candyNum / 4) * 1.99;
            }
            else
                this.candyBulkDiscount = 0;

            this.totalDiscount = popcornLSodaDiscount + groupPopcornDiscount + candyBulkDiscount;
        }
        public void TotalPriceCalc()
        {
            this.totalPrice = (ticketSum + concessionSum) - candyBulkDiscount;
            System.Console.WriteLine("Your bill comes to: $" + totalPrice + ".");
        }


    }
}
