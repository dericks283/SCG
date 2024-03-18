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

namespace Chamadaa.View.viewChamada
{
    public partial class ChamadaAnt : Form
    {
        string conexao = ConfigurationManager.ConnectionStrings["strg_bd_esportivo"].ConnectionString;
        

        public ChamadaAnt()
        {
            InitializeComponent();
        }

        private void ChamadaAnt_Load(object sender, EventArgs e)
        {
            btnEdit.Enabled = false;
            btnExclu.Enabled = false;
        }

        private void btnConsulta_Click(object sender, EventArgs e)
        {
            try
            {
                MySqlConnection con = new MySqlConnection(conexao);

                con.Open();
                string sql = "select tb_" + cbModa.Text + "_turma as '" + cbModa.Text + "' from tb_" + cbModa.Text + "";
                MySqlCommand executacmdsql = new MySqlCommand(sql, con);
                executacmdsql.ExecuteNonQuery();

                DataTable tabela_turma = new DataTable();
                MySqlDataAdapter da = new MySqlDataAdapter(executacmdsql);
                da.Fill(tabela_turma);
                dgvCham.DataSource = tabela_turma;
                con.Close();




            }
            catch (Exception erro)

            {
                MessageBox.Show("Aconteceu um erro" + erro);
            }
        }

        private void btnPesqui_Click(object sender, EventArgs e)
        {
            try
            {
                MySqlConnection con = new MySqlConnection(conexao);
                con.Open();
                string sql = "select  tb_alunos_id as 'ID', tb_alunos_nome as 'Aluno',tb_" + cbModa.Text + "_turma as 'Turma', tb_" + cbModa.Text + "_horario as 'Horario', tb_professor_nome as 'Professor', tb_" + cbModa.Text + "_" + txtData.Text + " as 'Chamada' " +
                    "from tb_alunos inner join tb_" + cbModa.Text + " on " +
                    "tb_alunos." + cbModa.Text + "_fk = tb_" + cbModa.Text + ".tb_" + cbModa.Text + "_id " +
                    "inner join tb_professor on " +
                    "tb_alunos.professor_fk = tb_professor.tb_professor_id " +
                    "where tb_" + cbModa.Text + "_turma = '" + txtTurma.Text + "'" +
                    " group by tb_alunos_nome";


                MySqlCommand executacmdsql = new MySqlCommand(sql, con);
                executacmdsql.ExecuteNonQuery();

                DataTable tabelaAluno = new DataTable();
                MySqlDataAdapter da = new MySqlDataAdapter(executacmdsql);
                da.Fill(tabelaAluno);
                dgvCham.DataSource = tabelaAluno;

                btnEdit.Enabled = true;
                btnExclu.Enabled = true;
            }
            catch(Exception erro)
            {
                MessageBox.Show("Algo deu Errado " + erro);
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            this.Hide();
            EditCha novo = new EditCha();
            novo.modalidades = cbModa.Text;
            novo.turmas = txtTurma.Text;
            novo.dia = txtData.Text;
            novo.Closed += (s, args) => this.Close();
            novo.Show();
        }

        private void btnExclu_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja Realmente Excluir esta chamada?", "Aviso!", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {

                MySqlConnection con = new MySqlConnection(conexao);
                con.Open();
                string sql = "alter table tb_alunos drop column tb_" + cbModa.Text + "_" + txtData.Text + "";

                string sql2 = "select  tb_alunos_id as 'ID', tb_alunos_nome as 'Aluno',tb_" + cbModa.Text + "_turma as 'Turma', tb_" + cbModa.Text + "_horario as 'Horario', tb_professor_nome as 'Professor'" +
                    "from tb_alunos inner join tb_" + cbModa.Text + " on " +
                    "tb_alunos." + cbModa.Text + "_fk = tb_" + cbModa.Text + ".tb_" + cbModa.Text + "_id " +
                    "inner join tb_professor on " +
                    "tb_alunos.professor_fk = tb_professor.tb_professor_id " +
                    "where tb_" + cbModa.Text + "_turma = '" + txtTurma.Text + "'" +
                    " group by tb_alunos_nome";

                MySqlCommand executacmdsql = new MySqlCommand(sql, con);
                executacmdsql.ExecuteNonQuery();

                MySqlCommand executacmdsql2 = new MySqlCommand(sql2, con);
                executacmdsql2.ExecuteNonQuery();

                DataTable tabelaAluno = new DataTable();
                MySqlDataAdapter da = new MySqlDataAdapter(executacmdsql2);
                da.Fill(tabelaAluno);
                dgvCham.DataSource = tabelaAluno;
                MessageBox.Show("A chamada do dia " + txtData.Text + " Foi excluida");
            }

        }

        private void txtData_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Verificar se foi digitado algum caracter
            if (char.IsNumber(e.KeyChar) == true)
            {
                switch (txtData.TextLength/*(tamanho do texto)*/)
                {
                    case 2:
                        txtData.Text = txtData.Text + "_";
                        //Jogar o cursor pra 4 posição
                        txtData.SelectionStart = 3;

                        break;
                    case 5:
                        txtData.Text = txtData.Text + "_";
                        //Jogar o cursor pra 4 posição
                        txtData.SelectionStart = 6;
                        break;

                }
            }
        }
    }
}
