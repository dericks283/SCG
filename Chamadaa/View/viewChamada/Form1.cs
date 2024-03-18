using Chamadaa.DAO;
using Chamadaa.Model;
using Chamadaa.View.viewChamada;
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

namespace Chamadaa
{

    public partial class Form1 : Form
    {
        string conexao = ConfigurationManager.ConnectionStrings["strg_bd_esportivo"].ConnectionString;

        public string modalidades;
        public string turmas;

        public Form1()
        {
            InitializeComponent();
        }

        private void txtHorario_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnNovCha_Click(object sender, EventArgs e)
        {

            try
            {
                MySqlConnection con = new MySqlConnection(conexao);

                con.Open();
                string sql = "alter table tb_alunos add tb_" + lblModalidade.Text + "_" + txtNovCha.Text + " varchar(8)";

                string sql2=    "select  tb_alunos_id as 'ID', tb_alunos_nome as 'Aluno',tb_" + lblModalidade.Text + "_turma as 'Turma', tb_" + lblModalidade.Text + "_horario as 'Horario', tb_professor_nome as 'Professor', tb_" + lblModalidade.Text + "_" + txtNovCha.Text + " as 'Chamada' " +
                    "from tb_alunos inner join tb_" + lblModalidade.Text + " on " +
                    "tb_alunos." + lblModalidade.Text + "_fk = tb_" + lblModalidade.Text + ".tb_" + lblModalidade.Text + "_id " +
                    "inner join tb_professor on " +
                    "tb_alunos.professor_fk = tb_professor.tb_professor_id " +
                    "where tb_" + lblModalidade.Text + "_turma = '" + txtTurma.Text + "'" +
                    " group by tb_alunos_nome";


                MySqlCommand executacmdsql = new MySqlCommand(sql,  con);
                executacmdsql.ExecuteNonQuery();


                MySqlCommand executacmdsql2 = new MySqlCommand(sql2, con);
                executacmdsql2.ExecuteNonQuery();
                DataTable tabelaAluno = new DataTable();
                MySqlDataAdapter da = new MySqlDataAdapter(executacmdsql2);
                da.Fill(tabelaAluno);
                dgAlunos.DataSource = tabelaAluno;

                btnAllPre.Enabled = true;
                btnAllAu.Enabled = true;
                btnPresente.Enabled = true;
                btnFalta.Enabled = true;

                MessageBox.Show("Nova Chamada criada com sucesso!");
                con.Close();
            }
            catch (Exception erro)

            {
                MessageBox.Show("Aconteceu um erro" + erro);
            }


        }

        private void Form1_Load(object sender, EventArgs e)
        {
            btnAllPre.Enabled = false;
            btnAllAu.Enabled = false;
            btnPresente.Enabled = false;
            btnFalta.Enabled = false;

            if(modalidades != "")
            {
                lblModalidade.Text = modalidades;
            }
            if(turmas != "")
            {
                txtTurma.Text = turmas;
            }


            try
            {
                MySqlConnection con = new MySqlConnection(conexao);
                con.Open();
                string turma = txtTurma.Text;
         
                string sql = @"select  tb_alunos_id as 'ID', tb_alunos_nome as 'Aluno',tb_" + lblModalidade.Text + "_turma as 'Turma', tb_" + lblModalidade.Text + "_horario as 'Horario', tb_professor_nome as 'Professor' " +
                              "from tb_alunos inner join tb_" + lblModalidade.Text + " on " +
                              "tb_alunos." + lblModalidade.Text + "_fk = tb_" + lblModalidade.Text + ".tb_" + lblModalidade.Text + "_id " +
                              "inner join tb_professor on " +
                              "tb_alunos.professor_fk = tb_professor.tb_professor_id " +
                              "where tb_" + lblModalidade.Text + "_turma = '"+txtTurma.Text+"'"+
                              " group by tb_alunos_nome";


                MySqlCommand executacmdsql = new MySqlCommand(sql, con);
                executacmdsql.Parameters.AddWithValue("@turma", turma);


                executacmdsql.ExecuteNonQuery();
                DataTable tabelaAluno = new DataTable();
                MySqlDataAdapter da = new MySqlDataAdapter(executacmdsql);
                da.Fill(tabelaAluno);
                dgAlunos.DataSource = tabelaAluno;
                
                con.Close();
                
            }catch(Exception erro)
            {
                MessageBox.Show("Erro " + erro);
            }

        }

