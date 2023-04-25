using MySql.Data.MySqlClient;
using Projeto_Controle_de_Vendas.br.com.projeto.conexao;
using Projeto_Controle_de_Vendas.br.com.projeto.model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projeto_Controle_de_Vendas.br.com.projeto.dao
{
    public class ClienteDAO
    {
        private MySqlConnection conexao;
        public ClienteDAO() { 
            this.conexao = new ConnectionFactory().getConnection();
        }

        public void cadastrarCliente(Clientes obj)
        {
            try
            {
                string sql = @"insert into tb_clientes (nome,rg,cpf,email,telefone,celular,endereco,numero,
                complemento,bairro,cidade,estado,cep)
                values(@nome,@rg,@cpf,@email,@telefone,@celular,@endereco,@numero,
                @complemento,@bairro,@cidade,@estado,@cep)";

                MySqlCommand executacmd = new MySqlCommand(sql, conexao);
                executacmd.Parameters.AddWithValue("@nome", obj.nome);
                executacmd.Parameters.AddWithValue("@rg", obj.rg);
                executacmd.Parameters.AddWithValue("@cpf", obj.cpf);
                executacmd.Parameters.AddWithValue("@email", obj.email);
                executacmd.Parameters.AddWithValue("@telefone", obj.telefone);
                executacmd.Parameters.AddWithValue("@celular", obj.celular);
                executacmd.Parameters.AddWithValue("@endereco", obj.endereco);
                executacmd.Parameters.AddWithValue("@numero", obj.numero);
                executacmd.Parameters.AddWithValue("@complemento", obj.complemento);
                executacmd.Parameters.AddWithValue("@bairro", obj.bairro);
                executacmd.Parameters.AddWithValue("@cidade", obj.cidade);
                executacmd.Parameters.AddWithValue("@estado", obj.estado);
                executacmd.Parameters.AddWithValue("@cep", obj.cep);

                //abrir conexao e executar o comando sql
                conexao.Open();
                executacmd.ExecuteNonQuery();

                MessageBox.Show("Cliente cadastrado com sucesso!");

            }
            catch (Exception erro)
            {

                MessageBox.Show("Aconteceu erro: " + erro);
                
            }

        }

        #region
        public DataTable listarClientes()
        {
            try
            {
                //criar o DataTable e o comando sql
                DataTable tabelaCliente = new DataTable();
                string sql = "select * from tb_clientes";
                
                //organzar o comando sql e executar
                MySqlCommand executecmd = new MySqlCommand(sql, conexao);
                conexao.Open();
                executecmd.ExecuteNonQuery();

                //criar o mysqldata para preencher os dados no datatable
                MySqlDataAdapter dataAdapter = new MySqlDataAdapter(executecmd);
                dataAdapter.Fill(tabelaCliente);

                return tabelaCliente;

            }
            catch (Exception erro)
            {
                MessageBox.Show("Erro ao executar o comando sql: " + erro);
                return null;
                
            }
        }

        #endregion
    }

}
