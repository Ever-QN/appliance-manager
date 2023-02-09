using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1
{
    internal class appManager
    {
        private List<Appliance> appliances;
        public appManager()
        {
            appliances = new List<Appliance>();
            loadFile();
            foreach (Appliance appliance in appliances)
            {
                Console.WriteLine(appliance.Brand);
                if (!string.IsNullOrEmpty(appliance.Brand))
                {
                    Console.WriteLine(appliance.Brand);
                }
            }
            this.displayMenu();
            //load a file
        }

        private void loadFile()
        {
            string filePath = @"appliances.txt";
            string[] lines = File.ReadAllLines(filePath);
            foreach (string line in lines)
            {
                string[] fields = line.Split(";");
                string s = fields[0];
                char firstchar = s[0];

                if (firstchar == '1')
                {
                   appliances.Add(new Refrigerator(long.Parse(fields[0]), fields[1], int.Parse(fields[2]), double.Parse(fields[3]), fields[4], double.Parse(fields[5]), int.Parse(fields[6]), double.Parse(fields[7]), double.Parse(fields[8])));
   
                }
                else if (firstchar == '2')
                {
                    /*appliances.Add(new Vacuum(long.Parse(fields[0]), fields[1], int.Parse(fields[2]), double.Parse(fields[3]), fields[4], double.Parse(fields[5]), fields[6], int.Parse(fields[7])));*/
                    //Console.WriteLine("Vacuum");
                }
                else if (firstchar == '3')
                {
                    //appliances.Add(new Microwave());
                    //Console.WriteLine("Microwave");
                }
                else if (firstchar == '4' || firstchar == '5')
                {
                    //appliances.Add(new Dishwasher());
                    //Console.WriteLine("Dishwasher");
                }
                
            }
        }

        public void displayMenu()
        {
            int choice = 0;
            while (choice != 5)
            {
                Console.WriteLine("Welcome to Modern Appliances!\n" +
                    "How may we assist you?\n" +
                    "1 – Check out appliance\n" +
                    "2 – Find appliances by brand\n" +
                    "3 – Display appliances by type\n" +
                    "4 – Produce random appliance list\n" +
                    "5 – Save & exit\n");
                Console.Write("Enter option: ");
                choice = int.Parse(Console.ReadLine());

                switch(choice)
                { // All of these cases should be calling a function
                    case 1:
                        Console.WriteLine("Checkout the appliance");
                        break;
                    case 2:
                        Console.WriteLine("Find appliances by brand");
                        break;
                    case 3:
                        Console.WriteLine("Display appliances by type");
                        break;
                    case 4:
                        Console.WriteLine("Produce random appliance list");
                        break;
                    case 5:
                        Console.WriteLine("Thanks for visiting");
                        break;
                }
            }
        }
    }
}
