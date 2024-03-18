using Chamadaa.View.VM;
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
    public partial class Form_buscar_porAluno : Form
    {
        string conexao = ConfigurationManager.ConnectionStrings["strg_bd_esportivo"].ConnectionString;
        public Form_buscar_porAluno()
        {
            InitializeComponent();
        }

        private void btnCarregar_Click(object sender, EventArgs e)
        {
            if (cbModalidade.Text == "Basquete")
            {
                try
                {
                    MySqlConnection con = new MySqlConnection(conexao);

                    con.Open();
                    string sql = "select tb_alunos_nome as 'NOME', tb_alunos_email as 'EMAIL', tb_alunos_telefone as 'TELEFONE', tb_alunos_celular as 'CELULAR' from tb_alunos where " + cbModalidade.Text + "_fk like 1";
                    MySqlCommand executacmdsql = new MySqlCommand(sql, con);
                    executacmdsql.ExecuteNonQuery();

                    DataTable tabela_turma = new DataTable();
                    MySqlDataAdapter da = new MySqlDataAdapter(executacmdsql);
                    da.Fill(tabela_turma);
                    dgAlunos.DataSource = tabela_turma;
                    con.Close();


                }
                catch (Exception erro)

                {
                    MessageBox.Show("Aconteceu um erro" + erro);
                }
            }
            else if (cbModalidade.Text == "Futsal")
            {
                try
                {
                    MySqlConnection con = new MySqlConnection(conexao);

                    con.Open();
                    string sql = "select tb_alunos_nome as 'NOME', tb_alunos_email as 'EMAIL', tb_alunos_telefone as 'TELEFONE', tb_alunos_celular as 'CELULAR' from tb_alunos where " + cbModalidade.Text + "_fk like 2";
                    MySqlCommand executacmdsql = new MySqlCommand(sql, con);
                    executacmdsql.ExecuteNonQuery();

                    DataTable tabela_turma = new DataTable();
                    MySqlDataAdapter da = new MySqlDataAdapter(executacmdsql);
                    da.Fill(tabela_turma);
                    dgAlunos.DataSource = tabela_turma;
                    con.Close();


                }
                catch (Exception erro)

                {
                    MessageBox.Show("Aconteceu um erro" + erro);
                }
            }
            else if (cbModalidade.Text == "Volei")
            {
                try
                {
                    MySqlConnection con = new MySqlConnection(conexao);

                    con.Open();
                    string sql = "select tb_alunos_nome as 'NOME', tb_alunos_email as 'EMAIL', tb_alunos_telefone as 'TELEFONE', tb_alunos_celular as 'CELULAR' from tb_alunos where " + cbModalidade.Text + "_fk like 3";
                    MySqlCommand executacmdsql = new MySqlCommand(sql, con);
                    executacmdsql.ExecuteNonQuery();

                    DataTable tabela_turma = new DataTable();
                    MySqlDataAdapter da = new MySqlDataAdapter(executacmdsql);
                    da.Fill(tabela_turma);
                    dgAlunos.DataSource = tabela_turma;
                    con.Close();


                }
                catch (Exception erro)

                {
                    MessageBox.Show("Aconteceu um erro" + erro);
                }
            }
            if (cbModalidade.Text == "Handebol")
            {
                try
                {
                    MySqlConnection con = new MySqlConnection(conexao);

                    con.Open();
                    string sql = "select tb_alunos_nome as 'NOME', tb_alunos_email as 'EMAIL', tb_alunos_telefone as 'TELEFONE', tb_alunos_celular as 'CELULAR' from tb_alunos where " + cbModalidade.Text + "_fk like 4";
                    MySqlCommand executacmdsql = new MySqlCommand(sql, con);
                    executacmdsql.ExecuteNonQuery();

                    DataTable tabela_turma = new DataTable();
                    MySqlDataAdapter da = new MySqlDataAdapter(executacmdsql);
                    da.Fill(tabela_turma);
                    dgAlunos.DataSource = tabela_turma;
                    con.Close();


                }
                catch (Exception erro)

                {
                    MessageBox.Show("Aconteceu um erro" + erro);
                }
            }
            if (cbModalidade.Text == "Natação")
            {
                try
                {
                    MySqlConnection con = new MySqlConnection(conexao);

                    con.Open();
                    string sql = "select tb_alunos_nome as 'NOME', tb_alunos_email as 'EMAIL', tb_alunos_telefone as 'TELEFONE', tb_alunos_celular as 'CELULAR' from tb_alunos where " + cbModalidade.Text + "_fk like 5";
                    MySqlCommand executacmdsql = new MySqlCommand(sql, con);
                    executacmdsql.ExecuteNonQuery();

                    DataTable tabela_turma = new DataTable();
                    MySqlDataAdapter da = new MySqlDataAdapter(executacmdsql);
                    da.Fill(tabela_turma);
                    dgAlunos.DataSource = tabela_turma;
                    con.Close();


                }
                catch (Exception erro)

                {
                    MessageBox.Show("Aconteceu um erro" + erro);
                }
            }

        }

        private void iconFechar_Click(object sender, EventArgs e)
        {
            this.Close();
            pbXAln.Dispose();
        }

        private void iconMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
    }
}
