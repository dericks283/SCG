using Chamadaa.conexao;
using Chamadaa.Model;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Chamadaa.DAO
{

    public class Chamada
    {
        MySqlConnection conexao = ConectionString.getConnection();

        public Chamada()
        {
            conexao.Open();
        }



        public DataTable ListarNovaChamada()
        {

            //1 passo - comando sql
            string sql = @"select  tb_alunos_id as 'ID', tb_alunos_nome as 'Aluno',tb_basquete_turma as 'Turma', tb_basquete_horario as 'Horario', tb_professor_nome as 'Professor'
		from tb_alunos inner join tb_basquete on
        tb_alunos.basq_fk = tb_basquete.tb_basquete_id
        inner join tb_professor on
		tb_alunos.prof_fk = tb_professor.tb_professor_id
        group by tb_alunos_nome";

            //2 passo - organizar o sql
            MySqlCommand executacmdsql = new MySqlCommand(sql, conexao);

            //3 passo - abrir a conexao e executar o comando                
            executacmdsql.ExecuteNonQuery();

            //4 passo - criar o MySQLDataAdapter

            MySqlDataAdapter da = new MySqlDataAdapter(executacmdsql);
            //5 passo - criar o DataTable

            DataTable tabelaAluno = new DataTable();
            da.Fill(tabelaAluno);

            //fechar conexão
            conexao.Close();

            //Retornar o DataTable com os dados
            return tabelaAluno;

        }
    }
}
