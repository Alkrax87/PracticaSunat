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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // Llamar al servicio
        private static ServiceReference1.WebService1SoapClient servicio;

        private void Form1_Load(object sender, EventArgs e)
        {
            servicio = new ServiceReference1.WebService1SoapClient();
            //dgvListar.DataSource = servicio.Listar().Tables[0];
        }

        private void txtCodAlumno_Enter(object sender, EventArgs e)
        {
            if (txtBuscar.Text == "Ingrese RUC")
            {
                txtBuscar.Text = "";
                txtBuscar.ForeColor = Color.Black;
            }
        }

        private void txtCodAlumno_Leave(object sender, EventArgs e)
        {
            if (txtBuscar.Text == "")
            {
                txtBuscar.Text = "Ingrese RUC";
                txtBuscar.ForeColor = Color.Silver;
            }
        }

        private void bttnBuscar_Click(object sender, EventArgs e)
        {
            servicio = new ServiceReference1.WebService1SoapClient();
            string buscar = txtBuscar.Text.Trim();
            string ruc, razonSocial, tipoContribuyente, nombreComercial, estado, condicion, domicilio;
            DateTime fechaInscripcion, fechaInicioActividades;

            dgvEmpresa.DataSource = servicio.Buscar(buscar, "RUC").Tables[0];

            Form2 form = new Form2();
            ruc = Convert.ToString(this.dgvEmpresa.CurrentRow.Cells[0].Value);
            razonSocial = Convert.ToString(this.dgvEmpresa.CurrentRow.Cells[1].Value);
            tipoContribuyente = Convert.ToString(this.dgvEmpresa.CurrentRow.Cells[2].Value);
            nombreComercial = Convert.ToString(this.dgvEmpresa.CurrentRow.Cells[3].Value);
            fechaInscripcion = Convert.ToDateTime(this.dgvEmpresa.CurrentRow.Cells[4].Value);
            fechaInicioActividades = Convert.ToDateTime(this.dgvEmpresa.CurrentRow.Cells[5].Value);
            estado = Convert.ToString(this.dgvEmpresa.CurrentRow.Cells[6].Value);
            condicion = Convert.ToString(this.dgvEmpresa.CurrentRow.Cells[7].Value);
            domicilio = Convert.ToString(this.dgvEmpresa.CurrentRow.Cells[8].Value);
            form.RecibirDatos(ruc, razonSocial, tipoContribuyente, nombreComercial, fechaInscripcion, fechaInicioActividades, estado, condicion, domicilio);
            form.ShowDialog();
        }

        private void bttnCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
