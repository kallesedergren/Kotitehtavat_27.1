
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Harjoitus6
{
    class Laptop : Electronics
    {
        public string Accessory { get; set; }

        public Laptop(string ProductName, string Brand, float ScreenSize, string Accessory)
            : base(ProductName, Brand, ScreenSize)
        {
            this.Accessory = Accessory;
        }

        public override void PrintData()
        {
            base.PrintData();
            Console.WriteLine("Extra Accessory: " + Accessory);
        }
    }
}