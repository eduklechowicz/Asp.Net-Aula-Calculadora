using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Aula1705
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        public int QuantidadeCliques {

            get
            {
              return Convert.ToInt32(ViewState["QuantidadeCliques"]);
            }
            set
            {
              ViewState["QuantidadeCliques"] = value;
            }
        }

        public int Primario
        {
            get
            {
                return Convert.ToInt32(ViewState["Primario"]);
            }
            set
            {
                ViewState["Primario"] = value;
            }
        }

        public int Secundario
        {
            get
            {
                return Convert.ToInt32(ViewState["Secundario"]);
            }
            set
            {
                ViewState["Secundario"] = value;
            }
        }

        protected void Page_Load(object sender, EventArgs e)
        {
           if(!IsPostBack)
                QuantidadeCliques = 0;
                
        }

        protected void btnClique_Click(object sender, EventArgs e)
        {
           // QuantidadeClique = Convert.ToInt32(ViewState["QuantidadeClique"]);

            QuantidadeCliques++;
            lblQuantidadeCliques.Text =  QuantidadeCliques.ToString();

            int primario = int.Parse(txtPrimario.Text);
            int secundario = int.Parse(txtSecundario.Text);
            int soma = primario + secundario;
            total.Text = soma.ToString();

            Primario = int.Parse(txtPrimario.Text);
            Secundario = int.Parse(txtSecundario.Text);

           // ViewState["QuantidadeClique"] = QuantidadeClique;
        }

        protected void btnEnviarCliques_Click(object sender, EventArgs e)
        {
            Session.Add("QuantidadeCliquesSession", QuantidadeCliques);
            Session.Add("Primario", Primario);
            Session.Add("Secundario", Secundario);
            Response.Redirect("~/WebForm2");
        }
    }
}