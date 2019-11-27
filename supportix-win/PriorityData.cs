using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace SupportixWin
{
    class PriorityData
    {
        public int id;
        public string name;
        public static List<PriorityData> getAll()
        {
            List<PriorityData> tickets = new List<PriorityData>();
            MySqlDataReader reader = Db.Read("select * from priority");

            while (reader.Read())
            {
                PriorityData ti = new PriorityData();
                ti.id = reader.GetInt32(0);
                ti.name = reader.GetString(1);

                tickets.Add(ti);
            }
            reader.Close();
            return tickets;

        }
    }
}
