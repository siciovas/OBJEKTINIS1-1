using System;
using System.Collections.Generic;

namespace L1.U22
{
    class Program
    {
        static void Main(string[] args)
        {

            List<Fridge> allFridges = InOut.ReadSaldytuvai(@"Saldytuvai.csv");
   
            List<int> DiffFridgeCapacities = Tasks.FindCapacities(allFridges);
            Console.WriteLine("Different fridge's capacities: ");
            InOut.PrintCapacities(DiffFridgeCapacities);
            Console.WriteLine();


            Console.WriteLine("Cheapest, has freezer, freestanding fridge(s):");
            int cheapest = Tasks.FindCheapestPrice(allFridges);
            List<Fridge> Chosen = Tasks.FindTrueMountingType(allFridges, cheapest);
            InOut.PrintShortInformation(Chosen);
            Console.WriteLine();

            List<Fridge> listOfWhiteAndAplusplus = Tasks.FindWhiteAPlus(allFridges, "balta", "A++");
            Console.WriteLine("White and A++ fridges: ");
            InOut.PrintAllInformation(listOfWhiteAndAplusplus);
            Console.WriteLine();

            InOut.PrintData(@"Data.txt", allFridges);
            InOut.PrintToCSV(@"Baltieji.csv", listOfWhiteAndAplusplus);

            Console.ReadLine();
        }
    }
}
