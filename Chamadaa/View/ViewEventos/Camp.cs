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
    public partial class TE_Principal : Form
    {
        string conexao = ConfigurationManager.ConnectionStrings["strg_bd_esportivo"].ConnectionString;
        public TE_Principal()
        {
            InitializeComponent();
        }

        private void btnClassAln1_Click(object sender, EventArgs e)
        {
            if (txtaln1Quar.Text == "" && txtaln2Quar.Text == "") { MessageBox.Show("Nenhum valor inserido nas posições iniciais."); }
            else
            {
                string nome_aluno = Convert.ToString(txtaln1Quar.Text);
                try
                {
                    MySqlConnection cone = new MySqlConnection(conexao);

                    string sql_update_aluno = @"update tb_quartas_aluno_1 set tb_aluno_nome = @nome_aluno where tb_quartas_id= 1";

                    MySqlCommand exeCmdMysl_update = new MySqlCommand(sql_update_aluno, cone);
                    exeCmdMysl_update.Parameters.AddWithValue("@nome_aluno", nome_aluno);

                    cone.Open();
                    exeCmdMysl_update.ExecuteNonQuery();
                    cone.Close();
                    MessageBox.Show("Feito!");
                    txtaln2Quar.Text = "";
                    btnClassAln2.Enabled = false;
                }

                catch (Exception erro)
                {

                    MessageBox.Show("Ocorreu um erro em: " + erro);
                }

                MySqlConnection con = new MySqlConnection(conexao);
                con.Open();

                string sql_select_tb_aluno = @"select tb_aluno_nome as 'NOME' from tb_quartas_aluno_1";

                MySqlCommand executacmdMySql_select_aluno = new MySqlCommand(sql_select_tb_aluno, con);

                executacmdMySql_select_aluno.ExecuteNonQuery();

                DataTable tbl_aluno = new DataTable();

                MySqlDataAdapter da_aluno = new MySqlDataAdapter(executacmdMySql_select_aluno);

                da_aluno.Fill(tbl_aluno);
                dgval1Quar.DataSource = tbl_aluno;
            }
        }

        private void btnClassAln2_Click(object sender, EventArgs e)
        {
            if (txtaln1Quar.Text == "" || txtaln2Quar.Text == "") { MessageBox.Show("Nenhum valor inserido nas posições iniciais."); }
            else
            {

                string nome_aluno = Convert.ToString(txtaln2Quar.Text);

                try
                {
                    MySqlConnection cone = new MySqlConnection(conexao);

                    string sql_update_aluno = @"update tb_quartas_aluno_1 set tb_aluno_nome = @nome_aluno where tb_quartas_id= 1";

                    MySqlCommand exeCmdMysl_update = new MySqlCommand(sql_update_aluno, cone);
                    exeCmdMysl_update.Parameters.AddWithValue("@nome_aluno", nome_aluno);

                    cone.Open();
                    exeCmdMysl_update.ExecuteNonQuery();
                    cone.Close();
                    MessageBox.Show("Feito!");
                    txtaln1Quar.Text = "";
                    btnClassAln1.Enabled = false;
                }

                catch (Exception erro)
                {

                    MessageBox.Show("Ocorreu um erro em: " + erro);
                }

                MySqlConnection con = new MySqlConnection(conexao);
                con.Open();

                string sql_select_tb_aluno = @"select tb_aluno_nome as 'NOME' from tb_quartas_aluno_1";

                MySqlCommand executacmdMySql_select_aluno = new MySqlCommand(sql_select_tb_aluno, con);

                executacmdMySql_select_aluno.ExecuteNonQuery();

                DataTable tbl_aluno = new DataTable();

                MySqlDataAdapter da_aluno = new MySqlDataAdapter(executacmdMySql_select_aluno);

                da_aluno.Fill(tbl_aluno);
                dgval1Quar.DataSource = tbl_aluno;
            }
        }

        private void btnClassAln3_Click(object sender, EventArgs e)
        {
            if (txtaln3Quar.Text == "" && txtaln4Quar.Text == "") { MessageBox.Show("Nenhum valor inserido nas posições iniciais."); }
            else
            {

                string nome_aluno = Convert.ToString(txtaln3Quar.Text);

                try
                {
                    MySqlConnection cone = new MySqlConnection(conexao);

                    string sql_update_aluno = @"update tb_quartas_aluno_2 set tb_aluno_nome = @nome_aluno where tb_quartas_id= 1";

                    MySqlCommand exeCmdMysl_update = new MySqlCommand(sql_update_aluno, cone);
                    exeCmdMysl_update.Parameters.AddWithValue("@nome_aluno", nome_aluno);

                    cone.Open();
                    exeCmdMysl_update.ExecuteNonQuery();
                    cone.Close();
                    MessageBox.Show("Feito!");
                    txtaln4Quar.Text = "";
                    btnClassAln4.Enabled = false;
                }

                catch (Exception erro)
                {

                    MessageBox.Show("Ocorreu um erro em: " + erro);
                }

                MySqlConnection con = new MySqlConnection(conexao);
                con.Open();

                string sql_select_tb_aluno = @"select tb_aluno_nome as 'NOME' from tb_quartas_aluno_2";

                MySqlCommand executacmdMySql_select_aluno = new MySqlCommand(sql_select_tb_aluno, con);

                executacmdMySql_select_aluno.ExecuteNonQuery();

                DataTable tbl_aluno = new DataTable();

                MySqlDataAdapter da_aluno = new MySqlDataAdapter(executacmdMySql_select_aluno);

                da_aluno.Fill(tbl_aluno);
                dgval2Quar.DataSource = tbl_aluno;
            }
        }

        private void btnClassAln4_Click(object sender, EventArgs e)
        {
            if (txtaln3Quar.Text == "" && txtaln4Quar.Text == "") { MessageBox.Show("Nenhum valor inserido nas posições iniciais."); }
            else
            {
                string nome_aluno = Convert.ToString(txtaln4Quar.Text);

                try
                {
                    MySqlConnection cone = new MySqlConnection(conexao);

                    string sql_update_aluno = @"update tb_quartas_aluno_2 set tb_aluno_nome = @nome_aluno where tb_quartas_id= 1";

                    MySqlCommand exeCmdMysl_update = new MySqlCommand(sql_update_aluno, cone);
                    exeCmdMysl_update.Parameters.AddWithValue("@nome_aluno", nome_aluno);

                    cone.Open();
                    exeCmdMysl_update.ExecuteNonQuery();
                    cone.Close();
                    MessageBox.Show("Feito!");
                    txtaln3Quar.Text = "";
                    btnClassAln3.Enabled = false;
                }

                catch (Exception erro)
                {

                    MessageBox.Show("Ocorreu um erro em: " + erro);
                }

                MySqlConnection con = new MySqlConnection(conexao);
                con.Open();

                string sql_select_tb_aluno = @"select tb_aluno_nome as 'NOME' from tb_quartas_aluno_2";

                MySqlCommand executacmdMySql_select_aluno = new MySqlCommand(sql_select_tb_aluno, con);

                executacmdMySql_select_aluno.ExecuteNonQuery();

                DataTable tbl_aluno = new DataTable();

                MySqlDataAdapter da_aluno = new MySqlDataAdapter(executacmdMySql_select_aluno);

                da_aluno.Fill(tbl_aluno);
                dgval2Quar.DataSource = tbl_aluno;
            }
        }

        private void btnClassAln5_Click(object sender, EventArgs e)
        {
            if (txtaln5Quar.Text == "" && txtaln6Quar.Text == "") { MessageBox.Show("Nenhum valor inserido nas posições iniciais."); }
            else
            {
                string nome_aluno = Convert.ToString(txtaln5Quar.Text);

                try
                {
                    MySqlConnection cone = new MySqlConnection(conexao);

                    string sql_update_aluno = @"update tb_quartas_aluno_3 set tb_aluno_nome = @nome_aluno where tb_quartas_id= 1";

                    MySqlCommand exeCmdMysl_update = new MySqlCommand(sql_update_aluno, cone);
                    exeCmdMysl_update.Parameters.AddWithValue("@nome_aluno", nome_aluno);

                    cone.Open();
                    exeCmdMysl_update.ExecuteNonQuery();
                    cone.Close();
                    MessageBox.Show("Feito!");
                    txtaln6Quar.Text = "";
                    btnClassAln6.Enabled = false;
                }

                catch (Exception erro)
                {

                    MessageBox.Show("Ocorreu um erro em: " + erro);
                }

                MySqlConnection con = new MySqlConnection(conexao);
                con.Open();

                string sql_select_tb_aluno = @"select tb_aluno_nome as 'NOME' from tb_quartas_aluno_3";

                MySqlCommand executacmdMySql_select_aluno = new MySqlCommand(sql_select_tb_aluno, con);

                executacmdMySql_select_aluno.ExecuteNonQuery();

                DataTable tbl_aluno = new DataTable();

                MySqlDataAdapter da_aluno = new MySqlDataAdapter(executacmdMySql_select_aluno);

                da_aluno.Fill(tbl_aluno);
                dgval3Quar.DataSource = tbl_aluno;
            }
        }

        private void btnClassAln6_Click(object sender, EventArgs e)
        {
            if (txtaln5Quar.Text == "" && txtaln6Quar.Text == "") { MessageBox.Show("Nenhum valor inserido nas posições iniciais."); }
            else
            {
                string nome_aluno = Convert.ToString(txtaln6Quar.Text);

                try
                {
                    MySqlConnection cone = new MySqlConnection(conexao);

                    string sql_update_aluno = @"update tb_quartas_aluno_3 set tb_aluno_nome = @nome_aluno where tb_quartas_id= 1";

                    MySqlCommand exeCmdMysl_update = new MySqlCommand(sql_update_aluno, cone);
                    exeCmdMysl_update.Parameters.AddWithValue("@nome_aluno", nome_aluno);

                    cone.Open();
                    exeCmdMysl_update.ExecuteNonQuery();
                    cone.Close();
                    MessageBox.Show("Feito!");
                    txtaln5Quar.Text = "";
                    btnClassAln5.Enabled = false;
                }

                catch (Exception erro)
                {

                    MessageBox.Show("Ocorreu um erro em: " + erro);
                }

                MySqlConnection con = new MySqlConnection(conexao);
                con.Open();

                string sql_select_tb_aluno = @"select tb_aluno_nome as 'NOME' from tb_quartas_aluno_3";

                MySqlCommand executacmdMySql_select_aluno = new MySqlCommand(sql_select_tb_aluno, con);

                executacmdMySql_select_aluno.ExecuteNonQuery();

                DataTable tbl_aluno = new DataTable();

                MySqlDataAdapter da_aluno = new MySqlDataAdapter(executacmdMySql_select_aluno);

                da_aluno.Fill(tbl_aluno);
                dgval3Quar.DataSource = tbl_aluno;
            }
        }

        private void btnClassAln7_Click(object sender, EventArgs e)
        {
            if (txtaln7Quar.Text == "" && txtaln8Quar.Text == "") { MessageBox.Show("Nenhum valor inserido nas posições iniciais."); }
            else
            {
                string nome_aluno = Convert.ToString(txtaln7Quar.Text);

                try
                {
                    MySqlConnection cone = new MySqlConnection(conexao);

                    string sql_update_aluno = @"update tb_quartas_aluno_4 set tb_aluno_nome = @nome_aluno where tb_quartas_id= 1";

                    MySqlCommand exeCmdMysl_update = new MySqlCommand(sql_update_aluno, cone);
                    exeCmdMysl_update.Parameters.AddWithValue("@nome_aluno", nome_aluno);

                    cone.Open();
                    exeCmdMysl_update.ExecuteNonQuery();
                    cone.Close();
                    MessageBox.Show("Feito!");
                    txtaln8Quar.Text = "";
                    btnClassAln8.Enabled = false;
                }

                catch (Exception erro)
                {

                    MessageBox.Show("Ocorreu um erro em: " + erro);
                }

                MySqlConnection con = new MySqlConnection(conexao);
                con.Open();

                string sql_select_tb_aluno = @"select tb_aluno_nome as 'NOME' from tb_quartas_aluno_4";

                MySqlCommand executacmdMySql_select_aluno = new MySqlCommand(sql_select_tb_aluno, con);

                executacmdMySql_select_aluno.ExecuteNonQuery();

                DataTable tbl_aluno = new DataTable();

                MySqlDataAdapter da_aluno = new MySqlDataAdapter(executacmdMySql_select_aluno);

                da_aluno.Fill(tbl_aluno);
                dgval4Quar.DataSource = tbl_aluno;
            }
        }

        private void btnClassAln8_Click(object sender, EventArgs e)
        {
            if (txtaln7Quar.Text == "" && txtaln8Quar.Text == "") { MessageBox.Show("Nenhum valor inserido nas posições iniciais."); }
            else
            {
                string nome_aluno = Convert.ToString(txtaln8Quar.Text);

                try
                {
                    MySqlConnection cone = new MySqlConnection(conexao);

                    string sql_update_aluno = @"update tb_quartas_aluno_4 set tb_aluno_nome = @nome_aluno where tb_quartas_id= 1";

                    MySqlCommand exeCmdMysl_update = new MySqlCommand(sql_update_aluno, cone);
                    exeCmdMysl_update.Parameters.AddWithValue("@nome_aluno", nome_aluno);

                    cone.Open();
                    exeCmdMysl_update.ExecuteNonQuery();
                    cone.Close();
                    MessageBox.Show("Feito!");
                    txtaln7Quar.Text = "";
                    btnClassAln7.Enabled = false;
                }

                catch (Exception erro)
                {

                    MessageBox.Show("Ocorreu um erro em: " + erro);
                }

                MySqlConnection con = new MySqlConnection(conexao);
                con.Open();

                string sql_select_tb_aluno = @"select tb_aluno_nome as 'NOME' from tb_quartas_aluno_4";

                MySqlCommand executacmdMySql_select_aluno = new MySqlCommand(sql_select_tb_aluno, con);

                executacmdMySql_select_aluno.ExecuteNonQuery();

                DataTable tbl_aluno = new DataTable();

                MySqlDataAdapter da_aluno = new MySqlDataAdapter(executacmdMySql_select_aluno);

                da_aluno.Fill(tbl_aluno);
                dgval4Quar.DataSource = tbl_aluno;
            }
        }

        private void btnClassAln23_Click(object sender, EventArgs e)
        {
            if (txtaln9Quar.Text == "" && txtaln10Quar.Text == "") { MessageBox.Show("Nenhum valor inserido nas posições iniciais."); }
            else
            {
                string nome_aluno = Convert.ToString(txtaln9Quar.Text);

                try
                {
                    MySqlConnection cone = new MySqlConnection(conexao);

                    string sql_update_aluno = @"update tb_quartas_aluno_5 set tb_aluno_nome = @nome_aluno where tb_quartas_id= 1";

                    MySqlCommand exeCmdMysl_update = new MySqlCommand(sql_update_aluno, cone);
                    exeCmdMysl_update.Parameters.AddWithValue("@nome_aluno", nome_aluno);

                    cone.Open();
                    exeCmdMysl_update.ExecuteNonQuery();
                    cone.Close();
                    MessageBox.Show("Feito!");
                    txtaln10Quar.Text = "";
                    btnClassAln24.Enabled = false;

                }

                catch (Exception erro)
                {

                    MessageBox.Show("Ocorreu um erro em: " + erro);
                }

                MySqlConnection con = new MySqlConnection(conexao);
                con.Open();

                string sql_select_tb_aluno = @"select tb_aluno_nome as 'NOME' from tb_quartas_aluno_5";

                MySqlCommand executacmdMySql_select_aluno = new MySqlCommand(sql_select_tb_aluno, con);

                executacmdMySql_select_aluno.ExecuteNonQuery();

                DataTable tbl_aluno = new DataTable();

                MySqlDataAdapter da_aluno = new MySqlDataAdapter(executacmdMySql_select_aluno);

                da_aluno.Fill(tbl_aluno);
                dgval5Quar.DataSource = tbl_aluno;
            }
        }

        private void btnClassAln24_Click(object sender, EventArgs e)
        {
            if (txtaln9Quar.Text == "" && txtaln10Quar.Text == "") { MessageBox.Show("Nenhum valor inserido nas posições iniciais."); }
            else
            {
                string nome_aluno = Convert.ToString(txtaln10Quar.Text);

                try
                {
                    MySqlConnection cone = new MySqlConnection(conexao);

                    string sql_update_aluno = @"update tb_quartas_aluno_5 set tb_aluno_nome = @nome_aluno where tb_quartas_id= 1";

                    MySqlCommand exeCmdMysl_update = new MySqlCommand(sql_update_aluno, cone);
                    exeCmdMysl_update.Parameters.AddWithValue("@nome_aluno", nome_aluno);

                    cone.Open();
                    exeCmdMysl_update.ExecuteNonQuery();
                    cone.Close();
                    MessageBox.Show("Feito!");
                    txtaln9Quar.Text = "";
                    btnClassAln23.Enabled = false;

                }

                catch (Exception erro)
                {

                    MessageBox.Show("Ocorreu um erro em: " + erro);
                }

                MySqlConnection con = new MySqlConnection(conexao);
                con.Open();

                string sql_select_tb_aluno = @"select tb_aluno_nome as 'NOME' from tb_quartas_aluno_5";

                MySqlCommand executacmdMySql_select_aluno = new MySqlCommand(sql_select_tb_aluno, con);

                executacmdMySql_select_aluno.ExecuteNonQuery();

                DataTable tbl_aluno = new DataTable();

                MySqlDataAdapter da_aluno = new MySqlDataAdapter(executacmdMySql_select_aluno);

                da_aluno.Fill(tbl_aluno);
                dgval5Quar.DataSource = tbl_aluno;
            }
        }

        private void btnClassAln25_Click(object sender, EventArgs e)
        {
            if (txtaln11Quar.Text == "" && txtaln12Quar.Text == "") { MessageBox.Show("Nenhum valor inserido nas posições iniciais."); }
            else
            {

                string nome_aluno = Convert.ToString(txtaln11Quar.Text);

                try
                {
                    MySqlConnection cone = new MySqlConnection(conexao);

                    string sql_update_aluno = @"update tb_quartas_aluno_6 set tb_aluno_nome = @nome_aluno where tb_quartas_id= 1";

                    MySqlCommand exeCmdMysl_update = new MySqlCommand(sql_update_aluno, cone);
                    exeCmdMysl_update.Parameters.AddWithValue("@nome_aluno", nome_aluno);

                    cone.Open();
                    exeCmdMysl_update.ExecuteNonQuery();
                    cone.Close();
                    MessageBox.Show("Feito!");
                    txtaln12Quar.Text = "";
                    btnClassAln26.Enabled = false;
                }

                catch (Exception erro)
                {

                    MessageBox.Show("Ocorreu um erro em: " + erro);
                }

                MySqlConnection con = new MySqlConnection(conexao);
                con.Open();

                string sql_select_tb_aluno = @"select tb_aluno_nome as 'NOME' from tb_quartas_aluno_6";

                MySqlCommand executacmdMySql_select_aluno = new MySqlCommand(sql_select_tb_aluno, con);

                executacmdMySql_select_aluno.ExecuteNonQuery();

                DataTable tbl_aluno = new DataTable();

                MySqlDataAdapter da_aluno = new MySqlDataAdapter(executacmdMySql_select_aluno);

                da_aluno.Fill(tbl_aluno);
                dgval6Quar.DataSource = tbl_aluno;
            }
        }

        private void btnClassAln26_Click(object sender, EventArgs e)
        {
            if (txtaln11Quar.Text == "" && txtaln12Quar.Text == "") { MessageBox.Show("Nenhum valor inserido nas posições iniciais."); }
            else
            {
                string nome_aluno = Convert.ToString(txtaln12Quar.Text);

                try
                {
                    MySqlConnection cone = new MySqlConnection(conexao);

                    string sql_update_aluno = @"update tb_quartas_aluno_6 set tb_aluno_nome = @nome_aluno where tb_quartas_id= 1";

                    MySqlCommand exeCmdMysl_update = new MySqlCommand(sql_update_aluno, cone);
                    exeCmdMysl_update.Parameters.AddWithValue("@nome_aluno", nome_aluno);

                    cone.Open();
                    exeCmdMysl_update.ExecuteNonQuery();
                    cone.Close();
                    MessageBox.Show("Feito!");
                    txtaln11Quar.Text = "";
                    btnClassAln25.Enabled = false;
                }

                catch (Exception erro)
                {

                    MessageBox.Show("Ocorreu um erro em: " + erro);
                }

                MySqlConnection con = new MySqlConnection(conexao);
                con.Open();

                string sql_select_tb_aluno = @"select tb_aluno_nome as 'NOME' from tb_quartas_aluno_6";

                MySqlCommand executacmdMySql_select_aluno = new MySqlCommand(sql_select_tb_aluno, con);

                executacmdMySql_select_aluno.ExecuteNonQuery();

                DataTable tbl_aluno = new DataTable();

                MySqlDataAdapter da_aluno = new MySqlDataAdapter(executacmdMySql_select_aluno);

                da_aluno.Fill(tbl_aluno);
                dgval6Quar.DataSource = tbl_aluno;
            }
        }

        private void btnClassAln27_Click(object sender, EventArgs e)
        {
            if (txtaln13Quar.Text == "" && txtaln14Quar.Text == "") { MessageBox.Show("Nenhum valor inserido nas posições iniciais."); }
            else
            {
                string nome_aluno = Convert.ToString(txtaln13Quar.Text);

                try
                {
                    MySqlConnection cone = new MySqlConnection(conexao);

                    string sql_update_aluno = @"update tb_quartas_aluno_7 set tb_aluno_nome = @nome_aluno where tb_quartas_id= 1";

                    MySqlCommand exeCmdMysl_update = new MySqlCommand(sql_update_aluno, cone);
                    exeCmdMysl_update.Parameters.AddWithValue("@nome_aluno", nome_aluno);

                    cone.Open();
                    exeCmdMysl_update.ExecuteNonQuery();
                    cone.Close();
                    MessageBox.Show("Feito!");
                    txtaln14Quar.Text = "";
                    btnClassAln28.Enabled = false;
                }

                catch (Exception erro)
                {

                    MessageBox.Show("Ocorreu um erro em: " + erro);
                }

                MySqlConnection con = new MySqlConnection(conexao);
                con.Open();

                string sql_select_tb_aluno = @"select tb_aluno_nome as 'NOME' from tb_quartas_aluno_7";

                MySqlCommand executacmdMySql_select_aluno = new MySqlCommand(sql_select_tb_aluno, con);

                executacmdMySql_select_aluno.ExecuteNonQuery();

                DataTable tbl_aluno = new DataTable();

                MySqlDataAdapter da_aluno = new MySqlDataAdapter(executacmdMySql_select_aluno);

                da_aluno.Fill(tbl_aluno);
                dgval7Quar.DataSource = tbl_aluno;
            }
        }

        private void btnClassAln28_Click(object sender, EventArgs e)
        {
            if (txtaln13Quar.Text == "" && txtaln14Quar.Text == "") { MessageBox.Show("Nenhum valor inserido nas posições iniciais."); }
            else
            {
                string nome_aluno = Convert.ToString(txtaln14Quar.Text);

                try
                {
                    MySqlConnection cone = new MySqlConnection(conexao);

                    string sql_update_aluno = @"update tb_quartas_aluno_7 set tb_aluno_nome = @nome_aluno where tb_quartas_id= 1";

                    MySqlCommand exeCmdMysl_update = new MySqlCommand(sql_update_aluno, cone);
                    exeCmdMysl_update.Parameters.AddWithValue("@nome_aluno", nome_aluno);

                    cone.Open();
                    exeCmdMysl_update.ExecuteNonQuery();
                    cone.Close();
                    MessageBox.Show("Feito!");
                    txtaln13Quar.Text = "";
                    btnClassAln27.Enabled = false;
                }

                catch (Exception erro)
                {

                    MessageBox.Show("Ocorreu um erro em: " + erro);
                }

                MySqlConnection con = new MySqlConnection(conexao);
                con.Open();

                string sql_select_tb_aluno = @"select tb_aluno_nome as 'NOME' from tb_quartas_aluno_7";

                MySqlCommand executacmdMySql_select_aluno = new MySqlCommand(sql_select_tb_aluno, con);

                executacmdMySql_select_aluno.ExecuteNonQuery();

                DataTable tbl_aluno = new DataTable();

                MySqlDataAdapter da_aluno = new MySqlDataAdapter(executacmdMySql_select_aluno);

                da_aluno.Fill(tbl_aluno);
                dgval7Quar.DataSource = tbl_aluno;
            }
        }

        private void btnClassAln29_Click(object sender, EventArgs e)
        {
            if (txtaln15Quar.Text == "" && txtaln16Quar.Text == "")
            {
                MessageBox.Show("Nenhum valor inserido nas posições iniciais.");
            }
            else
            {
                string nome_aluno = Convert.ToString(txtaln15Quar.Text);

                try
                {
                    MySqlConnection cone = new MySqlConnection(conexao);

                    string sql_update_aluno = @"update tb_quartas_aluno_8 set tb_aluno_nome = @nome_aluno where tb_quartas_id= 1";

                    MySqlCommand exeCmdMysl_update = new MySqlCommand(sql_update_aluno, cone);
                    exeCmdMysl_update.Parameters.AddWithValue("@nome_aluno", nome_aluno);

                    cone.Open();
                    exeCmdMysl_update.ExecuteNonQuery();
                    cone.Close();
                    MessageBox.Show("Feito!");
                    txtaln16Quar.Text = "";

                }

                catch (Exception erro)
                {

                    MessageBox.Show("Ocorreu um erro em: " + erro);
                }

                MySqlConnection con = new MySqlConnection(conexao);
                con.Open();

                string sql_select_tb_aluno = @"select tb_aluno_nome as 'NOME' from tb_quartas_aluno_8";

                MySqlCommand executacmdMySql_select_aluno = new MySqlCommand(sql_select_tb_aluno, con);

                executacmdMySql_select_aluno.ExecuteNonQuery();

                DataTable tbl_aluno = new DataTable();

                MySqlDataAdapter da_aluno = new MySqlDataAdapter(executacmdMySql_select_aluno);

                da_aluno.Fill(tbl_aluno);
                dgval8Quar.DataSource = tbl_aluno;

                btnClassAln30.Enabled = false;
            }
        }

        private void btnClassAln30_Click(object sender, EventArgs e)
        {
            if (txtaln15Quar.Text == "" && txtaln16Quar.Text == "")
            {
                MessageBox.Show("Nenhum valor inserido nas posições iniciais.");
            }
            else
            {
                string nome_aluno = Convert.ToString(txtaln16Quar.Text);

                try
                {
                    MySqlConnection cone = new MySqlConnection(conexao);

                    string sql_update_aluno = @"update tb_quartas_aluno_8 set tb_aluno_nome = @nome_aluno where tb_quartas_id= 1";

                    MySqlCommand exeCmdMysl_update = new MySqlCommand(sql_update_aluno, cone);
                    exeCmdMysl_update.Parameters.AddWithValue("@nome_aluno", nome_aluno);

                    cone.Open();
                    exeCmdMysl_update.ExecuteNonQuery();
                    cone.Close();
                    MessageBox.Show("Feito!");
                    txtaln15Quar.Text = "";
                    btnClassAln29.Enabled = false;
                }

                catch (Exception erro)
                {

                    MessageBox.Show("Ocorreu um erro em: " + erro);
                }

                MySqlConnection con = new MySqlConnection(conexao);
                con.Open();

                string sql_select_tb_aluno = @"select tb_aluno_nome as 'NOME' from tb_quartas_aluno_8";

                MySqlCommand executacmdMySql_select_aluno = new MySqlCommand(sql_select_tb_aluno, con);

                executacmdMySql_select_aluno.ExecuteNonQuery();

                DataTable tbl_aluno = new DataTable();

                MySqlDataAdapter da_aluno = new MySqlDataAdapter(executacmdMySql_select_aluno);

                da_aluno.Fill(tbl_aluno);
                dgval8Quar.DataSource = tbl_aluno;

                btnClassAln29.Enabled = false;
            }
        }

        private void btnClassAln9_Click(object sender, EventArgs e)
        {
            if (txtaln1Quar.Text == "")
            {
                string nome_aluno = Convert.ToString(txtaln2Quar.Text);

                try
                {
                    MySqlConnection cone = new MySqlConnection(conexao);

                    string sql_update_aluno = @"update tb_semi_aluno_1 set tb_aluno_nome = @nome_aluno where tb_semi_id= 1";

                    MySqlCommand exeCmdMysl_update = new MySqlCommand(sql_update_aluno, cone);
                    exeCmdMysl_update.Parameters.AddWithValue("@nome_aluno", nome_aluno);

                    cone.Open();
                    exeCmdMysl_update.ExecuteNonQuery();
                    cone.Close();
                    MessageBox.Show("Feito!");

                }

                catch (Exception erro)
                {

                    MessageBox.Show("Ocorreu um erro em: " + erro);
                }

                MySqlConnection con = new MySqlConnection(conexao);
                con.Open();

                string sql_select_tb_aluno = @"select tb_aluno_nome as 'NOME' from tb_semi_aluno_1";

                MySqlCommand executacmdMySql_select_aluno = new MySqlCommand(sql_select_tb_aluno, con);

                executacmdMySql_select_aluno.ExecuteNonQuery();

                DataTable tbl_aluno = new DataTable();

                MySqlDataAdapter da_aluno = new MySqlDataAdapter(executacmdMySql_select_aluno);

                da_aluno.Fill(tbl_aluno);
                dgval1Semi.DataSource = tbl_aluno;
            }

            else if (txtaln2Quar.Text == "")
            {
                string nome_aluno = Convert.ToString(txtaln1Quar.Text);

                try
                {
                    MySqlConnection cone = new MySqlConnection(conexao);

                    string sql_update_aluno = @"update tb_semi_aluno_1 set tb_aluno_nome = @nome_aluno where tb_semi_id= 1";

                    MySqlCommand exeCmdMysl_update = new MySqlCommand(sql_update_aluno, cone);
                    exeCmdMysl_update.Parameters.AddWithValue("@nome_aluno", nome_aluno);

                    cone.Open();
                    exeCmdMysl_update.ExecuteNonQuery();
                    cone.Close();
                    MessageBox.Show("Feito!");

                }

                catch (Exception erro)
                {

                    MessageBox.Show("Ocorreu um erro em: " + erro);
                }

                MySqlConnection con = new MySqlConnection(conexao);
                con.Open();

                string sql_select_tb_aluno = @"select tb_aluno_nome as 'NOME' from tb_semi_aluno_1";

                MySqlCommand executacmdMySql_select_aluno = new MySqlCommand(sql_select_tb_aluno, con);

                executacmdMySql_select_aluno.ExecuteNonQuery();

                DataTable tbl_aluno = new DataTable();

                MySqlDataAdapter da_aluno = new MySqlDataAdapter(executacmdMySql_select_aluno);

                da_aluno.Fill(tbl_aluno);
                dgval1Semi.DataSource = tbl_aluno;


            }
            if (txtaln1Quar.Text == "" && txtaln3Quar.Text == "")
            {
                txtaln4Quar.Text = "";
            }
            if (txtaln1Quar.Text == "" && txtaln4Quar.Text == "")
            {
                txtaln3Quar.Text = "";
            }
            if (txtaln2Quar.Text == "" && txtaln3Quar.Text == "")
            {
                txtaln4Quar.Text = "";
            }
            if (txtaln2Quar.Text == "" && txtaln4Quar.Text == "")
            {
                txtaln3Quar.Text = "";
            }
            btnClassAln10.Enabled = false;
        }

        private void btnClassAln10_Click(object sender, EventArgs e)
        {
            if (txtaln3Quar.Text == "")
            {
                string nome_aluno = Convert.ToString(txtaln4Quar.Text);

                try
                {
                    MySqlConnection cone = new MySqlConnection(conexao);

                    string sql_update_aluno = @"update tb_semi_aluno_1 set tb_aluno_nome = @nome_aluno where tb_semi_id= 1";

                    MySqlCommand exeCmdMysl_update = new MySqlCommand(sql_update_aluno, cone);
                    exeCmdMysl_update.Parameters.AddWithValue("@nome_aluno", nome_aluno);

                    cone.Open();
                    exeCmdMysl_update.ExecuteNonQuery();
                    cone.Close();
                    MessageBox.Show("Feito!");

                }

                catch (Exception erro)
                {

                    MessageBox.Show("Ocorreu um erro em: " + erro);
                }

                MySqlConnection con = new MySqlConnection(conexao);
                con.Open();

                string sql_select_tb_aluno = @"select tb_aluno_nome as 'NOME' from tb_semi_aluno_1";

                MySqlCommand executacmdMySql_select_aluno = new MySqlCommand(sql_select_tb_aluno, con);

                executacmdMySql_select_aluno.ExecuteNonQuery();

                DataTable tbl_aluno = new DataTable();

                MySqlDataAdapter da_aluno = new MySqlDataAdapter(executacmdMySql_select_aluno);

                da_aluno.Fill(tbl_aluno);
                dgval1Semi.DataSource = tbl_aluno;
            }

            else if (txtaln4Quar.Text == "")
            {
                string nome_aluno = Convert.ToString(txtaln3Quar.Text);

                try
                {
                    MySqlConnection cone = new MySqlConnection(conexao);

                    string sql_update_aluno = @"update tb_semi_aluno_1 set tb_aluno_nome = @nome_aluno where tb_semi_id= 1";

                    MySqlCommand exeCmdMysl_update = new MySqlCommand(sql_update_aluno, cone);
                    exeCmdMysl_update.Parameters.AddWithValue("@nome_aluno", nome_aluno);

                    cone.Open();
                    exeCmdMysl_update.ExecuteNonQuery();
                    cone.Close();
                    MessageBox.Show("Feito!");

                }

                catch (Exception erro)
                {

                    MessageBox.Show("Ocorreu um erro em: " + erro);
                }

                MySqlConnection con = new MySqlConnection(conexao);
                con.Open();

                string sql_select_tb_aluno = @"select tb_aluno_nome as 'NOME' from tb_semi_aluno_1";

                MySqlCommand executacmdMySql_select_aluno = new MySqlCommand(sql_select_tb_aluno, con);

                executacmdMySql_select_aluno.ExecuteNonQuery();

                DataTable tbl_aluno = new DataTable();

                MySqlDataAdapter da_aluno = new MySqlDataAdapter(executacmdMySql_select_aluno);

                da_aluno.Fill(tbl_aluno);
                dgval1Semi.DataSource = tbl_aluno;


            }
            if (txtaln1Quar.Text == "" && txtaln3Quar.Text == "")
            {
                txtaln2Quar.Text = "";
            }
            if (txtaln1Quar.Text == "" && txtaln4Quar.Text == "")
            {
                txtaln2Quar.Text = "";
            }
            if (txtaln2Quar.Text == "" && txtaln3Quar.Text == "")
            {
                txtaln1Quar.Text = "";
            }
            if (txtaln2Quar.Text == "" && txtaln4Quar.Text == "")
            {
                txtaln1Quar.Text = "";
            }


            btnClassAln9.Enabled = false;
        }

        private void btnClassAln11_Click(object sender, EventArgs e)
        {
            if (txtaln5Quar.Text == "")
            {
                string nome_aluno = Convert.ToString(txtaln6Quar.Text);

                try
                {
                    MySqlConnection cone = new MySqlConnection(conexao);

                    string sql_update_aluno = @"update tb_semi_aluno_3 set tb_aluno_nome = @nome_aluno where tb_semi_id= 1";

                    MySqlCommand exeCmdMysl_update = new MySqlCommand(sql_update_aluno, cone);
                    exeCmdMysl_update.Parameters.AddWithValue("@nome_aluno", nome_aluno);

                    cone.Open();
                    exeCmdMysl_update.ExecuteNonQuery();
                    cone.Close();
                    MessageBox.Show("Feito!");

                }

                catch (Exception erro)
                {

                    MessageBox.Show("Ocorreu um erro em: " + erro);
                }

                MySqlConnection con = new MySqlConnection(conexao);
                con.Open();

                string sql_select_tb_aluno = @"select tb_aluno_nome as 'NOME' from tb_semi_aluno_3";

                MySqlCommand executacmdMySql_select_aluno = new MySqlCommand(sql_select_tb_aluno, con);

                executacmdMySql_select_aluno.ExecuteNonQuery();

                DataTable tbl_aluno = new DataTable();

                MySqlDataAdapter da_aluno = new MySqlDataAdapter(executacmdMySql_select_aluno);

                da_aluno.Fill(tbl_aluno);
                dgval3Semi.DataSource = tbl_aluno;
            }

            else if (txtaln6Quar.Text == "")
            {
                string nome_aluno = Convert.ToString(txtaln5Quar.Text);

                try
                {
                    MySqlConnection cone = new MySqlConnection(conexao);

                    string sql_update_aluno = @"update tb_semi_aluno_3 set tb_aluno_nome = @nome_aluno where tb_semi_id= 1";

                    MySqlCommand exeCmdMysl_update = new MySqlCommand(sql_update_aluno, cone);
                    exeCmdMysl_update.Parameters.AddWithValue("@nome_aluno", nome_aluno);

                    cone.Open();
                    exeCmdMysl_update.ExecuteNonQuery();
                    cone.Close();
                    MessageBox.Show("Feito!");
                    btnClassAln12.Enabled = false;
                }

                catch (Exception erro)
                {

                    MessageBox.Show("Ocorreu um erro em: " + erro);
                }

                MySqlConnection con = new MySqlConnection(conexao);
                con.Open();

                string sql_select_tb_aluno = @"select tb_aluno_nome as 'NOME' from tb_semi_aluno_3";

                MySqlCommand executacmdMySql_select_aluno = new MySqlCommand(sql_select_tb_aluno, con);

                executacmdMySql_select_aluno.ExecuteNonQuery();

                DataTable tbl_aluno = new DataTable();

                MySqlDataAdapter da_aluno = new MySqlDataAdapter(executacmdMySql_select_aluno);

                da_aluno.Fill(tbl_aluno);
                dgval3Semi.DataSource = tbl_aluno;
            }

            if (txtaln5Quar.Text == "" && txtaln7Quar.Text == "")
            {
                txtaln8Quar.Text = "";
            }
            if (txtaln5Quar.Text == "" && txtaln8Quar.Text == "")
            {
                txtaln7Quar.Text = "";
            }
            if (txtaln6Quar.Text == "" && txtaln7Quar.Text == "")
            {
                txtaln8Quar.Text = "";
            }
            if (txtaln6Quar.Text == "" && txtaln8Quar.Text == "")
            {
                txtaln7Quar.Text = "";
            }
            btnClassAln12.Enabled = false;
        }

        private void btnClassAln12_Click(object sender, EventArgs e)
        {
            if (txtaln7Quar.Text == "")
            {
                string nome_aluno = Convert.ToString(txtaln8Quar.Text);

                try
                {
                    MySqlConnection cone = new MySqlConnection(conexao);

                    string sql_update_aluno = @"update tb_semi_aluno_3 set tb_aluno_nome = @nome_aluno where tb_semi_id= 1";

                    MySqlCommand exeCmdMysl_update = new MySqlCommand(sql_update_aluno, cone);
                    exeCmdMysl_update.Parameters.AddWithValue("@nome_aluno", nome_aluno);

                    cone.Open();
                    exeCmdMysl_update.ExecuteNonQuery();
                    cone.Close();
                    MessageBox.Show("Feito!");

                }

                catch (Exception erro)
                {

                    MessageBox.Show("Ocorreu um erro em: " + erro);
                }

                MySqlConnection con = new MySqlConnection(conexao);
                con.Open();

                string sql_select_tb_aluno = @"select tb_aluno_nome as 'NOME' from tb_semi_aluno_3";

                MySqlCommand executacmdMySql_select_aluno = new MySqlCommand(sql_select_tb_aluno, con);

                executacmdMySql_select_aluno.ExecuteNonQuery();

                DataTable tbl_aluno = new DataTable();

                MySqlDataAdapter da_aluno = new MySqlDataAdapter(executacmdMySql_select_aluno);

                da_aluno.Fill(tbl_aluno);
                dgval3Semi.DataSource = tbl_aluno;
            }

            else if (txtaln8Quar.Text == "")
            {
                string nome_aluno = Convert.ToString(txtaln7Quar.Text);

                try
                {
                    MySqlConnection cone = new MySqlConnection(conexao);

                    string sql_update_aluno = @"update tb_semi_aluno_3 set tb_aluno_nome = @nome_aluno where tb_semi_id= 1";

                    MySqlCommand exeCmdMysl_update = new MySqlCommand(sql_update_aluno, cone);
                    exeCmdMysl_update.Parameters.AddWithValue("@nome_aluno", nome_aluno);

                    cone.Open();
                    exeCmdMysl_update.ExecuteNonQuery();
                    cone.Close();
                    MessageBox.Show("Feito!");
                    btnClassAln11.Enabled = false;
                }

                catch (Exception erro)
                {

                    MessageBox.Show("Ocorreu um erro em: " + erro);
                }

                MySqlConnection con = new MySqlConnection(conexao);
                con.Open();

                string sql_select_tb_aluno = @"select tb_aluno_nome as 'NOME' from tb_semi_aluno_3";

                MySqlCommand executacmdMySql_select_aluno = new MySqlCommand(sql_select_tb_aluno, con);

                executacmdMySql_select_aluno.ExecuteNonQuery();

                DataTable tbl_aluno = new DataTable();

                MySqlDataAdapter da_aluno = new MySqlDataAdapter(executacmdMySql_select_aluno);

                da_aluno.Fill(tbl_aluno);
                dgval3Semi.DataSource = tbl_aluno;
            }

            if (txtaln5Quar.Text == "" && txtaln7Quar.Text == "")
            {
                txtaln6Quar.Text = "";
            }
            if (txtaln5Quar.Text == "" && txtaln8Quar.Text == "")
            {
                txtaln6Quar.Text = "";
            }
            if (txtaln6Quar.Text == "" && txtaln7Quar.Text == "")
            {
                txtaln5Quar.Text = "";
            }
            if (txtaln6Quar.Text == "" && txtaln8Quar.Text == "")
            {
                txtaln5Quar.Text = "";
            }
            btnClassAln11.Enabled = false;
        }

        private void btnClassAln19_Click(object sender, EventArgs e)
        {
            if (txtaln10Quar.Text == "")
            {
                string nome_aluno = Convert.ToString(txtaln9Quar.Text);

                try
                {
                    MySqlConnection cone = new MySqlConnection(conexao);

                    string sql_update_aluno = @"update tb_semi_aluno_2 set tb_aluno_nome = @nome_aluno where tb_semi_id= 1";

                    MySqlCommand exeCmdMysl_update = new MySqlCommand(sql_update_aluno, cone);
                    exeCmdMysl_update.Parameters.AddWithValue("@nome_aluno", nome_aluno);

                    cone.Open();
                    exeCmdMysl_update.ExecuteNonQuery();
                    cone.Close();
                    MessageBox.Show("Feito!");


                }

                catch (Exception erro)
                {

                    MessageBox.Show("Ocorreu um erro em: " + erro);
                }

                MySqlConnection con = new MySqlConnection(conexao);
                con.Open();

                string sql_select_tb_aluno = @"select tb_aluno_nome as 'NOME' from tb_semi_aluno_2";

                MySqlCommand executacmdMySql_select_aluno = new MySqlCommand(sql_select_tb_aluno, con);

                executacmdMySql_select_aluno.ExecuteNonQuery();

                DataTable tbl_aluno = new DataTable();

                MySqlDataAdapter da_aluno = new MySqlDataAdapter(executacmdMySql_select_aluno);

                da_aluno.Fill(tbl_aluno);
                dgval2Semi.DataSource = tbl_aluno;
            }

            else if (txtaln9Quar.Text == "")
            {
                string nome_aluno = Convert.ToString(txtaln10Quar.Text);

                try
                {
                    MySqlConnection cone = new MySqlConnection(conexao);

                    string sql_update_aluno = @"update tb_semi_aluno_2 set tb_aluno_nome = @nome_aluno where tb_semi_id= 1";

                    MySqlCommand exeCmdMysl_update = new MySqlCommand(sql_update_aluno, cone);
                    exeCmdMysl_update.Parameters.AddWithValue("@nome_aluno", nome_aluno);

                    cone.Open();
                    exeCmdMysl_update.ExecuteNonQuery();
                    cone.Close();
                    MessageBox.Show("Feito!");

                }

                catch (Exception erro)
                {

                    MessageBox.Show("Ocorreu um erro em: " + erro);
                }

                MySqlConnection con = new MySqlConnection(conexao);
                con.Open();

                string sql_select_tb_aluno = @"select tb_aluno_nome as 'NOME' from tb_semi_aluno_2";

                MySqlCommand executacmdMySql_select_aluno = new MySqlCommand(sql_select_tb_aluno, con);

                executacmdMySql_select_aluno.ExecuteNonQuery();

                DataTable tbl_aluno = new DataTable();

                MySqlDataAdapter da_aluno = new MySqlDataAdapter(executacmdMySql_select_aluno);

                da_aluno.Fill(tbl_aluno);
                dgval2Semi.DataSource = tbl_aluno;
            }

            if (txtaln9Quar.Text == "" && txtaln11Quar.Text == "")
            {
                txtaln12Quar.Text = "";
            }
            if (txtaln9Quar.Text == "" && txtaln12Quar.Text == "")
            {
                txtaln11Quar.Text = "";
            }
            if (txtaln10Quar.Text == "" && txtaln11Quar.Text == "")
            {
                txtaln12Quar.Text = "";
            }
            if (txtaln10Quar.Text == "" && txtaln12Quar.Text == "")
            {
                txtaln11Quar.Text = "";
            }
            btnClassAln20.Enabled = false;
        }

        private void btnClassAln20_Click(object sender, EventArgs e)
        {
            if (txtaln11Quar.Text == "")
            {
                string nome_aluno = Convert.ToString(txtaln12Quar.Text);

                try
                {
                    MySqlConnection cone = new MySqlConnection(conexao);

                    string sql_update_aluno = @"update tb_semi_aluno_3 set tb_aluno_nome = @nome_aluno where tb_semi_id= 1";

                    MySqlCommand exeCmdMysl_update = new MySqlCommand(sql_update_aluno, cone);
                    exeCmdMysl_update.Parameters.AddWithValue("@nome_aluno", nome_aluno);

                    cone.Open();
                    exeCmdMysl_update.ExecuteNonQuery();
                    cone.Close();
                    MessageBox.Show("Feito!");


                }

                catch (Exception erro)
                {

                    MessageBox.Show("Ocorreu um erro em: " + erro);
                }

                MySqlConnection con = new MySqlConnection(conexao);
                con.Open();

                string sql_select_tb_aluno = @"select tb_aluno_nome as 'NOME' from tb_semi_aluno_3";

                MySqlCommand executacmdMySql_select_aluno = new MySqlCommand(sql_select_tb_aluno, con);

                executacmdMySql_select_aluno.ExecuteNonQuery();

                DataTable tbl_aluno = new DataTable();

                MySqlDataAdapter da_aluno = new MySqlDataAdapter(executacmdMySql_select_aluno);

                da_aluno.Fill(tbl_aluno);
                dgval2Semi.DataSource = tbl_aluno;
            }

            else if (txtaln12Quar.Text == "")
            {
                string nome_aluno = Convert.ToString(txtaln11Quar.Text);

                try
                {
                    MySqlConnection cone = new MySqlConnection(conexao);

                    string sql_update_aluno = @"update tb_semi_aluno_3 set tb_aluno_nome = @nome_aluno where tb_semi_id= 1";

                    MySqlCommand exeCmdMysl_update = new MySqlCommand(sql_update_aluno, cone);
                    exeCmdMysl_update.Parameters.AddWithValue("@nome_aluno", nome_aluno);

                    cone.Open();
                    exeCmdMysl_update.ExecuteNonQuery();
                    cone.Close();
                    MessageBox.Show("Feito!");

                }

                catch (Exception erro)
                {

                    MessageBox.Show("Ocorreu um erro em: " + erro);
                }

                MySqlConnection con = new MySqlConnection(conexao);
                con.Open();

                string sql_select_tb_aluno = @"select tb_aluno_nome as 'NOME' from tb_semi_aluno_3";

                MySqlCommand executacmdMySql_select_aluno = new MySqlCommand(sql_select_tb_aluno, con);

                executacmdMySql_select_aluno.ExecuteNonQuery();

                DataTable tbl_aluno = new DataTable();

                MySqlDataAdapter da_aluno = new MySqlDataAdapter(executacmdMySql_select_aluno);

                da_aluno.Fill(tbl_aluno);
                dgval2Semi.DataSource = tbl_aluno;
            }
            if (txtaln9Quar.Text == "" && txtaln11Quar.Text == "")
            {
                txtaln10Quar.Text = "";
            }
            if (txtaln9Quar.Text == "" && txtaln12Quar.Text == "")
            {
                txtaln10Quar.Text = "";
            }
            if (txtaln10Quar.Text == "" && txtaln11Quar.Text == "")
            {
                txtaln9Quar.Text = "";
            }
            if (txtaln10Quar.Text == "" && txtaln12Quar.Text == "")
            {
                txtaln9Quar.Text = "";
            }
            btnClassAln19.Enabled = false;
        }

        private void btnClassAln21_Click(object sender, EventArgs e)
        {
            if (txtaln13Quar.Text == "")
            {
                string nome_aluno = Convert.ToString(txtaln14Quar.Text);

                try
                {
                    MySqlConnection cone = new MySqlConnection(conexao);

                    string sql_update_aluno = @"update tb_semi_aluno_4 set tb_aluno_nome = @nome_aluno where tb_semi_id= 1";

                    MySqlCommand exeCmdMysl_update = new MySqlCommand(sql_update_aluno, cone);
                    exeCmdMysl_update.Parameters.AddWithValue("@nome_aluno", nome_aluno);

                    cone.Open();
                    exeCmdMysl_update.ExecuteNonQuery();
                    cone.Close();
                    MessageBox.Show("Feito!");

                }

                catch (Exception erro)
                {

                    MessageBox.Show("Ocorreu um erro em: " + erro);
                }

                MySqlConnection con = new MySqlConnection(conexao);
                con.Open();

                string sql_select_tb_aluno = @"select tb_aluno_nome as 'NOME' from tb_semi_aluno_4";

                MySqlCommand executacmdMySql_select_aluno = new MySqlCommand(sql_select_tb_aluno, con);

                executacmdMySql_select_aluno.ExecuteNonQuery();

                DataTable tbl_aluno = new DataTable();

                MySqlDataAdapter da_aluno = new MySqlDataAdapter(executacmdMySql_select_aluno);

                da_aluno.Fill(tbl_aluno);
                dgval4Semi.DataSource = tbl_aluno;
            }

            else if (txtaln14Quar.Text == "")
            {
                string nome_aluno = Convert.ToString(txtaln13Quar.Text);

                try
                {
                    MySqlConnection cone = new MySqlConnection(conexao);

                    string sql_update_aluno = @"update tb_semi_aluno_4 set tb_aluno_nome = @nome_aluno where tb_semi_id= 1";

                    MySqlCommand exeCmdMysl_update = new MySqlCommand(sql_update_aluno, cone);
                    exeCmdMysl_update.Parameters.AddWithValue("@nome_aluno", nome_aluno);

                    cone.Open();
                    exeCmdMysl_update.ExecuteNonQuery();
                    cone.Close();
                    MessageBox.Show("Feito!");

                }

                catch (Exception erro)
                {

                    MessageBox.Show("Ocorreu um erro em: " + erro);
                }

                MySqlConnection con = new MySqlConnection(conexao);
                con.Open();

                string sql_select_tb_aluno = @"select tb_aluno_nome as 'NOME' from tb_semi_aluno_4";

                MySqlCommand executacmdMySql_select_aluno = new MySqlCommand(sql_select_tb_aluno, con);

                executacmdMySql_select_aluno.ExecuteNonQuery();

                DataTable tbl_aluno = new DataTable();

                MySqlDataAdapter da_aluno = new MySqlDataAdapter(executacmdMySql_select_aluno);

                da_aluno.Fill(tbl_aluno);
                dgval4Semi.DataSource = tbl_aluno;
            }
            if (txtaln13Quar.Text == "" && txtaln15Quar.Text == "")
            {
                txtaln16Quar.Text = "";
            }
            if (txtaln13Quar.Text == "" && txtaln16Quar.Text == "")
            {
                txtaln15Quar.Text = "";
            }
            if (txtaln14Quar.Text == "" && txtaln15Quar.Text == "")
            {
                txtaln16Quar.Text = "";
            }
            if (txtaln14Quar.Text == "" && txtaln16Quar.Text == "")
            {
                txtaln15Quar.Text = "";
            }

            btnClassAln22.Enabled = false;
        }

        private void btnClassAln22_Click(object sender, EventArgs e)
        {
            if (txtaln15Quar.Text == "")
            {
                string nome_aluno = Convert.ToString(txtaln16Quar.Text);

                try
                {
                    MySqlConnection cone = new MySqlConnection(conexao);

                    string sql_update_aluno = @"update tb_semi_aluno_4 set tb_aluno_nome = @nome_aluno where tb_semi_id= 1";

                    MySqlCommand exeCmdMysl_update = new MySqlCommand(sql_update_aluno, cone);
                    exeCmdMysl_update.Parameters.AddWithValue("@nome_aluno", nome_aluno);

                    cone.Open();
                    exeCmdMysl_update.ExecuteNonQuery();
                    cone.Close();
                    MessageBox.Show("Feito!");

                }

                catch (Exception erro)
                {

                    MessageBox.Show("Ocorreu um erro em: " + erro);
                }

                MySqlConnection con = new MySqlConnection(conexao);
                con.Open();

                string sql_select_tb_aluno = @"select tb_aluno_nome as 'NOME' from tb_semi_aluno_4";

                MySqlCommand executacmdMySql_select_aluno = new MySqlCommand(sql_select_tb_aluno, con);

                executacmdMySql_select_aluno.ExecuteNonQuery();

                DataTable tbl_aluno = new DataTable();

                MySqlDataAdapter da_aluno = new MySqlDataAdapter(executacmdMySql_select_aluno);

                da_aluno.Fill(tbl_aluno);
                dgval4Semi.DataSource = tbl_aluno;
            }

            else if (txtaln16Quar.Text == "")
            {
                string nome_aluno = Convert.ToString(txtaln15Quar.Text);

                try
                {
                    MySqlConnection cone = new MySqlConnection(conexao);

                    string sql_update_aluno = @"update tb_semi_aluno_4 set tb_aluno_nome = @nome_aluno where tb_semi_id= 1";

                    MySqlCommand exeCmdMysl_update = new MySqlCommand(sql_update_aluno, cone);
                    exeCmdMysl_update.Parameters.AddWithValue("@nome_aluno", nome_aluno);

                    cone.Open();
                    exeCmdMysl_update.ExecuteNonQuery();
                    cone.Close();
                    MessageBox.Show("Feito!");

                }

                catch (Exception erro)
                {

                    MessageBox.Show("Ocorreu um erro em: " + erro);
                }

                MySqlConnection con = new MySqlConnection(conexao);
                con.Open();

                string sql_select_tb_aluno = @"select tb_aluno_nome as 'NOME' from tb_semi_aluno_4";

                MySqlCommand executacmdMySql_select_aluno = new MySqlCommand(sql_select_tb_aluno, con);

                executacmdMySql_select_aluno.ExecuteNonQuery();

                DataTable tbl_aluno = new DataTable();

                MySqlDataAdapter da_aluno = new MySqlDataAdapter(executacmdMySql_select_aluno);

                da_aluno.Fill(tbl_aluno);
                dgval4Semi.DataSource = tbl_aluno;
            }
            if (txtaln13Quar.Text == "" && txtaln15Quar.Text == "")
            {
                txtaln14Quar.Text = "";
            }
            if (txtaln13Quar.Text == "" && txtaln16Quar.Text == "")
            {
                txtaln14Quar.Text = "";
            }
            if (txtaln14Quar.Text == "" && txtaln15Quar.Text == "")
            {
                txtaln13Quar.Text = "";
            }
            if (txtaln14Quar.Text == "" && txtaln16Quar.Text == "")
            {
                txtaln13Quar.Text = "";
            }
            btnClassAln21.Enabled = false;
        }

        private void btnClassAln13_Click(object sender, EventArgs e)
        {
            if (txtaln1Quar.Text == "" && txtaln2Quar.Text == "" && txtaln3Quar.Text == "")
            {

                string nome_aluno = Convert.ToString(txtaln4Quar.Text);

                try
                {
                    MySqlConnection cone = new MySqlConnection(conexao);

                    string sql_update_aluno = @"update tb_final_aluno_1 set tb_aluno_nome = @nome_aluno where tb_final_id= 1";

                    MySqlCommand exeCmdMysl_update = new MySqlCommand(sql_update_aluno, cone);
                    exeCmdMysl_update.Parameters.AddWithValue("@nome_aluno", nome_aluno);

                    cone.Open();
                    exeCmdMysl_update.ExecuteNonQuery();
                    cone.Close();
                    MessageBox.Show("Feito!");

                }

                catch (Exception erro)
                {

                    MessageBox.Show("Ocorreu um erro em: " + erro);
                }

                MySqlConnection con = new MySqlConnection(conexao);
                con.Open();

                string sql_select_tb_aluno = @"select tb_aluno_nome as 'NOME' from tb_final_aluno_1";

                MySqlCommand executacmdMySql_select_aluno = new MySqlCommand(sql_select_tb_aluno, con);

                executacmdMySql_select_aluno.ExecuteNonQuery();

                DataTable tbl_aluno = new DataTable();

                MySqlDataAdapter da_aluno = new MySqlDataAdapter(executacmdMySql_select_aluno);

                da_aluno.Fill(tbl_aluno);
                dgval1Final.DataSource = tbl_aluno;
            }

            else if (txtaln2Quar.Text == "" && txtaln3Quar.Text == "" && txtaln4Quar.Text == "")
            {

                string nome_aluno = Convert.ToString(txtaln1Quar.Text);

                try
                {
                    MySqlConnection cone = new MySqlConnection(conexao);

                    string sql_update_aluno = @"update tb_final_aluno_1 set tb_aluno_nome = @nome_aluno where tb_final_id= 1";

                    MySqlCommand exeCmdMysl_update = new MySqlCommand(sql_update_aluno, cone);
                    exeCmdMysl_update.Parameters.AddWithValue("@nome_aluno", nome_aluno);

                    cone.Open();
                    exeCmdMysl_update.ExecuteNonQuery();
                    cone.Close();
                    MessageBox.Show("Feito!");

                }

                catch (Exception erro)
                {

                    MessageBox.Show("Ocorreu um erro em: " + erro);
                }

                MySqlConnection con = new MySqlConnection(conexao);
                con.Open();

                string sql_select_tb_aluno = @"select tb_aluno_nome as 'NOME' from tb_final_aluno_1";

                MySqlCommand executacmdMySql_select_aluno = new MySqlCommand(sql_select_tb_aluno, con);

                executacmdMySql_select_aluno.ExecuteNonQuery();

                DataTable tbl_aluno = new DataTable();

                MySqlDataAdapter da_aluno = new MySqlDataAdapter(executacmdMySql_select_aluno);

                da_aluno.Fill(tbl_aluno);
                dgval1Final.DataSource = tbl_aluno;
                btnClassAln17.Enabled = false;
            }

            else if (txtaln1Quar.Text == "" && txtaln4Quar.Text == "" && txtaln3Quar.Text == "")
            {

                string nome_aluno = Convert.ToString(txtaln2Quar.Text);

                try
                {
                    MySqlConnection cone = new MySqlConnection(conexao);

                    string sql_update_aluno = @"update tb_final_aluno_1 set tb_aluno_nome = @nome_aluno where tb_final_id= 1";

                    MySqlCommand exeCmdMysl_update = new MySqlCommand(sql_update_aluno, cone);
                    exeCmdMysl_update.Parameters.AddWithValue("@nome_aluno", nome_aluno);

                    cone.Open();
                    exeCmdMysl_update.ExecuteNonQuery();
                    cone.Close();
                    MessageBox.Show("Feito!");

                }

                catch (Exception erro)
                {

                    MessageBox.Show("Ocorreu um erro em: " + erro);
                }

                MySqlConnection con = new MySqlConnection(conexao);
                con.Open();

                string sql_select_tb_aluno = @"select tb_aluno_nome as 'NOME' from tb_final_aluno_1";

                MySqlCommand executacmdMySql_select_aluno = new MySqlCommand(sql_select_tb_aluno, con);

                executacmdMySql_select_aluno.ExecuteNonQuery();

                DataTable tbl_aluno = new DataTable();

                MySqlDataAdapter da_aluno = new MySqlDataAdapter(executacmdMySql_select_aluno);

                da_aluno.Fill(tbl_aluno);
                dgval1Final.DataSource = tbl_aluno;
            }

            else if (txtaln2Quar.Text == "" && txtaln1Quar.Text == "" && txtaln4Quar.Text == "")
            {

                string nome_aluno = Convert.ToString(txtaln3Quar.Text);

                try
                {
                    MySqlConnection cone = new MySqlConnection(conexao);

                    string sql_update_aluno = @"update tb_final_aluno_1 set tb_aluno_nome = @nome_aluno where tb_final_id= 1";

                    MySqlCommand exeCmdMysl_update = new MySqlCommand(sql_update_aluno, cone);
                    exeCmdMysl_update.Parameters.AddWithValue("@nome_aluno", nome_aluno);

                    cone.Open();
                    exeCmdMysl_update.ExecuteNonQuery();
                    cone.Close();
                    MessageBox.Show("Feito!");

                }

                catch (Exception erro)
                {

                    MessageBox.Show("Ocorreu um erro em: " + erro);
                }

                MySqlConnection con = new MySqlConnection(conexao);
                con.Open();

                string sql_select_tb_aluno = @"select tb_aluno_nome as 'NOME' from tb_final_aluno_1";

                MySqlCommand executacmdMySql_select_aluno = new MySqlCommand(sql_select_tb_aluno, con);

                executacmdMySql_select_aluno.ExecuteNonQuery();

                DataTable tbl_aluno = new DataTable();

                MySqlDataAdapter da_aluno = new MySqlDataAdapter(executacmdMySql_select_aluno);

                da_aluno.Fill(tbl_aluno);
                dgval1Final.DataSource = tbl_aluno;
            }
            btnClassAln17.Enabled = false;
        }

        private void btnClassAln17_Click(object sender, EventArgs e)
        {
            if (txtaln9Quar.Text == "" && txtaln10Quar.Text == "" && txtaln11Quar.Text == "")
            {

                string nome_aluno = Convert.ToString(txtaln12Quar.Text);

                try
                {
                    MySqlConnection cone = new MySqlConnection(conexao);

                    string sql_update_aluno = @"update tb_final_aluno_1 set tb_aluno_nome = @nome_aluno where tb_final_id= 1";

                    MySqlCommand exeCmdMysl_update = new MySqlCommand(sql_update_aluno, cone);
                    exeCmdMysl_update.Parameters.AddWithValue("@nome_aluno", nome_aluno);

                    cone.Open();
                    exeCmdMysl_update.ExecuteNonQuery();
                    cone.Close();
                    MessageBox.Show("Feito!");

                }

                catch (Exception erro)
                {

                    MessageBox.Show("Ocorreu um erro em: " + erro);
                }

                MySqlConnection con = new MySqlConnection(conexao);
                con.Open();

                string sql_select_tb_aluno = @"select tb_aluno_nome as 'NOME' from tb_final_aluno_1";

                MySqlCommand executacmdMySql_select_aluno = new MySqlCommand(sql_select_tb_aluno, con);

                executacmdMySql_select_aluno.ExecuteNonQuery();

                DataTable tbl_aluno = new DataTable();

                MySqlDataAdapter da_aluno = new MySqlDataAdapter(executacmdMySql_select_aluno);

                da_aluno.Fill(tbl_aluno);
                dgval1Final.DataSource = tbl_aluno;
            }

            else if (txtaln10Quar.Text == "" && txtaln11Quar.Text == "" && txtaln12Quar.Text == "")
            {

                string nome_aluno = Convert.ToString(txtaln9Quar.Text);

                try
                {
                    MySqlConnection cone = new MySqlConnection(conexao);

                    string sql_update_aluno = @"update tb_final_aluno_1 set tb_aluno_nome = @nome_aluno where tb_final_id= 1";

                    MySqlCommand exeCmdMysl_update = new MySqlCommand(sql_update_aluno, cone);
                    exeCmdMysl_update.Parameters.AddWithValue("@nome_aluno", nome_aluno);

                    cone.Open();
                    exeCmdMysl_update.ExecuteNonQuery();
                    cone.Close();
                    MessageBox.Show("Feito!");

                }

                catch (Exception erro)
                {

                    MessageBox.Show("Ocorreu um erro em: " + erro);
                }

                MySqlConnection con = new MySqlConnection(conexao);
                con.Open();

                string sql_select_tb_aluno = @"select tb_aluno_nome as 'NOME' from tb_final_aluno_1";

                MySqlCommand executacmdMySql_select_aluno = new MySqlCommand(sql_select_tb_aluno, con);

                executacmdMySql_select_aluno.ExecuteNonQuery();

                DataTable tbl_aluno = new DataTable();

                MySqlDataAdapter da_aluno = new MySqlDataAdapter(executacmdMySql_select_aluno);

                da_aluno.Fill(tbl_aluno);
                dgval1Final.DataSource = tbl_aluno;
            }

            else if (txtaln9Quar.Text == "" && txtaln12Quar.Text == "" && txtaln11Quar.Text == "")
            {

                string nome_aluno = Convert.ToString(txtaln10Quar.Text);

                try
                {
                    MySqlConnection cone = new MySqlConnection(conexao);

                    string sql_update_aluno = @"update tb_final_aluno_1 set tb_aluno_nome = @nome_aluno where tb_final_id= 2";

                    MySqlCommand exeCmdMysl_update = new MySqlCommand(sql_update_aluno, cone);
                    exeCmdMysl_update.Parameters.AddWithValue("@nome_aluno", nome_aluno);

                    cone.Open();
                    exeCmdMysl_update.ExecuteNonQuery();
                    cone.Close();
                    MessageBox.Show("Feito!");

                }

                catch (Exception erro)
                {

                    MessageBox.Show("Ocorreu um erro em: " + erro);
                }

                MySqlConnection con = new MySqlConnection(conexao);
                con.Open();

                string sql_select_tb_aluno = @"select tb_aluno_nome as 'NOME' from tb_final_aluno_1";

                MySqlCommand executacmdMySql_select_aluno = new MySqlCommand(sql_select_tb_aluno, con);

                executacmdMySql_select_aluno.ExecuteNonQuery();

                DataTable tbl_aluno = new DataTable();

                MySqlDataAdapter da_aluno = new MySqlDataAdapter(executacmdMySql_select_aluno);

                da_aluno.Fill(tbl_aluno);
                dgval1Final.DataSource = tbl_aluno;
            }

            else if (txtaln10Quar.Text == "" && txtaln9Quar.Text == "" && txtaln12Quar.Text == "")
            {

                string nome_aluno = Convert.ToString(txtaln11Quar.Text);

                try
                {
                    MySqlConnection cone = new MySqlConnection(conexao);

                    string sql_update_aluno = @"update tb_final_aluno_2 set tb_aluno_nome = @nome_aluno where tb_final_id= 1";

                    MySqlCommand exeCmdMysl_update = new MySqlCommand(sql_update_aluno, cone);
                    exeCmdMysl_update.Parameters.AddWithValue("@nome_aluno", nome_aluno);

                    cone.Open();
                    exeCmdMysl_update.ExecuteNonQuery();
                    cone.Close();
                    MessageBox.Show("Feito!");

                }

                catch (Exception erro)
                {

                    MessageBox.Show("Ocorreu um erro em: " + erro);
                }

                MySqlConnection con = new MySqlConnection(conexao);
                con.Open();

                string sql_select_tb_aluno = @"select tb_aluno_nome as 'NOME' from tb_final_aluno_2";

                MySqlCommand executacmdMySql_select_aluno = new MySqlCommand(sql_select_tb_aluno, con);

                executacmdMySql_select_aluno.ExecuteNonQuery();

                DataTable tbl_aluno = new DataTable();

                MySqlDataAdapter da_aluno = new MySqlDataAdapter(executacmdMySql_select_aluno);

                da_aluno.Fill(tbl_aluno);
                dgval1Final.DataSource = tbl_aluno;
            }
            btnClassAln13.Enabled = false;
        }

        private void btnClassAln16_Click(object sender, EventArgs e)
        {
            if (txtaln5Quar.Text == "" && txtaln6Quar.Text == "" && txtaln7Quar.Text == "")
            {

                string nome_aluno = Convert.ToString(txtaln8Quar.Text);

                try
                {
                    MySqlConnection cone = new MySqlConnection(conexao);

                    string sql_update_aluno = @"update tb_final_aluno_2 set tb_aluno_nome = @nome_aluno where tb_final_id= 1";

                    MySqlCommand exeCmdMysl_update = new MySqlCommand(sql_update_aluno, cone);
                    exeCmdMysl_update.Parameters.AddWithValue("@nome_aluno", nome_aluno);
                    cone.Open();
                    exeCmdMysl_update.ExecuteNonQuery();
                    cone.Close();
                    MessageBox.Show("Feito!");

                }

                catch (Exception erro)
                {

                    MessageBox.Show("Ocorreu um erro em: " + erro);
                }

                MySqlConnection con = new MySqlConnection(conexao);
                con.Open();

                string sql_select_tb_aluno = @"select tb_aluno_nome as 'NOME' from tb_final_aluno_2";

                MySqlCommand executacmdMySql_select_aluno = new MySqlCommand(sql_select_tb_aluno, con);

                executacmdMySql_select_aluno.ExecuteNonQuery();

                DataTable tbl_aluno = new DataTable();

                MySqlDataAdapter da_aluno = new MySqlDataAdapter(executacmdMySql_select_aluno);

                da_aluno.Fill(tbl_aluno);
                dgval2Final.DataSource = tbl_aluno;
            }

            else if (txtaln6Quar.Text == "" && txtaln7Quar.Text == "" && txtaln8Quar.Text == "")
            {

                string nome_aluno = Convert.ToString(txtaln5Quar.Text);

                try
                {
                    MySqlConnection cone = new MySqlConnection(conexao);

                    string sql_update_aluno = @"update tb_final_aluno_2 set tb_aluno_nome = @nome_aluno where tb_final_id= 1";

                    MySqlCommand exeCmdMysl_update = new MySqlCommand(sql_update_aluno, cone);
                    exeCmdMysl_update.Parameters.AddWithValue("@nome_aluno", nome_aluno);

                    cone.Open();
                    exeCmdMysl_update.ExecuteNonQuery();
                    cone.Close();
                    MessageBox.Show("Feito!");

                }

                catch (Exception erro)
                {

                    MessageBox.Show("Ocorreu um erro em: " + erro);
                }

                MySqlConnection con = new MySqlConnection(conexao);
                con.Open();

                string sql_select_tb_aluno = @"select tb_aluno_nome as 'NOME' from tb_final_aluno_2";

                MySqlCommand executacmdMySql_select_aluno = new MySqlCommand(sql_select_tb_aluno, con);

                executacmdMySql_select_aluno.ExecuteNonQuery();

                DataTable tbl_aluno = new DataTable();

                MySqlDataAdapter da_aluno = new MySqlDataAdapter(executacmdMySql_select_aluno);

                da_aluno.Fill(tbl_aluno);
                dgval2Final.DataSource = tbl_aluno;
            }

            else if (txtaln5Quar.Text == "" && txtaln8Quar.Text == "" && txtaln7Quar.Text == "")
            {

                string nome_aluno = Convert.ToString(txtaln6Quar.Text);

                try
                {
                    MySqlConnection cone = new MySqlConnection(conexao);

                    string sql_update_aluno = @"update tb_final_aluno_2 set tb_aluno_nome = @nome_aluno where tb_final_id= 1";

                    MySqlCommand exeCmdMysl_update = new MySqlCommand(sql_update_aluno, cone);
                    exeCmdMysl_update.Parameters.AddWithValue("@nome_aluno", nome_aluno);

                    cone.Open();
                    exeCmdMysl_update.ExecuteNonQuery();
                    cone.Close();
                    MessageBox.Show("Feito!");

                }

                catch (Exception erro)
                {

                    MessageBox.Show("Ocorreu um erro em: " + erro);
                }

                MySqlConnection con = new MySqlConnection(conexao);
                con.Open();

                string sql_select_tb_aluno = @"select tb_aluno_nome as 'NOME' from tb_final_aluno_2";

                MySqlCommand executacmdMySql_select_aluno = new MySqlCommand(sql_select_tb_aluno, con);

                executacmdMySql_select_aluno.ExecuteNonQuery();

                DataTable tbl_aluno = new DataTable();

                MySqlDataAdapter da_aluno = new MySqlDataAdapter(executacmdMySql_select_aluno);

                da_aluno.Fill(tbl_aluno);
                dgval2Final.DataSource = tbl_aluno;
            }

            else if (txtaln6Quar.Text == "" && txtaln5Quar.Text == "" && txtaln8Quar.Text == "")
            {

                string nome_aluno = Convert.ToString(txtaln7Quar.Text);

                try
                {
                    MySqlConnection cone = new MySqlConnection(conexao);

                    string sql_update_aluno = @"update tb_final_aluno_2 set tb_aluno_nome = @nome_aluno where tb_final_id= 1";

                    MySqlCommand exeCmdMysl_update = new MySqlCommand(sql_update_aluno, cone);
                    exeCmdMysl_update.Parameters.AddWithValue("@nome_aluno", nome_aluno);

                    cone.Open();
                    exeCmdMysl_update.ExecuteNonQuery();
                    cone.Close();
                    MessageBox.Show("Feito!");

                }

                catch (Exception erro)
                {

                    MessageBox.Show("Ocorreu um erro em: " + erro);
                }

                MySqlConnection con = new MySqlConnection(conexao);
                con.Open();

                string sql_select_tb_aluno = @"select tb_aluno_nome as 'NOME' from tb_final_aluno_2";

                MySqlCommand executacmdMySql_select_aluno = new MySqlCommand(sql_select_tb_aluno, con);

                executacmdMySql_select_aluno.ExecuteNonQuery();

                DataTable tbl_aluno = new DataTable();

                MySqlDataAdapter da_aluno = new MySqlDataAdapter(executacmdMySql_select_aluno);

                da_aluno.Fill(tbl_aluno);
                dgval2Final.DataSource = tbl_aluno;
            }
            btnClassAln18.Enabled = false;
        }

        private void btnClassAln18_Click(object sender, EventArgs e)
        {
            if (txtaln13Quar.Text == "" && txtaln14Quar.Text == "" && txtaln15Quar.Text == "")
            {

                string nome_aluno = Convert.ToString(txtaln16Quar.Text);

                try
                {
                    MySqlConnection cone = new MySqlConnection(conexao);

                    string sql_update_aluno = @"update tb_final_aluno_2 set tb_aluno_nome = @nome_aluno where tb_final_id= 1";

                    MySqlCommand exeCmdMysl_update = new MySqlCommand(sql_update_aluno, cone);
                    exeCmdMysl_update.Parameters.AddWithValue("@nome_aluno", nome_aluno);

                    cone.Open();
                    exeCmdMysl_update.ExecuteNonQuery();
                    cone.Close();
                    MessageBox.Show("Feito!");

                }

                catch (Exception erro)
                {

                    MessageBox.Show("Ocorreu um erro em: " + erro);
                }

                MySqlConnection con = new MySqlConnection(conexao);
                con.Open();

                string sql_select_tb_aluno = @"select tb_aluno_nome as 'NOME' from tb_final_aluno_2";

                MySqlCommand executacmdMySql_select_aluno = new MySqlCommand(sql_select_tb_aluno, con);

                executacmdMySql_select_aluno.ExecuteNonQuery();

                DataTable tbl_aluno = new DataTable();

                MySqlDataAdapter da_aluno = new MySqlDataAdapter(executacmdMySql_select_aluno);

                da_aluno.Fill(tbl_aluno);
                dgval2Final.DataSource = tbl_aluno;
            }

            else if (txtaln14Quar.Text == "" && txtaln15Quar.Text == "" && txtaln16Quar.Text == "")
            {

                string nome_aluno = Convert.ToString(txtaln13Quar.Text);

                try
                {
                    MySqlConnection cone = new MySqlConnection(conexao);

                    string sql_update_aluno = @"update tb_final_aluno_2 set tb_aluno_nome = @nome_aluno where tb_final_id= 1";

                    MySqlCommand exeCmdMysl_update = new MySqlCommand(sql_update_aluno, cone);
                    exeCmdMysl_update.Parameters.AddWithValue("@nome_aluno", nome_aluno);

                    cone.Open();
                    exeCmdMysl_update.ExecuteNonQuery();
                    cone.Close();
                    MessageBox.Show("Feito!");

                }

                catch (Exception erro)
                {

                    MessageBox.Show("Ocorreu um erro em: " + erro);
                }

                MySqlConnection con = new MySqlConnection(conexao);
                con.Open();

                string sql_select_tb_aluno = @"select tb_aluno_nome as 'NOME' from tb_final_aluno_2";

                MySqlCommand executacmdMySql_select_aluno = new MySqlCommand(sql_select_tb_aluno, con);

                executacmdMySql_select_aluno.ExecuteNonQuery();

                DataTable tbl_aluno = new DataTable();

                MySqlDataAdapter da_aluno = new MySqlDataAdapter(executacmdMySql_select_aluno);

                da_aluno.Fill(tbl_aluno);
                dgval2Final.DataSource = tbl_aluno;
            }

            else if (txtaln13Quar.Text == "" && txtaln16Quar.Text == "" && txtaln15Quar.Text == "")
            {

                string nome_aluno = Convert.ToString(txtaln14Quar.Text);

                try
                {
                    MySqlConnection cone = new MySqlConnection(conexao);

                    string sql_update_aluno = @"update tb_final_aluno_2 set tb_aluno_nome = @nome_aluno where tb_final_id= 1";

                    MySqlCommand exeCmdMysl_update = new MySqlCommand(sql_update_aluno, cone);
                    exeCmdMysl_update.Parameters.AddWithValue("@nome_aluno", nome_aluno);

                    cone.Open();
                    exeCmdMysl_update.ExecuteNonQuery();
                    cone.Close();
                    MessageBox.Show("Feito!");

                }

                catch (Exception erro)
                {

                    MessageBox.Show("Ocorreu um erro em: " + erro);
                }

                MySqlConnection con = new MySqlConnection(conexao);
                con.Open();

                string sql_select_tb_aluno = @"select tb_aluno_nome as 'NOME' from tb_final_aluno_2";

                MySqlCommand executacmdMySql_select_aluno = new MySqlCommand(sql_select_tb_aluno, con);

                executacmdMySql_select_aluno.ExecuteNonQuery();

                DataTable tbl_aluno = new DataTable();

                MySqlDataAdapter da_aluno = new MySqlDataAdapter(executacmdMySql_select_aluno);

                da_aluno.Fill(tbl_aluno);
                dgval2Final.DataSource = tbl_aluno;
            }

            else if (txtaln14Quar.Text == "" && txtaln13Quar.Text == "" && txtaln16Quar.Text == "")
            {

                string nome_aluno = Convert.ToString(txtaln3Quar.Text);

                try
                {
                    MySqlConnection cone = new MySqlConnection(conexao);

                    string sql_update_aluno = @"update tb_final_aluno_2 set tb_aluno_nome = @nome_aluno where tb_final_id= 1";

                    MySqlCommand exeCmdMysl_update = new MySqlCommand(sql_update_aluno, cone);
                    exeCmdMysl_update.Parameters.AddWithValue("@nome_aluno", nome_aluno);

                    cone.Open();
                    exeCmdMysl_update.ExecuteNonQuery();
                    cone.Close();
                    MessageBox.Show("Feito!");

                }

                catch (Exception erro)
                {

                    MessageBox.Show("Ocorreu um erro em: " + erro);
                }

                MySqlConnection con = new MySqlConnection(conexao);
                con.Open();

                string sql_select_tb_aluno = @"select tb_aluno_nome as 'NOME' from tb_final_aluno_2";

                MySqlCommand executacmdMySql_select_aluno = new MySqlCommand(sql_select_tb_aluno, con);

                executacmdMySql_select_aluno.ExecuteNonQuery();

                DataTable tbl_aluno = new DataTable();

                MySqlDataAdapter da_aluno = new MySqlDataAdapter(executacmdMySql_select_aluno);

                da_aluno.Fill(tbl_aluno);
                dgval2Final.DataSource = tbl_aluno;
            }
            btnClassAln16.Enabled = false;
        }

        private void btnClassAln14_Click(object sender, EventArgs e)
        {
            Cadastro_finalistas cf = new Cadastro_finalistas();
            cf.ShowDialog();
        }

        private void btnClassAln15_Click(object sender, EventArgs e)
        {
            Cadastro_finalistas cf = new Cadastro_finalistas();
            cf.ShowDialog();
        }

        private void btnReiniVlres_Click(object sender, EventArgs e)
        {
            try
            {
                MySqlConnection conCarrtab = new MySqlConnection(conexao);
                conCarrtab.Open();
                string sql_update_tab_1 = @"update tb_oitavas_aluno_1 set tb_aluno_nome='Nome do Aluno' where tb_oitavas_id=1";
                string sql_update_tab_2 = @"update tb_oitavas_aluno_2 set tb_aluno_nome='Nome do Aluno' where tb_oitavas_id=1";
                string sql_update_tab_3 = @"update tb_oitavas_aluno_3 set tb_aluno_nome='Nome do Aluno' where tb_oitavas_id=1";
                string sql_update_tab_4 = @"update tb_oitavas_aluno_4 set tb_aluno_nome='Nome do Aluno' where tb_oitavas_id=1";
                string sql_update_tab_5 = @"update tb_oitavas_aluno_5 set tb_aluno_nome='Nome do Aluno' where tb_oitavas_id=1";
                string sql_update_tab_6 = @"update tb_oitavas_aluno_6 set tb_aluno_nome='Nome do Aluno' where tb_oitavas_id=1";
                string sql_update_tab_7 = @"update tb_oitavas_aluno_7 set tb_aluno_nome='Nome do Aluno' where tb_oitavas_id=1";
                string sql_update_tab_8 = @"update tb_oitavas_aluno_8 set tb_aluno_nome='Nome do Aluno' where tb_oitavas_id=1";
                string sql_update_tab_9 = @"update tb_oitavas_aluno_9 set tb_aluno_nome='Nome do Aluno' where tb_oitavas_id=1";
                string sql_update_tab_10 = @"update tb_oitavas_aluno_10 set tb_aluno_nome='Nome do Aluno' where tb_oitavas_id=1";
                string sql_update_tab_11 = @"update tb_oitavas_aluno_11 set tb_aluno_nome='Nome do Aluno' where tb_oitavas_id=1";
                string sql_update_tab_12 = @"update tb_oitavas_aluno_12 set tb_aluno_nome='Nome do Aluno' where tb_oitavas_id=1";
                string sql_update_tab_13 = @"update tb_oitavas_aluno_13 set tb_aluno_nome='Nome do Aluno' where tb_oitavas_id=1";
                string sql_update_tab_14 = @"update tb_oitavas_aluno_14 set tb_aluno_nome='Nome do Aluno' where tb_oitavas_id=1";
                string sql_update_tab_15 = @"update tb_oitavas_aluno_15 set tb_aluno_nome='Nome do Aluno' where tb_oitavas_id=1";
                string sql_update_tab_16 = @"update tb_oitavas_aluno_16 set tb_aluno_nome='Nome do Aluno' where tb_oitavas_id=1";

                MySqlCommand executacmdMySql_update_aluno1 = new MySqlCommand(sql_update_tab_1, conCarrtab); executacmdMySql_update_aluno1.ExecuteNonQuery();
                MySqlCommand executacmdMySql_update_aluno2 = new MySqlCommand(sql_update_tab_2, conCarrtab); executacmdMySql_update_aluno2.ExecuteNonQuery();
                MySqlCommand executacmdMySql_update_aluno3 = new MySqlCommand(sql_update_tab_3, conCarrtab); executacmdMySql_update_aluno3.ExecuteNonQuery();
                MySqlCommand executacmdMySql_update_aluno4 = new MySqlCommand(sql_update_tab_4, conCarrtab); executacmdMySql_update_aluno4.ExecuteNonQuery();
                MySqlCommand executacmdMySql_update_aluno5 = new MySqlCommand(sql_update_tab_5, conCarrtab); executacmdMySql_update_aluno5.ExecuteNonQuery();
                MySqlCommand executacmdMySql_update_aluno6 = new MySqlCommand(sql_update_tab_6, conCarrtab); executacmdMySql_update_aluno6.ExecuteNonQuery();
                MySqlCommand executacmdMySql_update_aluno7 = new MySqlCommand(sql_update_tab_7, conCarrtab); executacmdMySql_update_aluno7.ExecuteNonQuery();
                MySqlCommand executacmdMySql_update_aluno8 = new MySqlCommand(sql_update_tab_8, conCarrtab); executacmdMySql_update_aluno8.ExecuteNonQuery();
                MySqlCommand executacmdMySql_update_aluno9 = new MySqlCommand(sql_update_tab_9, conCarrtab); executacmdMySql_update_aluno9.ExecuteNonQuery();
                MySqlCommand executacmdMySql_update_aluno10 = new MySqlCommand(sql_update_tab_10, conCarrtab); executacmdMySql_update_aluno10.ExecuteNonQuery();
                MySqlCommand executacmdMySql_update_aluno11 = new MySqlCommand(sql_update_tab_11, conCarrtab); executacmdMySql_update_aluno11.ExecuteNonQuery();
                MySqlCommand executacmdMySql_update_aluno12 = new MySqlCommand(sql_update_tab_12, conCarrtab); executacmdMySql_update_aluno12.ExecuteNonQuery();
                MySqlCommand executacmdMySql_update_aluno13 = new MySqlCommand(sql_update_tab_13, conCarrtab); executacmdMySql_update_aluno13.ExecuteNonQuery();
                MySqlCommand executacmdMySql_update_aluno14 = new MySqlCommand(sql_update_tab_14, conCarrtab); executacmdMySql_update_aluno14.ExecuteNonQuery();
                MySqlCommand executacmdMySql_update_aluno15 = new MySqlCommand(sql_update_tab_15, conCarrtab); executacmdMySql_update_aluno15.ExecuteNonQuery();
                MySqlCommand executacmdMySql_update_aluno16 = new MySqlCommand(sql_update_tab_16, conCarrtab); executacmdMySql_update_aluno16.ExecuteNonQuery();
                conCarrtab.Close();
            }
            catch (Exception erro) { MessageBox.Show("" + erro); }


            MySqlConnection con1 = new MySqlConnection(conexao);
            con1.Open();

            string sql_select_tb_aluno1 = @"select tb_aluno_nome as 'NOME' from tb_oitavas_aluno_1";

            MySqlCommand executacmdMySql_select_aluno1 = new MySqlCommand(sql_select_tb_aluno1, con1);

            executacmdMySql_select_aluno1.ExecuteNonQuery();

            DataTable tbl_aluno1 = new DataTable();

            MySqlDataAdapter da_aluno1 = new MySqlDataAdapter(executacmdMySql_select_aluno1);

            da_aluno1.Fill(tbl_aluno1);
            dgval1Oita.DataSource = tbl_aluno1;


            MySqlConnection cone = new MySqlConnection(conexao);
            cone.Open();

            string sql_select_tb_aluno2 = @"select tb_aluno_nome as 'NOME' from tb_oitavas_aluno_2";

            MySqlCommand executacmdMySql_select_aluno2 = new MySqlCommand(sql_select_tb_aluno2, cone);

            executacmdMySql_select_aluno2.ExecuteNonQuery();

            DataTable tbl_aluno2 = new DataTable();

            MySqlDataAdapter da_aluno2 = new MySqlDataAdapter(executacmdMySql_select_aluno2);

            da_aluno2.Fill(tbl_aluno2);
            dgval2Oita.DataSource = tbl_aluno2;


            MySqlConnection con3 = new MySqlConnection(conexao);
            con3.Open();

            string sql_select_tb_aluno3 = @"select tb_aluno_nome as 'NOME' from tb_oitavas_aluno_3";

            MySqlCommand executacmdMySql_select_aluno3 = new MySqlCommand(sql_select_tb_aluno3, con3);

            executacmdMySql_select_aluno3.ExecuteNonQuery();

            DataTable tbl_aluno3 = new DataTable();

            MySqlDataAdapter da_aluno3 = new MySqlDataAdapter(executacmdMySql_select_aluno3);

            da_aluno3.Fill(tbl_aluno3);
            dgval3Oita.DataSource = tbl_aluno3;


            MySqlConnection con4 = new MySqlConnection(conexao);
            con4.Open();

            string sql_select_tb_aluno4 = @"select tb_aluno_nome as 'NOME' from tb_oitavas_aluno_4";

            MySqlCommand executacmdMySql_select_aluno4 = new MySqlCommand(sql_select_tb_aluno4, con4);

            executacmdMySql_select_aluno4.ExecuteNonQuery();

            DataTable tbl_aluno4 = new DataTable();

            MySqlDataAdapter da_aluno4 = new MySqlDataAdapter(executacmdMySql_select_aluno4);

            da_aluno4.Fill(tbl_aluno4);
            dgval4Oita.DataSource = tbl_aluno4;

            MySqlConnection con5 = new MySqlConnection(conexao);
            con5.Open();

            string sql_select_tb_aluno5 = @"select tb_aluno_nome as 'NOME' from tb_oitavas_aluno_5";

            MySqlCommand executacmdMySql_select_aluno5 = new MySqlCommand(sql_select_tb_aluno5, con5);

            executacmdMySql_select_aluno5.ExecuteNonQuery();

            DataTable tbl_aluno5 = new DataTable();

            MySqlDataAdapter da_aluno5 = new MySqlDataAdapter(executacmdMySql_select_aluno5);

            da_aluno5.Fill(tbl_aluno5);
            dgval5Oita.DataSource = tbl_aluno5;

            MySqlConnection con6 = new MySqlConnection(conexao);
            con6.Open();

            string sql_select_tb_aluno6 = @"select tb_aluno_nome as 'NOME' from tb_oitavas_aluno_6";

            MySqlCommand executacmdMySql_select_aluno6 = new MySqlCommand(sql_select_tb_aluno6, con6);

            executacmdMySql_select_aluno6.ExecuteNonQuery();

            DataTable tbl_aluno6 = new DataTable();

            MySqlDataAdapter da_aluno6 = new MySqlDataAdapter(executacmdMySql_select_aluno6);

            da_aluno6.Fill(tbl_aluno6);
            dgval6Oita.DataSource = tbl_aluno6;

            MySqlConnection con7 = new MySqlConnection(conexao);
            con7.Open();

            string sql_select_tb_aluno7 = @"select tb_aluno_nome as 'NOME' from tb_oitavas_aluno_7";

            MySqlCommand executacmdMySql_select_aluno7 = new MySqlCommand(sql_select_tb_aluno7, con7);

            executacmdMySql_select_aluno7.ExecuteNonQuery();

            DataTable tbl_aluno7 = new DataTable();

            MySqlDataAdapter da_aluno7 = new MySqlDataAdapter(executacmdMySql_select_aluno7);

            da_aluno7.Fill(tbl_aluno7);
            dgval7Oita.DataSource = tbl_aluno7;

            MySqlConnection con8 = new MySqlConnection(conexao);
            con8.Open();

            string sql_select_tb_aluno8 = @"select tb_aluno_nome as 'NOME' from tb_oitavas_aluno_8";

            MySqlCommand executacmdMySql_select_aluno8 = new MySqlCommand(sql_select_tb_aluno8, con8);

            executacmdMySql_select_aluno8.ExecuteNonQuery();

            DataTable tbl_aluno8 = new DataTable();

            MySqlDataAdapter da_aluno8 = new MySqlDataAdapter(executacmdMySql_select_aluno8);

            da_aluno8.Fill(tbl_aluno8);
            dgval8Oita.DataSource = tbl_aluno8;

            MySqlConnection con9 = new MySqlConnection(conexao);
            con9.Open();

            string sql_select_tb_aluno9 = @"select tb_aluno_nome as 'NOME' from tb_oitavas_aluno_9";

            MySqlCommand executacmdMySql_select_aluno9 = new MySqlCommand(sql_select_tb_aluno9, con9);

            executacmdMySql_select_aluno9.ExecuteNonQuery();

            DataTable tbl_aluno9 = new DataTable();

            MySqlDataAdapter da_aluno9 = new MySqlDataAdapter(executacmdMySql_select_aluno9);

            da_aluno9.Fill(tbl_aluno9);
            dgval9Oita.DataSource = tbl_aluno9;

            MySqlConnection con10 = new MySqlConnection(conexao);
            con10.Open();

            string sql_select_tb_aluno10 = @"select tb_aluno_nome as 'NOME' from tb_oitavas_aluno_10";

            MySqlCommand executacmdMySql_select_aluno10 = new MySqlCommand(sql_select_tb_aluno10, con10);

            executacmdMySql_select_aluno10.ExecuteNonQuery();

            DataTable tbl_aluno10 = new DataTable();

            MySqlDataAdapter da_aluno10 = new MySqlDataAdapter(executacmdMySql_select_aluno10);

            da_aluno10.Fill(tbl_aluno10);
            dgval10Oita.DataSource = tbl_aluno10;

            MySqlConnection con11 = new MySqlConnection(conexao);
            con11.Open();

            string sql_select_tb_aluno11 = @"select tb_aluno_nome as 'NOME' from tb_oitavas_aluno_11";

            MySqlCommand executacmdMySql_select_aluno11 = new MySqlCommand(sql_select_tb_aluno11, con11);

            executacmdMySql_select_aluno11.ExecuteNonQuery();

            DataTable tbl_aluno11 = new DataTable();

            MySqlDataAdapter da_aluno11 = new MySqlDataAdapter(executacmdMySql_select_aluno11);

            da_aluno11.Fill(tbl_aluno11);
            dgval11Oita.DataSource = tbl_aluno11;

            MySqlConnection con12 = new MySqlConnection(conexao);
            con12.Open();

            string sql_select_tb_aluno12 = @"select tb_aluno_nome as 'NOME' from tb_oitavas_aluno_12";

            MySqlCommand executacmdMySql_select_aluno12 = new MySqlCommand(sql_select_tb_aluno12, con12);

            executacmdMySql_select_aluno12.ExecuteNonQuery();

            DataTable tbl_aluno12 = new DataTable();

            MySqlDataAdapter da_aluno12 = new MySqlDataAdapter(executacmdMySql_select_aluno12);

            da_aluno12.Fill(tbl_aluno12);
            dgval12Oita.DataSource = tbl_aluno12;

            MySqlConnection con13 = new MySqlConnection(conexao);
            con13.Open();

            string sql_select_tb_aluno13 = @"select tb_aluno_nome as 'NOME' from tb_oitavas_aluno_13";

            MySqlCommand executacmdMySql_select_aluno13 = new MySqlCommand(sql_select_tb_aluno13, con13);

            executacmdMySql_select_aluno13.ExecuteNonQuery();

            DataTable tbl_aluno13 = new DataTable();

            MySqlDataAdapter da_aluno13 = new MySqlDataAdapter(executacmdMySql_select_aluno13);

            da_aluno13.Fill(tbl_aluno13);
            dgval13Oita.DataSource = tbl_aluno13;

            MySqlConnection con14 = new MySqlConnection(conexao);
            con14.Open();

            string sql_select_tb_aluno14 = @"select tb_aluno_nome as 'NOME' from tb_oitavas_aluno_14";

            MySqlCommand executacmdMySql_select_aluno14 = new MySqlCommand(sql_select_tb_aluno14, con14);

            executacmdMySql_select_aluno14.ExecuteNonQuery();

            DataTable tbl_aluno14 = new DataTable();

            MySqlDataAdapter da_aluno14 = new MySqlDataAdapter(executacmdMySql_select_aluno14);

            da_aluno14.Fill(tbl_aluno14);
            dgval14Oita.DataSource = tbl_aluno14;

            MySqlConnection con15 = new MySqlConnection(conexao);
            con15.Open();

            string sql_select_tb_aluno15 = @"select tb_aluno_nome as 'NOME' from tb_oitavas_aluno_15";

            MySqlCommand executacmdMySql_select_aluno15 = new MySqlCommand(sql_select_tb_aluno15, con15);

            executacmdMySql_select_aluno15.ExecuteNonQuery();

            DataTable tbl_aluno15 = new DataTable();

            MySqlDataAdapter da_aluno15 = new MySqlDataAdapter(executacmdMySql_select_aluno15);

            da_aluno15.Fill(tbl_aluno15);
            dgval15Oita.DataSource = tbl_aluno15;

            MySqlConnection con16 = new MySqlConnection(conexao);
            con16.Open();

            string sql_select_tb_aluno16 = @"select tb_aluno_nome as 'NOME' from tb_oitavas_aluno_16";

            MySqlCommand executacmdMySql_select_aluno16 = new MySqlCommand(sql_select_tb_aluno16, con16);

            executacmdMySql_select_aluno16.ExecuteNonQuery();

            DataTable tbl_aluno16 = new DataTable();

            MySqlDataAdapter da_aluno16 = new MySqlDataAdapter(executacmdMySql_select_aluno16);

            da_aluno16.Fill(tbl_aluno16);
            dgval16Oita.DataSource = tbl_aluno16;

        }

        private void btnInsertAln1_Click(object sender, EventArgs e)
        {
            string nome_aluno = Convert.ToString(txtaln1Quar.Text);

            try
            {
                MySqlConnection cone = new MySqlConnection(conexao);

                string sql_update_aluno = @"update tb_oitavas_aluno_1 set tb_aluno_nome = @nome_aluno where tb_oitavas_id= 1";

                MySqlCommand exeCmdMysl_update = new MySqlCommand(sql_update_aluno, cone);

                exeCmdMysl_update.Parameters.AddWithValue("@nome_aluno", nome_aluno);

                cone.Open();
                exeCmdMysl_update.ExecuteNonQuery();
                cone.Close();
                MessageBox.Show("Feito!");
                txtaln1Quar.Enabled = false;


            }

            catch (Exception erro)
            {

                MessageBox.Show("Ocorreu um erro em: " + erro);
            }

            MySqlConnection con = new MySqlConnection(conexao);
            con.Open();

            string sql_select_tb_aluno = @"select tb_aluno_nome as 'NOME' from tb_oitavas_aluno_1";

            MySqlCommand executacmdMySql_select_aluno = new MySqlCommand(sql_select_tb_aluno, con);

            executacmdMySql_select_aluno.ExecuteNonQuery();

            DataTable tbl_aluno = new DataTable();

            MySqlDataAdapter da_aluno = new MySqlDataAdapter(executacmdMySql_select_aluno);

            da_aluno.Fill(tbl_aluno);
            dgval1Oita.DataSource = tbl_aluno;
        }

        private void btnInsertAln3_Click(object sender, EventArgs e)
        {
            string nome_aluno = Convert.ToString(txtaln3Quar.Text);

            try
            {
                MySqlConnection cone = new MySqlConnection(conexao);

                string sql_update_aluno = @"update tb_oitavas_aluno_3 set tb_aluno_nome = @nome_aluno where tb_oitavas_id= 1";

                MySqlCommand exeCmdMysl_update = new MySqlCommand(sql_update_aluno, cone);

                exeCmdMysl_update.Parameters.AddWithValue("@nome_aluno", nome_aluno);

                cone.Open();
                exeCmdMysl_update.ExecuteNonQuery();
                cone.Close();
                MessageBox.Show("Feito!");
                txtaln3Quar.Enabled = false;
            }

            catch (Exception erro)
            {

                MessageBox.Show("Ocorreu um erro em: " + erro);
            }

            MySqlConnection con = new MySqlConnection(conexao);
            con.Open();

            string sql_select_tb_aluno = @"select tb_aluno_nome as 'NOME' from tb_oitavas_aluno_3";

            MySqlCommand executacmdMySql_select_aluno = new MySqlCommand(sql_select_tb_aluno, con);

            executacmdMySql_select_aluno.ExecuteNonQuery();

            DataTable tbl_aluno = new DataTable();

            MySqlDataAdapter da_aluno = new MySqlDataAdapter(executacmdMySql_select_aluno);

            da_aluno.Fill(tbl_aluno);
            dgval3Oita.DataSource = tbl_aluno;
        }

        private void btnInsertAln2_Click(object sender, EventArgs e)
        {
            string nome_aluno = Convert.ToString(txtaln2Quar.Text);

            try
            {
                MySqlConnection cone = new MySqlConnection(conexao);

                string sql_update_aluno = @"update tb_oitavas_aluno_2 set tb_aluno_nome = @nome_aluno where tb_oitavas_id= 1";

                MySqlCommand exeCmdMysl_update = new MySqlCommand(sql_update_aluno, cone);

                exeCmdMysl_update.Parameters.AddWithValue("@nome_aluno", nome_aluno);

                cone.Open();
                exeCmdMysl_update.ExecuteNonQuery();
                cone.Close();
                MessageBox.Show("Feito!");
                txtaln2Quar.Enabled = false;
            }

            catch (Exception erro)
            {

                MessageBox.Show("Ocorreu um erro em: " + erro);
            }

            MySqlConnection con = new MySqlConnection(conexao);
            con.Open();

            string sql_select_tb_aluno = @"select tb_aluno_nome as 'NOME' from tb_oitavas_aluno_2";

            MySqlCommand executacmdMySql_select_aluno = new MySqlCommand(sql_select_tb_aluno, con);

            executacmdMySql_select_aluno.ExecuteNonQuery();

            DataTable tbl_aluno = new DataTable();

            MySqlDataAdapter da_aluno = new MySqlDataAdapter(executacmdMySql_select_aluno);

            da_aluno.Fill(tbl_aluno);
            dgval2Oita.DataSource = tbl_aluno;
        }

        private void btnInsertAln4_Click(object sender, EventArgs e)
        {
            string nome_aluno = Convert.ToString(txtaln4Quar.Text);

            try
            {
                MySqlConnection cone = new MySqlConnection(conexao);

                string sql_update_aluno = @"update tb_oitavas_aluno_4 set tb_aluno_nome = @nome_aluno where tb_oitavas_id= 1";

                MySqlCommand exeCmdMysl_update = new MySqlCommand(sql_update_aluno, cone);

                exeCmdMysl_update.Parameters.AddWithValue("@nome_aluno", nome_aluno);

                cone.Open();
                exeCmdMysl_update.ExecuteNonQuery();
                cone.Close();
                MessageBox.Show("Feito!");
                txtaln4Quar.Enabled = false;

            }

            catch (Exception erro)
            {

                MessageBox.Show("Ocorreu um erro em: " + erro);
            }

            MySqlConnection con = new MySqlConnection(conexao);
            con.Open();

            string sql_select_tb_aluno = @"select tb_aluno_nome as 'NOME' from tb_oitavas_aluno_4";

            MySqlCommand executacmdMySql_select_aluno = new MySqlCommand(sql_select_tb_aluno, con);

            executacmdMySql_select_aluno.ExecuteNonQuery();

            DataTable tbl_aluno = new DataTable();

            MySqlDataAdapter da_aluno = new MySqlDataAdapter(executacmdMySql_select_aluno);

            da_aluno.Fill(tbl_aluno);
            dgval4Oita.DataSource = tbl_aluno;
        }

        private void btnInsertAln5_Click(object sender, EventArgs e)
        {
            string nome_aluno = Convert.ToString(txtaln5Quar.Text);

            try
            {
                MySqlConnection cone = new MySqlConnection(conexao);

                string sql_update_aluno = @"update tb_oitavas_aluno_5 set tb_aluno_nome = @nome_aluno where tb_oitavas_id= 1";

                MySqlCommand exeCmdMysl_update = new MySqlCommand(sql_update_aluno, cone);

                exeCmdMysl_update.Parameters.AddWithValue("@nome_aluno", nome_aluno);

                cone.Open();
                exeCmdMysl_update.ExecuteNonQuery();
                cone.Close();
                MessageBox.Show("Feito!");
                txtaln5Quar.Enabled = false;

            }

            catch (Exception erro)
            {

                MessageBox.Show("Ocorreu um erro em: " + erro);
            }

            MySqlConnection con = new MySqlConnection(conexao);
            con.Open();

            string sql_select_tb_aluno = @"select tb_aluno_nome as 'NOME' from tb_oitavas_aluno_5";

            MySqlCommand executacmdMySql_select_aluno = new MySqlCommand(sql_select_tb_aluno, con);

            executacmdMySql_select_aluno.ExecuteNonQuery();

            DataTable tbl_aluno = new DataTable();

            MySqlDataAdapter da_aluno = new MySqlDataAdapter(executacmdMySql_select_aluno);

            da_aluno.Fill(tbl_aluno);
            dgval5Oita.DataSource = tbl_aluno;
        }

        private void btnInsertAln6_Click(object sender, EventArgs e)
        {
            string nome_aluno = Convert.ToString(txtaln6Quar.Text);

            try
            {
                MySqlConnection cone = new MySqlConnection(conexao);

                string sql_update_aluno = @"update tb_oitavas_aluno_6 set tb_aluno_nome = @nome_aluno where tb_oitavas_id= 1";

                MySqlCommand exeCmdMysl_update = new MySqlCommand(sql_update_aluno, cone);

                exeCmdMysl_update.Parameters.AddWithValue("@nome_aluno", nome_aluno);

                cone.Open();
                exeCmdMysl_update.ExecuteNonQuery();
                cone.Close();
                MessageBox.Show("Feito!");
                txtaln6Quar.Enabled = false;

            }

            catch (Exception erro)
            {

                MessageBox.Show("Ocorreu um erro em: " + erro);
            }

            MySqlConnection con = new MySqlConnection(conexao);
            con.Open();

            string sql_select_tb_aluno = @"select tb_aluno_nome as 'NOME' from tb_oitavas_aluno_6";

            MySqlCommand executacmdMySql_select_aluno = new MySqlCommand(sql_select_tb_aluno, con);

            executacmdMySql_select_aluno.ExecuteNonQuery();

            DataTable tbl_aluno = new DataTable();

            MySqlDataAdapter da_aluno = new MySqlDataAdapter(executacmdMySql_select_aluno);

            da_aluno.Fill(tbl_aluno);
            dgval6Oita.DataSource = tbl_aluno;
        }

        private void btnInsertAln7_Click(object sender, EventArgs e)
        {
            string nome_aluno = Convert.ToString(txtaln7Quar.Text);

            try
            {
                MySqlConnection cone = new MySqlConnection(conexao);

                string sql_update_aluno = @"update tb_oitavas_aluno_7 set tb_aluno_nome = @nome_aluno where tb_oitavas_id= 1";

                MySqlCommand exeCmdMysl_update = new MySqlCommand(sql_update_aluno, cone);

                exeCmdMysl_update.Parameters.AddWithValue("@nome_aluno", nome_aluno);

                cone.Open();
                exeCmdMysl_update.ExecuteNonQuery();
                cone.Close();
                MessageBox.Show("Feito!");
                txtaln7Quar.Enabled = false;

            }

            catch (Exception erro)
            {

                MessageBox.Show("Ocorreu um erro em: " + erro);
            }

            MySqlConnection con = new MySqlConnection(conexao);
            con.Open();

            string sql_select_tb_aluno = @"select tb_aluno_nome as 'NOME' from tb_oitavas_aluno_7";

            MySqlCommand executacmdMySql_select_aluno = new MySqlCommand(sql_select_tb_aluno, con);

            executacmdMySql_select_aluno.ExecuteNonQuery();

            DataTable tbl_aluno = new DataTable();

            MySqlDataAdapter da_aluno = new MySqlDataAdapter(executacmdMySql_select_aluno);

            da_aluno.Fill(tbl_aluno);
            dgval7Oita.DataSource = tbl_aluno;
        }

        private void btnInsertAln8_Click(object sender, EventArgs e)
        {
            string nome_aluno = Convert.ToString(txtaln8Quar.Text);

            try
            {
                MySqlConnection cone = new MySqlConnection(conexao);

                string sql_update_aluno = @"update tb_oitavas_aluno_8 set tb_aluno_nome = @nome_aluno where tb_oitavas_id= 1";

                MySqlCommand exeCmdMysl_update = new MySqlCommand(sql_update_aluno, cone);

                exeCmdMysl_update.Parameters.AddWithValue("@nome_aluno", nome_aluno);

                cone.Open();
                exeCmdMysl_update.ExecuteNonQuery();
                cone.Close();
                MessageBox.Show("Feito!");
                txtaln8Quar.Enabled = false;

            }

            catch (Exception erro)
            {

                MessageBox.Show("Ocorreu um erro em: " + erro);
            }

            MySqlConnection con = new MySqlConnection(conexao);
            con.Open();

            string sql_select_tb_aluno = @"select tb_aluno_nome as 'NOME' from tb_oitavas_aluno_8";

            MySqlCommand executacmdMySql_select_aluno = new MySqlCommand(sql_select_tb_aluno, con);

            executacmdMySql_select_aluno.ExecuteNonQuery();

            DataTable tbl_aluno = new DataTable();

            MySqlDataAdapter da_aluno = new MySqlDataAdapter(executacmdMySql_select_aluno);

            da_aluno.Fill(tbl_aluno);
            dgval8Oita.DataSource = tbl_aluno;
        }

        private void btnInsertAln9_Click(object sender, EventArgs e)
        {
            string nome_aluno = Convert.ToString(txtaln9Quar.Text);

            try
            {
                MySqlConnection cone = new MySqlConnection(conexao);

                string sql_update_aluno = @"update tb_oitavas_aluno_9 set tb_aluno_nome = @nome_aluno where tb_oitavas_id= 1";

                MySqlCommand exeCmdMysl_update = new MySqlCommand(sql_update_aluno, cone);

                exeCmdMysl_update.Parameters.AddWithValue("@nome_aluno", nome_aluno);

                cone.Open();
                exeCmdMysl_update.ExecuteNonQuery();
                cone.Close();
                MessageBox.Show("Feito!");
                txtaln9Quar.Enabled = false;

            }

            catch (Exception erro)
            {

                MessageBox.Show("Ocorreu um erro em: " + erro);
            }

            MySqlConnection con = new MySqlConnection(conexao);
            con.Open();

            string sql_select_tb_aluno = @"select tb_aluno_nome as 'NOME' from tb_oitavas_aluno_9";

            MySqlCommand executacmdMySql_select_aluno = new MySqlCommand(sql_select_tb_aluno, con);

            executacmdMySql_select_aluno.ExecuteNonQuery();

            DataTable tbl_aluno = new DataTable();

            MySqlDataAdapter da_aluno = new MySqlDataAdapter(executacmdMySql_select_aluno);

            da_aluno.Fill(tbl_aluno);
            dgval9Oita.DataSource = tbl_aluno;
        }

        private void btnInsertAln10_Click(object sender, EventArgs e)
        {
            string nome_aluno = Convert.ToString(txtaln10Quar.Text);

            try
            {
                MySqlConnection cone = new MySqlConnection(conexao);

                string sql_update_aluno = @"update tb_oitavas_aluno_10 set tb_aluno_nome = @nome_aluno where tb_oitavas_id= 1";

                MySqlCommand exeCmdMysl_update = new MySqlCommand(sql_update_aluno, cone);

                exeCmdMysl_update.Parameters.AddWithValue("@nome_aluno", nome_aluno);

                cone.Open();
                exeCmdMysl_update.ExecuteNonQuery();
                cone.Close();
                MessageBox.Show("Feito!");
                txtaln10Quar.Enabled = false;

            }

            catch (Exception erro)
            {

                MessageBox.Show("Ocorreu um erro em: " + erro);
            }

            MySqlConnection con = new MySqlConnection(conexao);
            con.Open();

            string sql_select_tb_aluno = @"select tb_aluno_nome as 'NOME' from tb_oitavas_aluno_10";

            MySqlCommand executacmdMySql_select_aluno = new MySqlCommand(sql_select_tb_aluno, con);

            executacmdMySql_select_aluno.ExecuteNonQuery();

            DataTable tbl_aluno = new DataTable();

            MySqlDataAdapter da_aluno = new MySqlDataAdapter(executacmdMySql_select_aluno);

            da_aluno.Fill(tbl_aluno);
            dgval10Oita.DataSource = tbl_aluno;
        }

        private void btnInsertAln11_Click(object sender, EventArgs e)
        {
            string nome_aluno = Convert.ToString(txtaln11Quar.Text);

            try
            {
                MySqlConnection cone = new MySqlConnection(conexao);

                string sql_update_aluno = @"update tb_oitavas_aluno_11 set tb_aluno_nome = @nome_aluno where tb_oitavas_id= 1";

                MySqlCommand exeCmdMysl_update = new MySqlCommand(sql_update_aluno, cone);

                exeCmdMysl_update.Parameters.AddWithValue("@nome_aluno", nome_aluno);

                cone.Open();
                exeCmdMysl_update.ExecuteNonQuery();
                cone.Close();
                MessageBox.Show("Feito!");
                txtaln11Quar.Enabled = false;
            }

            catch (Exception erro)
            {

                MessageBox.Show("Ocorreu um erro em: " + erro);
            }

            MySqlConnection con = new MySqlConnection(conexao);
            con.Open();

            string sql_select_tb_aluno = @"select tb_aluno_nome as 'NOME' from tb_oitavas_aluno_11";

            MySqlCommand executacmdMySql_select_aluno = new MySqlCommand(sql_select_tb_aluno, con);

            executacmdMySql_select_aluno.ExecuteNonQuery();

            DataTable tbl_aluno = new DataTable();

            MySqlDataAdapter da_aluno = new MySqlDataAdapter(executacmdMySql_select_aluno);

            da_aluno.Fill(tbl_aluno);
            dgval11Oita.DataSource = tbl_aluno;
        }

        private void btnInsertAln12_Click(object sender, EventArgs e)
        {
            string nome_aluno = Convert.ToString(txtaln12Quar.Text);

            try
            {
                MySqlConnection cone = new MySqlConnection(conexao);

                string sql_update_aluno = @"update tb_oitavas_aluno_12 set tb_aluno_nome = @nome_aluno where tb_oitavas_id= 1";

                MySqlCommand exeCmdMysl_update = new MySqlCommand(sql_update_aluno, cone);

                exeCmdMysl_update.Parameters.AddWithValue("@nome_aluno", nome_aluno);

                cone.Open();
                exeCmdMysl_update.ExecuteNonQuery();
                cone.Close();
                MessageBox.Show("Feito!");
                txtaln12Quar.Enabled = false;
            }

            catch (Exception erro)
            {

                MessageBox.Show("Ocorreu um erro em: " + erro);
            }

            MySqlConnection con = new MySqlConnection(conexao);
            con.Open();

            string sql_select_tb_aluno = @"select tb_aluno_nome as 'NOME' from tb_oitavas_aluno_12";

            MySqlCommand executacmdMySql_select_aluno = new MySqlCommand(sql_select_tb_aluno, con);

            executacmdMySql_select_aluno.ExecuteNonQuery();

            DataTable tbl_aluno = new DataTable();

            MySqlDataAdapter da_aluno = new MySqlDataAdapter(executacmdMySql_select_aluno);

            da_aluno.Fill(tbl_aluno);
            dgval12Oita.DataSource = tbl_aluno;
        }

        private void btnInsertAln13_Click(object sender, EventArgs e)
        {
            string nome_aluno = Convert.ToString(txtaln13Quar.Text);

            try
            {
                MySqlConnection cone = new MySqlConnection(conexao);

                string sql_update_aluno = @"update tb_oitavas_aluno_13 set tb_aluno_nome = @nome_aluno where tb_oitavas_id= 1";

                MySqlCommand exeCmdMysl_update = new MySqlCommand(sql_update_aluno, cone);

                exeCmdMysl_update.Parameters.AddWithValue("@nome_aluno", nome_aluno);

                cone.Open();
                exeCmdMysl_update.ExecuteNonQuery();
                cone.Close();
                MessageBox.Show("Feito!");
                txtaln13Quar.Enabled = false;

            }

            catch (Exception erro)
            {

                MessageBox.Show("Ocorreu um erro em: " + erro);
            }

            MySqlConnection con = new MySqlConnection(conexao);
            con.Open();

            string sql_select_tb_aluno = @"select tb_aluno_nome as 'NOME' from tb_oitavas_aluno_13";

            MySqlCommand executacmdMySql_select_aluno = new MySqlCommand(sql_select_tb_aluno, con);

            executacmdMySql_select_aluno.ExecuteNonQuery();

            DataTable tbl_aluno = new DataTable();

            MySqlDataAdapter da_aluno = new MySqlDataAdapter(executacmdMySql_select_aluno);

            da_aluno.Fill(tbl_aluno);
            dgval13Oita.DataSource = tbl_aluno;
        }

        private void btnInsertAln14_Click(object sender, EventArgs e)
        {
            string nome_aluno = Convert.ToString(txtaln14Quar.Text);

            try
            {
                MySqlConnection cone = new MySqlConnection(conexao);

                string sql_update_aluno = @"update tb_oitavas_aluno_14 set tb_aluno_nome = @nome_aluno where tb_oitavas_id= 1";

                MySqlCommand exeCmdMysl_update = new MySqlCommand(sql_update_aluno, cone);

                exeCmdMysl_update.Parameters.AddWithValue("@nome_aluno", nome_aluno);

                cone.Open();
                exeCmdMysl_update.ExecuteNonQuery();
                cone.Close();
                MessageBox.Show("Feito!");
                txtaln14Quar.Enabled = false;

            }

            catch (Exception erro)
            {

                MessageBox.Show("Ocorreu um erro em: " + erro);
            }

            MySqlConnection con = new MySqlConnection(conexao);
            con.Open();

            string sql_select_tb_aluno = @"select tb_aluno_nome as 'NOME' from tb_oitavas_aluno_14";

            MySqlCommand executacmdMySql_select_aluno = new MySqlCommand(sql_select_tb_aluno, con);

            executacmdMySql_select_aluno.ExecuteNonQuery();

            DataTable tbl_aluno = new DataTable();

            MySqlDataAdapter da_aluno = new MySqlDataAdapter(executacmdMySql_select_aluno);

            da_aluno.Fill(tbl_aluno);
            dgval14Oita.DataSource = tbl_aluno;
        }

        private void btnInsertAln15_Click(object sender, EventArgs e)
        {
            string nome_aluno = Convert.ToString(txtaln15Quar.Text);

            try
            {
                MySqlConnection cone = new MySqlConnection(conexao);

                string sql_update_aluno = @"update tb_oitavas_aluno_15 set tb_aluno_nome = @nome_aluno where tb_oitavas_id= 1";

                MySqlCommand exeCmdMysl_update = new MySqlCommand(sql_update_aluno, cone);

                exeCmdMysl_update.Parameters.AddWithValue("@nome_aluno", nome_aluno);

                cone.Open();
                exeCmdMysl_update.ExecuteNonQuery();
                cone.Close();
                MessageBox.Show("Feito!");
                txtaln15Quar.Enabled = false;

            }

            catch (Exception erro)
            {

                MessageBox.Show("Ocorreu um erro em: " + erro);
            }

            MySqlConnection con = new MySqlConnection(conexao);
            con.Open();

            string sql_select_tb_aluno = @"select tb_aluno_nome as 'NOME' from tb_oitavas_aluno_15";

            MySqlCommand executacmdMySql_select_aluno = new MySqlCommand(sql_select_tb_aluno, con);

            executacmdMySql_select_aluno.ExecuteNonQuery();

            DataTable tbl_aluno = new DataTable();

            MySqlDataAdapter da_aluno = new MySqlDataAdapter(executacmdMySql_select_aluno);

            da_aluno.Fill(tbl_aluno);
            dgval15Oita.DataSource = tbl_aluno;
        }

        private void btnInsertAln16_Click(object sender, EventArgs e)
        {
            string nome_aluno = Convert.ToString(txtaln16Quar.Text);

            try
            {
                MySqlConnection cone = new MySqlConnection(conexao);

                string sql_update_aluno = @"update tb_oitavas_aluno_16 set tb_aluno_nome = @nome_aluno where tb_oitavas_id= 1";

                MySqlCommand exeCmdMysl_update = new MySqlCommand(sql_update_aluno, cone);

                exeCmdMysl_update.Parameters.AddWithValue("@nome_aluno", nome_aluno);

                cone.Open();
                exeCmdMysl_update.ExecuteNonQuery();
                cone.Close();
                MessageBox.Show("Feito!");
                txtaln16Quar.Enabled = false;

            }

            catch (Exception erro)
            {

                MessageBox.Show("Ocorreu um erro em: " + erro);
            }

            MySqlConnection con = new MySqlConnection(conexao);
            con.Open();

            string sql_select_tb_aluno = @"select tb_aluno_nome as 'NOME' from tb_oitavas_aluno_16";

            MySqlCommand executacmdMySql_select_aluno = new MySqlCommand(sql_select_tb_aluno, con);

            executacmdMySql_select_aluno.ExecuteNonQuery();

            DataTable tbl_aluno = new DataTable();

            MySqlDataAdapter da_aluno = new MySqlDataAdapter(executacmdMySql_select_aluno);

            da_aluno.Fill(tbl_aluno);
            dgval16Oita.DataSource = tbl_aluno;
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

        private void TE_Principal_Load(object sender, EventArgs e)
        {

        }
    }
}
