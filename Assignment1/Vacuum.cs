using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1
{
    internal class Vacuum : Appliance
    {
        private string grade;
        private int batteryVoltage;

        public Vacuum (long itemNumber, string brand, int quantity, double wattage, string color, double price, string grade, int batteryVoltage) : base(itemNumber, brand, quantity, wattage, color, price)
        {
            this.Grade = grade;
            this.BatteryVoltage = batteryVoltage;
        }

        public string Grade { get; set; }
        public int BatteryVoltage { get; set; }

        public override string formatForFile()
        {
            return base.formatForFile() + this.Grade + ";" + this.BatteryVoltage + ";";
        }
        public override string ToString()
        {
            return base.ToString() + "\nGrade: " + this.Grade + "\nBattery Voltage: " + this.BatteryVoltage + "\n";
        }
    }
}
