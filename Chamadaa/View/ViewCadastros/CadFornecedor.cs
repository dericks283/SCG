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

namespace Chamadaa.View.ViewCadastros
{
    public partial class CadFornecedor : Form
    {
        string conexao = ConfigurationManager.ConnectionStrings["strg_bd_esportivo"].ConnectionString;
        public CadFornecedor()
        {
            InitializeComponent();
        }

        private void CadFornecedor_Load(object sender, EventArgs e)
        {
          
        }

        private void btnCadastFornecedor_Click(object sender, EventArgs e)
        {
            try
            {
                MySqlConnection con = new MySqlConnection(conexao);

                string nome_forn = txtNomeFor.Text;

                string tel_forn = txtTelFor.Text;
                string cel_forn = txtFornCel.Text;

                string email_forn = txtEmailFor.Text;
                string endereco_forn = txtEndFornecedor.Text;
                string identificacao_forn = txtIdentificacaoForn.Text;

                string sql_insert_tb_forn = @"insert into tb_fornecedor
                                            (
                                                tb_fornecedor_nome,
                                                tb_fornecedor_email,
                                                tb_fornecedor_telefone,
                                                tb_fornecedor_celular,
                                                tb_fornecedor_endereco,
                                                tb_fornecedor_identidade             
                                            )
                                            values
                                            (
                                                @forn_nome,
                                                @forn_email, 
                                                @forn_tel,
                                                @forn_cel,
                                                @forn_endereco,
                                                @forn_identidade
                                                );";

                MySqlCommand exeCmdMysl_insert = new MySqlCommand(sql_insert_tb_forn, con);

                exeCmdMysl_insert.Parameters.AddWithValue("@forn_nome", nome_forn);
                exeCmdMysl_insert.Parameters.AddWithValue("@forn_email", email_forn);
                exeCmdMysl_insert.Parameters.AddWithValue("@forn_tel", tel_forn);
                exeCmdMysl_insert.Parameters.AddWithValue("@forn_cel", cel_forn);
                exeCmdMysl_insert.Parameters.AddWithValue("@forn_endereco", endereco_forn);
                exeCmdMysl_insert.Parameters.AddWithValue("@forn_identidade", identificacao_forn);

                con.Open();
                exeCmdMysl_insert.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Cadastro de fornecedor bem sucedido!");

                txtNomeFor.Text = "Nome*";
                txtEmailFor.Text = "Email*";
                txtTelFor.Text = "Telefone";
                txtFornCel.Text = "Celular";
                txtEndFornecedor.Text = "Endereço";
                txtIdentificacaoForn.Text = "CPF/CNPJ";

                MySqlConnection cone = new MySqlConnection(conexao);
                cone.Open();

                string sql_select_fornecedor = @"select tb_fornecedor_nome as 'NOME:', tb_fornecedor_telefone as 'TEL:',tb_fornecedor_celular as 'CEL:', tb_fornecedor_email as 'EMAIL:',tb_fornecedor_identidade as 'IDENT:' from tb_fornecedor";

                MySqlCommand executacmdMySql_select_fornecedor = new MySqlCommand(sql_select_fornecedor, cone);

                executacmdMySql_select_fornecedor.ExecuteNonQuery();

                DataTable tbl_forn = new DataTable();

                MySqlDataAdapter da_forn = new MySqlDataAdapter(executacmdMySql_select_fornecedor);

                da_forn.Fill(tbl_forn);
                dgvFornecedor.DataSource = tbl_forn;
                cone.Close();

                btnReset.Enabled = true;
            }

            catch (Exception ERRO)
            {

                MessageBox.Show("Valores não cadastrados por conterem alterações" + ERRO);
            }
        }

        private void txtEndFornecedor_Enter(object sender, EventArgs e)
        {
            if (txtEndFornecedor.Text == "Endereço")
            {

                txtEndFornecedor.Text = "";
                txtEndFornecedor.ForeColor = Color.Silver;
            }
        }

        private void txtEndFornecedor_Leave(object sender, EventArgs e)
        {
            if (txtEndFornecedor.Text == "")
            {

                txtEndFornecedor.Text = "Endereço";
                txtEndFornecedor.ForeColor = Color.Silver;
            }
        }

        private void txtNomeFor_Enter(object sender, EventArgs e)
        {
            if (txtNomeFor.Text == "Nome*")
            {

                txtNomeFor.Text = "";
                txtNomeFor.ForeColor = Color.Silver;
            }
        }

