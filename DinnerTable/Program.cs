using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DinnerTable
{
    class Program
    {
        static void Main(string[] args)
        {
            // Ask customer for their name
            Console.WriteLine("Welcome to my Dinner Table, what is your name?");
            string CustomerName = Console.ReadLine();

            // Ask how many plates will be on the ticket
            Console.WriteLine("How many meals will be on your ticket " + CustomerName + "?");
            int NumberOfPlates = Convert.ToInt32(Console.ReadLine());

            // Give Menu options
            Console.WriteLine("What would you like today? Our menu includes Rice, Steak, or The Double");


            
            List<Order> OrderList = new List<Order>();
            int plateNumber = 1;

            // Collect Menu Items for how many plates will be on the ticket customer inputed
            for (int i = 0; i < NumberOfPlates; i++)
            {
                Order order = new Order();

                Console.WriteLine("Plate " + plateNumber);

                // Collect Plate Name
                order.PlateName = Console.ReadLine().ToLower();

                // Set Price of those items
                switch (order.PlateName)
                {
                    case"rice":
                        order.Price = 4.99;
                        break;

                    case"steak":
                        order.Price = 10.99;
                        break;

                    case"the double":
                        order.Price = 13.99;
                        break;

                    default:
                        Console.WriteLine("Thats not on the menu... Sorry...");
                        break;
                }

                OrderList.Add(order);

                // Add one to plate number
                plateNumber++;
            }



            // Instiate PriceCalc Class
            PriceCalc calc = new PriceCalc();

            // Call methods for subtotal, tax total, tip total and grand total
            double SubTotal = calc.SubTotal(OrderList);
            double TaxTotal = calc.TaxTotal(SubTotal);
            double TipTotal = calc.TipTotal(SubTotal);
            double GrandTotal = calc.GrandTotal(SubTotal, TaxTotal, TipTotal);



            // Print reciept
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Receipt");
            Console.WriteLine("-------------");
            Console.WriteLine("Customer:" + CustomerName);
            Console.WriteLine();
            foreach (var item in OrderList)
            {
                Console.WriteLine(item.PlateName + " $" + item.Price);
            }
            Console.WriteLine();
            Console.WriteLine("Subtotal: $" + SubTotal);
            Console.WriteLine("Tax: $" + TaxTotal);
            Console.WriteLine("Tip: $" + TipTotal);
            Console.WriteLine("Grand Total: $" + GrandTotal);

            Console.ReadKey();
        }
    }
}
