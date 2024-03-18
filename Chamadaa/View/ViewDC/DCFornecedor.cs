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

namespace Chamadaa.View.ViewDC
{
    public partial class DCFornecedor : Form
    {
        string conexao = ConfigurationManager.ConnectionStrings["strg_bd_esportivo"].ConnectionString;
        public DCFornecedor()
        {
            InitializeComponent();
        }

        private void dgvFornecedor_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            txtIdFornecedor.Text = dgvFornecedor.CurrentRow.Cells[0].Value.ToString();
            txtNomeFor.Text = dgvFornecedor.CurrentRow.Cells[1].Value.ToString();           
            txtEmailFor.Text = dgvFornecedor.CurrentRow.Cells[2].Value.ToString();
            txtTelFor.Text = dgvFornecedor.CurrentRow.Cells[3].Value.ToString();
            txtCelForn.Text = dgvFornecedor.CurrentRow.Cells[4].Value.ToString();
            txtEndFornecedor.Text = dgvFornecedor.CurrentRow.Cells[5].Value.ToString();            
            txtIdentificacaoForn.Text = dgvFornecedor.CurrentRow.Cells[6].Value.ToString();
        }

        private void btnAtualizar_Click(object sender, EventArgs e)
        {
            MySqlConnection con = new MySqlConnection(conexao);
            con.Open();
            string sql = "update tb_fornecedor set tb_fornecedor_nome ='" + txtNomeFor.Text + "',tb_fornecedor_email = '" + txtEmailFor.Text + "', tb_fornecedor_telefone = " + txtTelFor.Text + ",tb_fornecedor_celular = " + txtCelForn.Text + ", tb_fornecedor_endereco = '" + txtEndFornecedor.Text + "',tb_fornecedor_identidade = '" + txtIdentificacaoForn.Text + "' where tb_fornecedor_id = " + txtIdFornecedor.Text + "";
            MySqlCommand executacmdsql = new MySqlCommand(sql, con);
            executacmdsql.ExecuteNonQuery();
            MessageBox.Show("Dados Atualizados!");
        }

        private void DCFornecedor_Load(object sender, EventArgs e)
        {
            MySqlConnection cone = new MySqlConnection(conexao);
            cone.Open();

            string sql_select_fornecedor = @"select tb_fornecedor_id as 'IDENTIF:', tb_fornecedor_nome as 'NOME:', tb_fornecedor_email as 'EMAIL:', tb_fornecedor_telefone as 'TEL:',tb_fornecedor_celular as 'CEL:',tb_fornecedor_endereco as 'END',tb_fornecedor_identidade as 'CPF/CNPJ:' from tb_fornecedor";

            MySqlCommand executacmdMySql_select_fornecedor = new MySqlCommand(sql_select_fornecedor, cone);

            executacmdMySql_select_fornecedor.ExecuteNonQuery();

            DataTable tbl_forn = new DataTable();

            MySqlDataAdapter da_forn = new MySqlDataAdapter(executacmdMySql_select_fornecedor);

            da_forn.Fill(tbl_forn);
            dgvFornecedor.DataSource = tbl_forn;
            cone.Close();
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            MySqlConnection con = new MySqlConnection(conexao);
            con.Open();
            string sql = "delete from tb_fornecedor where tb_fornecedor_id="+txtIdFornecedor.Text+"";
            MySqlCommand executacmdsql = new MySqlCommand(sql, con);
            executacmdsql.ExecuteNonQuery();
            MessageBox.Show("Dados editados!");

            MySqlConnection cone = new MySqlConnection(conexao);
            cone.Open();

            string sql_select_fornecedor = @"select tb_fornecedor_id as 'IDENTIF:', tb_fornecedor_nome as 'NOME:', tb_fornecedor_email as 'EMAIL:', tb_fornecedor_telefone as 'TEL:',tb_fornecedor_celular as 'CEL:',tb_fornecedor_endereco as 'END',tb_fornecedor_identidade as 'CPF/CNPJ:' from tb_fornecedor";

            MySqlCommand executacmdMySql_select_fornecedor = new MySqlCommand(sql_select_fornecedor, cone);

            executacmdMySql_select_fornecedor.ExecuteNonQuery();

            DataTable tbl_forn = new DataTable();

            MySqlDataAdapter da_forn = new MySqlDataAdapter(executacmdMySql_select_fornecedor);

            da_forn.Fill(tbl_forn);
            dgvFornecedor.DataSource = tbl_forn;
            cone.Close();
        }
    }
}
