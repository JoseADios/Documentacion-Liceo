using CapaPresentacion.Documentos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaPresentacion
{
    public partial class FormMenuPrincipal : Form
    {
        public FormMenuPrincipal()
        {
            InitializeComponent();
        }



        private void button1_Click(object sender, EventArgs e)
        {
            FormMantenientoTipoDoc Instancia = new FormMantenientoTipoDoc();
            Instancia.ShowDialog();

        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            //TODO: poner el nombre del proyecto

            if (MessageBox.Show("Esto le hará salir de la Aplicación!\nSeguro que desea Salir?", "Mensaje de DocumetacionLic",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == DialogResult.Yes)
                e.Cancel = false;
            else
                e.Cancel = true;
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MatnEstudiante InstanciaE = new MatnEstudiante();
            InstanciaE.ShowDialog();
        }

        private void btnConsultaGenEstudiantes_Click(object sender, EventArgs e)
        {
            ConsultGeneralEstudiante InstanciaCE = new ConsultGeneralEstudiante();
            InstanciaCE.ShowDialog();
        }

        private void btnConsultaGenTiposDocs_Click(object sender, EventArgs e)
        {
            FormConsultarTiposDocs InstanciaCT = new FormConsultarTiposDocs();
            InstanciaCT.ShowDialog();
        }

        private void datosGeneralesToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            ReporteCurso reporteCurso = new ReporteCurso();
            reporteCurso.ShowDialog();
        }

        private void nuevaSolicitudToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NuevaSolicitud nuev_solicitud = new NuevaSolicitud();
            nuev_solicitud.ShowDialog();
        }

        private void labelLogo_Click(object sender, EventArgs e)
        {
            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            statusStrip1.Items[1].Text = "Fecha/Hora: " + DateTime.Now.ToString(); 
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void salidaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void acercaDeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FAcercaDe fAcercade = new FAcercaDe();
            fAcercade.ShowDialog();
        }

        private void FormMenuPrincipal_Load(object sender, EventArgs e)
        {

        }

        private void datosgeneralesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ConsultGeneralEstudiante consultGeneralEstudiante = new ConsultGeneralEstudiante();
            consultGeneralEstudiante.ShowDialog();
        }

        private void datosGeneralesToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            FormConsultarTiposDocs formConsultarTiposDocs = new FormConsultarTiposDocs();
            formConsultarTiposDocs.ShowDialog();
        }

        private void estudiantesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MatnEstudiante matnEstudiante = new MatnEstudiante();
            matnEstudiante.ShowDialog();
        }

        private void tiposDeDocumentosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormMantenientoTipoDoc formMantenientoTipoDoc = new FormMantenientoTipoDoc();
            formMantenientoTipoDoc.ShowDialog();
        }

        private void datosGeneralesToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            FConsultaSolicitudEntrega consultaSolicitudEntrega = new FConsultaSolicitudEntrega();
            consultaSolicitudEntrega.ShowDialog();
        }

        private void calculadoraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("Calc.Exe");
        }

        private void wordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("WINWORD.Exe");
        }

        private void excelToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("Excel.Exe");
        }

        private void navegadorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.google.com/");
        }


    }
}
