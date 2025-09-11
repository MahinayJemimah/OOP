using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mahinay_InheritenaceUserInput
{
    class Program
    {
        // Complete name    : Jemimah Mae P. Mahinay,
        // Section          : IT306
        // Exercise title   : EXER_08: Inheritance with User Input
        static void Main(string[] args)
        {
            Console.WriteLine("Choose shirt type: (e.g. 1) ");
            Console.WriteLine("1. T-Shirt");
            Console.WriteLine("2. Polo Shirt");
            Console.Write("Enter choice: ");
            string choice = Console.ReadLine();

            if (choice == "1")
            {
                TShirt tshirt = new TShirt();

                Console.Write("Enter Brand: ");
                tshirt.Brand = Console.ReadLine();

                Console.Write("Enter Size: ");
                tshirt.Size = Console.ReadLine();

                Console.Write("Enter Color: ");
                tshirt.Color = Console.ReadLine();

                Console.Write("Enter Design: ");
                tshirt.Design = Console.ReadLine();

                Console.WriteLine("\n--- T-Shirt Details ---");
                tshirt.DisplayDetails();
            }
            else if (choice == "2")
            {
                PoloShirt polo = new PoloShirt();

                Console.Write("Enter Brand: ");
                polo.Brand = Console.ReadLine();

                Console.Write("Enter Size: ");
                polo.Size = Console.ReadLine();

                Console.Write("Enter Sleeve Length: ");
                polo.SleeveLength = Console.ReadLine();

                Console.Write("Enter Material: ");
                polo.Material = Console.ReadLine();

                Console.WriteLine("\n--- Polo Shirt Details ---");
                polo.DisplayDetails();
            }
            else
            {
                Console.WriteLine("Invalid choice!");
            }

            Console.ReadKey();
        }
    }
}
