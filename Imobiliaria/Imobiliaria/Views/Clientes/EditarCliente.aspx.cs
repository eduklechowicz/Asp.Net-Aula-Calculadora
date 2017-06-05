using Imobiliaria.Controllers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Imobiliaria.Views.Clientes
{
    public partial class EditarCliente : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            
        }

        protected void btnBuscar_Click(object sender, EventArgs e)
        {
            ClienteController ctrl = new ClienteController();
            Models.Cliente cli = new Models.Cliente();

            cli.Nome = ddlCliente.Text;
            cli = ctrl.BuscarClientePorNome(cli);

            txtEndereco.Text = cli.Endereco;
            txtPreco.Text = cli.Preco;
            txtDescricao.Text = cli.Descricao;
            chkAtivoCliente.Checked = (bool)cli.Ativo;
        }

        protected void btnEditarCliente_Click(object sender, EventArgs e)
        {
            ClienteController ctrl = new ClienteController();
            Models.Cliente cliente = new Models.Cliente();

            cliente.Nome = ddlCliente.Text;
            cliente = ctrl.BuscarClientePorNome(cliente);
            cliente.Id = cliente.Id;
            cliente.Nome = ddlCliente.Text;
            cliente.Endereco = txtEndereco.Text;
            cliente.Preco = txtPreco.Text;
            cliente.Descricao = txtDescricao.Text;
            cliente.Ativo = chkAtivoCliente.Checked;

            ctrl.Alterar(cliente);
            Response.Redirect("~/Default");
        }

        protected void btnDeletarCliente_Click(object sender, EventArgs e)
        {
            ClienteController ctrl = new ClienteController();
            Models.Cliente cliente = new Models.Cliente();

            cliente.Nome = ddlCliente.Text;
            cliente = ctrl.BuscarClientePorNome(cliente);
            cliente.Id = cliente.Id;
            cliente.Nome = ddlCliente.Text;
            cliente.Endereco = txtEndereco.Text;
            cliente.Preco = txtPreco.Text;
            cliente.Descricao = txtDescricao.Text;
            cliente.Ativo = chkAtivoCliente.Checked;

            ctrl.Excluir(cliente);
            Response.Redirect("~/Default");
        }

        protected void ddlCliente_Load(object sender, EventArgs e)
        {
            ClienteController ctrl = new ClienteController();

            Models.Cliente cli = new Models.Cliente();

            if (!IsPostBack)
            {
                foreach (Models.Cliente x in ctrl.Listar())
                {
                    ddlCliente.Items.Add(x.Nome);
                }

            }
            cli.Nome = ddlCliente.Text;
            cli = ctrl.BuscarClientePorNome(cli);
            txtEndereco.Text = cli.Endereco.ToString();
            txtPreco.Text = cli.Preco.ToString();
            txtDescricao.Text = cli.Descricao.ToString();
            chkAtivoCliente.Checked = (bool)cli.Ativo;
        }

        protected void ddlCliente_SelectedIndexChanged(object sender, EventArgs e)
        {
            ClienteController ctrl = new ClienteController();
            Models.Cliente cli = new Models.Cliente();

            cli.Nome = ddlCliente.Text;
            cli = ctrl.BuscarClientePorNome(cli);

            txtEndereco.Text = cli.Endereco;
            txtPreco.Text = cli.Preco;
            txtDescricao.Text = cli.Descricao;
            chkAtivoCliente.Checked = (bool)cli.Ativo;
        }
    }
}