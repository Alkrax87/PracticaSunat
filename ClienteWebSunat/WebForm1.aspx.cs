using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ClienteWebSunat
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        // Llamar al servicio
        private static ServiceReference1.WebService1SoapClient servicio;

        protected void Page_Load(object sender, EventArgs e)
        {
            //gvEmpresa.DataSource = servicio.Listar().Tables[0];
            //gvEmpresa.DataBind();
        }

        protected void Buscar_Click(object sender, EventArgs e)
        {
            string buscar = TextBuscar.Text.Trim();
            

            servicio = new ServiceReference1.WebService1SoapClient();
            gvEmpresa.DataSource = servicio.Buscar(buscar, cbBuscar.Text).Tables[0];
            gvEmpresa.DataBind();

            

            lblRUC.Text = gvEmpresa.Rows[0].Cells[0].Text;
            lblRazonSocial.Text = gvEmpresa.Rows[0].Cells[1].Text;
            lblTipoContrib.Text = gvEmpresa.Rows[0].Cells[2].Text;
            lblNombreComercial.Text = gvEmpresa.Rows[0].Cells[3].Text;
            lblFechaIncripcion.Text = gvEmpresa.Rows[0].Cells[4].Text;
            lblFechaInicioAct.Text = gvEmpresa.Rows[0].Cells[5].Text;
            lblEstado.Text = gvEmpresa.Rows[0].Cells[6].Text;
            lblCondicion.Text = gvEmpresa.Rows[0].Cells[7].Text;
            lblDomicilio.Text = gvEmpresa.Rows[0].Cells[8].Text;
        }
    }
}