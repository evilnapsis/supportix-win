namespace SupportixWin
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.inicioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.verTicketsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nuevoTicketToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.verCategoriasToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.proyectosToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.usuariosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.menuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.inicioToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1022, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // inicioToolStripMenuItem
            // 
            this.inicioToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.verTicketsToolStripMenuItem,
            this.nuevoTicketToolStripMenuItem,
            this.verCategoriasToolStripMenuItem1,
            this.proyectosToolStripMenuItem1,
            this.usuariosToolStripMenuItem});
            this.inicioToolStripMenuItem.Name = "inicioToolStripMenuItem";
            this.inicioToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.inicioToolStripMenuItem.Text = "Inicio";
            // 
            // verTicketsToolStripMenuItem
            // 
            this.verTicketsToolStripMenuItem.Name = "verTicketsToolStripMenuItem";
            this.verTicketsToolStripMenuItem.Size = new System.Drawing.Size(143, 22);
            this.verTicketsToolStripMenuItem.Text = "Ver Tickets";
            // 
            // nuevoTicketToolStripMenuItem
            // 
            this.nuevoTicketToolStripMenuItem.Name = "nuevoTicketToolStripMenuItem";
            this.nuevoTicketToolStripMenuItem.Size = new System.Drawing.Size(143, 22);
            this.nuevoTicketToolStripMenuItem.Text = "Nuevo Ticket";
            this.nuevoTicketToolStripMenuItem.Click += new System.EventHandler(this.NuevoTicketToolStripMenuItem_Click);
            // 
            // verCategoriasToolStripMenuItem1
            // 
            this.verCategoriasToolStripMenuItem1.Name = "verCategoriasToolStripMenuItem1";
            this.verCategoriasToolStripMenuItem1.Size = new System.Drawing.Size(143, 22);
            this.verCategoriasToolStripMenuItem1.Text = "Categorias ...";
            this.verCategoriasToolStripMenuItem1.Click += new System.EventHandler(this.VerCategoriasToolStripMenuItem1_Click);
            // 
            // proyectosToolStripMenuItem1
            // 
            this.proyectosToolStripMenuItem1.Name = "proyectosToolStripMenuItem1";
            this.proyectosToolStripMenuItem1.Size = new System.Drawing.Size(143, 22);
            this.proyectosToolStripMenuItem1.Text = "Proyectos ...";
            this.proyectosToolStripMenuItem1.Click += new System.EventHandler(this.ProyectosToolStripMenuItem1_Click);
            // 
            // usuariosToolStripMenuItem
            // 
            this.usuariosToolStripMenuItem.Name = "usuariosToolStripMenuItem";
            this.usuariosToolStripMenuItem.Size = new System.Drawing.Size(143, 22);
            this.usuariosToolStripMenuItem.Text = "Usuarios ...";
            this.usuariosToolStripMenuItem.Click += new System.EventHandler(this.UsuariosToolStripMenuItem_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 606);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1022, 22);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(123, 17);
            this.toolStripStatusLabel1.Text = "Powered by Evilnapsis";
            this.toolStripStatusLabel1.Click += new System.EventHandler(this.ToolStripStatusLabel1_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 24);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(1022, 582);
            this.dataGridView1.TabIndex = 2;
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridView1_CellDoubleClick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1022, 628);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem inicioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem verTicketsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nuevoTicketToolStripMenuItem;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ToolStripMenuItem verCategoriasToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem proyectosToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem usuariosToolStripMenuItem;
    }
}

