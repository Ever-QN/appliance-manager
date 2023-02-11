using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1
{
   internal class Dishwasher : Appliance
    {
        private string feature;
        private string soundRating;

        public Dishwasher(long itemNumber, string brand, int quantity, double wattage, string color, double price, 
            string feature, string soundRating) : base(itemNumber, brand, quantity, wattage, color, price)
        {
            this.Feature = feature;
            this.SoundRating = soundRating;
        }

        public string Feature { get; set; }
        public string SoundRating { get; set; }

        public override string formatForFile()
        {
            return base.formatForFile() + this.feature + ";" + this.soundRating;
        }

        public override string ToString()
        {
            return "Item Number: " + this.ItemNumber + "\nBrand: " + this.Brand + "\nQuantity: " + this.Quantity + 
                "\nWattage: " + this.Wattage + "\nColor: " + this.Color + "\nPrice: " + this.Price + 
                "\nFeature: " + this.feature + "\nSound Rating: " + this.soundRating + "\n";
        }
    }
}

