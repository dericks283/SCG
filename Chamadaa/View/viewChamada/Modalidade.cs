using Chamadaa.View.VM;
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

namespace Chamadaa.View.viewChamada
{
    public partial class Modalidade : Form
    {
        string conexao = ConfigurationManager.ConnectionStrings["strg_bd_esportivo"].ConnectionString;
        public string modalidades;
        public string turmas;

        public Modalidade()
        {
            InitializeComponent();
    }
        

        private void button1_Click(object sender, EventArgs e)
        {
            //Verifica se todos os campos foram selecionados
            if (this.Controls.OfType<TextBox>().Any(f => string.IsNullOrEmpty(f.Text)))
            {
                MessageBox.Show("É necessário Preencher todos os campos", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {


                this.Hide();
                Form1 novo = new Form1();
                novo.modalidades = comboBox1.Text;
                novo.turmas = txtTurma.Text;
                novo.Closed += (s, args) => this.Close();
                novo.Show();
            }           
        }

        private void Modalidade_Load(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                MySqlConnection con = new MySqlConnection(conexao);

                con.Open();
                string sql = "select tb_"+comboBox1.Text+"_turma as '"+comboBox1.Text+"' from tb_" + comboBox1.Text +"";
                MySqlCommand executacmdsql = new MySqlCommand(sql, con);
                executacmdsql.ExecuteNonQuery();

                DataTable tabela_turma = new DataTable();
                MySqlDataAdapter da = new MySqlDataAdapter(executacmdsql);
                da.Fill(tabela_turma);
                dgvListar.DataSource = tabela_turma;
                con.Close();

               


            }
            catch (Exception erro)

            {
                MessageBox.Show("Aconteceu um erro" + erro);
            }
        }

        private void dgvListar_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void button3_Click(object sender, EventArgs e)
        {
         
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgvListar_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            txtTurma.Text = dgvListar.CurrentRow.Cells[0].Value.ToString();

        }

        private void txtTurma_Enter(object sender, EventArgs e)
        {
            if (txtTurma.Text == "Turma:")
            {

                txtTurma.Text = "";
                txtTurma.ForeColor = Color.Silver;
            }
        }

        private void txtTurma_Leave(object sender, EventArgs e)
        {
            if (txtTurma.Text == "")
            {

                txtTurma.Text = "Turma:";
                txtTurma.ForeColor = Color.Silver;
            }
            
        }
    }
}
