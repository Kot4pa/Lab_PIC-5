using Lab_PIC_5.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_PIC_5.Controllers
{
    class ReportService
    {
        public static void GenereteReport(DateTime start, DateTime finish)
        {
            ReportRepository.GenereteReport(start, finish);
        }
    }
}
