using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Travel_agency.tours_information;

namespace Travel_agency
{
    public class Active_Tour : Tour
    {
        public Active_Tour(string city)
        {
            information_behavior = new Active_behavior(city);
        }
    }
}
