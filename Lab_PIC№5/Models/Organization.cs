using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_PIC_5.Models
{
    internal class Organization
    {
        public string idOrg;
        public string name;
        public string INN;
        public string KPP;
        public string registrationAdress;
        public string type;
        public string status;

        public Organization(string IdOrg, string name, string iNN, string kPP, string registrationAdress, string type, string status)
        {
            this.idOrg = IdOrg;
            this.name = name;
            INN = iNN;
            KPP = kPP;
            this.registrationAdress = registrationAdress;
            this.type = type;
            this.status = status;
        }
    }
}
