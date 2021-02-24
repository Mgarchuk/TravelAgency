using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Travel_agency.Singleton_pattern
{
    class Singleton
    {
        private static Singleton single = null;


        protected Singleton()
        {

        }

        public static Singleton Initialize()
        {
            if(single == null)
            {
                single = new Singleton();
                Client.Set_budget(Client.Get_budget() + 10.00);    
            }
            return single;
        }
    }
}
