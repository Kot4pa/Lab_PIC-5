using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_PIC_5.Models
{
    class AnimalCard
    {
        string kind;
        public string Kind
        {
            set { kind = value; }
            get { return kind; }
        }
        string animalSpecificarion { get; set; }
        string specialSigns;

        public AnimalCard(string kindTake, string animalSpecificarionTake, string specialSignsTake)
        {
            Kind = kindTake;
            animalSpecificarion = animalSpecificarionTake;
            specialSigns = specialSignsTake;
        }
    }
}
