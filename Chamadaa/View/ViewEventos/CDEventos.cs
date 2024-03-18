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
namespace Chamadaa.View.ViewEventos
{
    public partial class CDEventos : Form
    {
        string conexao = ConfigurationManager.ConnectionStrings["strg_bd_esportivo"].ConnectionString;
        public CDEventos()
        {
            InitializeComponent();
        }

        private void CDEventos_Load(object sender, EventArgs e)
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

        private void dgEventos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtId.Text = dgEventos.CurrentRow.Cells[0].Value.ToString();
            txtNomeevt.Text = dgEventos.CurrentRow.Cells[1].Value.ToString();
            txtData.Text = dgEventos.CurrentRow.Cells[2].Value.ToString();
            txtModalidade.Text = dgEventos.CurrentRow.Cells[3].Value.ToString();
            txtOrganizador.Text = dgEventos.CurrentRow.Cells[4].Value.ToString();
            txtLocal.Text = dgEventos.CurrentRow.Cells[5].Value.ToString();        
           
           
            
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            MySqlConnection con = new MySqlConnection(conexao);
            string sql_delete_tb_aln = @"delete from tb_eventos where tb_evento_id='" + txtId.Text + "'";

            MySqlCommand exeCmdMysl_delete = new MySqlCommand(sql_delete_tb_aln, con);

            con.Open();
            exeCmdMysl_delete.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Atualização efetuada!");

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

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            MySqlConnection con = new MySqlConnection(conexao);
            con.Open();
            string sql = "update tb_eventos set tb_evento_nome = '" + txtNomeevt.Text + "', tb_evento_data = '" + txtData.Text + "', tb_evento_modalidade= '" + txtModalidade.Text + "',tb_evento_organizador = '" + txtOrganizador.Text + "', tb_evento_local = '" + txtLocal.Text + "' where tb_evento_id = '" + txtId.Text + "'";
            MySqlCommand executacmdsql = new MySqlCommand(sql, con);
            executacmdsql.ExecuteNonQuery();
            MessageBox.Show("Dados alterados!");

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

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
