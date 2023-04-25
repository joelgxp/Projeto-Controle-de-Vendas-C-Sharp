using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using MySql.Data.MySqlClient;
using System.Configuration;

namespace Projeto_Controle_de_Vendas.br.com.projeto.conexao
{
    public class ConnectionFactory
    {

        public MySqlConnection getConnection()
        {
            string conexao = ConfigurationManager.ConnectionStrings["bdvendas"].ConnectionString;
            return new MySqlConnection(conexao);
        }
    }
}
