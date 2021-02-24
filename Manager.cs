using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Travel_agency
{
    public class Manager : Employee
    {
        private static Client cur_client;
        private static List<Worker> workers;

        public static void Add_worker(Worker worker)
        {
            workers.Add(worker);
        }

        public static void Remove_worker(int work_number)
        {
            foreach (Worker worker in workers)
            {
                if (worker.Get_id_card().Get_id() == work_number)
                {
                    workers.Remove(worker);
                }
            }
        }

        public static List<Worker> Get_workers()
        {
            return workers;
        }

        public static Client Get_client()
        {
            return cur_client;
        }
        public static void Set_client(Client cur)
        {
            cur_client = cur;
        }

        public static void Remove_client()
        {
            cur_client = null;
        }

    }
}
