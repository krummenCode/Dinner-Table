using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DinnerTable
{
    public class PriceCalc
    {
        // Create method to calculate subtotal
        public double SubTotal(List<Order> orders)
        {
            double subtotal = 0;

            foreach (var item in orders)
            {
                subtotal += item.Price;
            }

            return subtotal;
        }

        
        // Create method to calculate tax total
        public double TaxTotal(double subtotal)
        {
            double taxRate = 0.0725;

            double iTaxTotal = subtotal * taxRate;

            double TaxTotal = Math.Round(iTaxTotal, 2);

            return TaxTotal;
        }


        // Create Method to calculate tip total
        public double TipTotal(double subtotal)
        {
            double tipRate = 0.2;

            double iTipTotal = subtotal * tipRate;

            double TipTotal = Math.Round(iTipTotal, 2);

            return TipTotal;
        }


        // Create method to calculate grand total
        public double GrandTotal(double sub, double tax, double tip)
        {
            double iGrandTotal = sub + tax + tip;

            double GrandTotal = Math.Round(iGrandTotal, 2);

            return GrandTotal;
        }
    }
}
