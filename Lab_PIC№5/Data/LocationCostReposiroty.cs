using Lab_PIC_5.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_PIC_5.Data
{
    class LocationCostReposiroty
    {
        public static List<LocationCost> locationCosts = new List<LocationCost>
        { new LocationCost(1, "г. Тюмень", 100), new LocationCost(2, "г. Тобольск", 200)};
    }
}
