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
        public DateTime Date { get; set; }
        public Organization Organization { get; set; }
        public Contract Contracts { get; set; }
        public App Application { get; set; }
        public AnimalCard AnimalCard { get; set; }

        public Act(int actNumber, DateTime date, Organization organization, Contract contracts, App application, AnimalCard animalCard)
        {
            ActNumber = actNumber;
            Date = date;
            Organization = organization;
            Contracts = contracts;
            Application = application;
            AnimalCard = animalCard;
        }

    }
}
