using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Chamadaa.View.ViewLogin
{
    public partial class SenhaAdm3 : Form
    {
        public SenhaAdm3()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

          
            this.WindowState = FormWindowState.Minimized;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

            this.Close();
        }

        private void btnAcesso_Click(object sender, EventArgs e)
        {
            if (txtPass.Text == "82345")
            {
               Form_trocarNivel nivel = new Form_trocarNivel();
               nivel.ShowDialog();

                this.Close();
            }
            else if (txtPass.Text == "") { MessageBox.Show("Voce não digitou a chave!"); }
            else { MessageBox.Show("Chave inválida"); }
        }
    }
}
