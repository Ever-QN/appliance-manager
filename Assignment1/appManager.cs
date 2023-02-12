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
                    appliances.Add(new Vacuum(long.Parse(fields[0]), fields[1], int.Parse(fields[2]), double.Parse(fields[3]), fields[4], double.Parse(fields[5]), fields[6], int.Parse(fields[7])));
                }
                else if (firstchar == '3')
                {
                    appliances.Add(new Microwave(long.Parse(fields[0]), fields[1], int.Parse(fields[2]), int.Parse(fields[3]), fields[4], double.Parse(fields[5]), double.Parse(fields[6]), fields[7]));
                }
                else if (firstchar == '4' || firstchar == '5')
                {
                    appliances.Add(new Dishwasher(long.Parse(fields[0]), fields[1], int.Parse(fields[2]), int.Parse(fields[3]), fields[4], double.Parse(fields[5]), fields[6], fields[7]));
                }
                
            }
        }

        public void checkoutAppliance()
        {
            double itemNumberInput = double.Parse(Console.ReadLine());
            bool invalidItem = false;
            foreach (Appliance appliance in appliances)
            {
                if (itemNumberInput != appliance.ItemNumber)
                {
                    invalidItem = true;
                }
                if (itemNumberInput == appliance.ItemNumber)
                {
                    bool availableItem = appliance.isAvailable();
                    invalidItem = false;
                    if (availableItem == true)
                    {
                        appliance.checkout();
                        Console.WriteLine("Appliance " + itemNumberInput + " has been checked out.\n");
                        break;
                    }
                    else if (availableItem == false)
                    {
                        Console.WriteLine("The appliance is not available to be checked out.\n");
                        break;
                    }
                }
            }
            if(invalidItem == true)
            {
                Console.WriteLine("No appliances found with that number.\n");
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
                Console.WriteLine("Enter option: ");
                choice = int.Parse(Console.ReadLine());

                switch(choice)
                { // All of these cases should be calling a function
                    case 1:
                        Console.WriteLine("Enter the item number of an appliance: ");
                        checkoutAppliance();
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
