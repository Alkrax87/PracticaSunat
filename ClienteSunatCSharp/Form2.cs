using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClienteSunatCSharp
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        public void RecibirDatos(string ruc, string razonSocial, string tipoContribuyente, string nombreComercial, 
            DateTime fechaIncripcion, DateTime fechaInicioActividades, string estado, string condicion, string domicilio)
        {
            this.lblRUC.Text = ruc;
            this.lblRazonSocial.Text = razonSocial;
            this.lblTipoContribuyente.Text = tipoContribuyente;
            this.lblNombreComercial.Text = nombreComercial;
            this.lblFechaInscripcion.Text = fechaIncripcion.ToShortDateString();
            this.lblFechaInicioAct.Text = fechaInicioActividades.ToShortDateString();
            this.lblEstado.Text = estado;
            this.lblCondicion.Text = condicion;
            this.lblDomicilio.Text = domicilio;
            
        }

        private void bttnVolver_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
