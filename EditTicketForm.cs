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
    public partial class EditTicketForm : Form
    {
        public static string id;
        public static DataGridView datagrid;

        List<ProjectData> projects;
        List<KindData> kinds ;
        List<StatusData> statuses ;
        List<CategoryData> categories ;
        List<PriorityData> priorities ;
        List<UserData> users ;
        public EditTicketForm()
        {
            InitializeComponent();

            TicketData ticket = TicketData.getById(id);

            projects = ProjectData.getAll();
            kinds = KindData.getAll();
            statuses = StatusData.getAll();
            categories = CategoryData.getAll();
            priorities = PriorityData.getAll();
            users = UserData.getAll();

            string project_str = "";
            foreach (ProjectData p in projects)
            {
                projects_combo.Items.Add(p.name);
                if (p.id == ticket.project_id) { project_str = p.name; }
            }
            string kind_str = "";
            foreach (KindData k in kinds) { kind_combo.Items.Add(k.name); if (k.id == ticket.kind_id) { kind_str = k.name; } }
            string status_str = "";
            foreach (StatusData s in statuses) { status_combo.Items.Add(s.name); if (s.id == ticket.status_id) { status_str = s.name; } }
            string prior_str = "";
            foreach (PriorityData p in priorities) { prior_combo.Items.Add(p.name); if (p.id == ticket.priority_id) { prior_str = p.name; } }
            string category_str = "";
            foreach (CategoryData c in categories) { categories_combo.Items.Add(c.name); if (c.id == ticket.category_id) { category_str = c.name; } }
            string user_str = "";
            foreach (UserData u in users) { users_combo.Items.Add(u.name + " " + u.lastname); if (u.id == ticket.user_id) { user_str = u.name+ " "+u.lastname; } }

            textBox1.Text = ticket.title;
            richTextBox1.Text = ticket.description;


            kind_combo.SelectedIndex = kind_combo.FindString(kind_str);
            status_combo.SelectedIndex = status_combo.FindString(status_str);
            prior_combo.SelectedIndex = prior_combo.FindString(prior_str);
            categories_combo.SelectedIndex = categories_combo.FindString(category_str);
            projects_combo.SelectedIndex = projects_combo.FindString(project_str);
            users_combo.SelectedIndex = users_combo.FindString(user_str);


        }

        private void Button1_Click(object sender, EventArgs e)
        {
            if( projects_combo.SelectedIndex!=-1 && kind_combo.SelectedIndex!=-1 && status_combo.SelectedIndex!=-1 && prior_combo.SelectedIndex!=-1 && categories_combo.SelectedIndex != -1 && textBox1.Text!="" && richTextBox1.Text!="" && users_combo.SelectedIndex!=-1)
            {
                //int kind_id , status_id , priority_id , category_id , project_id , user_id = 0;



                string sql = string.Format("update ticket set title='{0}', description='{1}', kind_id={2}, project_id={3}, status_id={4}, category_id={5}, priority_id={6}, user_id={7} where id={8}", textBox1.Text, richTextBox1.Text, kinds[kind_combo.SelectedIndex].id, projects[projects_combo.SelectedIndex].id, statuses[status_combo.SelectedIndex].id, categories[categories_combo.SelectedIndex].id, priorities[prior_combo.SelectedIndex].id, users[users_combo.SelectedIndex].id, id);
                Db.exec(sql);
                /*
                kind_combo.SelectedIndex = -1;
                status_combo.SelectedIndex = prior_combo.SelectedIndex = categories_combo.SelectedIndex = users_combo.SelectedIndex = projects_combo.SelectedIndex = -1;
                textBox1.Text = "";
                richTextBox1.Text = "";*/
                MessageBox.Show("Actualizado!");
                Form1.renderDatagrid(datagrid);
            }
            else
            {
                MessageBox.Show("No debes dejar campos vacios!");
            }
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                string sql = string.Format("delete from ticket where id={0}", id);
                Db.exec(sql);
                MessageBox.Show("Eliminado!");
                Form1.renderDatagrid(datagrid);
                Dispose();
            }
            else
            {
                MessageBox.Show("Debes seleccionar el checkbox!");
            }
        }
    }
}
