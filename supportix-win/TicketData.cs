using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace SupportixWin
{
    class TicketData
    {
        public int id;
        public string title;
        public string description;
        public int kind_id;
        public int status_id;
        public int project_id;
        public int category_id;
        public int priority_id;
        public int user_id;
        public string created_at;
        public static List<TicketData>  getAll()
        {
            List<TicketData> tickets = new List<TicketData>();
            MySqlDataReader reader = Db.Read("select * from ticket");

            while (reader.Read())
            {
                TicketData ti = new TicketData();
                ti.id = reader.GetInt32(0);
                ti.title = reader.GetString(1);
                ti.description = reader.GetString(2);
                ti.created_at = reader.GetString(4);
                ti.kind_id = reader.GetInt32(5);
                ti.user_id = reader.GetInt32(6);
                ti.project_id = reader.GetInt32(8);
                ti.category_id = reader.GetInt32(9);
                ti.priority_id = reader.GetInt32(10);
                ti.status_id = reader.GetInt32(11);
                tickets.Add(ti);
            }
            reader.Close();
            return tickets;    

        }
        public static TicketData getById(string id)
        {
            MySqlDataReader reader = Db.Read("select * from ticket where id="+id);
            TicketData ti = new TicketData();

            while (reader.Read())
            {
                ti.id = reader.GetInt32(0);
                ti.title = reader.GetString(1);
                ti.description = reader.GetString(2);
                ti.created_at = reader.GetString(4);
                ti.kind_id = reader.GetInt32(5);
                ti.user_id = reader.GetInt32(6);
                ti.project_id = reader.GetInt32(8);
                ti.category_id = reader.GetInt32(9);
                ti.priority_id = reader.GetInt32(10);
                ti.status_id = reader.GetInt32(11);

            }
            reader.Close();
            return ti;

        }
    }
}
