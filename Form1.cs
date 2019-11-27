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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            renderDatagrid(dataGridView1);

        }

        public static void renderDatagrid( DataGridView dataGridView1) {
            List<TicketData> tickets = TicketData.getAll();
            List<ProjectData> projects;
            List<KindData> kinds;
            List<StatusData> statuses;
            List<CategoryData> categories;
            List<PriorityData> priorities;
            List<UserData> users;
            projects = ProjectData.getAll();
            kinds = KindData.getAll();
            statuses = StatusData.getAll();
            categories = CategoryData.getAll();
            priorities = PriorityData.getAll();
            users = UserData.getAll();



            dataGridView1.Columns.Clear();
            dataGridView1.Rows.Clear();

            dataGridView1.Columns.Add("Id", "Id");
            dataGridView1.Columns.Add("Titulo", "Titulo");
            dataGridView1.Columns.Add("Tipo", "Tipo");
            dataGridView1.Columns.Add("Proyecto", "Proyecto");
            dataGridView1.Columns.Add("Categoria", "Categoria");
            dataGridView1.Columns.Add("Prioridad", "Prioridad");
            dataGridView1.Columns.Add("Estado", "Estado");
            dataGridView1.Columns.Add("Usuario", "Usuario");

            dataGridView1.Columns.Add("Fecha", "Fecha");

            foreach (TicketData ticket in tickets)
            {
                string project_str = "";
                foreach (ProjectData p in projects)
                {
                    if (p.id == ticket.project_id) { project_str = p.name; }
                }
                string kind_str = "";
                foreach (KindData k in kinds) { if (k.id == ticket.kind_id) { kind_str = k.name; } }
                string status_str = "";
                foreach (StatusData s in statuses) { if (s.id == ticket.status_id) { status_str = s.name; } }
                string prior_str = "";
                foreach (PriorityData p in priorities) {  if (p.id == ticket.priority_id) { prior_str = p.name; } }
                string category_str = "";
                foreach (CategoryData c in categories) { if (c.id == ticket.category_id) { category_str = c.name; } }
                string user_str = "";
                foreach (UserData u in users) {  if (u.id == ticket.user_id) { user_str = u.name + " " + u.lastname; } }
                dataGridView1.Rows.Add(ticket.id, ticket.title, kind_str, project_str, category_str, prior_str, status_str, user_str , ticket.created_at);

            }
        }

        private void CategoriaToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void ToolStripStatusLabel1_Click(object sender, EventArgs e)
        {

        }

        private void VerCategoriasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CategoriesForm cf = new CategoriesForm();
            cf.ShowDialog();
        }

        private void VerCategoriasToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            CategoriesForm cf = new CategoriesForm();
            cf.ShowDialog();
        }

        private void ProyectosToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            ProjectsForm pf = new ProjectsForm();
            pf.ShowDialog();
        }

        private void NuevoTicketToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NewTicketForm.datagrid = dataGridView1;
            NewTicketForm ntf = new NewTicketForm();
            ntf.ShowDialog();
        }

        private void UsuariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UsersForm uf = new UsersForm();
            uf.ShowDialog();
        }

        private void DataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            string id  = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            EditTicketForm.id = id;
            EditTicketForm.datagrid = dataGridView1;
            EditTicketForm etf = new EditTicketForm();
            etf.ShowDialog();
        }
    }
}
