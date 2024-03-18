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
    public partial class DCAluno : Form
    {
        string conexao = ConfigurationManager.ConnectionStrings["strg_bd_esportivo"].ConnectionString;

        public DCAluno()
        {
            InitializeComponent();
        }

        private void DCAluno_Load(object sender, EventArgs e)
        {
            MySqlConnection con = new MySqlConnection(conexao);

            con.Open();
            string sql = "select tb_alunos_id, tb_alunos_nome, tb_alunos_email, tb_alunos_telefone,tb_alunos_celular, tb_alunos_complemento, tb_alunos_endereco, tb_alunos_sexo from tb_alunos";
            MySqlCommand executacmdsql = new MySqlCommand(sql, con);
            executacmdsql.ExecuteNonQuery();

            DataTable tabela_turma = new DataTable();
            MySqlDataAdapter da = new MySqlDataAdapter(executacmdsql);  
            da.Fill(tabela_turma);
            dgAlunos.DataSource = tabela_turma;
            con.Close();

        }

        private void dgAlunos_Click(object sender, EventArgs e)
        {
            
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (cbModalidade.Text == "Basquete")
            {
                try
                {
                    MySqlConnection con = new MySqlConnection(conexao);

                    con.Open();
                    string sql = "select tb_alunos_nome as 'NOME', tb_alunos_email as 'EMAIL', tb_alunos_telefone as 'TELEFONE', tb_alunos_celular as 'CELULAR' from tb_alunos where "+ cbModalidade.Text + "_fk like 1 and tb_alunos_nome like '"+txtNomeAlu.Text+ "%'";
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
                    string sql = "select tb_alunos_nome as 'NOME', tb_alunos_email as 'EMAIL', tb_alunos_telefone as 'TELEFONE', tb_alunos_celular as 'CELULAR' from tb_alunos where " + cbModalidade.Text + "_fk like 1 and tb_alunos_nome like '" + txtNomeAlu.Text + "%'";
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
                    string sql = "select tb_alunos_nome as 'NOME', tb_alunos_email as 'EMAIL', tb_alunos_telefone as 'TELEFONE', tb_alunos_celular as 'CELULAR' from tb_alunos where " + cbModalidade.Text + "_fk like 1 and tb_alunos_nome like '" + txtNomeAlu.Text + "%'";
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
                    string sql = "select tb_alunos_nome as 'NOME', tb_alunos_email as 'EMAIL', tb_alunos_telefone as 'TELEFONE', tb_alunos_celular as 'CELULAR' from tb_alunos where " + cbModalidade.Text + "_fk like 1 and tb_alunos_nome like '" + txtNomeAlu.Text + "%'";
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
                    string sql = "select tb_alunos_nome as 'NOME', tb_alunos_email as 'EMAIL', tb_alunos_telefone as 'TELEFONE', tb_alunos_celular as 'CELULAR' from tb_alunos where " + cbModalidade.Text + "_fk like 1 and tb_alunos_nome like '" + txtNomeAlu.Text + "%'";
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

        private void dgAlunos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_Enter(object sender, EventArgs e)
        {
            if (txtNomeAlu.Text == "Nome do Aluno*:")
            {

                txtNomeAlu.Text = "";
                txtNomeAlu.ForeColor = Color.Silver;
            }
        }

        private void textBox1_Leave(object sender, EventArgs e)
        {
            if (txtNomeAlu.Text == "")
            {

                txtNomeAlu.Text = "Nome do Aluno*:";
                txtNomeAlu.ForeColor = Color.Silver;
            }
        }

        private void dgAlunos_DoubleClick(object sender, EventArgs e)
        {
            PerfilAluno nov = new PerfilAluno();
            nov.txtId.Text = this.dgAlunos.CurrentRow.Cells[0].Value.ToString();
            nov.txtNome.Text = this.dgAlunos.CurrentRow.Cells[1].Value.ToString();
            nov.txtEmail.Text = this.dgAlunos.CurrentRow.Cells[2].Value.ToString();
            nov.txtTel.Text = this.dgAlunos.CurrentRow.Cells[3].Value.ToString();
            nov.txtCelAlu.Text = this.dgAlunos.CurrentRow.Cells[4].Value.ToString();
            nov.txtComplemento.Text = this.dgAlunos.CurrentRow.Cells[5].Value.ToString();
            nov.txtEndereco.Text = this.dgAlunos.CurrentRow.Cells[6].Value.ToString();
            nov.cbSexo.Text = this.dgAlunos.CurrentRow.Cells[7].Value.ToString();

            nov.Show();
        }
    }
}
