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
    public partial class PerfilAluno : Form
    {
        string conexao = ConfigurationManager.ConnectionStrings["strg_bd_esportivo"].ConnectionString;

        public PerfilAluno()
        {
            InitializeComponent();
        }

        private void Perfil_Load(object sender, EventArgs e)
        {

        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            MySqlConnection con = new MySqlConnection(conexao);
            con.Open();
            string sql = "update tb_alunos set tb_alunos_nome ='" + txtNome.Text + "',tb_alunos_email = '" + txtEmail.Text + "', tb_alunos_telefone = '" + txtTel.Text + "',tb_alunos_celular = '" + txtCelAlu.Text + "', tb_alunos_complemento = '" + txtComplemento.Text + "',tb_alunos_endereco = '" + txtEndereco.Text + "', tb_alunos_sexo = '" + cbSexo.Text + "' where tb_alunos_id = " + txtId.Text + "";
            MySqlCommand executacmdsql = new MySqlCommand(sql, con);
            executacmdsql.ExecuteNonQuery();
            MessageBox.Show("Aluno Editado");

            this.Close();


        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {

            if (MessageBox.Show("Deseja Realmente Excluir este aluno?", "Aviso!", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {

                MySqlConnection con = new MySqlConnection(conexao);
                con.Open();
                string sql = "delete from tb_alunos where tb_alunos_id = "+txtId.Text+"";
                MySqlCommand executacmdsql = new MySqlCommand(sql, con);
                executacmdsql.ExecuteNonQuery();
                MessageBox.Show("Aluno Excluido");

                this.Hide();
                DCAluno nov = new DCAluno();
                nov.Closed += (s, args) => this.Close();
                nov.Show();

            }
            else
            {

            }
        }

        private void txtTel_TextChanged(object sender, EventArgs e)
        {
            if (txtTel.Text == "")
            {
                txtTel.Text = "(";
                txtTel.SelectionStart = 2;
            }
            else if (txtTel.TextLength == 1) { 

                txtTel.Text = "(";
                txtTel.SelectionStart = 2;
            }
        }

        private void txtTel_Enter(object sender, EventArgs e)
        {
            if (txtTel.Text == "")
            {

                txtTel.Text = "(";
                txtTel.ForeColor = Color.Silver;
            }

        }

        private void txtCelAlu_TextChanged(object sender, EventArgs e)
        {
            if (txtCelAlu.Text == "")
            {
                txtCelAlu.Text = "(";
                txtCelAlu.SelectionStart = 2;
            }
            else if (txtCelAlu.TextLength == 1)
            {

                txtCelAlu.Text = "(";
                txtCelAlu.SelectionStart = 2;
            }
        }

        private void txtTel_Leave(object sender, EventArgs e)
        {
            if (txtTel.Text == "(")
            {

                txtTel.Text = "";
                txtTel.ForeColor = Color.Silver;
            }
        }

        private void txtCelAlu_Enter(object sender, EventArgs e)
        {
            if (txtCelAlu.Text == "")
            {

                txtCelAlu.Text = "(";
                txtCelAlu.ForeColor = Color.Silver;
            }
        }

        private void txtCelAlu_Leave(object sender, EventArgs e)
        {
            if (txtCelAlu.Text == "(")
            {

                txtCelAlu.Text = "";
                txtCelAlu.ForeColor = Color.Silver;
            }
        }

        private void txtTel_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Verificar se foi digitado algum caracter
            if (char.IsNumber(e.KeyChar) == true)
            {
                switch (txtTel.TextLength/*(tamanho do texto)*/)
                {
                    case 0:
                        txtTel.Text = "";
                        txtTel.Text = txtTel.Text + "(";
                        break;
                    case 3:
                        txtTel.Text = txtTel.Text + ")";
                        txtTel.SelectionStart = 4;
                        break;

                }
            }
        }

        private void txtCelAlu_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Verificar se foi digitado algum caracter
            if (char.IsNumber(e.KeyChar) == true)
            {
                switch (txtCelAlu.TextLength/*(tamanho do texto)*/)
                {
                    case 3:
                        txtCelAlu.Text = txtCelAlu.Text + ")";
                        txtCelAlu.SelectionStart = 4;
                        break;

                }
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

