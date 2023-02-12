using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1
{
    abstract class Appliance
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
            this.ItemNumber = itemNumber;
            this.Brand = brand;
            this.Quantity = quantity;
            this.Wattage = wattage;
            this.Color = color;
            this.Price = price;
        }
 
        public long ItemNumber { get; set; }
        public string Brand { get; set; }
        public int Quantity { get; set; }
        public double Wattage { get; set; }
        public string Color { get; set; }
        public double Price { get; set; }

        public bool isAvailable()
        {
            if (this.Quantity <= 0) 
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
            this.Quantity-- ;
        }

        public virtual string formatForFile()
        {
            return this.itemNumber + ";" + this.brand + ";" + this.quantity + ";" + this.wattage + ";" + 
                this.color + ";" + this.price + ";";
        }
        public override string ToString()
        {
            return "ItemNumber: " + this.ItemNumber + "\nBrand: " + this.Brand + "\nQuantity: " + 
                this.Quantity + "\nWattage:" + this.Wattage + "\nColor: " + this.Color + "\nPrice: " + this.Price;
        }
    }
}
