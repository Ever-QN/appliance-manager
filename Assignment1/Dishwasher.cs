using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1
{
   internal class Dishwasher : Appliance
    {
        private int wattage;
        private string soundRating;
        private string feature;

        public Dishwasher(long itemNumber, string brand, int quantity, int wattage, string color, double price, string feature, string soundRating)
            : base(itemNumber, brand, quantity, wattage, color, price)
        {
            this.Wattage = wattage;
            this.SoundRating = soundRating;
            this.Feature = feature;
        }

        public int Wattage { get; set; }
        public string SoundRating { get; set; }
        public string Feature { get; set; }

        public override string formatForFile()
        {
            return base.formatForFile() + this.wattage + ";" + this.feature + ";" + this.soundRating;
        }

        public override string ToString()
        {
            return base.ToString() + "\nWattage: " + this.Wattage + "\nSound Rating: " + this.SoundRating + "\nFeature: " + this.Feature + "\n";
        }
    }
}
