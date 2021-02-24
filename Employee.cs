using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Travel_agency
{
    public class Employee
    {
        private static double salary;
        private static IdCard id_card;


        private static string phone_number;
        private static string name;
        private static string surname;
        private static int id_num;

        public static string Get_phone_number()
        {
            return phone_number;
        }

        public static void Set_phone_number(string phone_num)
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

        public IdCard Get_id_card()
        {
            return id_card;
        }

        public static void Set_id_card(IdCard c)
        {
            id_card = c;
        }

        public static double Get_salary()
        {
            return salary;
        }

        public static void Set_salary(double s)
        {
            salary = s;
        }
    }
}
