﻿using MySql.Data.MySqlClient;
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
namespace Chamadaa.View.ViewLogin
{
    public partial class TrocarSenha : Form
    {
        string conexao = ConfigurationManager.ConnectionStrings["strg_bd_esportivo"].ConnectionString;
        public TrocarSenha()
        {
            InitializeComponent();
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            MySqlConnection cone = new MySqlConnection(conexao);
            string ident = Convert.ToString(txtId.Text);

            string sql = "select * from tb_usuarios where tb_usuario_identificacao= @id";
            MySqlCommand executacmdmysql = new MySqlCommand(sql, cone);

            executacmdmysql.Parameters.AddWithValue("@id", ident);
            cone.Open();
            MySqlDataReader dados = executacmdmysql.ExecuteReader();

            if (dados.Read())
            {
                MySqlConnection con = new MySqlConnection(conexao);
                con.Open();
                string update_usuarios = "update tb_usuarios set tb_usuario_senha ='" + txtSenha.Text + "' where tb_Usuario_identificacao like '" + txtId.Text + "'";
                MySqlCommand executacmdsql = new MySqlCommand(update_usuarios, con);
                executacmdsql.ExecuteNonQuery();
                MessageBox.Show("Alteração Bem sucedida.");

              

            }
            else if (txtId.Text=="" || txtId.Text=="") { MessageBox.Show("Campos não preenchidos"); }
            else { MessageBox.Show("Usuario não encontrado"); }



        }

        private void txtId_Enter(object sender, EventArgs e)
        {
            if (txtId.Text == "Nome de Usuário")
            {

                txtId.Text = "";
                txtId.ForeColor = Color.Silver;
            }
        }

        private void txtId_Leave(object sender, EventArgs e)
        {
            if (txtId.Text == "Nome de Usuário")
            {

                txtId.Text = "";
                txtId.ForeColor = Color.Silver;
            }
        }


        private void TrocarSenha_Load(object sender, EventArgs e)
        {
            if (txtId.Text=="") { txtId.Text = "Nome de Usuário"; }
        }

        private void iconFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void iconMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void lblSenha_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form_trocarNivel nivel = new Form_trocarNivel();
            nivel.Show();
           
        }


    }
}
