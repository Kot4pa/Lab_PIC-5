using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_PIC_5.Models
{
    class AnimalCard
    {
        public int IdAnimalCard { set; get; }
        public string Kind { set; get; }
        public string AnimalSpecificarion { get; set; }
        public string SpecialSigns { get; set; }

        public AnimalCard(int idAnimalCard, string kind, string animalSpecificarion, string specialSigns)
        {
            IdAnimalCard = idAnimalCard;
            Kind = kind;
            AnimalSpecificarion = animalSpecificarion;
            SpecialSigns = specialSigns;
        }
    }
}
