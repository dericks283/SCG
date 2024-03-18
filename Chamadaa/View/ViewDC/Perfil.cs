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
    public partial class Perfil : Form
    {
        string conexao = ConfigurationManager.ConnectionStrings["strg_bd_esportivo"].ConnectionString;

        public Perfil()
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
            string sql = "update tb_alunos set tb_alunos_nome ='" + txtNome.Text + "',tb_alunos_email = '" + txtEmail.Text + "', tb_alunos_telefone = " + txtTel.Text + ", tb_alunos_complemento = '" + txtComplemento.Text + "',tb_alunos_endereco = '" + txtEndereco.Text + "', tb_alunos_sexo = '" + cbSexo.Text + "' where tb_alunos_id = " + txtId.Text + "";
            MySqlCommand executacmdsql = new MySqlCommand(sql, con);
            executacmdsql.ExecuteNonQuery();
            MessageBox.Show("Aluno Editado");



            this.Hide();
            DCAluno nov = new DCAluno();
            nov.Closed += (s, args) => this.Close();
            nov.Show();


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
    }
}

