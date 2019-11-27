using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
namespace SupportixWin
{
    class KindData
    {
        public int id;
        public string name;
        public static List<KindData> getAll()
        {
            List<KindData> tickets = new List<KindData>();
            MySqlDataReader reader = Db.Read("select * from kind");

            while (reader.Read())
            {
                KindData ti = new KindData();
                ti.id = reader.GetInt32(0);
                ti.name = reader.GetString(1);

                tickets.Add(ti);
            }
            reader.Close();
            return tickets;

        }
    }
}
