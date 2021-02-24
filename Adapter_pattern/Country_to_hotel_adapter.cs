using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Travel_agency.Adapter_pattern;

namespace Travel_agency.Adapter_pattern
{
    class Country_to_hotel_adapter : IHotel
    {
        Country country;
        public Country_to_hotel_adapter(Country c)
        {
            country = c;
        }

        public string Get_title()
        {
            return country.Get_country();
        }
    }
}
