using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_PIC_5.Models
{
    internal class App
    {
        public string date;
        public string number;
        public string locality;
        public string territory;
        public string animalHabiat;
        public string urgencyOfExecution;
        public string animaldescription;
        public string applicantCategory;
        public App(string date, string number, string locality, string territory, string animalHabiat, string urgencyOfExecution, string animaldescription, string applicantCategory)
        {
            this.date = date;
            this.number = number;
            this.locality = locality;
            this.territory = territory;
            this.animalHabiat = animalHabiat;
            this.urgencyOfExecution = urgencyOfExecution;
            this.animaldescription = animaldescription;
            this.applicantCategory = applicantCategory;
        }
    }
}
