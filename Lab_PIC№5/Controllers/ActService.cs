using Lab_PIC_5.Data;
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

        private static List<string[]> stringMassChencher(List<Act> acts)
        {
            List<string[]> result = new List<string[]>();
            foreach (Act act in acts)
            {
                var oldAct = new List<string>
                {
                    act.ActNumber.ToString(),
                    act.date.ToString(),
                    act.organization,
                    act.contracts,
                    act.application,
                    act.animalCard.Kind
                };
                result.Add(oldAct.ToArray());
            }
            return result;
        }
    }
}