        private void txtNomeFor_Leave(object sender, EventArgs e)
        {
            if (txtNomeFor.Text == "")
            {

                txtNomeFor.Text = "Nome*";
                txtNomeFor.ForeColor = Color.Silver;
            }
        }

        private void txtTelFor_Enter(object sender, EventArgs e)
        {
            if (txtTelFor.Text == "Telefone")
            {

                txtTelFor.Text = "(";
                txtTelFor.ForeColor = Color.Silver;
            }
           
        }

        private void txtTelFor_Leave(object sender, EventArgs e)
        {
            if (txtTelFor.Text == "(")
            {

                txtTelFor.Text = "Telefone";
                txtTelFor.ForeColor = Color.Silver;
            }
        }

        private void txtEmailFor_Enter(object sender, EventArgs e)
        {
            if (txtEmailFor.Text == "Email*")
            {

                txtEmailFor.Text = "";
                txtEmailFor.ForeColor = Color.Silver;
            }
        }

        private void txtEmailFor_Leave(object sender, EventArgs e)
        {
            if (txtEmailFor.Text == "")
            {

                txtEmailFor.Text = "Email*";
                txtEmailFor.ForeColor = Color.Silver;
            }
        }

        private void txtIdentificacaoForn_Enter(object sender, EventArgs e)
        {
            if (txtIdentificacaoForn.Text == "CPF/CNPJ")
            {

                txtIdentificacaoForn.Text = "";
                txtIdentificacaoForn.ForeColor = Color.Silver;
            }
        }

        private void txtIdentificacaoForn_Leave(object sender, EventArgs e)
        {
            if (txtIdentificacaoForn.Text == "")
            {

                txtIdentificacaoForn.Text = "CPF/CNPJ";
                txtIdentificacaoForn.ForeColor = Color.Silver;
            }
        }

        private void txtTelFor_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Verificar se foi digitado algum caracter
            if (char.IsNumber(e.KeyChar) == true)
            {
                switch (txtTelFor.TextLength/*(tamanho do texto)*/)
                {
                    case 0:
                        txtTelFor.Text = txtTelFor.Text + "(";
                        //Jogar o cursor pra 4 posição
                        txtTelFor.SelectionStart = 4;
                        break;
                    case 3:
                        txtTelFor.Text = txtTelFor.Text + ")";
                        //Jogar o cursor pra 4 posição
                        txtTelFor.SelectionStart = 4;

                        break;

                }
            }
        }

        private void txtFornCel_Enter(object sender, EventArgs e)
        {
            if (txtFornCel.Text == "Celular")
            {

                txtFornCel.Text = "(";
                txtFornCel.ForeColor = Color.Silver;
            }
           
        }

        private void txtFornCel_Leave(object sender, EventArgs e)
        {
            if (txtFornCel.Text == "(")
            {

                txtFornCel.Text = "Celular";
                txtFornCel.ForeColor = Color.Silver;
            }
        }

        private void txtFornCel_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Verificar se foi digitado algum caracter
            if (char.IsNumber(e.KeyChar) == true)
            {
                switch (txtFornCel.TextLength/*(tamanho do texto)*/)
                {
                    case 0:
                        txtFornCel.Text = txtFornCel.Text + "(";
                        //Jogar o cursor pra 4 posição
                        txtFornCel.SelectionStart = 4;
                        break;
                    case 3:
                        txtFornCel.Text = txtFornCel.Text + ")";
                        //Jogar o cursor pra 4 posição
                        txtFornCel.SelectionStart = 4;

                        break;

                }
            }
        }
        private void btnReset_Click(object sender, EventArgs e)
        {
            MySqlConnection cone = new MySqlConnection(conexao);
            cone.Open();

            string sql_select_fornecedor = @"select tb_fornecedor_nome as 'NOME:', tb_fornecedor_telefone as 'TEL:',tb_fornecedor_celular as 'CEL:', tb_fornecedor_email as 'EMAIL:',tb_fornecedor_identidade as 'IDENT:' from tb_fornecedor";

            MySqlCommand executacmdMySql_select_fornecedor = new MySqlCommand(sql_select_fornecedor, cone);

            executacmdMySql_select_fornecedor.ExecuteNonQuery();

            DataTable tbl_forn = new DataTable();

            MySqlDataAdapter da_forn = new MySqlDataAdapter(executacmdMySql_select_fornecedor);

            da_forn.Fill(tbl_forn);
            dgvFornecedor.DataSource = tbl_forn;
            cone.Close();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void txtFornCel_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
