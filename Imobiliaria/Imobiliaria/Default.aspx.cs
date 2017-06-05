using Imobiliaria.Controllers;
using Imobiliaria.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Imobiliaria
{
    public partial class _Default : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            ClienteController ctrl = new ClienteController();
            List<Cliente> listaCliente = ctrl.Listar();

            ProprietarioController ctrl1 = new ProprietarioController();
            List<Proprietario> listaProprietario = ctrl1.Listar();

            gvwCliente.DataSource = listaCliente;
            gvwCliente.DataBind(); // Monta Tabela Cliente

            gvwProprietario.DataSource = listaProprietario;
            gvwProprietario.DataBind(); // Monta Tabela Proprietario
        }

        //protected void gvwCliente_RowDeleting(object sender, GridViewDeleteEventArgs e)
        //{
        //   ClienteController ctrl = new ClienteController();
        //    Cliente cli = new Cliente();
        //  //  cli.Id = gvwCliente.Columns["Id"];
        //    ctrl.Excluir(cli);
            
        //}
    }
}