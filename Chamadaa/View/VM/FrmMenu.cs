using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using Chamadaa.View.viewChamada;
using Chamadaa.Properties;
using Chamadaa.View.ViewCadastros;
using Chamadaa.View.ViewDC;
using Chamadaa.View.View_Eventos;
using Chamadaa.View.ViewEventos;

namespace Chamadaa.View.VM
{
    public partial class FrmMenu : Form
    {
        private bool isColapsed;
        private bool isColapsed2;
        private bool isColapsed3;

        public FrmMenu()
        {
            InitializeComponent();
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);


        private void btnMenuLateral_Click(object sender, EventArgs e)
        {
            if (MenuVertical.Width == 250)
            {
                MenuVertical.Width = 70;
            }
            else
            {
                MenuVertical.Width = 250;
            }
        }

        private void iconFechar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void iconMaximizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            iconRestaurar.Visible = true;
            iconMaximizar.Visible = false;
        }

        private void iconRestaurar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
            iconRestaurar.Visible = false;
            iconMaximizar.Visible = true;
        }

        private void iconMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void BarraTitulo_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void MenuVertical_Paint(object sender, PaintEventArgs e)
        {

        }


        private void AbrirFormInPanel(object Formhijo)
        {
            if (this.painelContenedor.Controls.Count > 0)
                this.painelContenedor.Controls.RemoveAt(0);
            Form fh = Formhijo as Form;
            fh.TopLevel = false;
            fh.Dock = DockStyle.Fill;
            this.painelContenedor.Controls.Add(fh);
            this.painelContenedor.Tag = fh;
            fh.Show();
        }
        private void btnFreq_Click(object sender, EventArgs e)
        {
            timer2.Start();
            /* AbrirFormInPanel(new Modalidade());*/
        }

        private void FrmMenu_Load(object sender, EventArgs e)
        {
            AbrirFormInPanel(new Menu());

        }

        private void horafecha_Tick(object sender, EventArgs e)
        {
            /*lblHora.Text = DateTime.Now.ToLongTimeString();
            lblData.Text = DateTime.Now.ToLongDateString();*/
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (isColapsed)
            {
                
                painelCad.Height += 10;
                if (painelCad.Size == painelCad.MaximumSize)
                {
                    timer1.Stop();
                    isColapsed = false;
                }
            }
            else
            {
               

                painelCad.Height -= 10;
                if (painelCad.Size == painelCad.MinimumSize)
                {
                    timer1.Stop();
                    isColapsed = true;
                }
            }



        }

        private void btnCad_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            if (isColapsed2)
            {
               
                painelFreq.Height += 10;
                if (painelFreq.Size == painelFreq.MaximumSize)
                {
                    timer2.Stop();
                    isColapsed2 = false;
                }
            }
            else
            {
                

                painelFreq.Height -= 10;
                if (painelFreq.Size == painelFreq.MinimumSize)
                {
                    timer2.Stop();
                    isColapsed2 = true;
                }
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            AbrirFormInPanel(new Modalidade());
        }

        private void button9_Click(object sender, EventArgs e)
        {
            AbrirFormInPanel(new ChamadaAnt());

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            AbrirFormInPanel(new Menu());

        }

        private void painelContenedor_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            AbrirFormInPanel(new CadAlu());
        }

        private void button7_Click(object sender, EventArgs e)
        {
            AbrirFormInPanel(new CadProfessor());
        }

        private void button8_Click(object sender, EventArgs e)
        {
            AbrirFormInPanel(new CadTurma());
        }
        private void timer3_Tick(object sender, EventArgs e)
        {
            if (isColapsed3)
            {
               
                painelDC.Height += 10;
                if (painelDC.Size == painelDC.MaximumSize)
                {
                    timer3.Stop();
                    isColapsed3 = false;
                }
            }
            else
            {
              

                painelDC.Height -= 10;
                if (painelDC.Size == painelDC.MinimumSize)
                {
                    timer3.Stop();
                    isColapsed3 = true;
                }
            }
        }
        private void button13_Click(object sender, EventArgs e)
        {
            AbrirFormInPanel(new DCTurma());
        }

        private void button12_Click(object sender, EventArgs e)
        {
            AbrirFormInPanel(new DCEstoque());
        }

        private void button11_Click(object sender, EventArgs e)
        {
            AbrirFormInPanel(new DCFornecedor());
        }

        private void button14_Click(object sender, EventArgs e)
        {
            AbrirFormInPanel(new CadEstoque());
        }

        private void button15_Click(object sender, EventArgs e)
        {
            AbrirFormInPanel(new CadFornecedor());
        }

        private void button5_Click(object sender, EventArgs e)
        {
            AbrirFormInPanel(new Tela_evts_principal());
        }

        private void button6_Click(object sender, EventArgs e)
        {
            AbrirFormInPanel(new Form_notificar()); 
        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {
            AbrirFormInPanel(new Menu());
        }

        private void button10_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void btnEvt2_Click(object sender, EventArgs e)
        {
            AbrirFormInPanel(new Form_evt_aluno());
        }

        private void btnNotificar_Click(object sender, EventArgs e)
        {
            AbrirFormInPanel(new Form_notificar());
        }

        private void BtnEvt_Click(object sender, EventArgs e)
        {
            AbrirFormInPanel(new CDEventos());
        }

        private void btnControleDados_Click(object sender, EventArgs e)
        {
            timer3.Start();
        }

        private void btnAlunos_Click(object sender, EventArgs e)
        {

        }
    } 
    }

