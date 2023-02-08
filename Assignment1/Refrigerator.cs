using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1
{
    internal class Refrigerator : Appliance
    {
        private int numberOfDoors;
        private double height;
        private double width;

        public Refrigerator(long itemNumber, string brand, int quantity, double wattage, string color, double price, int numberOfDoors, double height, double width) : base(itemNumber, brand, quantity, wattage, color, price)
        {
            this.numberOfDoors= numberOfDoors;
            this.height= height;
            this.width= width;
        }
    }
}
