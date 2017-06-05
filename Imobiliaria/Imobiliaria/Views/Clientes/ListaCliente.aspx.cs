using Imobiliaria.Controllers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Imobiliaria.Views.Cliente
{
    public partial class Cliente : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
           ClienteController ctrl = new ClienteController();
        }

        protected void btnSalvar_Click(object sender, EventArgs e)
        {
            ClienteController ctrl = new ClienteController();
            Models.Cliente cliente = new Models.Cliente();
            cliente.Nome = txtNome.Text;
            cliente.Endereco = txtEndereco.Text;
            cliente.Preco = txtPreco.Text;
            cliente.Descricao = txtDescricao.Text;
            cliente.Ativo = chkAtivo.Checked;

            ctrl.Adicionar(cliente);
            Response.Redirect("~/Default");
        }

        protected void btnCancelar_Click(object sender, EventArgs e)
        {
            LimparCampos();
        }

        private void LimparCampos()
        {
            txtNome.Text = string.Empty;
            txtEndereco.Text = string.Empty;
            txtPreco.Text = string.Empty;
            txtDescricao.Text = string.Empty;
        }
    }
}