using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Travel_agency.tours_information;

namespace Travel_agency
{
    public class Beach_Tour : Tour
    {
        public Beach_Tour(string city)
        {
            information_behavior = new Beach_behavior(city);
        }
    }
}
