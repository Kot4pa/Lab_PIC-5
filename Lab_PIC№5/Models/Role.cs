using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_PIC_5.Models
{
    class Role
    {
        public string Name { get; set; }
        //public PosibilitiesInteractions Posibilitie { get; }
        //public NameMdels NameMdel { get; }
        public Dictionary<string, bool> CheckPosibilitis { get; set; }

        public Role(string name, Dictionary<string, bool> checkPosibilitis)
        {
            CheckPosibilitis = checkPosibilitis;
            Name = name;
        }
    }
    
    //enum PosibilitiesInteractions
    //{
    //    View,
    //    Controll
    //}

    //enum NameMdels
    //{
    //    Act,
    //    App,
    //    Contract,
    //    Org,
    //    Report
    //}
}
