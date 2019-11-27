using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
namespace SupportixWin
{
    class UserData
    {
        public int id;
        public string name;
        public string lastname;
        public static List<UserData> getAll()
        {
            List<UserData> tickets = new List<UserData>();
            MySqlDataReader reader = Db.Read("select * from user");

            while (reader.Read())
            {
                UserData ti = new UserData();
                ti.id = reader.GetInt32(0);
                ti.name = reader.GetString(2);
                ti.lastname= reader.GetString(3);

                tickets.Add(ti);
            }
            reader.Close();
            return tickets;

        }
    }
}
