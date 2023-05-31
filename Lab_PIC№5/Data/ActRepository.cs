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
                                            { new Act(1, DateTime.Parse("01-01-01"), "OOO", "99999", "123", animalCards[0]),
                                            new Act(2, DateTime.Parse("02-02-02"), "AAA", "00000", "321", animalCards[1])};
        
        public static void SaveActData(Act actData)
        {
            var index = acts.FindIndex(x => x.ActNumber == actData.ActNumber);
            acts[index] = actData;
        }
    }
}
