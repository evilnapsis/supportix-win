using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace SupportixWin
{
    class ProjectData
    {
        
        public int id;
        public string name;
        public static List<ProjectData> getAll()
        {
            List<ProjectData> tickets = new List<ProjectData>();
            MySqlDataReader reader = Db.Read("select * from project");

            while (reader.Read())
            {
                ProjectData ti = new ProjectData();
                ti.id = reader.GetInt32(0);
                ti.name = reader.GetString(1);

                tickets.Add(ti);
            }
            reader.Close();
            return tickets;

        }
    }
}
