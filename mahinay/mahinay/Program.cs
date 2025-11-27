using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mahinay
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Complete name: Jemimah Mae P.Mahinay,
            // Section          : IT306
            // Exercise title   : EXER_04: Basics on Encapsulation
            static void Main(string[] args)
            {
                // User Input
                Console.Write("Enter a shirt brand: ");
                string brandInput = Console.ReadLine();

                Console.Write("Enter Shirt Size: ");
                string sizeInput = Console.ReadLine();
                Console.WriteLine();

                // Instantiate an object
                Shirt shirt1 = new Shirt
                {
                    Brand = brandInput,
                    Size = sizeInput

                };

                // Call method to display
                shirt1.DisplayDetails();

                Console.ReadKey();
            }
    }
}
