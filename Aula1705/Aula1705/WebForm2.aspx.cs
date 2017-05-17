using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Aula1705
{
    public partial class WebForm2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            int qtdCliquesViewState = Convert.ToInt32(ViewState["QuantidadeCliques"]);
            int qtdCliquesSession = Convert.ToInt32(Session["QuantidadeCliquesSession"]);

            int primario = Convert.ToInt32(Session["Primario"]);
            int secundario = Convert.ToInt32(Session["Secundario"]);

            lblQuantidadeCliques.Text = qtdCliquesSession.ToString();

            Label1.Text = primario.ToString();
            Label4.Text = primario.ToString();
            Label7.Text = primario.ToString();
            Label10.Text = primario.ToString();

            Label3.Text = secundario.ToString();
            Label6.Text = secundario.ToString();
            Label9.Text = secundario.ToString();
            Label12.Text = secundario.ToString();

            int soma = primario + secundario;
            int sub = primario - secundario;
            int mul = primario * secundario;
            int div = primario / secundario;

            totsoma.Text = soma.ToString();
            totsub.Text = sub.ToString();
            totmul.Text = mul.ToString();
            totdiv.Text = div.ToString();
        }
    }
}