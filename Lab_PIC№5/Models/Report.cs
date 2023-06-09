using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_PIC_5.Models
{
    class Report
    {
        DateTime DateStart { get; set; }
        DateTime DateFinish { get; set; }
        Location Loc { get; set; }
        int CountAnumals { get; set; }
        int Sum { get; set; }

        public Report(DateTime dateStart, DateTime dateFinish, Location loc, int countAnumals, int sum)
        {
            DateStart = dateStart;
            DateFinish = dateFinish;
            Loc = loc;
            CountAnumals = countAnumals;
            Sum = sum;
        }
    }
}
