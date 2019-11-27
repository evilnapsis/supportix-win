using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
namespace SupportixWin
{
    class StatusData
    {
        public int id;
        public string name;
        public static List<StatusData> getAll()
        {
            List<StatusData> tickets = new List<StatusData>();
            MySqlDataReader reader = Db.Read("select * from status");

            while (reader.Read())
            {
                StatusData ti = new StatusData();
                ti.id = reader.GetInt32(0);
                ti.name = reader.GetString(1);

                tickets.Add(ti);
            }
            reader.Close();
            return tickets;

        }
    }
}
