using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_PIC_5.Models
{
    class LocationCost
    {
        public int IdLocation { set; get; }
        public string City { set; get; }
        public string Cost { get; set; }

        public LocationCost(int idLocation, string city, string cost)
        {
            IdLocation = idLocation;
            City = city;
            Cost = cost;
        }
    }
}
