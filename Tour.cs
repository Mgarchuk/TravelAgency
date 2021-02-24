using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Travel_agency.Adapter_pattern;
using Travel_agency.tours_information;

namespace Travel_agency
{
    public class Tour
    {
        private Transport transport;
        private Hotel hotel;
        private Country country_;
        private int km;
        private int days;

        protected ITours_information information_behavior;

        public Tour()
        {

        }


        public string Get(IHotel hotel)
        {
            return hotel.Get_title();
        }

        public Transport Get_transport()
        {
            return transport;
        }


        public void Set_transport(Transport transport)
        {
            this.transport = transport;
        }

        public Hotel Get_hotel()
        {
            return hotel;
        }
        public void Set_hotel(Hotel hotel)
        {
            this.hotel = hotel;
        }

        public double Calculate_cost()
        {
            return Hotel.Get_price();
        }
        public Country Get_country()
        {
            return country_;
        }
    
        public void Set_country(Country country)
        {
            this.country_ = country;
        }

        public int Get_days()
        {
            return days;
        }

        public void Set_days(int days)
        {
            this.days = days;
        }

        /// <summary>
        /// /////////////////////////////////////////////// 
        /// </summary>
        /// <returns></returns>
        
        public virtual Tuple<double, double, double> Get_tours_information(string city)
        {
            return information_behavior.Get_tours_information(city);
        }
    }
}
