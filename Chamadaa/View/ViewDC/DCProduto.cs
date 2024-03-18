using Chamadaa.View.View_Eventos;
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
    public partial class DCProduto : Form
    {
        string conexao = ConfigurationManager.ConnectionStrings["strg_bd_esportivo"].ConnectionString;
        public DCProduto()
        {
            InitializeComponent();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void txtDataVerificação_TextChanged(object sender, EventArgs e)
        {

        }

        private void dgvEquipamentos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnAtualizar_Click(object sender, EventArgs e)
        {
            try
            {
                MySqlConnection cone = new MySqlConnection(conexao);

                string nome_prod = txtnomeProduto.Text;

                string produto_descricao = txtDescriçãoProduto.Text;

                string produto_tipo = txtTipo.Text;

                string dt_insercao = txtDataInserção.Text;
                string dt_verficacao = txtDataVerificação.Text;
                string produto_id = txtIdProduto.Text;

                string sql_update_produto = @"update tb_produto set tb_produto_nome = @nome_prod, tb_produto_descricao = @descricao_produto, tb_produto_tipo= @produto_tipo, tb_produto_dt_verificacao = @dt_verificacao, tb_produto_dt_chegada_estoque = @dt_insercao where tb_produto_id = @produto_id";

                MySqlCommand exeCmdMysl_insert = new MySqlCommand(sql_update_produto, cone);

                exeCmdMysl_insert.Parameters.AddWithValue("@nome_prod", nome_prod);
                exeCmdMysl_insert.Parameters.AddWithValue("@descricao_produto", produto_descricao);
                exeCmdMysl_insert.Parameters.AddWithValue("@produto_tipo", produto_tipo);
                exeCmdMysl_insert.Parameters.AddWithValue("@dt_insercao", dt_insercao);
                exeCmdMysl_insert.Parameters.AddWithValue("@dt_verificacao", dt_verficacao);
                exeCmdMysl_insert.Parameters.AddWithValue("@produto_id", produto_id);
                cone.Open();
                exeCmdMysl_insert.ExecuteNonQuery();
                cone.Close();
                MessageBox.Show("Atualização efetuada!");
            }

            catch (Exception erro)
            {

                MessageBox.Show("Ocorreu um erro em: " + erro);
            }

            MySqlConnection con = new MySqlConnection(conexao);
            con.Open();

            string sql_select_equi = @"select tb_produto_id as 'Identif:', tb_produto_nome as 'Nome:',tb_produto_descricao as 'DESC:',tb_produto_tipo as 'TIPO:',tb_produto_dt_chegada_estoque as 'DT_CHEGADA:',tb_produto_dt_verificacao AS 'DT_VERIFI:' from tb_produto";

            MySqlCommand executacmdMySql_select_equi = new MySqlCommand(sql_select_equi, con);

            executacmdMySql_select_equi.ExecuteNonQuery();

            DataTable tbl_equi = new DataTable();

            MySqlDataAdapter da_mod = new MySqlDataAdapter(executacmdMySql_select_equi);

            da_mod.Fill(tbl_equi);
            dgvEquipamentos.DataSource = tbl_equi;
            con.Close();
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            MySqlConnection con = new MySqlConnection(conexao);
            string sql_delete_tb_aln = @"delete from tb_alunos where tb_alunos_id='" + txtIdProduto.Text + "'";

            MySqlCommand exeCmdMysl_delete = new MySqlCommand(sql_delete_tb_aln, con);

            con.Open();
            exeCmdMysl_delete.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Atualização efetuada!");


            MySqlConnection cone = new MySqlConnection(conexao);
            cone.Open();

            string sql_select_equi = @"select tb_produto_id as 'Identif:', tb_produto_nome as 'Nome:',tb_produto_descricao as 'DESC:',tb_produto_tipo as 'TIPO:',tb_produto_dt_chegada_estoque as 'DT_CHEGADA:',tb_produto_dt_verificacao AS 'DT_VERIFI:' from tb_produto";

            MySqlCommand executacmdMySql_select_equi = new MySqlCommand(sql_select_equi, con);

            executacmdMySql_select_equi.ExecuteNonQuery();

            DataTable tbl_equi = new DataTable();

            MySqlDataAdapter da_mod = new MySqlDataAdapter(executacmdMySql_select_equi);

            da_mod.Fill(tbl_equi);
            dgvEquipamentos.DataSource = tbl_equi;
            con.Close();

        }

        private void dgvEquipamentos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtEquipamento.Text = dgvEquipamentos.CurrentRow.Cells[1].Value.ToString();
            txtIdProduto.Text = dgvEquipamentos.CurrentRow.Cells[0].Value.ToString();
            txtnomeProduto.Text = dgvEquipamentos.CurrentRow.Cells[2].Value.ToString();
            txtDescriçãoProduto.Text = dgvEquipamentos.CurrentRow.Cells[3].Value.ToString();
            txtTipo.Text = dgvEquipamentos.CurrentRow.Cells[4].Value.ToString();
            txtDataInserção.Text = dgvEquipamentos.CurrentRow.Cells[5].Value.ToString();
            txtDataVerificação.Text = dgvEquipamentos.CurrentRow.Cells[6].Value.ToString();

            txtStatus.Text = "Reposição necessária";
        }

        private void btnIr_Click(object sender, EventArgs e)
        {
            Tela_evts_principal evt = new Tela_evts_principal();
            evt.ShowDialog();
        }
    }
}
