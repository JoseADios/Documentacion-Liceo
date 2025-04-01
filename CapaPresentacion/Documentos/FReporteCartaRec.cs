using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaPresentacion.Documentos;
using Microsoft.Reporting.WinForms;
using CapaNegocio;

namespace CapaPresentacion.Documentos
{
    public partial class FReporteCartaRec : Form
    {
        public List<DatosCartaRec> ldatos = new List<DatosCartaRec>();

        public string NombreComp, idEst, mensaje = "", nombreEmpleado, ultimoIndice;
        public int primero = 0, idEmpleado;

        private void btnAceptar2_Click(object sender, EventArgs e)
        {

            if (textBoxCiudad.Text == String.Empty)
            {
                MessageBox.Show("Debe indicar la cuidad!");
                textBoxCiudad.Focus();
            }
            else if (textBoxLiceo.Text == String.Empty)
            {
                MessageBox.Show("Debe indicar el nombre del centro educativo!");
                textBoxLiceo.Focus();
            }
            else if (textBoxdepartamento.Text == String.Empty)
            {
                MessageBox.Show("Debe indicar el nombre del departamento!");
                textBoxdepartamento.Focus();
            }
            else if (textBoxSolicitud.Text == String.Empty)
            {
                MessageBox.Show("Debe indicar lo que desea solicitar!");
                textBoxSolicitud.Focus();
            }
            else if (textBoxEmisor.Text == String.Empty)
            {
                MessageBox.Show("Debe indicar el nmbre de la persona que emite el documento!");
                textBoxEmisor.Focus();
            }
            else
            {
                CompletaCartaRecomendacion();
                if (primero == 0)
                {
                    btnEntregado2.Enabled = true;
                }

            }

        }

        private void btnEntregado2_Click(object sender, EventArgs e)
        {

            FRegistroEntrega instaciaRE = new FRegistroEntrega();
            instaciaRE.nombreEmpleado = nombreEmpleado;
            instaciaRE.idEmpleado = idEmpleado;
            instaciaRE.ultimoIndice = ultimoIndice;

            instaciaRE.ShowDialog();
            btnEntregado2.Enabled = false;
            primero = 1;
        }

        public FReporteCartaRec()
        {
            InitializeComponent();
        }

        private void FReporteCartaRec_Load(object sender, EventArgs e)
        {
            reportViewer1.LocalReport.DataSources.Clear();
            reportViewer1.LocalReport.DataSources.Add(new ReportDataSource("DataSet1", ldatos));
            btnEntregado2.Enabled = false;
            
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {

        }

        private void btnEntregado_Click(object sender, EventArgs e)
        {
        }

        private void CompletaCartaRecomendacion()
        {
            DatosCartaRec objDatosCR = new DatosCartaRec();
            objDatosCR.PropNombre = NombreComp;
            objDatosCR.PropMatricula = idEst;
            objDatosCR.PropLiceo = textBoxLiceo.Text;
            objDatosCR.PropSolicitud = textBoxSolicitud.Text;
            objDatosCR.PropEmisor = textBoxEmisor.Text;
            objDatosCR.PropCiudad = textBoxCiudad.Text;
            objDatosCR.PropDepartamento = textBoxdepartamento.Text;

            ldatos.Add(objDatosCR);

            this.reportViewer1.RefreshReport();
        }

    }
}
