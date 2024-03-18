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
    public partial class DCTurmas : Form
    {
        string conexao = ConfigurationManager.ConnectionStrings["strg_bd_esportivo"].ConnectionString;
        public DCTurmas()
        {
            InitializeComponent();
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (cbModalidades.Text == "Basquete")
            {
                MySqlConnection con = new MySqlConnection(conexao);
                string sql_delete = @"delete from tb_basquete where tb_basquete_id='" + txtIdTurmas.Text + "'";

                MySqlCommand exeCmdMysl_delete = new MySqlCommand(sql_delete, con);

                con.Open();
                exeCmdMysl_delete.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Atualização efetuada!");
                MySqlConnection cone = new MySqlConnection(conexao);
                cone.Open();
            }
            else if (cbModalidades.Text == "Volei")
            {
                MySqlConnection con = new MySqlConnection(conexao);
                string sql_delete = @"delete from tb_volei where tb_volei_id='" + txtIdTurmas.Text + "'";

                MySqlCommand exeCmdMysl_delete = new MySqlCommand(sql_delete, con);

                con.Open();
                exeCmdMysl_delete.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Atualização efetuada!");
                MySqlConnection cone = new MySqlConnection(conexao);
                cone.Open();
            }
            else if (cbModalidades.Text == "Futsal")
            {
                MySqlConnection con = new MySqlConnection(conexao);
                string sql_delete = @"delete from tb_futsal where tb_futsal_id='" + txtIdTurmas.Text + "'";

                MySqlCommand exeCmdMysl_delete = new MySqlCommand(sql_delete, con);

                con.Open();
                exeCmdMysl_delete.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Atualização efetuada!");
                MySqlConnection cone = new MySqlConnection(conexao);
                cone.Open();
            }
            else if (cbModalidades.Text == "Handebol")
            {
                MySqlConnection con = new MySqlConnection(conexao);
                string sql_delete = @"delete from tb_handebol where tb_handebol_id='" + txtIdTurmas.Text + "'";

                MySqlCommand exeCmdMysl_delete = new MySqlCommand(sql_delete, con);

                con.Open();
                exeCmdMysl_delete.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Atualização efetuada!");
                MySqlConnection cone = new MySqlConnection(conexao);
                cone.Open();
            }
            else if (cbModalidades.Text == "Natação")
            {
                MySqlConnection con = new MySqlConnection(conexao);
                string sql_delete = @"delete from tb_natacao where tb_natacao_id='" + txtIdTurmas.Text + "'";

                MySqlCommand exeCmdMysl_delete = new MySqlCommand(sql_delete, con);

                con.Open();
                exeCmdMysl_delete.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Atualização efetuada!");
                MySqlConnection cone = new MySqlConnection(conexao);
                cone.Open();
            }
        }

        private void btnCarregar_Click(object sender, EventArgs e)
        {
            if (cbModalidades.Text == "Basquete")
            {

                MySqlConnection cone = new MySqlConnection(conexao);
                cone.Open();

                string sql_select_modalidade = @"select tb_basquete_id as 'IDENTIF:', tb_basquete_turma as 'COL1:', tb_basquete_horario as 'COL2:' from tb_basquete";

                MySqlCommand executacmdMySql_select_modalidade = new MySqlCommand(sql_select_modalidade, cone);

                executacmdMySql_select_modalidade.ExecuteNonQuery();

                DataTable tbl_mod = new DataTable();

                MySqlDataAdapter da_mod = new MySqlDataAdapter(executacmdMySql_select_modalidade);

                da_mod.Fill(tbl_mod);
                dgvTurmas.DataSource = tbl_mod;
                cone.Close();

            }
            else if (cbModalidades.Text == "Volei")
            {

                MySqlConnection cone = new MySqlConnection(conexao);
                cone.Open();

                string sql_select_modalidade = @"select tb_volei_id as 'IDENTIF', tb_volei_turma as 'COL1:', tb_volei_horario as 'COL2:' from tb_volei";

                MySqlCommand executacmdMySql_select_modalidade = new MySqlCommand(sql_select_modalidade, cone);

                executacmdMySql_select_modalidade.ExecuteNonQuery();

                DataTable tbl_mod = new DataTable();

                MySqlDataAdapter da_mod = new MySqlDataAdapter(executacmdMySql_select_modalidade);

                da_mod.Fill(tbl_mod);
                dgvTurmas.DataSource = tbl_mod;
                cone.Close();
            }
            else if (cbModalidades.Text == "Futsal")
            {
                MySqlConnection cone = new MySqlConnection(conexao);
                cone.Open();

                string sql_select_modalidade = @"select tb_futsal_id as 'IDENTIF', tb_futsal_turma as 'COL1:', tb_futsal_horario as 'COL2:' from tb_futsal";

                MySqlCommand executacmdMySql_select_modalidade = new MySqlCommand(sql_select_modalidade, cone);

                executacmdMySql_select_modalidade.ExecuteNonQuery();

                DataTable tbl_mod = new DataTable();

                MySqlDataAdapter da_mod = new MySqlDataAdapter(executacmdMySql_select_modalidade);

                da_mod.Fill(tbl_mod);
                dgvTurmas.DataSource = tbl_mod;
                cone.Close();
            }
            else if (cbModalidades.Text == "Handebol")
            {
                MySqlConnection cone = new MySqlConnection(conexao);
                cone.Open();

                string sql_select_modalidade = @"select tb_handebol_id as 'IDENTIF', tb_handebol_turma as 'COL1:', tb_handebol_horario as 'COL2:' from tb_handebol";

                MySqlCommand executacmdMySql_select_modalidade = new MySqlCommand(sql_select_modalidade, cone);

                executacmdMySql_select_modalidade.ExecuteNonQuery();

                DataTable tbl_mod = new DataTable();

                MySqlDataAdapter da_mod = new MySqlDataAdapter(executacmdMySql_select_modalidade);

                da_mod.Fill(tbl_mod);
                dgvTurmas.DataSource = tbl_mod;
                cone.Close();
            }
            else if (cbModalidades.Text == "Natação")
            {
                MySqlConnection cone = new MySqlConnection(conexao);
                cone.Open();

                string sql_select_modalidade = @"select tb_natacao_id as 'IDENTIF', tb_natacao_turma as 'COL1:', tb_natacao_horario as 'COL2:' from tb_natacao";

                MySqlCommand executacmdMySql_select_modalidade = new MySqlCommand(sql_select_modalidade, cone);

                executacmdMySql_select_modalidade.ExecuteNonQuery();

                DataTable tbl_mod = new DataTable();

                MySqlDataAdapter da_mod = new MySqlDataAdapter(executacmdMySql_select_modalidade);

                da_mod.Fill(tbl_mod);
                dgvTurmas.DataSource = tbl_mod;
                cone.Close();
            }
        }

        private void btnAtualizar_Click(object sender, EventArgs e)
        {
            if (cbModalidades.Text == "Basquete")
            {
                try
                {
                    MySqlConnection con = new MySqlConnection(conexao);

                    string nome_turma = txtTurma.Text;
                    string horario = txtHorario.Text;
                    string id_turma = txtIdTurmas.Text;

                    string sql_update_turmas = @"update tb_basquete set tb_basquete_turma = @nome_turma, tb_basquete_horario = @horario where tb_basquete_id = @id_turma";

                    MySqlCommand exeCmdMysl_insert = new MySqlCommand(sql_update_turmas, con);

                    exeCmdMysl_insert.Parameters.AddWithValue("@nome_turma", nome_turma);
                    exeCmdMysl_insert.Parameters.AddWithValue("@horario", horario);
                    exeCmdMysl_insert.Parameters.AddWithValue("@id_turma", id_turma);
                    con.Open();
                    exeCmdMysl_insert.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("Atualização efetuada!");

                }

                catch (Exception erro)
                {

                    MessageBox.Show("Ocorreu um erro em: " + erro);
                }

                MySqlConnection cone = new MySqlConnection(conexao);
                cone.Open();

                string sql_select_modalidade = @"select tb_Basquete_id as 'IDENTIF:', tb_basquete_turma as 'COL1:', tb_basquete_horario as 'COL2:' from tb_basquete";

                MySqlCommand executacmdMySql_select_modalidade = new MySqlCommand(sql_select_modalidade, cone);

                executacmdMySql_select_modalidade.ExecuteNonQuery();

                DataTable tbl_mod = new DataTable();

                MySqlDataAdapter da_mod = new MySqlDataAdapter(executacmdMySql_select_modalidade);

                da_mod.Fill(tbl_mod);
                dgvTurmas.DataSource = tbl_mod;
                cone.Close();

            }
            else if (cbModalidades.Text == "Volei")
            {
                try
                {
                    MySqlConnection con = new MySqlConnection(conexao);

                    string nome_turma = txtTurma.Text;
                    string horario = txtHorario.Text;
                    string id_turma = txtIdTurmas.Text;

                    string sql_update_turmas = @"update tb_volei set tb_volei_turma = @nome_turma, tb_volei_horario = @horario where tb_volei_id = @id_turma";

                    MySqlCommand exeCmdMysl_insert = new MySqlCommand(sql_update_turmas, con);

                    exeCmdMysl_insert.Parameters.AddWithValue("@nome_turma", nome_turma);
                    exeCmdMysl_insert.Parameters.AddWithValue("@horario", horario);
                    exeCmdMysl_insert.Parameters.AddWithValue("@id_turma", id_turma);
                    con.Open();
                    exeCmdMysl_insert.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("Atualização efetuada!");

                }

                catch (Exception erro)
                {

                    MessageBox.Show("Ocorreu um erro em: " + erro);
                }

                MySqlConnection cone = new MySqlConnection(conexao);
                cone.Open();

                string sql_select_modalidade = @"select tb_volei_id as 'IDENTIF:', tb_volei_turma as 'COL1:', tb_basquete_horario as 'COL2:' from tb_volei";

                MySqlCommand executacmdMySql_select_modalidade = new MySqlCommand(sql_select_modalidade, cone);

                executacmdMySql_select_modalidade.ExecuteNonQuery();

                DataTable tbl_mod = new DataTable();

                MySqlDataAdapter da_mod = new MySqlDataAdapter(executacmdMySql_select_modalidade);

                da_mod.Fill(tbl_mod);
                dgvTurmas.DataSource = tbl_mod;
                cone.Close();

            }
            else if (cbModalidades.Text == "Futsal")
            {
                try
                {
                    MySqlConnection con = new MySqlConnection(conexao);

                    string nome_turma = txtTurma.Text;
                    string horario = txtHorario.Text;
                    string id_turma = txtIdTurmas.Text;

                    string sql_update_turmas = @"update tb_futsal set tb_futsal_turma = @nome_turma, tb_futsal_horario = @horario where tb_futsal_id = @id_turma";

                    MySqlCommand exeCmdMysl_insert = new MySqlCommand(sql_update_turmas, con);

                    exeCmdMysl_insert.Parameters.AddWithValue("@nome_turma", nome_turma);
                    exeCmdMysl_insert.Parameters.AddWithValue("@horario", horario);
                    exeCmdMysl_insert.Parameters.AddWithValue("@id_turma", id_turma);
                    con.Open();
                    exeCmdMysl_insert.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("Atualização efetuada!");

                }

                catch (Exception erro)
                {

                    MessageBox.Show("Ocorreu um erro em: " + erro);
                }

                MySqlConnection cone = new MySqlConnection(conexao);
                cone.Open();

                string sql_select_modalidade = @"select tb_futsal_id as 'IDENTIF:', tb_futsal_turma as 'COL1:', tb_basquete_horario as 'COL2:' from tb_futsal";

                MySqlCommand executacmdMySql_select_modalidade = new MySqlCommand(sql_select_modalidade, cone);

                executacmdMySql_select_modalidade.ExecuteNonQuery();

                DataTable tbl_mod = new DataTable();

                MySqlDataAdapter da_mod = new MySqlDataAdapter(executacmdMySql_select_modalidade);

                da_mod.Fill(tbl_mod);
                dgvTurmas.DataSource = tbl_mod;
                cone.Close();

            }
            else if (cbModalidades.Text == "Handebol")
            {
                try
                {
                    MySqlConnection con = new MySqlConnection(conexao);

                    string nome_turma = txtTurma.Text;
                    string horario = txtHorario.Text;
                    string id_turma = txtIdTurmas.Text;

                    string sql_update_turmas = @"update tb_basquete set tb_handebol_turma = @nome_turma, tb_handebol_horario = @horario where tb_handebol_id = @id_turma";

                    MySqlCommand exeCmdMysl_insert = new MySqlCommand(sql_update_turmas, con);

                    exeCmdMysl_insert.Parameters.AddWithValue("@nome_turma", nome_turma);
                    exeCmdMysl_insert.Parameters.AddWithValue("@horario", horario);
                    exeCmdMysl_insert.Parameters.AddWithValue("@id_turma", id_turma);
                    con.Open();
                    exeCmdMysl_insert.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("Atualização efetuada!");

                }

                catch (Exception erro)
                {

                    MessageBox.Show("Ocorreu um erro em: " + erro);
                }

                MySqlConnection cone = new MySqlConnection(conexao);
                cone.Open();

                string sql_select_modalidade = @"select tb_handebol_id as 'IDENTIF:', tb_handebol_turma as 'COL1:', tb_handebol_horario as 'COL2:' from tb_handebol";

                MySqlCommand executacmdMySql_select_modalidade = new MySqlCommand(sql_select_modalidade, cone);

                executacmdMySql_select_modalidade.ExecuteNonQuery();

                DataTable tbl_mod = new DataTable();

                MySqlDataAdapter da_mod = new MySqlDataAdapter(executacmdMySql_select_modalidade);

                da_mod.Fill(tbl_mod);
                dgvTurmas.DataSource = tbl_mod;
                cone.Close();

            }
            else if (cbModalidades.Text == "Natação")
            {
                try
                {
                    MySqlConnection con = new MySqlConnection(conexao);

                    string nome_turma = txtTurma.Text;
                    string horario = txtHorario.Text;
                    string id_turma = txtIdTurmas.Text;

                    string sql_update_turmas = @"update tb_natacao set tb_natacao_turma = @nome_turma, tb_natacao_horario = @horario where tb_natacao_id = @id_turma";

                    MySqlCommand exeCmdMysl_insert = new MySqlCommand(sql_update_turmas, con);

                    exeCmdMysl_insert.Parameters.AddWithValue("@nome_turma", nome_turma);
                    exeCmdMysl_insert.Parameters.AddWithValue("@horario", horario);
                    exeCmdMysl_insert.Parameters.AddWithValue("@id_turma", id_turma);
                    con.Open();
                    exeCmdMysl_insert.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("Atualização efetuada!");

                }

                catch (Exception erro)
                {

                    MessageBox.Show("Ocorreu um erro em: " + erro);
                }

                MySqlConnection cone = new MySqlConnection(conexao);
                cone.Open();

                string sql_select_modalidade = @"select tb_natacao_id as 'IDENTIF:', tb_natacao_turma as 'COL1:', tb_natacao_horario as 'COL2:' from tb_natacao";

                MySqlCommand executacmdMySql_select_modalidade = new MySqlCommand(sql_select_modalidade, cone);

                executacmdMySql_select_modalidade.ExecuteNonQuery();

                DataTable tbl_mod = new DataTable();

                MySqlDataAdapter da_mod = new MySqlDataAdapter(executacmdMySql_select_modalidade);

                da_mod.Fill(tbl_mod);
                dgvTurmas.DataSource = tbl_mod;
                cone.Close();

            }
        }

        private void dgvTurmas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgvTurmas_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtTurma.Text = dgvTurmas.CurrentRow.Cells[1].Value.ToString();
            txtIdTurmas.Text = dgvTurmas.CurrentRow.Cells[0].Value.ToString();
            txtHorario.Text = dgvTurmas.CurrentRow.Cells[2].Value.ToString();
        }
    }
}
