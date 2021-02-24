using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Travel_agency.Adapter_pattern;

namespace Travel_agency
{
    public class Hotel : IHotel
    {
        private string title;
        private int stars;
        private static double price_per_night;
        private double quality;

        public Hotel()
        {

        }

        public Hotel(string title, int stars, double price, double quality)
        {
            this.title = title;
            this.stars = stars;
            price_per_night = price;
            this.quality = quality;
        }
       

        public string Get_title()
        {
            return title;
        }

        public void Set_stars(int stars)
        {
            this.stars = stars;
        }

        public int Get_stars()
        {
            return stars;
        }
            
        public void Set_title(string title)
        {
            this.title = title;
        }

        public static double Get_price()
        {
            return price_per_night;
        }

        public void Set_price(double price)
        {
            price_per_night = price;
        }

        public double Get_quality()
        {
            return quality;
        }

        public void Set_quality(double quality)
        {
            this.quality = quality;
        }
        
    }
}
