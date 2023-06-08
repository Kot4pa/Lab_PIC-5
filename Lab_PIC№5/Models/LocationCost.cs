using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_PIC_5.Models
{
    class LocationCost
    {
        public int IdLocation { get; set; }
        public string City { get; set; }

        public LocationCost(int idLocation, string city)
        {
            IdLocation = idLocation;
            City = city;
        }
    }
}
