using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Chamadaa.View.ViewCadastros
{
    public partial class CadProfessor : Form
    {
        string conexao = ConfigurationManager.ConnectionStrings["strg_bd_esportivo"].ConnectionString;
        public CadProfessor()
        {
            InitializeComponent();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            try
            {
                MySqlConnection con = new MySqlConnection(conexao);

                string nome_prof = txtNomeProf.Text;
                string tel_prof = txtTelProf.Text;
                string email_prof = txtEmailProf.Text;


                string sql_insert_tb_prof = @"insert into tb_professor
                                            (
                                                tb_professor_nome,
                                                tb_professor_email,
                                                tb_professor_telefone                                           

                                            )
                                            values
                                            (
                                                @prof_nome,
                                                @prof_email, 
                                                @prof_tel                                     

                                                );";

                MySqlCommand exeCmdMysl_insert = new MySqlCommand(sql_insert_tb_prof, con);

                exeCmdMysl_insert.Parameters.AddWithValue("@prof_nome", nome_prof);
                exeCmdMysl_insert.Parameters.AddWithValue("@prof_email", email_prof);
                exeCmdMysl_insert.Parameters.AddWithValue("@prof_tel", tel_prof);
                con.Open();
                exeCmdMysl_insert.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Cadastro de professor bem sucedido!");

                txtNomeProf.Text = "Nome*";
                txtEmailProf.Text = "Email*";
                txtTelProf.Text = "Telefone*";

                btnReset.Enabled = true;
            }
            catch (Exception ERRO)
            {

                MessageBox.Show("Valores não cadastrados por conterem alterações" + ERRO);
            }

            MySqlConnection cone = new MySqlConnection(conexao);
            cone.Open();

            string sql_select_professor = @"select tb_professor_nome as 'NOME:', tb_professor_email as 'EMAIL:', tb_professor_telefone as'TELEFONE:' from tb_professor";

            MySqlCommand executacmdMySql_select_professor = new MySqlCommand(sql_select_professor, cone);

            executacmdMySql_select_professor.ExecuteNonQuery();

            DataTable tbl_prof = new DataTable();

            MySqlDataAdapter da_prof = new MySqlDataAdapter(executacmdMySql_select_professor);

            da_prof.Fill(tbl_prof);
            dgProfessores.DataSource = tbl_prof;
            cone.Close();
        }

        private void CadProfessor_Load(object sender, EventArgs e)
        {
            MySqlConnection con = new MySqlConnection(conexao);
            con.Open();

            string sql_select_professor = @"select tb_professor_nome as 'NOME:', tb_professor_email as 'EMAIL:', tb_professor_telefone as'TELEFONE:' from tb_professor";

            MySqlCommand executacmdMySql_select_professor = new MySqlCommand(sql_select_professor, con);

            executacmdMySql_select_professor.ExecuteNonQuery();

            DataTable tbl_prof = new DataTable();

            MySqlDataAdapter da_prof = new MySqlDataAdapter(executacmdMySql_select_professor);

            da_prof.Fill(tbl_prof);
            dgProfessores.DataSource = tbl_prof;
            con.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtNomeProf_Enter(object sender, EventArgs e)
        {
            if (txtNomeProf.Text == "Nome*")
            {

                txtNomeProf.Text = "";
                txtNomeProf.ForeColor = Color.Silver;
            }
        }

        private void txtNomeProf_Leave(object sender, EventArgs e)
        {
            if (txtNomeProf.Text == "")
            {

                txtNomeProf.Text = "Nome*";
                txtNomeProf.ForeColor = Color.Silver;
            }
        }

        private void txtEmailProf_Enter(object sender, EventArgs e)
        {
            if (txtEmailProf.Text == "Email*")
            {

                txtEmailProf.Text = "";
                txtEmailProf.ForeColor = Color.Silver;
            }
        }

        private void txtEmailProf_Leave(object sender, EventArgs e)
        {
            if (txtEmailProf.Text == "")
            {

                txtEmailProf.Text = "Email*";
                txtEmailProf.ForeColor = Color.Silver;
            }
        }

        private void txtTelProf_Enter(object sender, EventArgs e)
        {
            if (txtTelProf.Text == "Telefone*")
            {

                txtTelProf.Text = "(";
                txtTelProf.ForeColor = Color.Silver;
            }
           

        }

        private void txtTelProf_Leave(object sender, EventArgs e)
        {
            if (txtTelProf.Text == "(")
            {

                txtTelProf.Text = "Telefone*";
                txtTelProf.ForeColor = Color.Silver;
            }
        }

        private void txtTelProf_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Verificar se foi digitado algum caracter
            if (char.IsNumber(e.KeyChar) == true)
            {
                switch (txtTelProf.TextLength/*(tamanho do texto)*/)
                {
                    case 0:
                        txtTelProf.Text = txtTelProf.Text + "(";
                        //Jogar o cursor pra 4 posição
                        txtTelProf.SelectionStart = 4;
                        break;
                    case 3:
                        txtTelProf.Text = txtTelProf.Text + ")";
                        //Jogar o cursor pra 4 posição
                        txtTelProf.SelectionStart = 4;

                        break;

                }
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            MySqlConnection con = new MySqlConnection(conexao);
            con.Open();

            string sql_select_professor = @"select tb_professor_nome as 'NOME:', tb_professor_email as 'EMAIL:', tb_professor_telefone as'TELEFONE:' from tb_professor";

            MySqlCommand executacmdMySql_select_professor = new MySqlCommand(sql_select_professor, con);

            executacmdMySql_select_professor.ExecuteNonQuery();

            DataTable tbl_prof = new DataTable();

            MySqlDataAdapter da_prof = new MySqlDataAdapter(executacmdMySql_select_professor);

            da_prof.Fill(tbl_prof);
            dgProfessores.DataSource = tbl_prof;
            con.Close();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void iconMinimizar_Click(object sender, EventArgs e)
        {

        }

        private void iconFechar_Click(object sender, EventArgs e)
        {

        }
    }
}
