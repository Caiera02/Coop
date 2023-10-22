namespace ProjetoLogin.Apresentacap
{
    partial class Home
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
            this.menuHome = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.computadorNotebooksToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripComboBox1 = new System.Windows.Forms.ToolStripComboBox();
            this.uranoInfoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.brilhoArteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.celularesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuHome.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuHome
            // 
            this.menuHome.AccessibleRole = System.Windows.Forms.AccessibleRole.MenuBar;
            this.menuHome.AllowMerge = false;
            this.menuHome.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.menuHome.Dock = System.Windows.Forms.DockStyle.Left;
            this.menuHome.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.menuHome.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1});
            this.menuHome.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.VerticalStackWithOverflow;
            this.menuHome.Location = new System.Drawing.Point(0, 0);
            this.menuHome.MdiWindowListItem = this.toolStripMenuItem1;
            this.menuHome.Name = "menuHome";
            this.menuHome.Size = new System.Drawing.Size(90, 368);
            this.menuHome.TabIndex = 0;
            this.menuHome.Text = "menuStrip1";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.CheckOnClick = true;
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.computadorNotebooksToolStripMenuItem,
            this.celularesToolStripMenuItem});
            this.toolStripMenuItem1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(77, 25);
            this.toolStripMenuItem1.Text = "Cadastro";
            this.toolStripMenuItem1.Click += new System.EventHandler(this.toolStripMenuItem1_Click);
            // 
            // computadorNotebooksToolStripMenuItem
            // 
            this.computadorNotebooksToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripComboBox1,
            this.uranoInfoToolStripMenuItem,
            this.brilhoArteToolStripMenuItem});
            this.computadorNotebooksToolStripMenuItem.Name = "computadorNotebooksToolStripMenuItem";
            this.computadorNotebooksToolStripMenuItem.Size = new System.Drawing.Size(250, 26);
            this.computadorNotebooksToolStripMenuItem.Text = "Computador/Notebooks";
            this.computadorNotebooksToolStripMenuItem.Click += new System.EventHandler(this.computadorNotebooksToolStripMenuItem_Click);
            // 
            // toolStripComboBox1
            // 
            this.toolStripComboBox1.Name = "toolStripComboBox1";
            this.toolStripComboBox1.Overflow = System.Windows.Forms.ToolStripItemOverflow.Always;
            this.toolStripComboBox1.Size = new System.Drawing.Size(121, 23);
            this.toolStripComboBox1.Text = "Cooperativa";
            this.toolStripComboBox1.Click += new System.EventHandler(this.toolStripComboBox1_Click);
            // 
            // uranoInfoToolStripMenuItem
            // 
            this.uranoInfoToolStripMenuItem.Name = "uranoInfoToolStripMenuItem";
            this.uranoInfoToolStripMenuItem.Size = new System.Drawing.Size(181, 26);
            this.uranoInfoToolStripMenuItem.Text = "UranoInfo";
            this.uranoInfoToolStripMenuItem.Click += new System.EventHandler(this.uranoInfoToolStripMenuItem_Click);
            // 
            // brilhoArteToolStripMenuItem
            // 
            this.brilhoArteToolStripMenuItem.Name = "brilhoArteToolStripMenuItem";
            this.brilhoArteToolStripMenuItem.Size = new System.Drawing.Size(181, 26);
            this.brilhoArteToolStripMenuItem.Text = "Brilho Arte";
            this.brilhoArteToolStripMenuItem.Click += new System.EventHandler(this.brilhoArteToolStripMenuItem_Click);
            // 
            // celularesToolStripMenuItem
            // 
            this.celularesToolStripMenuItem.Name = "celularesToolStripMenuItem";
            this.celularesToolStripMenuItem.Size = new System.Drawing.Size(250, 26);
            this.celularesToolStripMenuItem.Text = "Celulares";
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(651, 368);
            this.Controls.Add(this.menuHome);
            this.ImeMode = System.Windows.Forms.ImeMode.On;
            this.MainMenuStrip = this.menuHome;
            this.Name = "Home";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Home";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.menuHome.ResumeLayout(false);
            this.menuHome.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuHome;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem computadorNotebooksToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem celularesToolStripMenuItem;
        private System.Windows.Forms.ToolStripComboBox toolStripComboBox1;
        private System.Windows.Forms.ToolStripMenuItem uranoInfoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem brilhoArteToolStripMenuItem;
    }
}