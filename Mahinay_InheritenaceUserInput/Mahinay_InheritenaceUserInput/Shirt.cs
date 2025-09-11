using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mahinay_InheritenaceUserInput
{
    class Shirt
    {
        // Private fields
        private string brand;
        private string size;

        // Encapsulated Properties
        public string Brand
        {
            get { return brand; }
            set { brand = value; }
        }

        public string Size
        {
            get { return size; }
            set { size = value; }
        }

        // Method
        public virtual void DisplayDetails()
        {
            Console.WriteLine($"Shirt Brand: {Brand}");
            Console.WriteLine($"Shirt Size : {Size}");
        }
    }

    // Derived Class 1
    internal class TShirt : Shirt
    {
        private string color;
        private string design;

        public string Color
        {
            get { return color; }
            set { color = value; }
        }

        public string Design
        {
            get { return design; }
            set { design = value; }
        }

        public override void DisplayDetails()
        {
            base.DisplayDetails();
            Console.WriteLine($"Shirt Color : {Color}");
            Console.WriteLine($"Shirt Design: {Design}");
        }
    }

    // Derived Class 2
    internal class PoloShirt : Shirt
    {
        private string sleeveLength;
        private string material;

        public string SleeveLength
        {
            get { return sleeveLength; }
            set { sleeveLength = value; }
        }

        public string Material
        {
            get { return material; }
            set { material = value; }
        }

        public override void DisplayDetails()
        {
            base.DisplayDetails();
            Console.WriteLine($"Sleeve Length: {SleeveLength}");
            Console.WriteLine($"Material     : {Material}");
        }
    }
}

