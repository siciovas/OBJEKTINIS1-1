using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L1.U22
{
    /// <summary>
    /// Class for input and output methods
    /// </summary>
    static class InOut
    {
        /// <summary>
        /// Reads the text file
        /// </summary>
        /// <param name="fileName">Current file name</param>
        /// <returns></returns>
        public static List<Fridge> ReadSaldytuvai(string fileName)
        {
            List<Fridge> Fridges = new List<Fridge>();
            string[] lines = File.ReadAllLines(fileName, Encoding.UTF8);
            foreach (string line in lines)
            {
                string[] values = line.Split(';');
                string brandname = values[0];
                string model = values[1];
                int capacity = Convert.ToInt32(values[2]);
                string energyclass = values[3];
                string mountingtype = values[4];
                string color = values[5];
                bool freezer = Convert.ToBoolean(values[6]);
                int price = Convert.ToInt32(values[7]);

                Fridge fridge = new Fridge(brandname, model, capacity, energyclass, mountingtype, color, freezer, price);
                Fridges.Add(fridge);
            }
            return Fridges;
        }

        /// <summary>
        /// Prints different capacities of fridges
        /// </summary>
        /// <param name="DiffFridgeCapacities">List of different capacities</param>
        public static void PrintCapacities(List<int> DiffFridgeCapacities)
        {
            foreach (int FridgeCapacity in DiffFridgeCapacities)
            {
                Console.WriteLine(FridgeCapacity);
            }

        }
        
        /// <summary>
        /// Prints fridges who are cheapest, has freezer and are freestanding
        /// </summary>
        /// <param name="Fridges">List of fridges</param>
        public static void PrintShortInformation(List<Fridge> Fridges)
        {
            foreach(Fridge fridge in Fridges)
            {
                Console.WriteLine("{0} {1} {2} {3}", fridge.BrandName, fridge.Model, fridge.Capacity, fridge.Price);
            }
        }

        /// <summary>
        /// Prints fridges who are white and have A++ energy class
        /// </summary>
        /// <param name="Fridges">List of fridges</param>
        public static void PrintAllInformation(List<Fridge> Fridges)
        {

            foreach (Fridge fridge in Fridges)
            {
                Console.WriteLine("{0} {1} {2} {3} {4} {5} {6} {7}", fridge.BrandName, fridge.Model, fridge.Capacity, fridge.EnergyClass, fridge.MountingType, fridge.Color,
                    fridge.Freezer, fridge.Price);
            }

        }

        /// <summary>
        /// Prints our data about fridges
        /// </summary>
        /// <param name="fileName">Current file name</param>
        /// <param name="Fridges">List of fridges</param>
        public static void PrintData(string fileName, List<Fridge> Fridges)
        {
            string[] lines = new string[Fridges.Count + 1];
            lines[0] = String.Format("{0,-5}  {1,7}  {2,19}  {3,15}  {4,10}  {5,12}  {6,20} {7,8} ",
                "Brandname", "Model", "Capacity", "Energy class", "Mounting type", "Color", "Has a freezer", "Price");
            string bracket = new string('-',176);
            for (int i = 0; i < Fridges.Count; i++)
            {
                lines[i + 1] = string.Format("| {0,-10} | {1,-15} | {2,10} | {3,-10} | {4,-20} | {5,-10} | {6,-15} | {7,5} |", Fridges[i].BrandName, Fridges[i].Model, Fridges[i].Capacity,
                    Fridges[i].EnergyClass, Fridges[i].MountingType, Fridges[i].Color, Fridges[i].Freezer, Fridges[i].Price);
            }
            File.WriteAllLines(fileName, lines, Encoding.UTF8);
        }

        /// <summary>
        /// Prints results to .CSV file
        /// </summary>
        /// <param name="fileName">Current file name</param>
        /// <param name="Fridges">List of fridges</param>
        public static void PrintToCSV(string fileName, List<Fridge> Fridges)
        {
            string[] lines = new string[Fridges.Count + 1];
            for (int i = 0; i < Fridges.Count; i++)
            {
                lines[i + 1] = string.Format("{0};{1};{2};{3};{4};{5};{6};{7}", Fridges[i].BrandName, Fridges[i].Model, Fridges[i].Capacity,
                    Fridges[i].EnergyClass, Fridges[i].MountingType, Fridges[i].Color, Fridges[i].Freezer, Fridges[i].Price);
            }
            File.WriteAllLines(fileName, lines, Encoding.UTF8);
        }

    }
}
