using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Travel_agency
{
    public class Client
    {
        private static double budget;
        private static bool visa_EU = false;
        private static bool visa_KOR = false;


        private static int phone_number;
        private static string name;
        private static string surname;
        private static int id_num;

        public static int Get_phone_number()
        {
            return phone_number;
        }

        public static void Set_phone_number(int phone_num)
        {
            phone_number = phone_num;
        }

        public static string Get_name()
        {
            return name;
        }

        public static void Set_name(string n)
        {
            name = n;
        }

        public static string Get_surname()
        {
            return surname;
        }

        public static void Set_surname(string sn)
        {
            surname = sn;
        }
        public static int Get_id_number()
        {
            return id_num;
        }

        public static void Set_id_number(int id)
        {
            id_num = id;
        }

        public static double Get_budget()
        {
            return budget;
        }

        public static bool Get_visa_EU()
        {
            return visa_EU;
        }

        public static bool Get_visa_KOR()
        {
            return visa_KOR;
        }

        public static void Set_budget(double new_budget)
        {
            budget = new_budget;
        }

        public static void Set_visa_EU(bool new_status)
        {
            visa_EU = new_status;
        }

        public static void Set_visa_KOR(bool new_status)
        {
            visa_KOR = new_status;
        }
    }
}