        private void Form1_Activated(object sender, EventArgs e)
        {
            /*Chamada dao = new Chamada();

            dgAlunos.DataSource = dao.ListarNovaChamada();*/
        }
        
        private void dgAlunos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgAlunos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtId.Text = dgAlunos.CurrentRow.Cells[0].Value.ToString();
            txtNome.Text = dgAlunos.CurrentRow.Cells[1].Value.ToString();
           // txtIdade.Text = dgAlunos.CurrentRow.Cells[2].Value.ToString();
            
            txtTurma.Text = dgAlunos.CurrentRow.Cells[2].Value.ToString();
            txtHorario.Text = dgAlunos.CurrentRow.Cells[3].Value.ToString();
            txtProfessor.Text = dgAlunos.CurrentRow.Cells[4].Value.ToString();
            


        }

        private void btnPresente_Click(object sender, EventArgs e)
        {
            try
            {
                MySqlConnection con = new MySqlConnection(conexao);
                con.Open();
                string sql = "update tb_alunos set tb_"+lblModalidade.Text+"_"+txtNovCha.Text+" = 'Presente' where tb_alunos_id = "+txtId.Text+"";
                MySqlCommand executacmdsql = new MySqlCommand(sql, con);
                executacmdsql.ExecuteNonQuery();


                string sql2 = "select  tb_alunos_id as 'ID', tb_alunos_nome as 'Aluno',tb_" + lblModalidade.Text + "_turma as 'Turma', tb_" + lblModalidade.Text + "_horario as 'Horario', tb_professor_nome as 'Professor', tb_" + lblModalidade.Text + "_" + txtNovCha.Text + " as 'Chamada' " +
                    "from tb_alunos inner join tb_" + lblModalidade.Text + " on " +
                    "tb_alunos." + lblModalidade.Text + "_fk = tb_" + lblModalidade.Text + ".tb_" + lblModalidade.Text + "_id " +
                    "inner join tb_professor on " +
                    "tb_alunos.professor_fk = tb_professor.tb_professor_id " +
                    "where tb_" + lblModalidade.Text + "_turma = '" + txtTurma.Text + "'" +
                    " group by tb_alunos_nome";

                MySqlCommand executacmdsql2 = new MySqlCommand(sql2, con);
                executacmdsql2.ExecuteNonQuery();
                DataTable tabelaAluno = new DataTable();
                MySqlDataAdapter da = new MySqlDataAdapter(executacmdsql2);
                da.Fill(tabelaAluno);
                dgAlunos.DataSource = tabelaAluno;

                con.Close();

                MessageBox.Show("Este Aluno esteve Presente na aula");
                

            }
            catch (Exception erro)

            {
                MessageBox.Show("Aconteceu um erro" + erro);
            }
        }

        private void btnFalta_Click(object sender, EventArgs e)
        {
            try
            {
                MySqlConnection con = new MySqlConnection(conexao);
                con.Open();
                string sql = "update tb_alunos set tb_basquete_" + txtNovCha.Text + " = 'Ausente' where tb_alunos_id = " + txtId.Text + "";
                MySqlCommand executacmdsql = new MySqlCommand(sql, con);
                executacmdsql.ExecuteNonQuery();

                string sql2 = "select  tb_alunos_id as 'ID', tb_alunos_nome as 'Aluno',tb_" + lblModalidade.Text + "_turma as 'Turma', tb_" + lblModalidade.Text + "_horario as 'Horario', tb_professor_nome as 'Professor', tb_" + lblModalidade.Text + "_" + txtNovCha.Text + " as 'Chamada' " +
                    "from tb_alunos inner join tb_" + lblModalidade.Text + " on " +
                    "tb_alunos." + lblModalidade.Text + "_fk = tb_" + lblModalidade.Text + ".tb_" + lblModalidade.Text + "_id " +
                    "inner join tb_professor on " +
                    "tb_alunos.professor_fk = tb_professor.tb_professor_id " +
                    "where tb_" + lblModalidade.Text + "_turma = '" + txtTurma.Text + "'" +
                    " group by tb_alunos_nome";

                MySqlCommand executacmdsql2 = new MySqlCommand(sql2, con);
                executacmdsql2.ExecuteNonQuery();
                DataTable tabelaAluno = new DataTable();
                MySqlDataAdapter da = new MySqlDataAdapter(executacmdsql2);
                da.Fill(tabelaAluno);
                dgAlunos.DataSource = tabelaAluno;

                con.Close();

                MessageBox.Show("Este Aluno esteve Ausente!");


            }
            catch (Exception erro)

            {
                MessageBox.Show("Aconteceu um erro" + erro);
            }
        }

