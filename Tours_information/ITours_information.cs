using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Travel_agency.tours_information
{
    public interface ITours_information
    {
        Tuple<double, double, double> Get_tours_information(string tour);
    }
}
