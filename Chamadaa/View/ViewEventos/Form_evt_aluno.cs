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
    public partial class Form_evt_aluno : Form
    {
        string conexao = ConfigurationManager.ConnectionStrings["strg_bd_esportivo"].ConnectionString;
        public Form_evt_aluno()
        {
            InitializeComponent();
        }

        private void dgEventos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            Detalhes_evt det = new Detalhes_evt();

            det.lblNomeevt.Text = dgEventos.CurrentRow.Cells[1].Value.ToString();
            det.lblData.Text = dgEventos.CurrentRow.Cells[2].Value.ToString();
            det.lblModalidade.Text = dgEventos.CurrentRow.Cells[3].Value.ToString();
            det.lblOrganizador.Text = dgEventos.CurrentRow.Cells[4].Value.ToString();
            det.lblLocal.Text = dgEventos.CurrentRow.Cells[5].Value.ToString();
            det.ShowDialog();
        }

        private void Form_evt_aluno_Load(object sender, EventArgs e)
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
    }
}
