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
        public static List<AnimalCard> animalCards = new List<AnimalCard>();
        public static List<Act> acts = new List<Act>();

        public static void AddTestActs()
        {
            animalCards.Add(new AnimalCard(1, "Кот", "1", "1"));


            acts.Add(new Act(1, DateTime.Parse("02-02-02"), "OOO", "99999", "123", animalCards[0]));
        }
        
        public static void SaveActData(Act actData)
        {
            var index = acts.FindIndex(x => x.ActNumber == actData.ActNumber);
            acts[index] = actData;
        }
    }
}
