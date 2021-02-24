using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Travel_agency.Adapter_pattern;

namespace Travel_agency
{
    public class Country : ICountry
    {
        private string title;
        private string city;
        private bool need_visa_EU;
        private bool need_visa_KOR;
        private int safety;

        public Country()
        {

        }

        public Country(string title, string city, bool need_visa_EU, bool need_visa_KOR)
        {
            this.title = title;
            this.need_visa_EU = need_visa_EU;
            this.need_visa_KOR = need_visa_KOR;
        }

        public string Get_country()
        {
            return title;
        }

        public void Change_title(string title)
        {
            this.title = title;
        }

        public bool Get_visa_EU()
        {
            return need_visa_EU;
        }

        public bool Get_visa_KOR()
        {
            return need_visa_KOR;
        }

        public void Set_visa_EU(bool new_status)
        {
            need_visa_EU = new_status;
        }

        public void Set_visa_KOR(bool new_status)
        {
            need_visa_KOR = new_status;
        }

        public int Get_safety()
        {
            return safety;
        }

        public void Set_safety(int new_safety)
        {
            safety = new_safety;
        }
    }
}
