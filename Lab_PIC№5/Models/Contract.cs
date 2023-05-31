using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_PIC_5.Models
{
    class Contract
    {
        public int IdContract { get; set; }
        public DateTime DateConclusion { get; set; }
        public DateTime ActionDate { get; set; }
        public LocationCost LocationCost { get; set; }
        public string Executer { get; set; }
        public string Costumer { get; set; }

        public Contract(int idContract, DateTime dateConclusion, DateTime actionDate, LocationCost location, LocationCost cost, string executer, string costumer)
        {
            IdContract = idContract;
            DateConclusion = dateConclusion;
            ActionDate = actionDate;
            LocationCost = location;
            LocationCost= cost;
            Executer = executer;
            Costumer = costumer;
        }

    }
}
