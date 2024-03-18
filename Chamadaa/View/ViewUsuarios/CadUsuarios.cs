using Chamadaa.View.ViewLogin;
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

namespace Chamadaa.View.ViewUsuarios
{
    public partial class CadUsuarios : Form
    {
        string conexao = ConfigurationManager.ConnectionStrings["strg_bd_esportivo"].ConnectionString;
        public CadUsuarios()
        {
            InitializeComponent();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            MySqlConnection cone = new MySqlConnection(conexao);
            string ident = Convert.ToString(txtId.Text);            

            string sql = "select * from tb_usuarios where tb_usuarioS_identificacao= @id";
            MySqlCommand executacmdmysql = new MySqlCommand(sql, cone);

            executacmdmysql.Parameters.AddWithValue("@id", ident);            
            cone.Open();
            MySqlDataReader dados = executacmdmysql.ExecuteReader();

            if (dados.Read()){ MessageBox.Show("Este usuário já existe!!"); txtId.Text = "Nome de Usuario:"; }
            else
            {
                if (cbNiveis.Text == "Níveis de acesso")
                { MessageBox.Show("Por favor, selecione um nível de acesso ao sistema para prosseguir"); }

                else
                {
                    cbNiveis.Enabled = false;
                    try
                    {
                        MySqlConnection con = new MySqlConnection(conexao);

                        string nome_usuario = txtId.Text;
                        string senha = txtSenha.Text;
                        string permicao = Convert.ToString(cbNiveis.Text);


                        string sql_insert_tb_usuario = @"insert into tb_usuarios
                                            (
                                                tb_usuario_identificacao,
                                                tb_usuario_senha,                                                
                                                tb_usuario_permicao

                                            )
                                            values
                                            (
                                                @usuario_identificacao,
                                                @usuario_senha,                                                
                                                @usuario_permicao

                                                );";

                        MySqlCommand exeCmdMysl_insert = new MySqlCommand(sql_insert_tb_usuario, con);

                        exeCmdMysl_insert.Parameters.AddWithValue("@usuario_identificacao", nome_usuario);
                        exeCmdMysl_insert.Parameters.AddWithValue("@usuario_senha", senha);
                        exeCmdMysl_insert.Parameters.AddWithValue("@usuario_permicao", permicao);
                        con.Open();
                        exeCmdMysl_insert.ExecuteNonQuery();
                        con.Close();
                        MessageBox.Show("Cadastro de usuario bem sucedido!");

                        txtId.Text = "Nome de Usuário";
                        txtSenha.Text = "Senha";

                    }
                    catch (Exception ERRO)
                    {

                        MessageBox.Show("Valores não cadastrados por conterem alterações" + ERRO);
                    }
                    if (cbNiveis.Text == "Administrador") { MessageBox.Show("Atenção, sua Chave-Pass de acesso é: 82345, guarde-a pois irá precisar!"); }

                    cbNiveis.Text = "Níveis de acesso";
                }
            }
        }


        private void CadUsuarios_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            FormLogin login = new FormLogin();
            login.Show();
            this.Close();
          
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
    }
}
