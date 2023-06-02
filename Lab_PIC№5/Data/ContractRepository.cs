using Lab_PIC_5.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_PIC_5.Data
{
    class ContractRepository
    {
        public static List<LocationCost> locationCost = new List<LocationCost>();
        public static List<Contract> contract = new List<Contract>();

        public static void AddTestContract()
        {
            locationCost.AddRange(new List<LocationCost>() { new LocationCost(1, "г. Тюмень", "100"),
                                                          new LocationCost(2, "г. Тобольск", "200")});


            contract.AddRange(new List<Contract>() { new Contract(1, DateTime.Parse("02.05.2023"), DateTime.Parse("05.05.2023"), locationCost[0], locationCost[0], "OOO", "OAO"),
                                            new Contract(2, DateTime.Parse("12.05.2023"), DateTime.Parse("15.05.2023"), locationCost[1], locationCost[1], "ПАО", "OОO")});
        }

        public static void SaveContractData(Contract cont)
        {
            var index = contract.FindIndex(x => x.IdContract == cont.IdContract);
            contract[index] = cont;
        }
        public static void SaveAdd(Contract cont)
        {
            contract.Add(cont);
        }
        public static void Del(Contract cont)
        {
            contract.Remove(cont);
        }
    }
}
