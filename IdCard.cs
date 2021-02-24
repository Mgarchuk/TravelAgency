using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Travel_agency
{
    public class IdCard
    {
        private int work_number;
        private DateTime date_expire;
        private double work_rating;

        public IdCard(int work_number, DateTime date_expire, double work_rating)
        {
            this.work_number = work_number;
            this.date_expire = date_expire;
            this.work_rating = work_rating;
        }

        public int Get_id()
        {
            return work_number;
        }

        public DateTime Get_date()
        {
            return date_expire;
        }

        public double Get_rating()
        {
            return work_rating;
        }

        public void Change_date(DateTime new_date)
        {
            date_expire = new_date;
        }

        public void Change_rating(double new_rating)
        {
            work_rating = new_rating;
        }
            
    }
}
