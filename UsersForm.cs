using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace SupportixWin
{
    public partial class UsersForm : Form
    {
        private MySqlDataAdapter adapter = new MySqlDataAdapter();
        private BindingSource bindingSource1 = new BindingSource();
        MySqlCommandBuilder commandbuilder;
        public UsersForm()
        {
            InitializeComponent();
            MySqlConnection con = Db.connect();

            adapter.SelectCommand = new MySqlCommand("select * from user", con);
            commandbuilder = new MySqlCommandBuilder(adapter);

            DataTable table = new DataTable();
            adapter.Fill(table);

            bindingSource1.DataSource = table;
            mydatagrid1.DataSource = bindingSource1;

            mydatagrid1.Columns[0].Visible = false;
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            adapter.Update((DataTable)bindingSource1.DataSource);
            MessageBox.Show("Actualizado!");
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow onerow in mydatagrid1.SelectedRows)
            {
                //                MessageBox.Show(""+onerow.Index);
                string id = mydatagrid1.Rows[onerow.Index].Cells[0].Value.ToString(); // assuming loannmber is integer
                                                                                      //                    string username = dataGridView1.Rows[oneCell.RowIndex].Cells['index of username column in datagridview'].Value; // assuming username is string

                string query = string.Format("DELETE FROM user WHERE id= {0} ", id);
                MySqlConnection con = Db.connect();
                Db.exec(query);
                mydatagrid1.Rows.RemoveAt(onerow.Index);
            }
        }
    }
}
