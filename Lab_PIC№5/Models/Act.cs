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
        int actNumber;
        DateTime date;
        string organization;
        string contracts;
        string application;
        AnimalCard animalCard;

        public Act(int actNumberTake, DateTime dateTake, string organizationTake, string contractsTake, string applicationTake, AnimalCard animalCardTake)
        {
            actNumber = actNumberTake;
            date = dateTake;
            organization = organizationTake;
            contracts = contractsTake;
            application = applicationTake;
            animalCard = animalCardTake;
        }

    }
}
