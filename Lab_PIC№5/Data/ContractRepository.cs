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
        public static List<Contract> contract = new List<Contract> { new Contract(1, DateTime.Parse("02.05.2023"), DateTime.Parse("05.05.2023"), 
                                                                     LocationCostReposiroty.locationCosts[0], 100, 
                                                                     OrgRepository.Organizations[0], OrgRepository.Organizations[1]),
                                                                new Contract(2, DateTime.Parse("12.05.2023"), DateTime.Parse("15.05.2023"), 
                                                                     LocationCostReposiroty.locationCosts[1], 200, 
                                                                     OrgRepository.Organizations[1], OrgRepository.Organizations[1])};

        public static void EditContractData(Contract cont)
        {
            var index = contract.FindIndex(x => x.IdContract == cont.IdContract);
            contract[index] = cont;
        }
        public static void SaveAdd(Contract cont)
        {
            contract.Add(cont);
        }
        public static List<Contract> ShowCont(string filter)
        {
            List<Contract> returnCont = contract.Where(x => x.DateConclusion >= DateTime.Parse(filter)).ToList();
            return returnCont;
        }
        public static void DeleteContract(Contract cont)
        {
            contract.Remove(cont);
        }
    }
}
