using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Principal
{
    public partial class frmClientes : Form
    {
        public frmClientes()
        {
            InitializeComponent();
        }
        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (lblId.Text == "0")
            {
                Inserir();
            }
            else
            {
                Alterar();
            }
        }

        private void Inserir()
        {
            Cliente cliente = new Cliente();
            cliente.Nome = txtNome.Text;
            cliente.Saldo = Convert.ToDecimal(mtbSaldo.Text);
            cliente.Telefone = mtbTelefone.Text;
            cliente.Estado = txtEstado.Text;
            cliente.Cidade = txtCidade.Text;
            cliente.Bairro = txtBairro.Text;
            cliente.Cep = txtCep.Text;
            cliente.Logradouro = txtLogradouro.Text;
            cliente.Numero = Convert.ToInt32(txtNumero.Text);
            cliente.Complemento = rtbComplemento.Text;
            if (ckbNomeSujo.Checked == true)
            {
                cliente.NomeSujo = true;
            }
            else
            {
                cliente.NomeSujo = false;
            }
            cliente.Altura = Convert.ToDecimal(txtAltura.Text);
            cliente.Peso = Convert.ToDecimal(txtPeso.Text);

            SqlConnection conexao = new SqlConnection();
            conexao.ConnectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Eduardo\Documents\Clientes.mdf;Integrated Security=True;Connect Timeout=30";
            conexao.Open();

            SqlCommand comando = new SqlCommand();
            comando.Connection = conexao;
            comando.CommandText = "INSERT INTO clientes (nome, saldo, telefone, estado, cidade, bairro, cep, logradouro, numero, complemento, nome_Sujo, altura, peso) VALUES (@NOME, @SALDO, @TELEFONE, @ESTADO, @CIDADE, @BAIRRO, @CEP, @LOGRADOURO, @NUMERO, @COMPLEMENTO, @NOME_SUJO, @ALTURA, @PESO)";
            comando.Parameters.AddWithValue("@NOME", cliente.Nome);
            comando.Parameters.AddWithValue("@SALDO", cliente.Saldo);
            comando.Parameters.AddWithValue("@TELEFONE", cliente.Telefone);
            comando.Parameters.AddWithValue("@ESTADO", cliente.Estado);
            comando.Parameters.AddWithValue("@CIDADE", cliente.Cidade);
            comando.Parameters.AddWithValue("@BAIRRO", cliente.Bairro);
            comando.Parameters.AddWithValue("@CEP", cliente.Cep);
            comando.Parameters.AddWithValue("@LOGRADOURO", cliente.Logradouro);
            comando.Parameters.AddWithValue("@NUMERO", cliente.Numero);
            comando.Parameters.AddWithValue("@COMPLEMENTO", cliente.Complemento);
            comando.Parameters.AddWithValue("@NOME_SUJO", cliente.NomeSujo);
            comando.Parameters.AddWithValue("@ALTURA", cliente.Altura);
            comando.Parameters.AddWithValue("@PESO", cliente.Peso);
            comando.ExecuteNonQuery();

            MessageBox.Show("Registrado com Sucesso");
            LimparCampos();
            conexao.Close();
            AtualizarTabela();

        }

        private void Alterar()
        {
            Cliente cliente = new Cliente();
            cliente.Id = Convert.ToInt32(lblId.Text);
            cliente.Nome = txtNome.Text;
            cliente.Saldo = Convert.ToDecimal(mtbSaldo.Text);
            cliente.Telefone = mtbTelefone.Text;
            cliente.Estado = txtEstado.Text;
            cliente.Cidade = txtCidade.Text;
            cliente.Bairro = txtBairro.Text;
            cliente.Cep = txtCep.Text;
            cliente.Logradouro = txtLogradouro.Text;
            cliente.Numero = Convert.ToInt32(txtNumero.Text);
            cliente.Complemento = rtbComplemento.Text;
            if (ckbNomeSujo.Checked == true)
            {
                cliente.NomeSujo = true;
            }
            else
            {
                cliente.NomeSujo = false;
            }
            cliente.Altura = Convert.ToDecimal(txtAltura.Text);
            cliente.Peso = Convert.ToDecimal(txtPeso.Text);

            SqlConnection conexao = new SqlConnection();
            conexao.ConnectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Eduardo\Documents\Clientes.mdf;Integrated Security=True;Connect Timeout=30";
            conexao.Open();

            SqlCommand comando = new SqlCommand();
            comando.Connection = conexao;
            comando.CommandText = @"UPDATE clientes SET nome = @NOME, saldo = @SALDO, telefone = @TELEFONE, estado = @ESTADO, cidade = @CIDADE, bairro = @BAIRRO, cep = @CEP, logradouro = @LOGRADOURO, numero = @NUMERO, complemento = @COMPLEMENTO, nome_Sujo = @NOME_SUJO, altura = @ALTURA, peso = @PESO WHERE id = @ID";
            comando.Parameters.AddWithValue("@ID", cliente.Id);
            comando.Parameters.AddWithValue("@NOME", cliente.Nome);
            comando.Parameters.AddWithValue("@SALDO", cliente.Saldo);
            comando.Parameters.AddWithValue("@TELEFONE", cliente.Telefone);
            comando.Parameters.AddWithValue("@ESTADO", cliente.Estado);
            comando.Parameters.AddWithValue("@CIDADE", cliente.Cidade);
            comando.Parameters.AddWithValue("@BAIRRO", cliente.Bairro);
            comando.Parameters.AddWithValue("@CEP", cliente.Cep);
            comando.Parameters.AddWithValue("@LOGRADOURO", cliente.Logradouro);
            comando.Parameters.AddWithValue("@NUMERO", cliente.Numero);
            comando.Parameters.AddWithValue("@COMPLEMENTO", cliente.Complemento);
            comando.Parameters.AddWithValue("@NOME_SUJO", cliente.NomeSujo);
            comando.Parameters.AddWithValue("@ALTURA", cliente.Altura);
            comando.Parameters.AddWithValue("@PESO", cliente.Peso);
            comando.ExecuteNonQuery();

            MessageBox.Show("Alterado com Sucesso");
            LimparCampos();
            conexao.Close();
            AtualizarTabela();
        }

        private void LimparCampos()
        {
            lblId.Text = "0";
            txtNome.Clear();
            txtAltura.Clear();
            txtBairro.Clear();
            txtCep.Clear();
            txtCidade.Clear();
            txtEstado.Clear();
            txtLogradouro.Clear();
            txtNumero.Clear();
            txtPeso.Clear();
            mtbSaldo.Clear();
            mtbTelefone.Clear();
            rtbComplemento.Clear();
            if (ckbNomeSujo.Checked == true)
            {
                ckbNomeSujo.Checked = false;
            }

        }

        private void AtualizarTabela()
        {
            SqlConnection conexao = new SqlConnection();
            conexao.ConnectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Eduardo\Documents\Clientes.mdf;Integrated Security=True;Connect Timeout=30";
            conexao.Open();

            SqlCommand comando = new SqlCommand();
            comando.Connection = conexao;
            comando.CommandText = @"SELECT id, nome, saldo, telefone, estado, cidade, bairro, cep, logradouro, numero, complemento, nome_Sujo, altura, peso FROM clientes";

            DataTable tabela = new DataTable();
            tabela.Load(comando.ExecuteReader());

            for (int i = 0; i < tabela.Rows.Count; i++)
            {
                DataRow linha = tabela.Rows[i];
                Cliente cliente = new Cliente();
                cliente.Id = Convert.ToInt32(linha["id"]);
                cliente.Nome = linha["nome"].ToString();
                cliente.Saldo = Convert.ToDecimal(linha["saldo"]);
                cliente.Telefone = linha["telefone"].ToString();
                cliente.Estado = linha["estado"].ToString();
                cliente.Cidade = linha["cidade"].ToString();
                cliente.Bairro = linha["bairro"].ToString();
                cliente.Cep = linha["cep"].ToString();
                cliente.Logradouro = linha["logradouro"].ToString();
                cliente.Numero = Convert.ToInt32(linha["numero"]);
                cliente.Complemento = linha["complemento"].ToString();
                cliente.NomeSujo = Convert.ToBoolean(linha["nome_Sujo"]);
                cliente.Altura = Convert.ToDecimal(linha["altura"]);
                cliente.Peso = Convert.ToDecimal(linha["peso"]);
                dgvClientes.Rows.Add(new string[] {cliente.Id.ToString(), cliente.Nome, cliente.Saldo.ToString(), cliente.Telefone, cliente.Estado, cliente.Cidade, cliente.Bairro, cliente.Cep, cliente.Logradouro,
                    cliente.Numero.ToString(), cliente.Complemento,  cliente.NomeSujo.ToString(), cliente.Altura.ToString(), cliente.Peso.ToString()});
            }
        }

        private void btnApagar_Click(object sender, EventArgs e)
        {

        }

        private void dgvClientes_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void frmClientes_Load(object sender, EventArgs e)
        {
            AtualizarTabela();
        }
    }
}
