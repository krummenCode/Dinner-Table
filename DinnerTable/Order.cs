using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DinnerTable
{
    public class Order
    {
        public Order() { }

        public Order(string iPlateName, double iPrice)
        {
            this.PlateName = iPlateName;
            this.Price = iPrice;
        }

        public string PlateName { get; set; }
        public double Price { get; set; }
    }
}
