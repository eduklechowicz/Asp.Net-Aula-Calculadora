using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Aula1505
{
    public partial class CadastroProjeto : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnSalvar_Click(object sender, EventArgs e)
        {
            Projeto Projeto = new Projeto();
            Projeto.Nome = txtNome.Text;
            Projeto.Descricao = txtDescricao.Text;
            Projeto.Ativo = txtAtivo.Text;
        }
        
        protected void btnCancelar_Click(object sender, EventArgs e)
        {
            LimparCampos();
        }
        private void LimparCampos()
        {
            txtNome.Text = string.Empty;
            chkAtivo.Checked = false;
        }

    }
}