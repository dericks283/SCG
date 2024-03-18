using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chamadaa.conexao
{
    public class ConectionString
    {
        //metodo para conectar o banco de dados
        public static MySqlConnection getConnection()
        {
            //acessando a string de conexão
            string conexao = ConfigurationManager.ConnectionStrings["chamada"].ConnectionString;

            return new MySqlConnection(conexao);
        }
    }
}
