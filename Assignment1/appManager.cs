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
            this.appliances = new List<Appliance>();
            this.displayMenu();
            //load a file

        }
        public void displayMenu()
        {
            int choice = 0;
            while (choice != 5)
            {
                Console.WriteLine("Welcome to Modern Appliances!" +
                    "How may we assist you?" +
                    "1 – Check out appliance" +
                    "2 – Find appliances by brand" +
                    "3 – Display appliances by type" +
                    "4 – Produce random appliance list" +
                    "5 – Save & exit");
                Console.WriteLine("Enter option: ");
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
