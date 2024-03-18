using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Configuration;
using System.Data;
using Chamadaa.View.VM;
using Chamadaa.View.ViewDC;
using System.Drawing;

namespace Chamadaa.View.ViewLogin
{
    public partial class FormLogin : Form
    {
        string conexao = ConfigurationManager.ConnectionStrings["strg_bd_esportivo"].ConnectionString;
        public FormLogin()
        {
            InitializeComponent();
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            //try
            //{
                MySqlConnection con = new MySqlConnection(conexao);
                string ident = Convert.ToString(txtId.Text);
                string senh = Convert.ToString(txtSenha.Text);

                string sql = "select * from tb_usuarios where tb_usuarios_identificacao= @id and tb_usuarios_senha= @senha";
                MySqlCommand executacmdmysql = new MySqlCommand(sql, con);

                executacmdmysql.Parameters.AddWithValue("@id", ident);
                executacmdmysql.Parameters.AddWithValue("@senha", senh);
                con.Open();

                MySqlDataReader dados = executacmdmysql.ExecuteReader();

                if (dados.Read())
                {
                    string permicao = dados.GetString("tb_usuarios_permicao");

                    if (permicao.Equals("Administrador"))
                    {
                        FrmMenu Menu = new FrmMenu();
                        Menu.Show();                        
                        Menu.lblPerfil.Text = "ADMIN";
                        con.Close();                        
                        
                    }
                    else if (permicao.Equals("Professor"))
                    {
                        FrmMenu Menu = new FrmMenu();
                        Menu.Show();

                        Menu.btnAlunos.Enabled = false;
                        Menu.btnProfessores.Enabled = false;

                        Menu.button7.Enabled = false;
                        Menu.button8.Enabled = false;
                        Menu.button14.Enabled = false;
                        Menu.button15.Enabled = false;

                        Menu.btnControleDados.Enabled = false;
                        Menu.lblPerfil.Text = "Professor";
                        

                        Menu.btnAlunos.Image = null;
                        Menu.btnProfessores.Image = null;


                        Menu.button7.Text = "Professores(Ind..)";
                        Menu.button8.Text = "Turmas(Ind..)";
                        Menu.button14.Text = "Estoque(Ind..)";
                        Menu.button15.Text = "Fornecedor(Ind..)";

                        Menu.btnAlunos.Text = "Alunos(Ind..)";
                        Menu.btnProfessores.Text = "Professores(Ind..)";
                        Menu.btnControleDados.Text = "Professores(Ind..)";


                        Menu.btnAlunos.BackColor = Color.AliceBlue;
                        Menu.btnProfessores.BackColor = Color.AliceBlue;
                        Menu.btnControleDados.BackColor = Color.AliceBlue;


                        con.Close();
                       

                    }
                    else if (permicao.Equals("Funcionário"))
                    {
                        FrmMenu Menu = new FrmMenu();
                        Menu.Show();
                        Menu.btnCad.Enabled = false;
                        //Menu.btnCadFornecedor.Enabed = false;
                        //Menu.btnCadEstoque.Enabled = false;


                        Menu.lblPerfil.Text = "Funcionário";

                        //Menu.btnCadFornecedor.BackColor = Color.White;
                        //Menu.btnCadEstoque.BackColor = Color.White;
                        Menu.btnCad.BackColor = Color.White;
                        Menu.btnControleDados.BackColor = Color.White;


                        con.Close();
                        

                    }
                    else if (permicao.Equals("Aluno"))
                    {
                        FrmMenu Menu = new FrmMenu();
                        Menu.Show();
                        Menu.btnCad.Enabled = false;
                        Menu.btnAlunos.Enabled = false;
                        Menu.btnProfessores.Enabled = false;
                        Menu.button3.Enabled = false;
                        Menu.button7.Enabled = false;
                        Menu.btnControleDados.Enabled = false;
                        Menu.button4.Enabled = false;
                        Menu.BtnEvt.Enabled = false;


                        Menu.lblPerfil.Text = "Aluno";

                        Menu.btnAlunos.Image = null;
                        Menu.btnProfessores.Image = null;

                        Menu.btnCad.Text = "Cadastros(Ind..)";
                        Menu.button4.Text = "Nova chamada(Ind..)";
                        Menu.btnAlunos.Text = "Alunos(Ind..)";
                        Menu.btnProfessores.Text = "Professores(Ind..)";
                        Menu.BtnEvt.Text = "(Alterado..)";
                        Menu.btnControleDados.Text = "Controle de Dados(Ind..)";

                        Menu.panelbtnEvt.Visible = true;
                        Menu.panelbtnEvt2.Visible = true;
                        Menu.btnEvt2.Visible = true;

                        Menu.btnCad.BackColor = Color.AliceBlue;
                        Menu.button4.BackColor = Color.AliceBlue;
                        Menu.btnAlunos.BackColor = Color.AliceBlue;
                        Menu.btnProfessores.BackColor = Color.AliceBlue;
                        Menu.btnControleDados.BackColor = Color.AliceBlue;
                        Menu.BtnEvt.BackColor = Color.AliceBlue;


                        con.Close();
                        
                    }                  




                }
                else { MessageBox.Show("Verifique os dados e tente novamente!!"); }


                //executacmdmysql.ExecuteNonQuery();


            //}
            //catch (Exception Erro)
            //{
            //    MessageBox.Show("Erro" + Erro);


            //}
        }

        private void FormLogin_Load(object sender, EventArgs e)
        {

        }

       
        private void lblSenha_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            MessageBox.Show("peça para um administrador conceder a alteração dos seus dados!!");

            SenhaAdm2 acesso = new SenhaAdm2();
            acesso.ShowDialog();
            
        }

        private void lblSemcad_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
           
            MessageBox.Show("peça para um administrador conceder seu cadastro como usuário!!");

            SenhaAdm1 acesso = new SenhaAdm1();
            acesso.ShowDialog();

            
        }
        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            MessageBox.Show("peça para um administrador conceder sua troca de permissão como usuário!!");

            SenhaAdm3 senha = new SenhaAdm3();
            senha.ShowDialog();
            
        }
    }
}
