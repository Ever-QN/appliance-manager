using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1
{
    internal class Microwave : Appliance
    {
        private int wattage;
        private double capacity;
        private string roomType;

        public Microwave(long itemNumber, string brand, int quantity, int wattage, string color, double price, double capacity, string roomType)
            : base(itemNumber, brand, quantity, wattage, color, price)
        {
            this.Wattage = wattage;
            this.Capacity = capacity;
            this.RoomType = roomType;
        }

        public int Wattage { get; set; }
        public double Capacity { get; set; }
        public string RoomType { get; set; }

        public override string formatForFile()
        {
            return base.formatForFile() + this.Wattage + ";" + this.Capacity + ";" + this.RoomType + ";";
        }

        public override string ToString()
        {
            return base.ToString() + "\nWattage: " + this.Wattage + "\nCapacity: " + this.Capacity + "\nRoom Type: " + this.RoomType + "\n";
        }
    }
}

