using Chamadaa.View.ViewUsuarios;
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
    public partial class SenhaAdm1 : Form
    {
        public SenhaAdm1()
        {
            InitializeComponent();
        }

        private void btnAcesso_Click(object sender, EventArgs e)
        {
            // Verificar versatilidade
            if (txtPass.Text == "82345")
            {
                CadUsuarios cad = new CadUsuarios();
                cad.ShowDialog();

                this.Close();
            }
            else if (txtPass.Text == "") { MessageBox.Show("Voce não digitou a chave!"); }
            else { MessageBox.Show("Chave inválida"); 
            }
        }

        private void iconFechar_Click(object sender, EventArgs e)
        {

            this.Close();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;         
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Close();

           
        }
    }
}
