using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1
{
    class Refrigerator : Appliance
    {
        private int numberOfDoors;
        private double height;
        private double width;

        public Refrigerator(long itemNumber, string brand, int quantity, double wattage, string color, double price, 
            int numberOfDoors, double height, double width) : base(itemNumber, brand, quantity, wattage, color, price)
        {
            this.numberOfDoors = numberOfDoors;
            this.height = height;
            this.width = width;
        }



        public override string formatForFile()
        {
            return base.formatForFile() + this.numberOfDoors + ";" + this.height + ";" + this.width;
        }

        public override string ToString()
        {
            return base.ToString() + "\nNumber of Doors: " + this.numberOfDoors + "\nHeight: " + this.height + 
                "\nWidth: " + this.width;
        }
    }
}
