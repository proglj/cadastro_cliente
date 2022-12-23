using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SISCONTROLE
{
    public partial class frmClientes : Form
    {
        string Acao = "";
        string CodigoSelecionado = "";
        public frmClientes()
        {
            InitializeComponent();
        }

        void LimparCampos()
        {
            txtcodigo.Clear();
            txtNome.Clear();
            txtEndereco.Clear();
            txtestado.Clear();
            txtcidade.Clear();
            txtcep.Clear();
            txttelefone.Clear();
            txtcelular.Clear();
            txtemail.Clear();
        }

        private void btnGravar_Click(object sender, EventArgs e)
        {
            if (txtNome.Text == "")
            {
                MessageBox.Show("Preencher campo Nome", "ATENÇÃO", MessageBoxButtons.OK);
                BotoesInicio();
            }
            else
            {
                var cli = new DAO.Cliente()
                {
                        Nome = txtNome.Text,
                        Endereco = txtEndereco.Text,
                        Estado = txtestado.Text,
                        Cidade = txtcidade.Text,
                        Cep = txtcep.Text,
                        Telefone = txttelefone.Text,
                        Celular = txtcelular.Text,
                        Email = txtemail.Text
                };

                if (Acao == "Novo")
                {
                    MessageBox.Show(cli.Incluir());
                }else
                {
                    cli.Codigo = int.Parse(txtcodigo.Text);
                    MessageBox.Show(cli.Alterar());
                }
            }
            BotoesInicio();
            ListarClientes();
        }

        void ListarClientes()
        {
            gvwClientes.DataSource = new DAO.Cliente().Listar();
            gvwClientes.Show();
            BotoesInicio();
        }

        private void frmClientes_Load(object sender, EventArgs e)
        {

        }

        private void frmClientes_Activated(object sender, EventArgs e)
        {
            btnGravar.Enabled = false;
            btnEditar.Enabled = false;
            btnCancelar.Enabled = false;
            ListarClientes();
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            Acao = "Novo";
            BotoesGravarCancelar();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Acao = "Cancelar";
            BotoesInicio();
        }

        void BotoesGravarCancelar()
        {
            btnNovo.Enabled = false;
            btnEditar.Enabled = false;
            btnGravar.Enabled = true;
            btnCancelar.Enabled = true;
            btnExcluir.Enabled = txtcodigo.Text!="";
        }

        void BotoesInicio()
        {
            LimparCampos();
            btnNovo.Enabled = true;
            btnGravar.Enabled = false;
            btnCancelar.Enabled = false;
            btnEditar.Enabled = false;
            btnExcluir.Enabled = false;
        }

        void BotoesEditar()
        {
            btnNovo.Enabled = true;
            btnGravar.Enabled = false;
            btnCancelar.Enabled = false;
            btnEditar.Enabled = true;
            btnExcluir.Enabled = true;
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            gvwClientes.DataSource = new DAO.Cliente().Buscar(txtbuscar.Text);
            gvwClientes.Show();
            BotoesInicio();
        }

        private void btnListarTodos_Click(object sender, EventArgs e)
        {
            ListarClientes();
        }

        private void gvwClientes_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            //e.RowIndex
            //e.ColumnIndex[0] 
        }

        private void gvwClientes_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            string codigo = gvwClientes.Rows[e.RowIndex].Cells["Codigo"].Value.ToString();
            if (codigo != "")
            {
                Acao = "Editar";
                CodigoSelecionado = codigo;
                var cli = new DAO.Cliente(codigo);
                txtcodigo.Text = cli.Codigo.ToString();
                txtNome.Text = cli.Nome.ToString();
                txtEndereco.Text = cli.Endereco.ToString();
                txtcep.Text = cli.Cep.ToString();
                txtcidade.Text = cli.Cidade.ToString();
                txtestado.Text = cli.Estado.ToString();
                txttelefone.Text = cli.Telefone.ToString();
                txtcelular.Text = cli.Celular.ToString();
                txtemail.Text = cli.Email.ToString();

                BotoesGravarCancelar();
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            Acao = "Editar";
            BotoesGravarCancelar();
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Confirma Exclusão","EXCLUIR CLIENTE", MessageBoxButtons.YesNo)==DialogResult.Yes)
            {
                MessageBox.Show(new DAO.Cliente().Excluir(CodigoSelecionado));
                txtcodigo.Enabled = false;
                ListarClientes();
                CodigoSelecionado = "";
            }
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
