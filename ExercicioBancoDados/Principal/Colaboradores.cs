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
    public partial class frmColaboradores : Form
    {
        public frmColaboradores()
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
            Colaborador colaborador = new Colaborador();
            colaborador.Nome = txtNome.Text;
            colaborador.Cpf = txtCpf.Text;
            colaborador.Salario = Convert.ToDecimal(mtbSalario.Text);
            if (rbFeminino.Checked == true)
            {
                colaborador.Sexo = rbFeminino.Text;
            }
            else
            {
                colaborador.Sexo = rbMasculino.Text;
            }
            colaborador.Cargo = txtCargo.Text;
            if (ckbProgramador.Checked == true)
            {
                colaborador.Programador = "Sim";
            }
            else
            {
                colaborador.Programador = "Não";
            }

            SqlConnection conexao = new SqlConnection();
            conexao.ConnectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=T:\Documentos\Colaboradores.mdf;Integrated Security=True;Connect Timeout=30";
            conexao.Open();

            SqlCommand comando = new SqlCommand();
            comando.Connection = conexao;
            comando.CommandText = @"INSERT INTO colaboradores (nome, cpf, salario, sexo, cargo, programador) VALUES (@NOME, @CPF, @SALARIO, @SEXO, @CARGO, @PROGRAMADOR)";
            comando.Parameters.AddWithValue("@NOME", colaborador.Nome);
            comando.Parameters.AddWithValue("@CPF", colaborador.Cpf);
            comando.Parameters.AddWithValue("@SALARIO", colaborador.Salario);
            comando.Parameters.AddWithValue("@SEXO", colaborador.Sexo);
            comando.Parameters.AddWithValue("@CARGO", colaborador.Cargo);
            comando.Parameters.AddWithValue("@PROGRAMADOR", colaborador.Programador);
            comando.ExecuteNonQuery();

            MessageBox.Show("Registrado com Sucesso");
            LimparCampos();
            conexao.Close();
            AtualizarTabela();
        }

        private void Alterar()
        {
            Colaborador colaborador = new Colaborador();
            colaborador.Id = Convert.ToInt32(lblId.Text);
            colaborador.Nome = txtNome.Text;
            colaborador.Cpf = txtCpf.Text;
            colaborador.Salario = Convert.ToDecimal(mtbSalario.Text);
            if (rbFeminino.Checked == true)
            {
                colaborador.Sexo = rbFeminino.Text;
            }
            else
            {
                colaborador.Sexo = rbMasculino.Text;
            }
            if (ckbProgramador.Checked == true)
            {
                ckbProgramador.Checked = true;
            }
            else
            {
                ckbProgramador.Checked = false;
            }

            SqlConnection conexao = new SqlConnection();
            conexao.ConnectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=T:\Documentos\Colaboradores.mdf;Integrated Security=True;Connect Timeout=30";
            conexao.Open();

            SqlCommand comando = new SqlCommand();
            comando.Connection = conexao;
            comando.CommandText = "UPDATE colaboradores SET nome = @NOME, cpf = @CPF, salario = @SALARIO, saxo = @SEXO, cargo = @CARGO, programador = @PROGRAMADOR WHERE id = @ID";
            comando.Parameters.AddWithValue("@Id", colaborador.Id);
            comando.Parameters.AddWithValue("@NOME", colaborador.Nome);
            comando.Parameters.AddWithValue("@CPF", colaborador.Cpf);
            comando.Parameters.AddWithValue("@SALARIO", colaborador.Salario);
            comando.Parameters.AddWithValue("@SEXO", colaborador.Sexo);
            comando.Parameters.AddWithValue("@CARGO", colaborador.Cargo);
            comando.Parameters.AddWithValue("@PROGRAMADOR", colaborador.Programador);
            comando.ExecuteNonQuery();
            LimparCampos();
            conexao.Close();
            AtualizarTabela();
        }

        private void LimparCampos()
        {
            lblId.Text = "0";
            txtCargo.Clear();
            txtCpf.Clear();
            txtNome.Clear();
            mtbSalario.Clear();
            if (rbMasculino.Checked == true)
            {
                rbMasculino.Checked = false;
            }
            else
            {
                rbFeminino.Checked = false;
            }
            if (ckbProgramador.Checked == true)
            {
                ckbProgramador.Checked = false;
            }
        }

        private void AtualizarTabela()
        {
            SqlConnection conexao = new SqlConnection();
            conexao.ConnectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=T:\Documentos\Colaboradores.mdf;Integrated Security=True;Connect Timeout=30";
            conexao.Open();

            SqlCommand comando = new SqlCommand();
            comando.Connection = conexao;
            comando.CommandText = "SELECT id, nome, cpf, salario, sexo, cargo, programador FROM colaboradores";

            DataTable tabela = new DataTable();
            tabela.Load(comando.ExecuteReader());

            dgvColaboradores.RowCount = 0;
            for (int i = 0; i < tabela.Rows.Count; i++)
            {
                DataRow linha = tabela.Rows[i];
                Colaborador colaborador = new Colaborador();
                colaborador.Id = Convert.ToInt32(linha["id"]);
                colaborador.Nome = linha["nome"].ToString();
                colaborador.Cargo = linha["cargo"].ToString();
                colaborador.Cpf = linha["cpf"].ToString();
                colaborador.Sexo = linha["sexo"].ToString();
                colaborador.Salario = Convert.ToDecimal(linha["salario"]);
                colaborador.Programador = linha["programador"].ToString();
                dgvColaboradores.Rows.Add(new string[] { colaborador.Id.ToString(), colaborador.Nome, colaborador.Cargo,
                    colaborador.Cpf,colaborador.Sexo, colaborador.Salario.ToString(), colaborador.Programador});
            }
        }
    }
}
