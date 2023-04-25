using Projeto_Controle_de_Vendas.br.com.projeto.dao;
using Projeto_Controle_de_Vendas.br.com.projeto.model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projeto_Controle_de_Vendas.br.com.projeto.view
{
    public partial class Frmclientes : Form
    {
        public Frmclientes()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            Clientes obj = new Clientes();
            obj.nome = txtNome.Text;
            obj.rg = txtRG.Text;
            obj.cpf = txtCPF.Text;
            obj.email = txtEmail.Text;
            obj.telefone = txtTel.Text;
            obj.celular = txtCelular.Text;
            obj.endereco = txtLogradouro.Text;
            obj.numero = int.Parse (txtNumero.Text);
            obj.bairro = txtBAirro.Text;
            obj.complemento = txtComplemento.Text;
            obj.cidade = txtCidade.Text;
            obj.estado = txtUF.Text;
            obj.cep = txtCEP.Text;

            //passo 2 - criar um Obj da classe ClienteDAO e chamara metdodo cadastrar cliente
            ClienteDAO dao = new ClienteDAO();
            dao.cadastrarCliente(obj);

        }

        private void Frmclientes_Load(object sender, EventArgs e)
        {
            ClienteDAO dao = new ClienteDAO();
            dataGridClientes.DataSource = dao.listarClientes();
                }
    }
}
