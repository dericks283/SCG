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

namespace Chamadaa.View.ViewDC
{
    public partial class DCProfessor : Form
    {
        string conexao = ConfigurationManager.ConnectionStrings["strg_bd_esportivo"].ConnectionString;
        public DCProfessor()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (cbModalidade.Text == "Basquete")
            {
                try
                {
                    MySqlConnection con = new MySqlConnection(conexao);

                    con.Open();
                    string sql = "select tb_professor_nome as 'NOME', tb_professor_email as 'EMAIL', tb_professor_telefone as 'TELEFONE' from tb_professor where " + cbModalidade.Text + "_fk like 1 and tb_professor_nome like '" + txtNomeProf.Text + "%'";
                    MySqlCommand executacmdsql = new MySqlCommand(sql, con);
                    executacmdsql.ExecuteNonQuery();

                    DataTable tabela_turma = new DataTable();
                    MySqlDataAdapter da = new MySqlDataAdapter(executacmdsql);
                    da.Fill(tabela_turma);
                    dgProfessor.DataSource = tabela_turma;
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
                    string sql = "select tb_alunos_nome as 'NOME', tb_alunos_email as 'EMAIL', tb_alunos_telefone as 'TELEFONE', tb_alunos_celular as 'CELULAR' from tb_alunos where " + cbModalidade.Text + "_fk like 1 and tb_professor_nome like '" + txtNomeProf.Text + "%'";
                    MySqlCommand executacmdsql = new MySqlCommand(sql, con);
                    executacmdsql.ExecuteNonQuery();

                    DataTable tabela_turma = new DataTable();
                    MySqlDataAdapter da = new MySqlDataAdapter(executacmdsql);
                    da.Fill(tabela_turma);
                    dgProfessor.DataSource = tabela_turma;
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
                    string sql = "select tb_alunos_nome as 'NOME', tb_alunos_email as 'EMAIL', tb_alunos_telefone as 'TELEFONE', tb_alunos_celular as 'CELULAR' from tb_alunos where " + cbModalidade.Text + "_fk like 1 and tb_professor_nome like '" + txtNomeProf.Text + "%'";
                    MySqlCommand executacmdsql = new MySqlCommand(sql, con);
                    executacmdsql.ExecuteNonQuery();

                    DataTable tabela_turma = new DataTable();
                    MySqlDataAdapter da = new MySqlDataAdapter(executacmdsql);
                    da.Fill(tabela_turma);
                    dgProfessor.DataSource = tabela_turma;
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
                    string sql = "select tb_alunos_nome as 'NOME', tb_alunos_email as 'EMAIL', tb_alunos_telefone as 'TELEFONE', tb_alunos_celular as 'CELULAR' from tb_alunos where " + cbModalidade.Text + "_fk like 1 and tb_professor_nome like '" + txtNomeProf.Text + "%'";
                    MySqlCommand executacmdsql = new MySqlCommand(sql, con);
                    executacmdsql.ExecuteNonQuery();

                    DataTable tabela_turma = new DataTable();
                    MySqlDataAdapter da = new MySqlDataAdapter(executacmdsql);
                    da.Fill(tabela_turma);
                    dgProfessor.DataSource = tabela_turma;
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
                    string sql = "select tb_alunos_nome as 'NOME', tb_alunos_email as 'EMAIL', tb_alunos_telefone as 'TELEFONE', tb_alunos_celular as 'CELULAR' from tb_alunos where " + cbModalidade.Text + "_fk like 1 and tb_professor_nome like '" + txtNomeProf.Text + "%'";
                    MySqlCommand executacmdsql = new MySqlCommand(sql, con);
                    executacmdsql.ExecuteNonQuery();

                    DataTable tabela_turma = new DataTable();
                    MySqlDataAdapter da = new MySqlDataAdapter(executacmdsql);
                    da.Fill(tabela_turma);
                    dgProfessor.DataSource = tabela_turma;
                    con.Close();


                }
                catch (Exception erro)

                {
                    MessageBox.Show("Aconteceu um erro" + erro);
                }
            }
        }

        private void dgAlunos_Click(object sender, EventArgs e)
        {
            
        }

        private void DCProfessor_Load(object sender, EventArgs e)
        {
            MySqlConnection con = new MySqlConnection(conexao);

            con.Open();
            string sql = "select tb_professor_id, tb_professor_nome, tb_professor_email, tb_professor_telefone from tb_professor";
            MySqlCommand executacmdsql = new MySqlCommand(sql, con);
            executacmdsql.ExecuteNonQuery();

            DataTable tabela_turma = new DataTable();
            MySqlDataAdapter da = new MySqlDataAdapter(executacmdsql);
            da.Fill(tabela_turma);
            dgProfessor.DataSource = tabela_turma;
            con.Close();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void textBox1_Enter(object sender, EventArgs e)
        {
            if (txtNomeProf.Text == "Nome do Professor*:")
            {

                txtNomeProf.Text = "";
                txtNomeProf.ForeColor = Color.Silver;
            }
        }

        private void textBox1_Leave(object sender, EventArgs e)
        {
            if (txtNomeProf.Text == "")
            {

                txtNomeProf.Text = "Nome do Professor*:";
                txtNomeProf.ForeColor = Color.Silver;
            }
        }

        private void dgProfessor_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgProfessor_DoubleClick(object sender, EventArgs e)
        {

            PerfilProf nov = new PerfilProf();
            nov.txtId.Text = this.dgProfessor.CurrentRow.Cells[0].Value.ToString();
            nov.txtNome.Text = this.dgProfessor.CurrentRow.Cells[1].Value.ToString();
            nov.txtEmail.Text = this.dgProfessor.CurrentRow.Cells[2].Value.ToString();
            nov.txtTel.Text = this.dgProfessor.CurrentRow.Cells[3].Value.ToString();
            nov.Show();
        }
    }
}
