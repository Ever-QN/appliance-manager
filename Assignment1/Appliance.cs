using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1
{
    class Appliance
    {
        private long itemNumber;
        private string brand;
        private int quantity;
        private double wattage;
        private string color;
        private double price;

        public Appliance(long itemNumber, string brand, int quantity, double wattage, string color, 
            double price)
        {
            this.itemNumber = itemNumber;
            this.brand = brand;
            this.quantity = quantity;
            this.wattage = wattage;
            this.color = color;
            this.price = price;
        }
 
        public long ItemNumber { get; set; }
        public string Brand { get; set; }
        public int Quantity { get; set; }
        public double Wattage { get; set; }
        public string Color { get; set; }
        public double Price { get; set; }

        public bool isAvailable()
        {
            if (this.quantity == 0) 
            { 
                return false;
            }
            else
            {
                return true;
            }
        }
        
        public void checkout()
        {
            Console.WriteLine("Enter item number of an Appliance: ");
            
        }

        public virtual string formatForFile()
        {
            return this.itemNumber + ";" + this.brand + ";" + this.quantity + ";" + this.wattage + ";" + 
                this.color + ";" + this.price + ";";
        }
        public override string ToString()
        {
            return "ItemNumber: " + this.itemNumber + "\nBrand: " + this.itemNumber + "\nQuantity: " + 
                this.quantity + "\nWattage:" + this.wattage + "\nColor: " + this.color + "\nPrice: " + this.price;
        }
    }
}
