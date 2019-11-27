using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
namespace SupportixWin
{
    class Db
    {

        public string server = "localhost";
        public string userid = "root";
        public string password = "";
        public string database = "supportix";
        public static MySqlConnection constatic = null;
        public static MySqlConnection connect()
        {
            if (constatic == null)
            {
                MySqlConnectionStringBuilder builder = new MySqlConnectionStringBuilder();
                builder.Server = "localhost";
                builder.UserID = "root";
                builder.Password = "";
                builder.Database = "supportix";
                constatic = new MySqlConnection(builder.ToString());
                constatic.Open();
                Console.WriteLine("Abriendo Conexion ...");
            }


            return constatic;
        }

        public static void exec(string sql)
        {
            MySqlConnection conn = connect();
            MySqlCommand cmd = conn.CreateCommand();
            cmd.CommandText = sql; // "INSERT INTO mitabla (valor1,valor2) value (1,2)";
            //conn.Open();
            cmd.ExecuteNonQuery();
        }

        public static MySqlDataReader Read(string sql)
        {
            MySqlConnection conn = connect();
            MySqlDataReader rdr = null;

            try
            {

                string stm = sql;//  "SELECT * FROM Authors";
                MySqlCommand cmd = new MySqlCommand(stm, conn);
                rdr = cmd.ExecuteReader();

               /* while (rdr.Read())
                {
                    Console.WriteLine(rdr.GetInt32(0) + ": "
                        + rdr.GetString(1));
                }*/

            }
            catch (MySqlException ex)
            {
                Console.WriteLine("Error: {0}", ex.ToString());
            }
            return rdr;
        }
    }
}
