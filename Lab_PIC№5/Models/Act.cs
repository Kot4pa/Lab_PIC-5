using Lab_PIC_5.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_PIC_5
{
    class Act
    {
        public int ActNumber { get; set; }
        public DateTime date { get; set; }
        public string organization { get; set; }
        public string contracts { get; set; }
        public string application { get; set; }
        public AnimalCard animalCard { get; set; }

        public Act(int actNumberTake, DateTime dateTake, string organizationTake, string contractsTake, string applicationTake, AnimalCard animalCardTake)
        {
            ActNumber = actNumberTake;
            date = dateTake;
            organization = organizationTake;
            contracts = contractsTake;
            application = applicationTake;
            animalCard = animalCardTake;
        }

    }
}
