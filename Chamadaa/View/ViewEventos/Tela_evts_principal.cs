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
using Chamadaa.View.ViewEventos;

namespace Chamadaa.View.View_Eventos
{
    public partial class Tela_evts_principal : Form
    {
        string conexao = ConfigurationManager.ConnectionStrings["strg_bd_esportivo"].ConnectionString;
        public Tela_evts_principal()
        {
            InitializeComponent();
        }

        private void btnCamp_Click(object sender, EventArgs e)
        {
            TE_Principal Camp = new TE_Principal();
            Camp.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Dispose();
            Cadastro_finalistas cf = new Cadastro_finalistas();
            cf.Show();
            
        }

        private void txtLocal_Enter(object sender, EventArgs e)
        {
            if (txtLocal.Text == "Local")
            {

                txtLocal.Text = "";

            }
        }

        private void txtLocal_Leave(object sender, EventArgs e)
        {
            if (txtLocal.Text == "")
            {

                txtLocal.Text = "Local";

            }
        }

        private void txtData_Enter(object sender, EventArgs e)
        {
            if (txtData.Text == "Data")
            {

                txtData.Text = "";
            }
        }

        private void txtData_Leave(object sender, EventArgs e)
        {
            if (txtData.Text == "")
            {

                txtData.Text = "Data";
            }
        }

        private void txtOrganizador_Enter(object sender, EventArgs e)
        {
            if (txtOrganizador.Text == "Organizador")
            {

                txtOrganizador.Text = "";

            }
        }

        private void txtOrganizador_Leave(object sender, EventArgs e)
        {
            if (txtOrganizador.Text == "")
            {

                txtOrganizador.Text = "Organizador";

            }
        }

        private void Tela_evts_principal_Load(object sender, EventArgs e)
        {
            MySqlConnection cone = new MySqlConnection(conexao);
            cone.Open();

            string sql_select = @"select tb_evento_id as 'ID', tb_evento_nome as 'NOME', tb_evento_data as 'DATA DO EVENTO',tb_evento_modalidade as 'MODALIDADE PRATICADA',tb_evento_organizador as 'ORGANIZADO POR:', tb_evento_local as 'LOCAL' from tb_eventos";

            MySqlCommand executacmdMySql_select = new MySqlCommand(sql_select, cone);

            executacmdMySql_select.ExecuteNonQuery();

            DataTable tbl_evt = new DataTable();

            MySqlDataAdapter da_evt = new MySqlDataAdapter(executacmdMySql_select);

            da_evt.Fill(tbl_evt);
            dgEventos.DataSource = tbl_evt;
            cone.Close();
        }

        private void txtModalidade_Enter(object sender, EventArgs e)
        {
            if (txtModalidade.Text == "Modalidade")
            {

                txtModalidade.Text = "";

            }
        }

        private void txtModalidade_Leave(object sender, EventArgs e)
        {
            if (txtModalidade.Text == "")
            {

                txtModalidade.Text = "Modalidade";

            }
        }

        private void btnIr_Click(object sender, EventArgs e)
        {
            Form_buscar_porAluno not = new Form_buscar_porAluno();
            not.Show();
            not.pbXAln.Show();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            #region
            if (txtNomeevt.Text == "" || txtModalidade.Text == "Modalidade" || txtLocal.Text == "Local" || txtData.Text == "Data" || txtOrganizador.Text == "Organizador") { MessageBox.Show("Valores não inseridos."); }
            else
            {
                #endregion
                try
                {
                    MySqlConnection con = new MySqlConnection(conexao);

                    string nome = txtNomeevt.Text;
                    string mod = txtModalidade.Text;
                    string local = txtLocal.Text;
                    string data = txtData.Text;
                    string organizador = txtOrganizador.Text;



                    string sql_insert_tb_eventos = @"insert into tb_eventos
                                            (
                                                tb_evento_nome,                                                
                                                tb_evento_data,
                                                tb_evento_modalidade,
                                                tb_evento_organizador,
                                                tb_evento_local                                          

                                            )
                                            values
                                            (
                                                @nome,
                                                @data, 
                                                @mod,
                                                @organizador,
                                                @local                                               

                                                );";

                    MySqlCommand exeCmdMysl_insert = new MySqlCommand(sql_insert_tb_eventos, con);

                    exeCmdMysl_insert.Parameters.AddWithValue("@nome", nome);
                    exeCmdMysl_insert.Parameters.AddWithValue("@data", data);
                    exeCmdMysl_insert.Parameters.AddWithValue("@mod", mod);
                    exeCmdMysl_insert.Parameters.AddWithValue("@organizador", organizador);
                    exeCmdMysl_insert.Parameters.AddWithValue("@local", local);


                    con.Open();
                    exeCmdMysl_insert.ExecuteNonQuery();
                    con.Close();

                    MessageBox.Show("Cadastro bem sucedido!");

                    txtNomeevt.Text = "";
                    txtData.Text = "Data";
                    txtModalidade.Text = "Modalidade";
                    txtOrganizador.Text = "Organizador";
                    txtLocal.Text = "Local";

                }
                catch (Exception ERRO)
                {

                    MessageBox.Show("Valores não cadastrados por conterem alterações" + ERRO);
                }

                MySqlConnection cone = new MySqlConnection(conexao);
                cone.Open();

                string sql_select = @"select tb_evento_nome as 'NOME', tb_evento_data as 'DATA DO EVENTO',tb_evento_modalidade as 'MODALIDADE PRATICADA',tb_evento_organizador as 'ORGANIZADO POR:', tb_evento_local as 'LOCAL' from tb_eventos";

                MySqlCommand executacmdMySql_select = new MySqlCommand(sql_select, cone);

                executacmdMySql_select.ExecuteNonQuery();

                DataTable tbl_evt = new DataTable();

                MySqlDataAdapter da_evt = new MySqlDataAdapter(executacmdMySql_select);

                da_evt.Fill(tbl_evt);
                dgEventos.DataSource = tbl_evt;
                cone.Close();
            }
        }

        private void txtData_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsNumber(e.KeyChar) == true)
            {
                switch (txtData.TextLength/*(tamanho do texto)*/)
                {
                    case 2:
                        txtData.Text = txtData.Text + "_";
                        //Jogar o cursor pra 4 posição
                        txtData.SelectionStart = 4;

                        break;
                    case 5:
                        txtData.Text = txtData.Text + "_";
                        //Jogar o cursor pra 4 posição
                        txtData.SelectionStart = 7;
                        break;

                }
            }
        }

        private void dgEventos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void dgEventos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgEventos_DoubleClick(object sender, EventArgs e)
        {

            Detalhes_evt det = new Detalhes_evt();

            det.lblNomeevt.Text = dgEventos.CurrentRow.Cells[1].Value.ToString();
            det.lblData.Text = dgEventos.CurrentRow.Cells[2].Value.ToString();
            det.lblModalidade.Text = dgEventos.CurrentRow.Cells[3].Value.ToString();
            det.lblOrganizador.Text = dgEventos.CurrentRow.Cells[4].Value.ToString();
            det.lblLocal.Text = dgEventos.CurrentRow.Cells[5].Value.ToString();
            det.ShowDialog();
        }
    }
    
}
