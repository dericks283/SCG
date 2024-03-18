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
    public partial class PerfilProf : Form
    {
        string conexao = ConfigurationManager.ConnectionStrings["strg_bd_esportivo"].ConnectionString;
        public PerfilProf()
        {
            InitializeComponent();
        }



        private void btnSalvar_Click(object sender, EventArgs e)
        {
            MySqlConnection con = new MySqlConnection(conexao);
            con.Open();
            string sql = "update tb_professor set tb_professor_nome = '"+txtNome.Text+"', tb_professor_email = '"+txtEmail.Text+"', tb_professor_telefone = '"+txtTel.Text+"' where tb_professor_id = " + txtId.Text + "";
            MySqlCommand executacmdsql = new MySqlCommand(sql, con);
            executacmdsql.ExecuteNonQuery();
            MessageBox.Show("Professor Editado");

            this.Close();


            
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja Realmente Excluir este Professor?", "Aviso!", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {

                MySqlConnection con = new MySqlConnection(conexao);
                con.Open();
                string sql = "delete from tb_professor where tb_professor_id = " + txtId.Text + "";
                MySqlCommand executacmdsql = new MySqlCommand(sql, con);
                executacmdsql.ExecuteNonQuery();
                MessageBox.Show("Professor Excluido");

                this.Hide();
                DCProfessor nov = new DCProfessor();
                nov.Closed += (s, args) => this.Close();
                nov.Show();

            }
            else
            {

            }
        }

        private void PerfilProf_Load(object sender, EventArgs e)
        {

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
            

        private void txtTel_Enter(object sender, EventArgs e)
        {
            if (txtTel.Text == "")
            {

                txtTel.Text = "(";
                txtTel.ForeColor = Color.Silver;
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

        private void txtTel_TextChanged(object sender, EventArgs e)
        {
            if (txtTel.Text == "")
            {
                txtTel.Text = "(";
                txtTel.SelectionStart = 2;
            }
            else if (txtTel.TextLength == 1)
            {

                txtTel.Text = "(";
                txtTel.SelectionStart = 2;
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
    }
