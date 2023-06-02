using Lab_PIC_5.Data;
using Lab_PIC_5.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_PIC_5.Controllers
{
    internal class ContractService
    {
        public static List<string[]> ShowContract(string filter)
        {
            List<string[]> contracts = stringMassChencher(ContractRepository.ShowCont(filter));
            return contracts;
        }

        public static void EditCont(string[] ContData)
        {
            var contData = new Contract(int.Parse(ContData[0]), DateTime.Parse(ContData[1]), DateTime.Parse(ContData[2]),
                                  LocationCostReposiroty.locationCosts[LocationCostReposiroty.locationCosts.FindIndex(x => x.IdLocation == int.Parse(ContData[3]))],
                                  LocationCostReposiroty.locationCosts[LocationCostReposiroty.locationCosts.FindIndex(x => x.IdLocation == int.Parse(ContData[4]))],
                                  OrgRepository.Organizations[OrgRepository.Organizations.FindIndex(x => x.idOrg == int.Parse(ContData[5]))],
                                  OrgRepository.Organizations[OrgRepository.Organizations.FindIndex(x => x.idOrg == int.Parse(ContData[6]))]);
            ContractRepository.SaveContractData(contData);
        }
        public static void DeleteContract(string cont)
        {
            foreach (Contract contract in ContractRepository.contract)
                if (contract.IdContract == int.Parse(cont))
                {
                    ContractRepository.Del(contract);
                    break;
                }
        }

        public static List<string[]> stringMassChencher(List<Contract> contracts)
        {
            List<string[]> result = new List<string[]>();
            foreach (Contract contract in contracts)
            {
                var oldContract = new List<string>
                {
                    contract.IdContract.ToString(),
                    contract.DateConclusion.ToString(),
                    contract.ActionDate.ToString(),
                    contract.LocationCost.City,
                    contract.LocationCost.Cost.ToString(),
                    contract.Executer.name,
                    contract.Costumer.name
                };
                result.Add(oldContract.ToArray());
            }
            return result;
        }
    }
}
