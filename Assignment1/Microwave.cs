using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1
{
    internal class Microwave : Appliance
    {
        private double capacity;
        private string roomType;

        public Microwave(long itemNumber, string brand, int quantity, double wattage, string color, double price, double capacity, string roomType) : base(itemNumber, brand, quantity, wattage, color, price)
        {
            this.Capacity = capacity;
            this.RoomType = roomType;
        }
        public double Capacity { get; set; }
        public string RoomType { get; set; }

        public override string formatForFile()
        {
            return base.formatForFile() + this.Capacity + ";" + this.RoomType + ";";
        }

        public override string ToString()
        {
            return base.ToString() + "\nCapacity: " + this.Capacity + "\nRoom Type: " + this.RoomType + "\n";
        }
    }
}

