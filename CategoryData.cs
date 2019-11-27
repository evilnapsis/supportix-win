using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
namespace SupportixWin
{
    class CategoryData
    {
        public int id;
        public string name;
        public static List<CategoryData> getAll()
        {
            List<CategoryData> tickets = new List<CategoryData>();
            MySqlDataReader reader = Db.Read("select * from category");

            while (reader.Read())
            {
                CategoryData ti = new CategoryData();
                ti.id = reader.GetInt32(0);
                ti.name = reader.GetString(1);

                tickets.Add(ti);
            }
            reader.Close();
            return tickets;

        }
    }
}
