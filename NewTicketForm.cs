using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SupportixWin
{
    public partial class NewTicketForm : Form
    {
        public static DataGridView datagrid;

        List<ProjectData> projects;
        List<KindData> kinds ;
        List<StatusData> statuses ;
        List<CategoryData> categories ;
        List<PriorityData> priorities ;
        List<UserData> users ;
        public NewTicketForm()
        {
            InitializeComponent();

            projects = ProjectData.getAll();
            kinds = KindData.getAll();
            statuses = StatusData.getAll();
            categories = CategoryData.getAll();
            priorities = PriorityData.getAll();
            users = UserData.getAll();


            foreach (ProjectData p in projects)
            {
                projects_combo.Items.Add(p.name);
            }

            foreach(KindData k in kinds) { kind_combo.Items.Add(k.name); }
            foreach (StatusData s in statuses) { status_combo.Items.Add(s.name); }
            foreach (PriorityData p in priorities) { prior_combo.Items.Add(p.name); }
            foreach (CategoryData c in categories) { categories_combo.Items.Add(c.name); }
            foreach (UserData u in users) { users_combo.Items.Add(u.name + " " + u.lastname); }
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            if( projects_combo.SelectedIndex!=-1 && kind_combo.SelectedIndex!=-1 && status_combo.SelectedIndex!=-1 && prior_combo.SelectedIndex!=-1 && categories_combo.SelectedIndex != -1 && textBox1.Text!="" && richTextBox1.Text!="" && users_combo.SelectedIndex!=-1)
            {
                int kind_id , status_id , priority_id , category_id , project_id , user_id = 0;



                string sql = string.Format("insert into ticket (title, description, kind_id, project_id, status_id, category_id, priority_id, user_id, created_at) value ('{0}','{1}',{2},{3},{4},{5},{6},{7},NOW())", textBox1.Text, richTextBox1.Text, kinds[kind_combo.SelectedIndex].id, projects[projects_combo.SelectedIndex].id, statuses[status_combo.SelectedIndex].id, categories[categories_combo.SelectedIndex].id, priorities[prior_combo.SelectedIndex].id, users[users_combo.SelectedIndex].id);
                Db.exec(sql);
                kind_combo.SelectedIndex = -1;
                status_combo.SelectedIndex = prior_combo.SelectedIndex = categories_combo.SelectedIndex = users_combo.SelectedIndex = projects_combo.SelectedIndex = -1;
                textBox1.Text = "";
                richTextBox1.Text = "";
                MessageBox.Show("Agregado!");
                Form1.renderDatagrid(datagrid);
            }
            else
            {
                MessageBox.Show("No debes dejar campos vacios!");
            }
        }
    }
}
