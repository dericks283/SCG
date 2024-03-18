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
    public partial class CadTurma : Form
    {
        string conexao = ConfigurationManager.ConnectionStrings["strg_bd_esportivo"].ConnectionString;
        public CadTurma()
        {
            InitializeComponent();
        }

        private void btnCad_Click(object sender, EventArgs e)
        {
            #region
            if (txtHorario.Text == "Horário referente:" || txtNovaTur.Text == "Nome da nova turma:" || cbModalidades.Text == "Modalidade" || txtHorario.Text == "__:__") { MessageBox.Show("Campos vazios, verifique os valores correspondentes e tente novamente!"); }
            else
            {
                #endregion
                if (cbModalidades.Text == "Basquete")
                {
                    try
                    {
                        MySqlConnection con = new MySqlConnection(conexao);

                        string nome_turma = txtNovaTur.Text;
                        string horario_turma = txtHorario.Text;


                        string sql_insert_tb_mod = @"insert into tb_basquete
                                            (
                                                tb_basquete_turma,
                                                tb_basquete_horario                                         

                                            )
                                            values
                                            (
                                                @turma_nome,
                                                @turma_horario                                                                              

                                                );";

                        MySqlCommand exeCmdMysl_insert = new MySqlCommand(sql_insert_tb_mod, con);

                        exeCmdMysl_insert.Parameters.AddWithValue("@turma_nome", nome_turma);
                        exeCmdMysl_insert.Parameters.AddWithValue("@turma_horario", horario_turma);

                        con.Open();
                        exeCmdMysl_insert.ExecuteNonQuery();
                        con.Close();
                        MessageBox.Show("Nova turma adicionada!");

                        txtNovaTur.Text = "";
                        txtHorario.Text = "";
                    }
                    catch (Exception ERRO)
                    {

                        MessageBox.Show("Valores não cadastrados por conterem alterações" + ERRO);
                    }

                    MySqlConnection cone = new MySqlConnection(conexao);
                    cone.Open();

                    string sql_select_modalidade = @"select tb_basquete_turma as 'COL1:', tb_basquete_horario as 'COL2:' from tb_basquete";

                    MySqlCommand executacmdMySql_select_modalidade = new MySqlCommand(sql_select_modalidade, cone);

                    executacmdMySql_select_modalidade.ExecuteNonQuery();

                    DataTable tbl_mod = new DataTable();

                    MySqlDataAdapter da_mod = new MySqlDataAdapter(executacmdMySql_select_modalidade);

                    da_mod.Fill(tbl_mod);
                    dgvTurmas.DataSource = tbl_mod;
                    cone.Close();

                    btnReset.Enabled = true;
                }

                else if (cbModalidades.Text == "Volei")
                {
                    try
                    {
                        MySqlConnection con = new MySqlConnection(conexao);

                        string nome_turma = txtNovaTur.Text;
                        string horario_turma = txtHorario.Text;


                        string sql_insert_tb_mod = @"insert into tb_volei
                                            (
                                                tb_volei_turma,
                                                tb_volei_horario                                         

                                            )
                                            values
                                            (
                                                @turma_nome,
                                                @turma_horario                                                                              

                                                );";

                        MySqlCommand exeCmdMysl_insert = new MySqlCommand(sql_insert_tb_mod, con);

                        exeCmdMysl_insert.Parameters.AddWithValue("@turma_nome", nome_turma);
                        exeCmdMysl_insert.Parameters.AddWithValue("@turma_horario", horario_turma);

                        con.Open();
                        exeCmdMysl_insert.ExecuteNonQuery();
                        con.Close();
                        MessageBox.Show("Nova turma adicionada!");

                        txtNovaTur.Text = "";
                        txtHorario.Text = "";
                    }
                    catch (Exception ERRO)
                    {

                        MessageBox.Show("Valores não cadastrados por conterem alterações" + ERRO);
                    }

                    MySqlConnection cone = new MySqlConnection(conexao);
                    cone.Open();

                    string sql_select_modalidade = @"select tb_volei_turma as 'COL1:', tb_volei_horario as 'COL2:' from tb_volei";

                    MySqlCommand executacmdMySql_select_modalidade = new MySqlCommand(sql_select_modalidade, cone);

                    executacmdMySql_select_modalidade.ExecuteNonQuery();

                    DataTable tbl_mod = new DataTable();

                    MySqlDataAdapter da_mod = new MySqlDataAdapter(executacmdMySql_select_modalidade);

                    da_mod.Fill(tbl_mod);
                    dgvTurmas.DataSource = tbl_mod;
                    cone.Close();

                    btnReset.Enabled = true;
                }

                else if (cbModalidades.Text == "Futsal")
                {
                    try
                    {
                        MySqlConnection con = new MySqlConnection(conexao);

                        string nome_turma = txtNovaTur.Text;
                        string horario_turma = txtHorario.Text;


                        string sql_insert_tb_mod = @"insert into tb_futsal
                                            (
                                                tb_futsal_turma,
                                                tb_futsal_horario                                         

                                            )
                                            values
                                            (
                                                @turma_nome,
                                                @turma_horario                                                                              

                                                );";

                        MySqlCommand exeCmdMysl_insert = new MySqlCommand(sql_insert_tb_mod, con);

                        exeCmdMysl_insert.Parameters.AddWithValue("@turma_nome", nome_turma);
                        exeCmdMysl_insert.Parameters.AddWithValue("@turma_horario", horario_turma);

                        con.Open();
                        exeCmdMysl_insert.ExecuteNonQuery();
                        con.Close();
                        MessageBox.Show("Nova turma adicionada!");

                        txtNovaTur.Text = "";
                        txtHorario.Text = "";
                    }
                    catch (Exception ERRO)
                    {

                        MessageBox.Show("Valores não cadastrados por conterem alterações" + ERRO);
                    }

                    MySqlConnection cone = new MySqlConnection(conexao);
                    cone.Open();

                    string sql_select_modalidade = @"select tb_futsal_turma as 'COL1:', tb_futsal_horario as 'COL2:' from tb_futsal";

                    MySqlCommand executacmdMySql_select_modalidade = new MySqlCommand(sql_select_modalidade, cone);

                    executacmdMySql_select_modalidade.ExecuteNonQuery();

                    DataTable tbl_mod = new DataTable();

                    MySqlDataAdapter da_mod = new MySqlDataAdapter(executacmdMySql_select_modalidade);

                    da_mod.Fill(tbl_mod);
                    dgvTurmas.DataSource = tbl_mod;
                    cone.Close();

                    btnReset.Enabled = true;
                }


                else if (cbModalidades.Text == "Handebol")
                {
                    try
                    {
                        MySqlConnection con = new MySqlConnection(conexao);

                        string nome_turma = txtNovaTur.Text;
                        string horario_turma = txtHorario.Text;


                        string sql_insert_tb_mod = @"insert into tb_handebol
                                            (
                                                tb_handebol_turma,
                                                tb_handebol_horario                                         

                                            )
                                            values
                                            (
                                                @turma_nome,
                                                @turma_horario                                                                              

                                                );";

                        MySqlCommand exeCmdMysl_insert = new MySqlCommand(sql_insert_tb_mod, con);

                        exeCmdMysl_insert.Parameters.AddWithValue("@turma_nome", nome_turma);
                        exeCmdMysl_insert.Parameters.AddWithValue("@turma_horario", horario_turma);

                        con.Open();
                        exeCmdMysl_insert.ExecuteNonQuery();
                        con.Close();
                        MessageBox.Show("Nova turma adicionada!");

                        txtNovaTur.Text = "";
                        txtHorario.Text = "";
                    }
                    catch (Exception ERRO)
                    {

                        MessageBox.Show("Valores não cadastrados por conterem alterações" + ERRO);
                    }

                    MySqlConnection cone = new MySqlConnection(conexao);
                    cone.Open();

                    string sql_select_modalidade = @"select tb_handebol_turma as 'COL1:', tb_handebol_horario as 'COL2:' from tb_handebol";

                    MySqlCommand executacmdMySql_select_modalidade = new MySqlCommand(sql_select_modalidade, cone);

                    executacmdMySql_select_modalidade.ExecuteNonQuery();

                    DataTable tbl_mod = new DataTable();

                    MySqlDataAdapter da_mod = new MySqlDataAdapter(executacmdMySql_select_modalidade);

                    da_mod.Fill(tbl_mod);
                    dgvTurmas.DataSource = tbl_mod;
                    cone.Close();

                    btnReset.Enabled = true;
                }
                else if (cbModalidades.Text == "Natação")
                {
                    try
                    {
                        MySqlConnection con = new MySqlConnection(conexao);

                        string nome_turma = txtNovaTur.Text;
                        string horario_turma = txtHorario.Text;


                        string sql_insert_tb_mod = @"insert into tb_natacao
                                            (
                                                tb_natacao_turma,
                                                tb_natacao_horario                                         

                                            )
                                            values
                                            (
                                                @turma_nome,
                                                @turma_horario                                                                              

                                                );";

                        MySqlCommand exeCmdMysl_insert = new MySqlCommand(sql_insert_tb_mod, con);

                        exeCmdMysl_insert.Parameters.AddWithValue("@turma_nome", nome_turma);
                        exeCmdMysl_insert.Parameters.AddWithValue("@turma_horario", horario_turma);

                        con.Open();
                        exeCmdMysl_insert.ExecuteNonQuery();
                        con.Close();
                        MessageBox.Show("Nova turma adicionada!");

                        txtNovaTur.Text = "";
                        txtHorario.Text = "";
                    }
                    catch (Exception ERRO)
                    {

                        MessageBox.Show("Valores não cadastrados por conterem alterações" + ERRO);
                    }

                    MySqlConnection cone = new MySqlConnection(conexao);
                    cone.Open();

                    string sql_select_modalidade = @"select tb_natacao_turma as 'COL1:', tb_natacao_horario as 'COL2:' from tb_natacao";

                    MySqlCommand executacmdMySql_select_modalidade = new MySqlCommand(sql_select_modalidade, cone);

                    executacmdMySql_select_modalidade.ExecuteNonQuery();

                    DataTable tbl_mod = new DataTable();

                    MySqlDataAdapter da_mod = new MySqlDataAdapter(executacmdMySql_select_modalidade);

                    da_mod.Fill(tbl_mod);
                    dgvTurmas.DataSource = tbl_mod;
                    cone.Close();

                    btnReset.Enabled = true;
                }
                else if (cbModalidades.Text == "Modalidade") { MessageBox.Show("Selecione uma modalidade para continuar"); }
            }
            txtNovaTur.Text = "Nome da nova Turma*";


        }

        private void txtNovaTur_Enter(object sender, EventArgs e)
        {
            if (txtNovaTur.Text == "Nome da nova Turma*")
            {

                txtNovaTur.Text = "";
                txtNovaTur.ForeColor = Color.Silver;
            }
        }

        private void txtNovaTur_Leave(object sender, EventArgs e)
        {
            if (txtNovaTur.Text == "")
            {

                txtNovaTur.Text = "Nome da nova Turma*";
                txtNovaTur.ForeColor = Color.Silver;
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }

        
   
}

