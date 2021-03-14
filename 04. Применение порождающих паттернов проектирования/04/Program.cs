using System;
using System.Collections.Generic;
using System.ComponentModel;

namespace Lab4
{
    class Program
    {
        static void Main(string[] args)
        {
            IDeveloper dev1 = new A_100Development();
            IDeveloper dev2 = new DanaHoldings();

            List<IRealEstate> realEstates = new List<IRealEstate>();
            realEstates.Add(dev1.GetFlat());
            realEstates.Add(dev2.GetHouse());
            realEstates.Add(dev2.GetFlat());
            realEstates.Add(dev1.GetHouse());

            foreach (var re in realEstates)
            {
                Console.WriteLine(re);
            }
        }
    }
}
