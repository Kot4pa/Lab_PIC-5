using Lab_PIC_5.Data;
using Lab_PIC_5.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_PIC_5
{
    internal class ActService
    {
        public static List<string[]> ShowAct()
        {
            List<string[]> acts = stringMassChencher(ActRepository.acts);
            return acts;
        }

        public static void EditAct(Act actData)
        {
            ActRepository.SaveActData(actData);
        }

        private AnimalCard FindAnimalCard(int idAnimalCard)
        {
            var index = ActRepository.animalCards.FindIndex(x => x.IdAnimalCard == idAnimalCard);
            return ActRepository.animalCards[index];
        }

        private static List<string[]> stringMassChencher(List<Act> acts)
        {
            List<string[]> result = new List<string[]>();
            foreach (Act act in acts)
            {
                var oldAct = new List<string>
                {
                    act.ActNumber.ToString(),
                    act.Date.ToString(),
                    act.Organization,
                    act.Contracts,
                    act.Application,
                    act.AnimalCard.Kind
                };
                result.Add(oldAct.ToArray());
            }
            return result;
        }
    }
}
