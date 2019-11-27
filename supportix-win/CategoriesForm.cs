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
    public partial class CategoriesForm : Form
    {
        private MySqlDataAdapter adapter = new MySqlDataAdapter();
        private BindingSource bindingSource1 = new BindingSource();
        MySqlCommandBuilder commandbuilder;

        public CategoriesForm()
        {
            InitializeComponent();

            MySqlConnection con = Db.connect();

            adapter.SelectCommand = new MySqlCommand("select * from category", con);
            commandbuilder = new MySqlCommandBuilder(adapter);

            DataTable table = new DataTable();
            adapter.Fill(table);

            bindingSource1.DataSource = table;
            mydatagrid1.DataSource = bindingSource1;
            /*

            List<CategoryData> tickets = CategoryData.getAll();

            dataGridView1.Columns.Clear();
            dataGridView1.Rows.Clear();

            dataGridView1.Columns.Add("Id", "Id");
            dataGridView1.Columns.Add("Nombre", "Nombre");

            foreach (CategoryData ti in tickets)
            {
                dataGridView1.Rows.Add(ti.id, ti.name);

            }*/
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            adapter.Update((DataTable)bindingSource1.DataSource);
            MessageBox.Show("Actualizado!");
        }

        private void DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow onerow in mydatagrid1.SelectedRows)
            {
//                MessageBox.Show(""+onerow.Index);
                string id = mydatagrid1.Rows[onerow.Index].Cells[0].Value.ToString(); // assuming loannmber is integer
                                                                                          //                    string username = dataGridView1.Rows[oneCell.RowIndex].Cells['index of username column in datagridview'].Value; // assuming username is string

                string query = string.Format("DELETE FROM category WHERE id= {0} ", id);
                MySqlConnection con = Db.connect();
                Db.exec(query);
                mydatagrid1.Rows.RemoveAt(onerow.Index);
            }
        }
    }
}
