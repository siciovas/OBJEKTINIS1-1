using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L1.U22
{
    static class Tasks
    {
       /// <summary>
       /// A method creates a list of different capacities that fridges has
       /// </summary>
       /// <param name="Fridges">Information about fridges</param>
       /// <returns>List of different capacities</returns>
        public static List<int> FindCapacities(List<Fridge> Fridges)
        {
            List<int> DiffFridgeCapacities = new List<int>();
            foreach (Fridge fridge in Fridges)
            {
                int FridgeCapacity = fridge.Capacity;
                if (!DiffFridgeCapacities.Contains(FridgeCapacity))
                {
                    DiffFridgeCapacities.Add(FridgeCapacity);
                }

            }
            return DiffFridgeCapacities;
        }

       /// <summary>
       /// A method finds the cheapest fridge from our list
       /// </summary>
       /// <param name="Fridges">Information about fridges</param>
       /// <returns>We get one cheapest fridge price</returns>

        public static int FindCheapestPrice(List<Fridge> Fridges)
        {
            int Cheapest = Fridges[0].Price;
            for(int i = 1; i < Fridges.Count; i++)
            {
                if(Fridges[i].Price < Cheapest)
                {
                    Cheapest = Fridges[i].Price;
                }
            }
            return Cheapest;
        }

        /// <summary>
        /// A method finds if that fridge has freezer and is freestanding
        /// </summary>
        /// <param name="Fridges">List of all fridges</param>
        /// <param name="Cheapest">Cheapest price in all list</param>
        /// <returns>Chosen fridges who are cheapest, has freezer and are freestanding</returns>

        public static List<Fridge> FindTrueMountingType(List<Fridge> Fridges, int Cheapest)
        {
            List<Fridge> Chosen = new List<Fridge>();
            foreach(Fridge fridge in Fridges)
            {
                if (fridge.Price == Cheapest && fridge.Freezer && fridge.MountingType == "laisvai pastatomas")
                {
                    Chosen.Add(fridge);
                }
            }
            return Chosen;
        }

        /// <summary>
        /// A method shows us fridges who are white and have A++ energy class
        /// </summary>
        /// <param name="Fridges">Information about fridges</param>
        /// <param name="Fcolor">Color we check to see if its true</param>
        /// <param name="Fenergyclass">Energy class we check to see if its true</param>
        /// <returns>List of fridges that are white and A++</returns>
        public static List<Fridge> FindWhiteAPlus(List<Fridge> Fridges, string Fcolor, string Fenergyclass)
        {
            List<Fridge> Filtered = new List<Fridge>();
            foreach(Fridge fridge in Fridges)
            {   
                if(fridge.Color.Equals(Fcolor) && (fridge.EnergyClass.Equals(Fenergyclass)))
                {
                    Filtered.Add(fridge);
                }
            }
            return Filtered;
        }
    }
}