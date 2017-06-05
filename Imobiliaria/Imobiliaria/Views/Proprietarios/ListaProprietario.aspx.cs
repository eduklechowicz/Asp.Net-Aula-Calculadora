using Imobiliaria.Controllers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Imobiliaria.Views.Proprietario
{
    public partial class Proprietario : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            ProprietarioController ctrl = new ProprietarioController();
        }

        protected void btnSalvar_Click(object sender, EventArgs e)
        {
            ProprietarioController ctrl = new ProprietarioController();
            Models.Proprietario proprietario = new Models.Proprietario();
            proprietario.Nome = txtNome.Text;
            proprietario.Telefone = txtTelefone.Text;
            proprietario.Email = txtEmail.Text;
            proprietario.Ativo = chkAtivo.Checked;
            proprietario.ClienteId = int.Parse(txtIdCliente.Text);

            ctrl.Adicionar(proprietario);
            Response.Redirect("~/Default");
        }

        protected void btnCancelar_Click(object sender, EventArgs e)
        {
            LimparCampos();
        }

        private void LimparCampos()
        {
            txtNome.Text = string.Empty;
            txtTelefone.Text = string.Empty;
            txtEmail.Text = string.Empty;
        }
    }
}