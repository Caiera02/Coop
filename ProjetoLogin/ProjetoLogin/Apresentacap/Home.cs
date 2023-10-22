using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoLogin.Apresentacap
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void computadorNotebooksToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Hellou !");
        }

        private void toolStripComboBox1_Click(object sender, EventArgs e)
        {
            Cad_Notebook notebook = new Cad_Notebook();
            notebook.Show();
        }

        private void uranoInfoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Cad_Notebook notebook = new Cad_Notebook();
            notebook.Show();
        }

        private void brilhoArteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Cad_Notebook notebook = new Cad_Notebook();
            notebook.Show();
        }
    }
}
