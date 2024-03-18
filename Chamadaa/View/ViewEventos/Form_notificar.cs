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

namespace Chamadaa.View.ViewEventos
{
    public partial class Form_notificar : Form
    {
        string conexao = ConfigurationManager.ConnectionStrings["strg_bd_esportivo"].ConnectionString;
        public Form_notificar()
        {
            InitializeComponent();
        }

        private void Form_notificar_Load(object sender, EventArgs e)
        {
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            if (cbBusca.Text == "Pesquisar por:") { MessageBox.Show("Selecione uma opção de esquisa."); }
            else if (cbBusca.Text == "Aluno")
            {
                MySqlConnection con = new MySqlConnection(conexao);

                con.Open();
                string sql = "select tb_alunos_id as 'ID', tb_alunos_nome as 'NOME', tb_alunos_email AS 'EMAIL', tb_alunos_telefone AS 'TELEFONE',tb_alunos_celular AS 'CELULAR' from tb_alunos where tb_alunos_nome like '" + txtNomeAlu.Text + "%'";
                MySqlCommand executacmdsql = new MySqlCommand(sql, con);
                executacmdsql.ExecuteNonQuery();

                DataTable tabela_turma = new DataTable();
                MySqlDataAdapter da = new MySqlDataAdapter(executacmdsql);
                da.Fill(tabela_turma);
                dgAlunos.DataSource = tabela_turma;
                con.Close();
            }

            else if (cbBusca.Text == "Professor") 
            {
                MySqlConnection con = new MySqlConnection(conexao);

                con.Open();
                string sql = "select tb_professor_id as 'ID', tb_professor_nome as 'NOME', tb_professor_email AS 'EMAIL', tb_professor_telefone AS 'TELEFONE' from tb_professor where tb_professor_nome like '" + txtNomeAlu.Text + "%'";
                MySqlCommand executacmdsql = new MySqlCommand(sql, con);
                executacmdsql.ExecuteNonQuery();

                DataTable tabela_turma = new DataTable();
                MySqlDataAdapter da = new MySqlDataAdapter(executacmdsql);
                da.Fill(tabela_turma);
                dgAlunos.DataSource = tabela_turma;
                con.Close();


            }
            else
            {
                MySqlConnection con = new MySqlConnection(conexao);

                con.Open();
                string sql = "select tb_fornecedor_id as 'ID', tb_fornecedor_nome as 'NOME', tb_fornecedor_email AS 'EMAIL', tb_fornecedor_telefone AS 'TELEFONE',tb_fornecedor_celular as 'CELULAR' from tb_fornecedor where tb_fornecedor_nome like '" + txtNomeAlu.Text + "%'";
                MySqlCommand executacmdsql = new MySqlCommand(sql, con);
                executacmdsql.ExecuteNonQuery();

                DataTable tabela_turma = new DataTable();
                MySqlDataAdapter da = new MySqlDataAdapter(executacmdsql);
                da.Fill(tabela_turma);
                dgAlunos.DataSource = tabela_turma;
                con.Close();


            }
        }

        private void btnCarregar_Click(object sender, EventArgs e)
        {
            if (cbBusca.Text == "Pesquisar por:") { MessageBox.Show("Selecione uma opção de esquisa."); }
            else if (cbBusca.Text == "Aluno")
            {
                MySqlConnection con = new MySqlConnection(conexao);

                con.Open();
                string sql = "select tb_alunos_id as 'ID', tb_alunos_nome as 'NOME', tb_alunos_email AS 'EMAIL', tb_alunos_telefone AS 'TELEFONE',tb_alunos_celular AS 'CELULAR' from tb_alunos";
                MySqlCommand executacmdsql = new MySqlCommand(sql, con);
                executacmdsql.ExecuteNonQuery();

                DataTable tabela_turma = new DataTable();
                MySqlDataAdapter da = new MySqlDataAdapter(executacmdsql);
                da.Fill(tabela_turma);
                dgAlunos.DataSource = tabela_turma;
                con.Close();
            }

            else if (cbBusca.Text == "Professor")
            {
                MySqlConnection con = new MySqlConnection(conexao);

                con.Open();
                string sql = "select tb_professor_id as 'ID', tb_professor_nome as 'NOME', tb_professor_email AS 'EMAIL', tb_professor_telefone AS 'TELEFONE' from tb_professor";
                MySqlCommand executacmdsql = new MySqlCommand(sql, con);
                executacmdsql.ExecuteNonQuery();

                DataTable tabela_turma = new DataTable();
                MySqlDataAdapter da = new MySqlDataAdapter(executacmdsql);
                da.Fill(tabela_turma);
                dgAlunos.DataSource = tabela_turma;
                con.Close();


            }
            else
            {
                MySqlConnection con = new MySqlConnection(conexao);

                con.Open();
                string sql = "select tb_fornecedor_id as 'ID', tb_fornecedor_nome as 'NOME', tb_fornecedor_email AS 'EMAIL', tb_fornecedor_telefone AS 'TELEFONE',tb_fornecedor_celular as 'CELULAR' from tb_fornecedor";
                MySqlCommand executacmdsql = new MySqlCommand(sql, con);
                executacmdsql.ExecuteNonQuery();

                DataTable tabela_turma = new DataTable();
                MySqlDataAdapter da = new MySqlDataAdapter(executacmdsql);
                da.Fill(tabela_turma);
                dgAlunos.DataSource = tabela_turma;
                con.Close();


            }
        }

        private void txtNomeAlu_Enter(object sender, EventArgs e)
        {
            if (txtNomeAlu.Text == "Nome:")
            {

                txtNomeAlu.Text = "";
                txtNomeAlu.ForeColor = Color.Silver;
            }
        }

        private void txtNomeAlu_Leave(object sender, EventArgs e)
        {
            if (txtNomeAlu.Text == "")
            {

                txtNomeAlu.Text = "Nome:";
                txtNomeAlu.ForeColor = Color.Silver;
            }
        }

        private void pbXNoti_Click(object sender, EventArgs e)
        {
            this.Close();
            pbXNoti.Dispose();
        }
    }
}
