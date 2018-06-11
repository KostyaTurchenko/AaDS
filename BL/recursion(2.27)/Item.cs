using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL.recursion_2._27_
{
    public class Item
    {
        public string Name { get; set; }
        public double Weigth { get; set; }
        public double Price { get; set; }

        public Item (string name, double weigth, double price)
        {
            this.Name = name;
            this.Weigth = weigth;
            this.Price = price;
        }

    }
}
