using Lab_PIC_5.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_PIC_5.Data
{
    class ReportRepository
    {
        public static List<Report> reports = new List<Report>();
        public static List<Report> GenereteReport(DateTime start, DateTime finish)
        {
            foreach (var loc in LocationCostReposiroty.locationCosts)
            {
                foreach (var act in ActRepository.acts) 
                {
                    if (act.Application.locality == loc.City)
                    {
                        reports.Add( new Report(start, finish, loc, act.Sum, act.Contracts.Cost));
                    }
                } 
            }
            return reports;
        }
    }
}
