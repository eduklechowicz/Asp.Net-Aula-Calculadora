using Imobiliaria.Controllers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Imobiliaria
{
    public partial class About : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnProcurar_Click(object sender, EventArgs e)
        {
            ProprietarioController ctrl = new ProprietarioController();
            Models.Proprietario proprietario = new Models.Proprietario();

            string prop = txtNome.Text;
            proprietario = ctrl.BuscarProprietarioPorNome(prop);

            txtTelefone.Text = proprietario.Telefone;
            txtEmail.Text = proprietario.Email;
            chkAtivo.Checked = (bool)proprietario.Ativo;
        }

        protected void btnEditar_Click(object sender, EventArgs e)
        {
            ProprietarioController ctrl = new ProprietarioController();
            Models.Proprietario proprietario = new Models.Proprietario();
            proprietario.Nome = txtNome.Text;
            proprietario.Telefone = txtTelefone.Text;
            proprietario.Email = txtEmail.Text;
            proprietario.Ativo = chkAtivo.Checked;

            ctrl.Alterar(proprietario);
            Response.Redirect("~/Default");
        }

        protected void btnDeletar_Click(object sender, EventArgs e)
        {
            ProprietarioController ctrl = new ProprietarioController();
            Models.Proprietario proprietario = new Models.Proprietario();
            proprietario.Nome = txtNome.Text;
            proprietario.Telefone = txtTelefone.Text;
            proprietario.Email = txtEmail.Text;
            proprietario.Ativo = chkAtivo.Checked;

            ctrl.Excluir(proprietario);
            Response.Redirect("~/Default");
        }

        //protected void btnBuscar_Click(object sender, EventArgs e)
        //{
        //    ClienteController ctrl = new ClienteController();
        //    Models.Cliente cliente = new Models.Cliente();


        //    cliente.Nome = txtNomeCliente.Text;
        //    cliente = ctrl.BuscarClientePorNome(cliente);

        //    txtEndereco.Text = cliente.Endereco;
        //    txtPreco.Text = cliente.Preco;
        //    txtDescricao.Text = cliente.Descricao;
        //    chkAtivo.Checked = cliente.Ativo;

        //    ctrl.Adicionar(cliente);
        //    Response.Redirect("~/Default");
        //}

        //protected void btnEditarCliente_Click(object sender, EventArgs e)
        //{
        //    ClienteController ctrl = new ClienteController();
        //    Models.Cliente cliente = new Models.Cliente();
        //    cliente.Nome = txtNomeCliente.Text;
        //    cliente.Endereco = txtEndereco.Text;
        //    cliente.Preco = txtPreco.Text;
        //    cliente.Descricao = txtDescricao.Text;
        //    cliente.Ativo = chkAtivo.Checked;

        //    ctrl.Alterar(cliente);
        //    Response.Redirect("~/Default");
        //}

        //protected void btnDeletarCliente_Click(object sender, EventArgs e)
        //{
        //    ClienteController ctrl = new ClienteController();
        //    Models.Cliente cliente = new Models.Cliente();
        //    cliente.Nome = txtNomeCliente.Text;
        //    cliente.Endereco = txtEndereco.Text;
        //    cliente.Preco = txtPreco.Text;
        //    cliente.Descricao = txtDescricao.Text;
        //    cliente.Ativo = chkAtivo.Checked;

        //    ctrl.Excluir(cliente);
        //    Response.Redirect("~/Default");
        //}
    }
}