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
        public static List<string[]> ShowContract()
        {
            List<string[]> contracts = stringMassChencher(ContractRepository.contract);
            return contracts;
        }
        public static void AddContract(Contract cont)
        {
            ContractRepository.SaveAdd(cont);
        }

        public static void EditAct(Contract cont)
        {
            ContractRepository.SaveContractData(cont);
        }
        public static void DeleteContract(string cont)
        {
            foreach (Contract contract in ContractRepository.contract)
            {
                if (contract.IdContract == int.Parse(cont))
                {
                    ContractRepository.Del(contract);
                    break;
                }

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
                    contract.LocationCost.Cost,
                    contract.Executer,
                    contract.Costumer
                };
                result.Add(oldContract.ToArray());
            }
            return result;
        }
    }
}
