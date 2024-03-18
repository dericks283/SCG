using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using MySql.Data.MySqlClient;

namespace Chamadaa.View.View_Eventos
{
    public partial class Cadastro_finalistas : Form
    {
        string conexao = ConfigurationManager.ConnectionStrings["strg_bd_esportivo"].ConnectionString;
        public Cadastro_finalistas()
        {
            InitializeComponent();
        }

        private void btnCadatrar_Click(object sender, EventArgs e)
        {
            try
            {
                MySqlConnection con = new MySqlConnection(conexao);

                string nome = txtNome.Text;

                string data = txtdt.Text;

                string local = txtLocal.Text;

                string organizador = txtOrg.Text;

                string modalidade = txtModa.Text;

                string sql_insert_tb_camp = @"insert into tb_FINALISTAS
                                            (
                                                TB_ALUNO_NOME,
                                                TB_DT_FINAL,
                                                TB_MODALIDADE_CAMP,
                                                TB_NOME_ORGANIZADOR,
                                                TB_NOME_LOCAL
                 
                                            )
                                            values
                                            (
                                                @nome,
                                                @data,
                                                @modalidade,
                                                @nome_organizador,
                                                @nome_local
                                                
                                                );";

                MySqlCommand exeCmdMysl_insert = new MySqlCommand(sql_insert_tb_camp, con);

                exeCmdMysl_insert.Parameters.AddWithValue("@nome", nome);
                exeCmdMysl_insert.Parameters.AddWithValue("@data", data);
                exeCmdMysl_insert.Parameters.AddWithValue("@@modalidade", modalidade);
                exeCmdMysl_insert.Parameters.AddWithValue("@nome_organizador", organizador);
                exeCmdMysl_insert.Parameters.AddWithValue("@nome_local", local);

                con.Open();
                exeCmdMysl_insert.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Cadastro bem sucedido!");

                
                txtdt.Text = "Data da Final*";
                txtLocal.Text = "Local";
                txtOrg.Text = "Organizador";
                txtModa.Text = "Modalidade*";
            }

            catch (Exception erro)
            {
                MessageBox.Show(erro + "Valores não cadastrados por conterem alterações!!");
            }
        }

        private void txtdt_Enter(object sender, EventArgs e)
        {
            if (txtdt.Text == "Data da Final*")
            {

                txtdt.Text = "";
               
            }
        }

        private void txtdt_Leave(object sender, EventArgs e)
        {
            if (txtdt.Text == "")
            {

                txtdt.Text = "Data da Final*";
               
            }
        }

        private void txtLocal_Enter(object sender, EventArgs e)
        {
            if (txtLocal.Text == "Local")
            {

                txtLocal.Text = "";
                
            }
        }

        private void txtLocal_Leave(object sender, EventArgs e)
        {
            if (txtLocal.Text == "")
            {

                txtLocal.Text = "Local";
               
            }
        }

        private void txtOrg_Enter(object sender, EventArgs e)
        {
            if (txtOrg.Text == "Organizador")
            {

                txtOrg.Text = "";
                
            }
        }

        private void txtOrg_Leave(object sender, EventArgs e)
        {
            if (txtOrg.Text == "")
            {

                txtOrg.Text = "Organizador";
                
            }
        }

        private void txtModa_Enter(object sender, EventArgs e)
        {
            if (txtModa.Text == "Modalidade*")
            {

                txtModa.Text = "";
                
            }
        }

        private void txtModa_Leave(object sender, EventArgs e)
        {
            if (txtModa.Text == "")
            {
                txtModa.Text = "Modalidade*";
               
            }
        }

        private void Cadastro_finalistas_Load(object sender, EventArgs e)
        {

        }

        private void iconMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void iconFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Close();           
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void txtdt_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Verificar se foi digitado algum caracter
            if (char.IsNumber(e.KeyChar) == true)
            {
                switch (txtdt.TextLength/*(tamanho do texto)*/)
                {
                    case 2:
                        txtdt.Text = txtdt.Text + "_";
                        //Jogar o cursor pra 4 posição
                        txtdt.SelectionStart = 3;
                        break;
                    case 5:
                        txtdt.Text = txtdt.Text + "_";
                        //Jogar o cursor pra 4 posição
                        txtdt.SelectionStart = 6;

                        break;

                }
            }
        }
    }
}
