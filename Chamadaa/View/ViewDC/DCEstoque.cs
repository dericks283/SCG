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
    public partial class DCEstoque : Form
    {
        string conexao = ConfigurationManager.ConnectionStrings["strg_bd_esportivo"].ConnectionString;
        public DCEstoque()
        {
            InitializeComponent();
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            MySqlConnection con = new MySqlConnection(conexao);
            string sql_delete_tb_aln = @"delete from tb_produto where tb_produto_id='" + txtIdProduto.Text + "'";

            MySqlCommand exeCmdMysl_delete = new MySqlCommand(sql_delete_tb_aln, con);

            con.Open();
            exeCmdMysl_delete.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Atualização efetuada!");


            MySqlConnection cone = new MySqlConnection(conexao);
            cone.Open();

            string sql_select_equi = @"select tb_produto_id as 'Identif:', tb_produto_nome as 'Nome:',tb_produto_descricao as 'DESC:',tb_produto_tipo as 'TIPO:',tb_produto_dt_chegada_estoque as 'DT_CHEGADA:',tb_produto_dt_verificacao AS 'DT_VERIFI:' from tb_produto";

            MySqlCommand executacmdMySql_select_equi = new MySqlCommand(sql_select_equi, cone);

            executacmdMySql_select_equi.ExecuteNonQuery();

            DataTable tbl_equi = new DataTable();

            MySqlDataAdapter da_mod = new MySqlDataAdapter(executacmdMySql_select_equi);

            da_mod.Fill(tbl_equi);
            dgvEquipamentos.DataSource = tbl_equi;
            cone.Close();
        }

        private void DCEstoque_Load(object sender, EventArgs e)
        {
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

            MySqlConnection conexa = new MySqlConnection(conexao);
            conexa.Open();

            string sql_select_forn = @"select * from tb_fornecedor";

            MySqlCommand executacmdMySql_select_forn = new MySqlCommand(sql_select_forn, conexa);

            executacmdMySql_select_forn.ExecuteNonQuery();

            DataTable tabela_forn = new DataTable();

            MySqlDataAdapter tbl_forn = new MySqlDataAdapter(executacmdMySql_select_forn);
            tbl_forn.Fill(tabela_forn);

            cbFornecedor.DataSource = tabela_forn;

            cbFornecedor.ValueMember = "tb_fornecedor_nome";

            conexa.Close();
        }

        private void btnAtualizar_Click(object sender, EventArgs e)
        {
            #region
            if (txtnomeProduto.Text == "Produto:" || txtDescriçãoProduto.Text == "Descrição:" || txtDataInserção.Text == "Data de inserção no estoque:" || txtDataVerificação.Text == "Data da ultima verificação:" || txtTipo.Text == "Tipo:" || cbFornecedor.Text == "Fornecedor") { MessageBox.Show("CAmpos vazios ou não selecionados,verifique e tente novamente."); }
            else
            {
                #endregion
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
        }
        private void dgvEquipamentos_CellClick(object sender, DataGridViewCellEventArgs e)
        {          
            txtIdProduto.Text = dgvEquipamentos.CurrentRow.Cells[0].Value.ToString();
            txtnomeProduto.Text = dgvEquipamentos.CurrentRow.Cells[1].Value.ToString();
            txtDescriçãoProduto.Text = dgvEquipamentos.CurrentRow.Cells[2].Value.ToString();
            txtTipo.Text = dgvEquipamentos.CurrentRow.Cells[3].Value.ToString();
            txtDataInserção.Text = dgvEquipamentos.CurrentRow.Cells[4].Value.ToString();
            txtDataVerificação.Text = dgvEquipamentos.CurrentRow.Cells[5].Value.ToString();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            
        }

        private void txtnomeProduto_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void txtTipo_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void txtDataInserção_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void txtDataInserção_KeyPress(object sender, KeyPressEventArgs e)
        {

            //Verificar se foi digitado algum caracter
            if (char.IsNumber(e.KeyChar) == true)
            {
                switch (txtDataInserção.TextLength/*(tamanho do texto)*/)
                {
                    case 2:
                        txtDataInserção.Text = txtDataInserção.Text + "_";
                        //Jogar o cursor pra 4 posição
                        txtDataInserção.SelectionStart = 3;

                        break;
                    case 5:
                        txtDataInserção.Text = txtDataInserção.Text + "_";
                        //Jogar o cursor pra 4 posição
                        txtDataInserção.SelectionStart = 6;
                        break;

                }
            }
        }

        private void txtDataVerificação_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Verificar se foi digitado algum caracter
            if (char.IsNumber(e.KeyChar) == true)
            {
                switch (txtDataVerificação.TextLength/*(tamanho do texto)*/)
                {
                    case 2:
                        txtDataVerificação.Text = txtDataVerificação.Text + "_";
                        //Jogar o cursor pra 4 posição
                        txtDataVerificação.SelectionStart = 3;

                        break;
                    case 5:
                        txtDataVerificação.Text = txtDataVerificação.Text + "_";
                        //Jogar o cursor pra 4 posição
                        txtDataVerificação.SelectionStart = 6;
                        break;

                }
            }
        }

        private void dgvEquipamentos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
    
}
