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

    public partial class CadAlu : Form
    {
        string conexao = ConfigurationManager.ConnectionStrings["strg_bd_esportivo"].ConnectionString;
       
        public CadAlu()
        {
            InitializeComponent();
        }

        private void CadModaAlu_Load(object sender, EventArgs e)
        {
            MySqlConnection conexa = new MySqlConnection(conexao);
            conexa.Open();

            string sql_select_aln = @"select * from tb_professor";

            MySqlCommand executacmdMySql_select_aln = new MySqlCommand(sql_select_aln, conexa);

            executacmdMySql_select_aln.ExecuteNonQuery();

            DataTable tabela_aln = new DataTable();

            MySqlDataAdapter tbl_aln = new MySqlDataAdapter(executacmdMySql_select_aln);
            tbl_aln.Fill(tabela_aln);

            cbProfessorAlu.DataSource = tabela_aln;

            cbProfessorAlu.DisplayMember = "tb_professor_nome";
            cbProfessorAlu.ValueMember = "tb_professor_id";
            conexa.Close();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            try
            {
                MySqlConnection con = new MySqlConnection(conexao);
                string sql_insert_tb_aln = @"insert into tb_alunos
                                            (
                                                tb_alunos_nome,
                                                tb_alunos_email,
                                                tb_alunos_sexo,
                                                tb_alunos_telefone,
                                                tb_alunos_celular,
                                                tb_alunos_endereco,
                                                tb_alunos_complemento,
                                                "+cbModalidadeAlu.Text+"_fk," +
                                                "professor_fk)" +
                                            "values" +
                                           " ("+
                                                "'"+txtNomeAlu.Text+"',"+
                                                "'"+txtEmailAlu.Text+"'," +
                                                "'"+cbSexo.Text+"',"+
                                                "'"+txtTelAlu.Text+"',"+
                                                "'"+ txtCelularAlu.Text + "'," +
                                               "'" +txtEndereco.Text+"',"+
                                                "'"+txtComplemento.Text+"',"+
                                                "'"+txtId.Text+"',"+
                                                "'"+cbProfessorAlu.SelectedValue +"'"+

                                               ")";

                MySqlCommand exeCmdMysl_insert = new MySqlCommand(sql_insert_tb_aln, con);
                con.Open();
                exeCmdMysl_insert.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Cadastro de aluno bem sucedido!");
                #region pao
                /* if (cbModalidadeAlu.Text == "Basquete")
                {
                    MySqlConnection con = new MySqlConnection(conexao);

                    string nome_Alu = txtNomeAlu.Text;

                    int tel_alu = int.Parse(txtTelAlu.Text);
                    string email_alu = txtEmailAlu.Text;
                    string endereco_alu = txtEndereco.Text;
                    string complemento_alu = txtComplemento.Text;
                    string turma = txtId.Text;
                    string professor = Convert.ToString(cbProfessorAlu.SelectedIndex);
                    string sexo = Convert.ToString(cbSexo.SelectedValue);


                    string sql_insert_tb_aln = @"insert into tb_alunos
                                            (
                                                tb_alunos_nome,
                                                tb_alunos_email,
                                                tb_alunos_sexo,
                                                tb_alunos_telefone,
                                                tb_alunos_endereco,
                                                tb_alunos_complemento,
                                                basquete_fk,
                                                professor_fk
                                            )
                                            values
                                            (
                                                @aluno_nome,
                                                @aluno_email, 
                                                @alunos_sexo,
                                                @aluno_tel,
                                                @aluno_endereco,
                                                @aluno_complemento,
                                                @basquete_fk,
                                                @professor_fk

                                                );";

                    MySqlCommand exeCmdMysl_insert = new MySqlCommand(sql_insert_tb_aln, con);

                    exeCmdMysl_insert.Parameters.AddWithValue("@aluno_nome", nome_Alu);
                    exeCmdMysl_insert.Parameters.AddWithValue("@aluno_email", email_alu);
                    exeCmdMysl_insert.Parameters.AddWithValue("@alunos_sexo", sexo);
                    exeCmdMysl_insert.Parameters.AddWithValue("@aluno_tel", tel_alu);
                    exeCmdMysl_insert.Parameters.AddWithValue("@aluno_endereco", endereco_alu);
                    exeCmdMysl_insert.Parameters.AddWithValue("@aluno_complemento", complemento_alu);
                    exeCmdMysl_insert.Parameters.AddWithValue("@basquete_fk", turma);
                    exeCmdMysl_insert.Parameters.AddWithValue("@professor_fk", professor);

                    con.Open();
                    exeCmdMysl_insert.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("Cadastro de aluno bem sucedido!");

                    txtNomeAlu.Text = "";
                    txtEmailAlu.Text = "";
                    txtTelAlu.Text = "";
                    txtEndereco.Text = "";
                    txtComplemento.Text = "";
                }
                else if(cbModalidadeAlu.Text == "Volei")
                {
                    MySqlConnection con = new MySqlConnection(conexao);

                    string nome_Alu = txtNomeAlu.Text;

                    int tel_alu = int.Parse(txtTelAlu.Text);
                    string email_alu = txtEmailAlu.Text;
                    string endereco_alu = txtEndereco.Text;
                    string complemento_alu = txtComplemento.Text;
                    string turma = txtId.Text;
                    string professor = Convert.ToString(cbProfessorAlu.SelectedIndex);
                    string sexo = Convert.ToString(cbSexo.SelectedValue);


                    string sql_insert_tb_aln = @"insert into tb_alunos
                                            (
                                                tb_alunos_nome,
                                                tb_alunos_email,
                                                tb_alunos_sexo,
                                                tb_alunos_telefone,
                                                tb_alunos_endereco,
                                                tb_alunos_complemento,
                                                volei_fk,
                                                professor_fk
                                            )
                                            values
                                            (
                                                @aluno_nome,
                                                @aluno_email, 
                                                @alunos_sexo,
                                                @aluno_tel,
                                                @aluno_endereco,
                                                @aluno_complemento,
                                                @volei_fk,
                                                @professor_fk

                                                );";

                    MySqlCommand exeCmdMysl_insert = new MySqlCommand(sql_insert_tb_aln, con);

                    exeCmdMysl_insert.Parameters.AddWithValue("@aluno_nome", nome_Alu);
                    exeCmdMysl_insert.Parameters.AddWithValue("@aluno_email", email_alu);
                    exeCmdMysl_insert.Parameters.AddWithValue("@alunos_sexo", sexo);
                    exeCmdMysl_insert.Parameters.AddWithValue("@aluno_tel", tel_alu);
                    exeCmdMysl_insert.Parameters.AddWithValue("@aluno_endereco", endereco_alu);
                    exeCmdMysl_insert.Parameters.AddWithValue("@aluno_complemento", complemento_alu);
                    exeCmdMysl_insert.Parameters.AddWithValue("@volei_fk", turma);
                    exeCmdMysl_insert.Parameters.AddWithValue("@professor_fk", professor);

                    con.Open();
                    exeCmdMysl_insert.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("Cadastro de aluno bem sucedido!");

                    txtNomeAlu.Text = "";
                    txtEmailAlu.Text = "";
                    txtTelAlu.Text = "";
                    txtEndereco.Text = "";
                    txtComplemento.Text = "";
                }
                else if (cbModalidadeAlu.Text == "Futsal")
                {
                    MySqlConnection con = new MySqlConnection(conexao);

                    string nome_Alu = txtNomeAlu.Text;

                    int tel_alu = int.Parse(txtTelAlu.Text);
                    string email_alu = txtEmailAlu.Text;
                    string endereco_alu = txtEndereco.Text;
                    string complemento_alu = txtComplemento.Text;
                    string turma = txtId.Text;
                    string professor = Convert.ToString(cbProfessorAlu.SelectedIndex);
                    string sexo = Convert.ToString(cbSexo.SelectedValue);


                    string sql_insert_tb_aln = @"insert into tb_alunos
                                            (
                                                tb_alunos_nome,
                                                tb_alunos_email,
                                                tb_alunos_sexo,
                                                tb_alunos_telefone,
                                                tb_alunos_endereco,
                                                tb_alunos_complemento,
                                                futsal_fk,
                                                professor_fk
                                            )
                                            values
                                            (
                                                @aluno_nome,
                                                @aluno_email, 
                                                @alunos_sexo,
                                                @aluno_tel,
                                                @aluno_endereco,
                                                @aluno_complemento,
                                                @futsal_fk,
                                                @professor_fk

                                                );";

                    MySqlCommand exeCmdMysl_insert = new MySqlCommand(sql_insert_tb_aln, con);

                    exeCmdMysl_insert.Parameters.AddWithValue("@aluno_nome", nome_Alu);
                    exeCmdMysl_insert.Parameters.AddWithValue("@aluno_email", email_alu);
                    exeCmdMysl_insert.Parameters.AddWithValue("@alunos_sexo", sexo);
                    exeCmdMysl_insert.Parameters.AddWithValue("@aluno_tel", tel_alu);
                    exeCmdMysl_insert.Parameters.AddWithValue("@aluno_endereco", endereco_alu);
                    exeCmdMysl_insert.Parameters.AddWithValue("@aluno_complemento", complemento_alu);
                    exeCmdMysl_insert.Parameters.AddWithValue("@futsal_fk", turma);
                    exeCmdMysl_insert.Parameters.AddWithValue("@professor_fk", professor);

                    con.Open();
                    exeCmdMysl_insert.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("Cadastro de aluno bem sucedido!");

                    txtNomeAlu.Text = "";
                    txtEmailAlu.Text = "";
                    txtTelAlu.Text = "";
                    txtEndereco.Text = "";
                    txtComplemento.Text = "";
                }
                else if (cbModalidadeAlu.Text == "Handebol")
                {
                    MySqlConnection con = new MySqlConnection(conexao);

                    string nome_Alu = txtNomeAlu.Text;

                    int tel_alu = int.Parse(txtTelAlu.Text);
                    string email_alu = txtEmailAlu.Text;
                    string endereco_alu = txtEndereco.Text;
                    string complemento_alu = txtComplemento.Text;
                    string turma = txtId.Text;
                    string professor = Convert.ToString(cbProfessorAlu.SelectedIndex);
                    string sexo = Convert.ToString(cbSexo.SelectedValue);

                    string sql_insert_tb_aln = @"insert into tb_alunos
                                            (
                                                tb_alunos_nome,
                                                tb_alunos_email,
                                                tb_alunos_sexo,
                                                tb_alunos_telefone,
                                                tb_alunos_endereco,
                                                tb_alunos_complemento,
                                                handebol_fk,
                                                professor_fk
                                            )
                                            values
                                            (
                                                @aluno_nome,
                                                @aluno_email, 
                                                @alunos_sexo,
                                                @aluno_tel,
                                                @aluno_endereco,
                                                @aluno_complemento,
                                                @handebol_fk,
                                                @professor_fk

                                                );";

                    MySqlCommand exeCmdMysl_insert = new MySqlCommand(sql_insert_tb_aln, con);

                    exeCmdMysl_insert.Parameters.AddWithValue("@aluno_nome", nome_Alu);
                    exeCmdMysl_insert.Parameters.AddWithValue("@aluno_email", email_alu);
                    exeCmdMysl_insert.Parameters.AddWithValue("@alunos_sexo", sexo);
                    exeCmdMysl_insert.Parameters.AddWithValue("@aluno_tel", tel_alu);
                    exeCmdMysl_insert.Parameters.AddWithValue("@aluno_endereco", endereco_alu);
                    exeCmdMysl_insert.Parameters.AddWithValue("@aluno_complemento", complemento_alu);
                    exeCmdMysl_insert.Parameters.AddWithValue("@handebol_fk", turma);
                    exeCmdMysl_insert.Parameters.AddWithValue("@professor_fk", professor);

                    con.Open();
                    exeCmdMysl_insert.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("Cadastro de aluno bem sucedido!");

                    txtNomeAlu.Text = "";
                    txtEmailAlu.Text = "";
                    txtTelAlu.Text = "";
                    txtEndereco.Text = "";
                    txtComplemento.Text = "";
                }
                else if (cbModalidadeAlu.Text == "Natacao")
                {
                    MySqlConnection con = new MySqlConnection(conexao);

                    string nome_Alu = txtNomeAlu.Text;

                    int tel_alu = int.Parse(txtTelAlu.Text);
                    string email_alu = txtEmailAlu.Text;
                    string endereco_alu = txtEndereco.Text;
                    string complemento_alu = txtComplemento.Text;
                    string turma = txtId.Text;
                    string professor = Convert.ToString(cbProfessorAlu.SelectedIndex);
                    string sexo = Convert.ToString(cbSexo.SelectedValue);

                    string sql_insert_tb_aln = @"insert into tb_alunos
                                            (
                                                tb_alunos_nome,
                                                tb_alunos_email,
                                                tb_alunos_sexo,
                                                tb_alunos_telefone,
                                                tb_alunos_endereco,
                                                tb_alunos_complemento,
                                                natacao_fk,
                                                professor_fk
                                            )
                                            values
                                            (
                                                @aluno_nome,
                                                @aluno_email, 
                                                @alunos_sexo,
                                                @aluno_tel,
                                                @aluno_endereco,
                                                @aluno_complemento,
                                                @natacao_fk,
                                                @professor_fk

                                                );";

                    MySqlCommand exeCmdMysl_insert = new MySqlCommand(sql_insert_tb_aln, con);

                    exeCmdMysl_insert.Parameters.AddWithValue("@aluno_nome", nome_Alu);
                    exeCmdMysl_insert.Parameters.AddWithValue("@aluno_email", email_alu);
                    exeCmdMysl_insert.Parameters.AddWithValue("@alunos_sexo", sexo);
                    exeCmdMysl_insert.Parameters.AddWithValue("@aluno_tel", tel_alu);
                    exeCmdMysl_insert.Parameters.AddWithValue("@aluno_endereco", endereco_alu);
                    exeCmdMysl_insert.Parameters.AddWithValue("@aluno_complemento", complemento_alu);
                    exeCmdMysl_insert.Parameters.AddWithValue("@natacao_fk", turma);
                    exeCmdMysl_insert.Parameters.AddWithValue("@professor_fk", professor);

                    con.Open();
                    exeCmdMysl_insert.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("Cadastro de aluno bem sucedido!");*/
                #endregion

                txtNomeAlu.Text = "Nome*";
                txtEmailAlu.Text = "Email*";
                txtTelAlu.Text = "Telefone";
                txtCelularAlu.Text = "Celular*";
                txtEndereco.Text = "Endereço*";
                txtComplemento.Text = "Complemento";
                cbProfessorAlu.Text = "Professor";
                cbModalidadeAlu.Text = "Modalidade";
                cbSexo.Text = "Sexo*";

                btnReset.Enabled = true;
            }

            catch (Exception ERRO)
            {

                MessageBox.Show("Valores não cadastrados por conterem alterações" + ERRO);
            }
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                MySqlConnection con = new MySqlConnection(conexao);
                con.Open();

                string sql_select_modalidade = @"select tb_" + cbModalidadeAlu.Text + "_id,tb_" + cbModalidadeAlu.Text + "_turma, tb_" + cbModalidadeAlu.Text + "_horario from tb_" + cbModalidadeAlu.Text + "";

                MySqlCommand executacmdMySql_select_modalidade = new MySqlCommand(sql_select_modalidade, con);

                executacmdMySql_select_modalidade.ExecuteNonQuery();

                DataTable tbl_modalidade = new DataTable();

                MySqlDataAdapter da_mod = new MySqlDataAdapter(executacmdMySql_select_modalidade);

                da_mod.Fill(tbl_modalidade);
                dgvModalidades.DataSource = tbl_modalidade;
                con.Close();
                btnCadastrar.Enabled = true;
            }
            catch (Exception) { MessageBox.Show("Seleção incorreta.");}
        }

        private void dgvModalidades_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtId.Text = dgvModalidades.CurrentRow.Cells[0].Value.ToString();
            txtTurma.Text = dgvModalidades.CurrentRow.Cells[1].Value.ToString();
            
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtNomeAlu_Enter(object sender, EventArgs e)
        {
            if (txtNomeAlu.Text == "Nome*")
            {

                txtNomeAlu.Text = "";
                txtNomeAlu.ForeColor = Color.Silver;
            }
        }

        private void txtNomeAlu_Leave(object sender, EventArgs e)
        {
            if (txtNomeAlu.Text == "")
            {

                txtNomeAlu.Text = "Nome*";
                txtNomeAlu.ForeColor = Color.Silver;
            }
        }

        private void txtTelAlu_Enter(object sender, EventArgs e)
        {
            if (txtTelAlu.Text == "Telefone")
            {

                txtTelAlu.Text = "(";
                txtTelAlu.ForeColor = Color.Silver;
            }
           
        }

        private void txtTelAlu_Leave(object sender, EventArgs e)
        {
            if (txtTelAlu.Text == "(")
            {

                txtTelAlu.Text = "Telefone";
                txtTelAlu.ForeColor = Color.Silver;
            }
        }

        private void txtEmailAlu_Enter(object sender, EventArgs e)
        {
            if (txtEmailAlu.Text == "Email*")
            {

                txtEmailAlu.Text = "";
                txtEmailAlu.ForeColor = Color.Silver;
            }
        }

        private void txtEmailAlu_Leave(object sender, EventArgs e)
        {
            if (txtEmailAlu.Text == "")
            {

                txtEmailAlu.Text = "Email*";
                txtEmailAlu.ForeColor = Color.Silver;
            }
        }

        private void txtEndereco_Enter(object sender, EventArgs e)
        {
            if (txtEndereco.Text == "Endereço*")
            {

                txtEndereco.Text = "";
                txtEndereco.ForeColor = Color.Silver;
            }
        }

        private void txtEndereco_Leave(object sender, EventArgs e)
        {
            if (txtEndereco.Text == "")
            {

                txtEndereco.Text = "Endereço*";
                txtEndereco.ForeColor = Color.Silver;
            }
        }

        private void txtComplemento_Enter(object sender, EventArgs e)
        {
            if (txtComplemento.Text == "Complemento")
            {

                txtComplemento.Text = "";
                txtComplemento.ForeColor = Color.Silver;
            }
        }

        private void txtComplemento_Leave(object sender, EventArgs e)
        {
            if (txtComplemento.Text == "")
            {

                txtComplemento.Text = "Complemento";
                txtComplemento.ForeColor = Color.Silver;
            }
        }

        private void cbModalidadeAlu_DropDown(object sender, EventArgs e)
        {
            btnCadastrar.Enabled = false;
        }

        private void txtCelularAlu_Enter(object sender, EventArgs e)
        {
            if (txtCelularAlu.Text == "Celular*")
            {

                txtCelularAlu.Text = "(";
                txtCelularAlu.ForeColor = Color.Silver;
            }
            
        }

        private void txtCelularAlu_Leave(object sender, EventArgs e)
        {
            if (txtCelularAlu.Text == "(")
            {

                txtCelularAlu.Text = "Celular*";
                txtCelularAlu.ForeColor = Color.Silver;
            }
        }

        private void txtTelAlu_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Verificar se foi digitado algum caracter
            if (char.IsNumber(e.KeyChar) == true)
            {
                switch (txtTelAlu.TextLength/*(tamanho do texto)*/)
                {
                    case 0:
                        txtTelAlu.Text = txtTelAlu.Text + "(";
                        //Jogar o cursor pra 4 posição
                        txtTelAlu.SelectionStart = 4;
                        break;
                    case 3:
                        txtTelAlu.Text = txtTelAlu.Text + ")";
                        //Jogar o cursor pra 4 posição
                        txtTelAlu.SelectionStart = 4;

                        break;

                }
            }
        }

        private void txtCelularAlu_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Verificar se foi digitado algum caracter
            if (char.IsNumber(e.KeyChar) == true)
            {
                switch (txtCelularAlu.TextLength/*(tamanho do texto)*/)
                {
                    case 0:
                        txtCelularAlu.Text = txtCelularAlu.Text + "(";
                        //Jogar o cursor pra 4 posição
                        txtCelularAlu.SelectionStart = 4;
                        break;
                    case 3:
                        txtCelularAlu.Text = txtCelularAlu.Text + ")";
                        //Jogar o cursor pra 4 posição
                        txtCelularAlu.SelectionStart = 4;

                        break;

                }
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            MySqlConnection conexa = new MySqlConnection(conexao);
            conexa.Open();

            string sql_select_aln = @"select * from tb_professor";

            MySqlCommand executacmdMySql_select_aln = new MySqlCommand(sql_select_aln, conexa);

            executacmdMySql_select_aln.ExecuteNonQuery();

            DataTable tabela_aln = new DataTable();

            MySqlDataAdapter tbl_aln = new MySqlDataAdapter(executacmdMySql_select_aln);
            tbl_aln.Fill(tabela_aln);

            cbProfessorAlu.DataSource = tabela_aln;

            cbProfessorAlu.DisplayMember = "tb_professor_nome";
            cbProfessorAlu.ValueMember = "tb_professor_id";
            conexa.Close();
        }

        private void iconFechar_Click(object sender, EventArgs e)
        {
            
        }

        private void iconMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
    }
}
