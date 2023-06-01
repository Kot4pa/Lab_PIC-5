using Lab_PIC_5.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_PIC_5.Data
{
    class ActRepository
    {
        public static List<AnimalCard> animalCards = new List<AnimalCard>
                                                          { new AnimalCard(1, "Кот", "1", "1"),
                                                          new AnimalCard(2, "Собака", "2", "2")};
        public static List<Act> acts = new List<Act>
                                            { new Act(1, DateTime.Parse("01-01-23"), OrgRepository.Organizations[0], ContractRepository.contract[0], AppRepository.Applicatiions[0], animalCards[0]),
                                            new Act(2, DateTime.Parse("02-01-23"), OrgRepository.Organizations[1], ContractRepository.contract[1], AppRepository.Applicatiions[1], animalCards[1]),
                                            new Act(3, DateTime.Parse("05-01-23"), OrgRepository.Organizations[2], ContractRepository.contract[1], AppRepository.Applicatiions[2], animalCards[1]),
                                            new Act(4, DateTime.Parse("10-01-23"), OrgRepository.Organizations[0], ContractRepository.contract[0], AppRepository.Applicatiions[0], animalCards[0])};
        
        public static void SaveActData(Act actData)
        {
            var index = acts.FindIndex(x => x.ActNumber == actData.ActNumber);
            acts[index] = actData;
        }

        public static List<Act> ShowAct(string filter)
        {
            List<Act> returnAct = acts.Where(x => x.Date >= DateTime.Parse(filter)).ToList();
            return returnAct;
        }
    }
}
