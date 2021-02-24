using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Travel_agency
{
    public class Worker : Employee
    {
        private static Client cur_client;
        private static int reputation;

        public static void Set_client(Client cur)
        {
            cur_client = cur;
        }

        public static void Remove_client()
        {
            cur_client = null;
        }

        public static int Get_reputation()
        {
            return reputation;
        }

        public static void Set_reputation(int new_reputation)
        {
            reputation = new_reputation;
        }

    }

}
