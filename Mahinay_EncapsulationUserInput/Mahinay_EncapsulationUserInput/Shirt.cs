using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mahinay_EncapsulationUserInput
{
    internal class Shirt
    {
        // Declaring private fields
        public string Brand { get; set; }
        public string Size { get; set; } 

        // Method to display details
        public void DisplayDetails()
        {
            Console.WriteLine( "    Shirt Details:" + "\n" +
                              "Shirt Brand: " + Brand + "\n" +
                              "Shirt Size : " + Size);
        }
    }
}