        private void btnChamada_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show( "Deseja Realmente Sair desta Janela?", "Aviso!",MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                this.Close();
            }
            else
            {

            }
        }

        private void btnAllPre_Click(object sender, EventArgs e)
        {
            try
            {
                MySqlConnection con = new MySqlConnection(conexao);
                con.Open();
                string sql = "update tb_alunos set tb_" + lblModalidade.Text + "_" + txtNovCha.Text + " = 'Presente'";
                MySqlCommand executacmdsql = new MySqlCommand(sql, con);
                executacmdsql.ExecuteNonQuery();


                string sql2 = "select  tb_alunos_id as 'ID', tb_alunos_nome as 'Aluno',tb_" + lblModalidade.Text + "_turma as 'Turma', tb_" + lblModalidade.Text + "_horario as 'Horario', tb_professor_nome as 'Professor', tb_" + lblModalidade.Text + "_" + txtNovCha.Text + " as 'Chamada' " +
                    "from tb_alunos inner join tb_" + lblModalidade.Text + " on " +
                    "tb_alunos." + lblModalidade.Text + "_fk = tb_" + lblModalidade.Text + ".tb_" + lblModalidade.Text + "_id " +
                    "inner join tb_professor on " +
                    "tb_alunos.professor_fk = tb_professor.tb_professor_id " +
                    "where tb_" + lblModalidade.Text + "_turma = '" + txtTurma.Text + "'" +
                    " group by tb_alunos_nome";

                MySqlCommand executacmdsql2 = new MySqlCommand(sql2, con);
                executacmdsql2.ExecuteNonQuery();
                DataTable tabelaAluno = new DataTable();
                MySqlDataAdapter da = new MySqlDataAdapter(executacmdsql2);
                da.Fill(tabelaAluno);
                dgAlunos.DataSource = tabelaAluno;

                con.Close();

                MessageBox.Show("Todos os alunos foram marcados como 'Presentes'!");


            }
            catch (Exception erro)

            {
                MessageBox.Show("Aconteceu um erro" + erro);
            }
        }

        private void btnAllAu_Click(object sender, EventArgs e)
        {
            try
            {
            
                    MySqlConnection con = new MySqlConnection(conexao);
                    con.Open();
                    string sql = "update tb_alunos set tb_" + lblModalidade.Text + "_" + txtNovCha.Text + " = 'Ausente'";
                    MySqlCommand executacmdsql = new MySqlCommand(sql, con);
                    executacmdsql.ExecuteNonQuery();


                    string sql2 = "select  tb_alunos_id as 'ID', tb_alunos_nome as 'Aluno',tb_" + lblModalidade.Text + "_turma as 'Turma', tb_" + lblModalidade.Text + "_horario as 'Horario', tb_professor_nome as 'Professor', tb_" + lblModalidade.Text + "_" + txtNovCha.Text + " as 'Chamada' " +
                        "from tb_alunos inner join tb_" + lblModalidade.Text + " on " +
                        "tb_alunos." + lblModalidade.Text + "_fk = tb_" + lblModalidade.Text + ".tb_" + lblModalidade.Text + "_id " +
                        "inner join tb_professor on " +
                        "tb_alunos.professor_fk = tb_professor.tb_professor_id " +
                        "where tb_" + lblModalidade.Text + "_turma = '" + txtTurma.Text + "'" +
                        " group by tb_alunos_nome";

                    MySqlCommand executacmdsql2 = new MySqlCommand(sql2, con);
                    executacmdsql2.ExecuteNonQuery();
                    DataTable tabelaAluno = new DataTable();
                    MySqlDataAdapter da = new MySqlDataAdapter(executacmdsql2);
                    da.Fill(tabelaAluno);
                    dgAlunos.DataSource = tabelaAluno;

                    con.Close();

                    MessageBox.Show("Todos os alunos foram marcados como 'Ausentes'!");
                


            }
            catch (Exception erro)

            {
                MessageBox.Show("Aconteceu um erro" + erro);
            }
        }
    }
}
