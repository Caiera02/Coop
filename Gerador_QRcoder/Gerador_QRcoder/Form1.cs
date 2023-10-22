using QRCoder;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gerador_QRcoder
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBoxURL != null)
            {
                QRCodeGenerator qrGenerator = new QRCodeGenerator();
                QRCodeData qrCodeData = qrGenerator.CreateQrCode(textBoxURL.Text, 
                QRCodeGenerator.ECCLevel.Q);

                QRCode qrCode = new QRCode(qrCodeData);
                Bitmap qrCodeImage = qrCode.GetGraphic(50);
                pictureBox1.Image = qrCodeImage.Save;
           
            }
            else
            {
                MessageBox.Show("Necessario digitar a URL");
            }
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void textBoxURL_TextChanged(object sender, EventArgs e)
        {
            if (textBoxURL == null)
            {
                MessageBox.Show("Necessario digitar a URL");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            SaveFileDialog salvar = new SaveFileDialog();

            if (salvar.ShowDialog() == DialogResult.OK);
            {
                MessageBox.Show(salvar.FileName);
            }
            
        }

    }
}
