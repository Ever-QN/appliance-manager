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
            this.NumberOfDoors = numberOfDoors;
            this.Height = height;
            this.Width = width;
        }

        public int NumberOfDoors { get; set; }
        public double Height { get; set; }
        public double Width { get; set; }

        public override string formatForFile()
        {
            return base.formatForFile() + this.NumberOfDoors + ";" + this.Height + ";" + this.Width + ";";
        }

        public override string ToString()
        {
            return base.ToString() + "\nNumber of Doors: " + this.NumberOfDoors + "\nHeight: " + this.Height + 
                "\nWidth: " + this.Width + "\n";
        }
    }
}
