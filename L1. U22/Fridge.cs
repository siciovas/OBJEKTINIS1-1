using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L1.U22
{
    public class Fridge
    {
        public string BrandName { get; set; }
        public string Model { get; set; }
        public int Capacity { get; set; }
        public string EnergyClass { get; set; }
        public string MountingType { get; set; }
        public string Color { get; set; }
        public bool Freezer { get; set; }
        public int Price { get; set; }

        public Fridge(string brandname, string model, int capacity, string energyclass, string mountingtype, string color, bool freezer, int price)
        {
            this.BrandName = brandname;
            this.Model = model;
            this.Capacity = capacity;
            this.EnergyClass = energyclass;
            this.MountingType = mountingtype;
            this.Color = color;
            this.Freezer = freezer;
            this.Price = price;
        }
    }
}
