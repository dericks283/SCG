using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Configuration;

namespace Chamadaa.View.ViewCadastros
{
    public partial class CadEstoque : Form
    {
        string conexao = ConfigurationManager.ConnectionStrings["strg_bd_esportivo"].ConnectionString;
        public CadEstoque()
        {
            InitializeComponent();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            #region
            if (txtnomeProduto.Text == "Produto:" || txtDescriçãoProduto.Text == "Descrição:" || txtDataInserção.Text == "Data de inserção no estoque:" || txtDataVerificação.Text == "Data da ultima verificação:" || txtTipo.Text == "Tipo:" || cbFornecedor.Text == "Fornecedor") { MessageBox.Show("CAmpos vazios ou não selecionados,verifique e tente novamente."); }
            else
            {
                #endregion
                try
                {
                    MySqlConnection con = new MySqlConnection(conexao);

                    string nome_prod = txtnomeProduto.Text;
                    string desc = txtDescriçãoProduto.Text;
                    string tipo = txtTipo.Text;
                    string dt_estoque = txtDataInserção.Text;
                    string dt_revisao = txtDataVerificação.Text;
                    string fornecedor_fk = Convert.ToString(cbFornecedor.SelectedIndex);


                    string sql_insert_tb_produto = @"insert into tb_produto
                                            (
                                                tb_produto_nome,
                                                tb_produto_descricao,
                                                tb_produto_tipo,
                                                tb_produto_dt_chegada_estoque,
                                                tb_produto_dt_verificacao,
                                                fornecedor_fk                                                

                                            )
                                            values
                                            (
                                                @produto_nome,
                                                @produto_desc, 
                                                @produto_tipo,
                                                @data_inser,
                                                @data_verificacao,
                                                @forn_fk

                                                );";

                    MySqlCommand exeCmdMysl_insert = new MySqlCommand(sql_insert_tb_produto, con);

                    exeCmdMysl_insert.Parameters.AddWithValue("@produto_nome", nome_prod);
                    exeCmdMysl_insert.Parameters.AddWithValue("@produto_desc", desc);
                    exeCmdMysl_insert.Parameters.AddWithValue("@produto_tipo", tipo);
                    exeCmdMysl_insert.Parameters.AddWithValue("@data_verificacao", dt_revisao);
                    exeCmdMysl_insert.Parameters.AddWithValue("@data_inser", dt_estoque);
                    exeCmdMysl_insert.Parameters.AddWithValue("@forn_fk", fornecedor_fk);

                    con.Open();
                    exeCmdMysl_insert.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("Cadastro de produto bem sucedido!");

                    txtnomeProduto.Text = "Produto:";
                    txtDescriçãoProduto.Text = "Descrição:";
                    txtTipo.Text = "Tipo:";
                    txtDataVerificação.Text = "Data da ultima verificação:";
                    txtDataInserção.Text = "Data de inserção no estoque:";
                    cbFornecedor.Text = "Fornecedor";

                    btnReset.Enabled = true;
                }
                catch (Exception ERRO)
                {

                    MessageBox.Show("Valores não cadastrados por conterem alterações" + ERRO);
                }

                MySqlConnection cone = new MySqlConnection(conexao);
                cone.Open();

                string sql_select_professor = @"select tb_produto_nome as 'NOME:', tb_produto_descricao as 'DESC:', tb_produto_tipo as 'TIPO:',tb_produto_dt_chegada_estoque as 'DT_INSER:', tb_produto_dt_verificacao as 'DT_VERIF'  from tb_produto";

                MySqlCommand executacmdMySql_select_professor = new MySqlCommand(sql_select_professor, cone);

                executacmdMySql_select_professor.ExecuteNonQuery();

                DataTable tbl_prof = new DataTable();

                MySqlDataAdapter da_prof = new MySqlDataAdapter(executacmdMySql_select_professor);

                da_prof.Fill(tbl_prof);
                dgvProdutos.DataSource = tbl_prof;
                cone.Close();
            }
        }

        private void CadEstoque_Load(object sender, EventArgs e)
        {
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

        private void txtnomeProduto_Enter(object sender, EventArgs e)
        {
            if (txtnomeProduto.Text == "Produto:")
            {

                txtnomeProduto.Text = "";
                txtnomeProduto.ForeColor = Color.Silver;
            }
        }

        private void txtnomeProduto_Leave(object sender, EventArgs e)
        {
            if (txtnomeProduto.Text == "")
            {

                txtnomeProduto.Text = "Produto:";
                txtnomeProduto.ForeColor = Color.Silver;
            }
        }

        private void txtTipo_Enter(object sender, EventArgs e)
        {
            if (txtTipo.Text == "Tipo:")
            {

                txtTipo.Text = "";
                txtTipo.ForeColor = Color.Silver;
            }
        }

        private void txtTipo_Leave(object sender, EventArgs e)
        {
            if (txtTipo.Text == "")
            {

                txtTipo.Text = "Tipo:";
                txtTipo.ForeColor = Color.Silver;
            }
        }

        private void txtDataInserção_Enter(object sender, EventArgs e)
        {
            if (txtDataInserção.Text == "Data de inserção no estoque:")
            {

                txtDataInserção.Text = "";
                txtDataInserção.ForeColor = Color.Silver;
            }
        }

        private void txtDataInserção_Leave(object sender, EventArgs e)
        {
            if (txtDataInserção.Text == "")
            {

                txtDataInserção.Text = "Data de inserção no estoque:";
                txtDataInserção.ForeColor = Color.Silver;
            }
        }

        private void txtDescriçãoProduto_Enter(object sender, EventArgs e)
        {
            if (txtDescriçãoProduto.Text == "Descrição:")
            {

                txtDescriçãoProduto.Text = "";
                txtDescriçãoProduto.ForeColor = Color.Silver;
            }
        }

        private void txtDescriçãoProduto_Leave(object sender, EventArgs e)
        {
            if (txtDescriçãoProduto.Text == "")
            {

                txtDescriçãoProduto.Text = "Descrição:";
                txtDescriçãoProduto.ForeColor = Color.Silver;
            }
        }

        private void txtDataVerificação_Enter(object sender, EventArgs e)
        {
            if (txtDataVerificação.Text == "Data da ultima verificação:")
            {

                txtDataVerificação.Text = "";
                txtDataVerificação.ForeColor = Color.Silver;
            }
        }

        private void txtDataVerificação_Leave(object sender, EventArgs e)
        {
            if (txtDataVerificação.Text == "")
            {

                txtDataVerificação.Text = "Data da ultima verificação:";
                txtDataVerificação.ForeColor = Color.Silver;
            }
        }

        private void txtDataInserção_KeyPress(object sender, KeyPressEventArgs e)
        {

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

        private void btnReset_Click(object sender, EventArgs e)
        {
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


        private void txtDataInserção_KeyPress_1(object sender, KeyPressEventArgs e)
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

    }
}
