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
    public partial class frmPeixes : Form
    {
        public frmPeixes()
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
            Peixe peixe = new Peixe();
            peixe.Nome = txtNome.Text;
            peixe.Raca = cbRaca.SelectedItem.ToString();
            peixe.Preco = Convert.ToDecimal(mtbPreco.Text);
            peixe.Quantidade = Convert.ToInt32(txtQuantidade.Text);

            SqlConnection conexao = new SqlConnection();
            conexao.ConnectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=T:\Documentos\Eduardo.mdf;Integrated Security=True;Connect Timeout=30";
            conexao.Open();

            SqlCommand comando = new SqlCommand();
            comando.Connection = conexao;
            comando.CommandText = @"INSERT INTO peixes (nome, raca, preco, quantidade) VALUES (@NOME, @RACA, @PRECO, @QUANTIDADE)";
            comando.Parameters.AddWithValue("@NOME", peixe.Nome);
            comando.Parameters.AddWithValue("@RACA", peixe.Raca);
            comando.Parameters.AddWithValue("@PRECO", peixe.Preco);
            comando.Parameters.AddWithValue("@QUANTIDADE", peixe.Quantidade);
            comando.ExecuteNonQuery();

            MessageBox.Show("Registrado com Sucesso");
            LimparCampos();
            conexao.Close();
            AtualizarTabela();
        }

        private void Alterar()
        {
            Peixe peixe = new Peixe();
            peixe.Id = Convert.ToInt32(lblId.Text);
            peixe.Nome = txtNome.Text;
            peixe.Raca = cbRaca.SelectedItem.ToString();
            peixe.Preco = Convert.ToDecimal(mtbPreco.Text);
            peixe.Quantidade = Convert.ToInt32(txtQuantidade.Text);

            SqlConnection conexao = new SqlConnection();
            conexao.ConnectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=T:\Documentos\Eduardo.mdf;Integrated Security=True;Connect Timeout=30";
            conexao.Open();

            SqlCommand comando = new SqlCommand();
            comando.Connection = conexao;
            comando.CommandText = "UPDATE peixes SET nome = @NOME, raca = @RACA, preco = @PRECO, quantidade = @QUANTIDADE WHERE id = @ID";
            comando.Parameters.AddWithValue("@ID", peixe.Id);
            comando.Parameters.AddWithValue("@NOME", peixe.Nome);
            comando.Parameters.AddWithValue("@RACA", peixe.Raca);
            comando.Parameters.AddWithValue("@PRECO", peixe.Preco);
            comando.Parameters.AddWithValue("@QUANTIDADE", peixe.Quantidade);
            comando.ExecuteNonQuery();

            MessageBox.Show("Alterado com Sucessso");
            LimparCampos();
            conexao.Close();
            AtualizarTabela();
        }
        
        private void LimparCampos()
        {
            lblId.Text = "0";
            txtNome.Clear();
            cbRaca.SelectedIndex = -1;
            txtQuantidade.Clear();
            mtbPreco.Clear();
        }

        private void AtualizarTabela()

        {
            SqlConnection conexao = new SqlConnection();
            conexao.ConnectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=T:\Documentos\Eduardo.mdf;Integrated Security=True;Connect Timeout=30";
            conexao.Open();

            SqlCommand comando = new SqlCommand();
            comando.Connection = conexao;
            comando.CommandText = "SELECT id, nome, raca, preco, quantidade FROM peixes";

            DataTable tabela = new DataTable();
            tabela.Load(comando.ExecuteReader());

            dgvPeixes.RowCount = 0;
            for (int i = 0; i < tabela.Rows.Count; i++)
            {
                DataRow linha = tabela.Rows[i];
                Peixe peixe = new Peixe();
                peixe.Id = Convert.ToInt32(linha["id"]);
                peixe.Nome = linha["nome"].ToString();
                peixe.Raca = linha["raca"].ToString();
                peixe.Preco = Convert.ToDecimal(linha["preco"]);
                peixe.Quantidade = Convert.ToInt32(linha["quantidade"]);
                dgvPeixes.Rows.Add(new string[] {
                    peixe.Id.ToString(), peixe.Nome, peixe.Raca, peixe.Preco.ToString(), peixe.Quantidade.ToString()});
            }
        }

        private void frmPeixes_Load(object sender, EventArgs e)
        {
            AtualizarTabela();
        }

        private void btnApagar_Click(object sender, EventArgs e)
        {
            if (dgvPeixes.Rows.Count == 0)
            {
                MessageBox.Show("Registre um Peixe");
                return;
            }


            DialogResult caixaDialogo = MessageBox.Show("Desejá realmente Apagar?", "AVISO", MessageBoxButtons.YesNo);

            if (caixaDialogo == DialogResult.Yes)
            {
                SqlConnection conexao = new SqlConnection();
                conexao.ConnectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=T:\Documentos\Eduardo.mdf;Integrated Security=True;Connect Timeout=30";
                conexao.Open();

                SqlCommand comando = new SqlCommand();
                comando.Connection = conexao;
                comando.CommandText = "DELETE FROM peixes WHERE id = @ID";

                int id = Convert.ToInt32(dgvPeixes.CurrentRow.Cells[0].Value);
                comando.Parameters.AddWithValue("@ID", id);
                comando.ExecuteNonQuery();

                MessageBox.Show("Apagado com Sucesso");
                conexao.Close();
                AtualizarTabela();
            }
        }

        private void dgvPeixes_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int id = Convert.ToInt32(dgvPeixes.CurrentRow.Cells[0].Value); 

            SqlConnection conexao = new SqlConnection();
            conexao.ConnectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=T:\Documentos\Eduardo.mdf;Integrated Security=True;Connect Timeout=30";
            conexao.Open();

            SqlCommand comando = new SqlCommand();
            comando.Connection = conexao;
            comando.CommandText = "SELECT id, nome, raca, preco, quantidade FROM peixes WHERE id = @ID";
            comando.Parameters.AddWithValue("@ID", id);

            DataTable tabela = new DataTable();
            tabela.Load(comando.ExecuteReader());
            DataRow linha = tabela.Rows[0];
            Peixe peixe = new Peixe();
            peixe.Id = Convert.ToInt32(linha["id"]);
            peixe.Nome = linha["nome"].ToString();
            peixe.Raca = linha["raca"].ToString();
            peixe.Preco = Convert.ToDecimal(linha["preco"]);
            peixe.Quantidade = Convert.ToInt32(linha["quantidade"]);

            lblId.Text = peixe.Id.ToString();
            txtNome.Text = peixe.Nome;
            cbRaca.SelectedItem = peixe.Raca;
            mtbPreco.Text = peixe.Preco.ToString();
            txtQuantidade.Text = peixe.Quantidade.ToString();

            conexao.Close();
        }
    }
}